using EF6Demo.Data;
using EF6Demo.Models;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Demo.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolContext _db;
        public TeacherRepository()
        {
            _db = new SchoolContext();
        }
        public void CreateTeacher(TeacherDTO teacher)
        {
            Teacher dbTeacher = new Teacher()
            {
                Name = teacher.TeacherName,
                Department_Id = teacher.DepartmentId
            };

            _db.Teachers.Add(dbTeacher);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EditTeacher(int id, TeacherDTO teacherDTO)
        {
            var teacher = _db.Teachers
                .Where(x => x.Id == id)
                .Join(_db.Departments, s => s.Department_Id, d => d.Id, (s, d) => new { s, d })
                .FirstOrDefault();

            teacher.s.Department_Id = teacherDTO.DepartmentId;
            teacher.s.Name = teacherDTO.TeacherName;

            _db.SaveChanges();
        }

        public TeacherDTO GetTeacher(int id)
        {
            TeacherDTO teacher = _db.Teachers
                .Where(x => x.Id == id)
                .Join(_db.Departments, s => s.Department_Id, d => d.Id, (s, d) => new TeacherDTO()
                {
                    DepartmentId = s.Department_Id,
                    DepartmentName = s.Department.Name,
                    TeacherID = id,
                    TeacherName = s.Name
                })
                .FirstOrDefault();

            return teacher;
        }

        public List<TeacherDTO> GetTeacherList()
        {
            var list = _db.Teachers
                    .Join(_db.Departments, s => s.Department_Id, d => d.Id, (s, d) => new TeacherDTO() { DepartmentId = d.Id, DepartmentName = d.Name,  TeacherID = s.Id, TeacherName = s.Name })
                    .ToList();
            return list;
        }
    }
}