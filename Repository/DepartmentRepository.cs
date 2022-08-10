using EF6Demo.Data;
using EF6Demo.Models;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Demo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly SchoolContext _db;
        public DepartmentRepository()
        {
            _db = new SchoolContext();
        }

        public void CreateDepartment(Department department)
        {
            Department dbDepartment = new Department()
            {
                Id = department.Id,
                Name = department.Name
            };

            _db.Departments.Add(dbDepartment);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void EditDepartment(int id, Department department)
        {
            var dept = _db.Departments.Find(department.Id);

            dept.Name = department.Name;
            _db.SaveChanges();
        }

        public Department GetDepartment(int id)
        {
            return _db.Departments.Find(id);
        }

        public List<Department> GetDepartmentList()
        {
            return _db.Departments.OrderBy(x => x.Name).ToList();
        }
    }
}