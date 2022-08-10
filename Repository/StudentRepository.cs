using EF6Demo.Data;
using EF6Demo.Models;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6Demo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext _db;
        public StudentRepository()
        {
            _db = new SchoolContext();
        }

        public void CreateStudent(StudentDTO student)
        {
            Student dbStudent = new Student()
            {
                StudentName = student.StudentName,
                Department_Id = student.DepartmentId
            };

            _db.Students.Add(dbStudent);
            _db.SaveChanges();
        }        

        public void EditStudent(int id, StudentDTO studentDTO)
        {
            var student = _db.Students
                .Where(x => x.StudentID == id)
                .Join(_db.Departments, s=> s.Department_Id, d=> d.Id,(s,d) => new {s,d})
                .FirstOrDefault();

            student.s.Department_Id = studentDTO.DepartmentId;
            student.s.StudentName = studentDTO.StudentName;
            
            _db.SaveChanges();
        }

        public StudentDTO GetStudent(int id)
        {
            StudentDTO student = _db.Students
                .Where(x => x.StudentID == id)
                .Join(_db.Departments, s => s.Department_Id, d => d.Id, (s, d) => new StudentDTO() { 
                    DepartmentId = s.Department_Id, 
                    DepartmentName = s.Department.Name,
                    StudentID = id,
                    StudentName = s.StudentName
                })
                .FirstOrDefault();

            return student;
        }

        public List<StudentDTO> GetStudentList()
        {
            var list = _db.Students
                    .Join(_db.Departments, s => s.Department_Id, d => d.Id,(s,d) => new StudentDTO() { DepartmentId = d.Id, DepartmentName = d.Name, StudentID = s.StudentID, StudentName = s.StudentName })
                    .ToList();
            return list;
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}