using EF6Demo.Data;
using EF6Demo.Models;
using EF6Demo.Repository;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF6Demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //you can comment this out after you run the code the first time
            //SeedDb();


        }


        //Seed the DB with test data
        protected void SeedDb()
        {
            using (SchoolContext context = new SchoolContext())
            {
                if (context.Database.Exists()) { 
                    if(context.Departments.Count() == 0) { 
                        var deptList = new List<Department>();
                        deptList.Add(new Department() { Name = "English" });
                        deptList.Add(new Department() { Name = "Physics" });
                        deptList.Add(new Department() { Name = "Chemistry" });
                        deptList.Add(new Department() { Name = "Math" });

                        deptList.ForEach(s => context.Departments.Add(s));
                        context.SaveChanges();
                    }

                    if(context.Students.Count() == 0)
                    {
                        var studentList = new List<Student>();
                        studentList.Add(new Student() { Department_Id = 1, StudentName = "Tony Stark" });
                        studentList.Add(new Student() { Department_Id = 2, StudentName = "Peter Parker" });
                        studentList.Add(new Student() { Department_Id = 3, StudentName = "Stephen Strange" });
                        studentList.Add(new Student() { Department_Id = 4, StudentName = "Steve Rogers" });

                        studentList.ForEach(s => context.Students.Add(s));
                        context.SaveChanges();
                    }
                }
            }
        }


       
    }
}