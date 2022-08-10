using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Demo.Models
{
    public class TeacherDTO
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}