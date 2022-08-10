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
    public partial class ViewStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IStudentRepository repos = new StudentRepository();
            var list = repos.GetStudentList();

            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table table-striped table-bordered'>");
            sb.Append("<thead><tr><th>ID</th><th>Name</th><th>Department</th><th></th></tr></thead>");
            sb.Append("<tbody>");

            foreach (var item in list)
            {
                sb.Append("<tr><td >" + item.StudentID + "</td><td >" + item.StudentName + "</td><td >" + item.DepartmentName + "</td>");
                var t = "<a href=../EditStudent.aspx?id=" + item.StudentID + ">Edit</a>";
                sb.Append("<td><a class='btn btn-primary btn-sm' href=../EditStudent.aspx?id=" + item.StudentID + ">Edit</a></td>");
                sb.Append("</tr>");
            }
            sb.Append("</tbody></table>");
            ltlTableDisplay.Text = sb.ToString();
        }
    }
}