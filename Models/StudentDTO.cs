using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Demo.Models
{
    public class StudentDTO
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}