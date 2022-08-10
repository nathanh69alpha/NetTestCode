using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF6Demo.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("Department")]
        public int Department_Id { get; set; }
        public Department Department { get; set; }
    }
}