using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF6Demo.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Department")]
        public int Department_Id { get; set; }
        public Department Department { get; set; }
    }
}