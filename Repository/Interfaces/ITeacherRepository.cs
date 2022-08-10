using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6Demo.Models;

namespace EF6Demo.Repository.Interfaces
{
    public interface ITeacherRepository: IDisposable
    {
        List<TeacherDTO> GetTeacherList();
        void EditTeacher(int id, TeacherDTO teacherDTO);
        void CreateTeacher(TeacherDTO teacher);

        TeacherDTO GetTeacher(int id);
    }
}
