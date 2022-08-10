using EF6Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Demo.Repository.Interfaces
{
    public interface IDepartmentRepository : IDisposable
    {
        List<Department> GetDepartmentList();
        void EditDepartment(int id, Department department);
        void CreateDepartment(Department department);

        Department GetDepartment(int id);
    }
}
