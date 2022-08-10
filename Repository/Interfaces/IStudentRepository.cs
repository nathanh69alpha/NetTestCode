using EF6Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Demo.Repository.Interfaces
{
    public interface IStudentRepository: IDisposable
    {
        List<StudentDTO> GetStudentList();
        void EditStudent(int id, StudentDTO studentDTO);
        void CreateStudent(StudentDTO student);

        StudentDTO GetStudent(int id);
    }
}
