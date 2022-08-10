using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EF6Demo.Repository;
using EF6Demo.Repository.Interfaces;

namespace EF6Demo
{
    public partial class ViewTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ITeacherRepository repos = new TeacherRepository();
            var list = repos.GetTeacherList();

            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table table-striped table-bordered'>");
            sb.Append("<thead><tr><th>ID</th><th>Name</th><th>Department</th><th></th></tr></thead>");
            sb.Append("<tbody>");

            foreach (var item in list)
            {
                sb.Append("<tr><td >" + item.TeacherID + "</td><td >" + item.TeacherName + "</td><td >" + item.DepartmentName + "</td>");
                var t = "<a href=../EditTeacher.aspx?id=" + item.TeacherID + ">Edit</a>";
                sb.Append("<td><a class='btn btn-primary btn-sm' href=../EditTeacher.aspx?id=" + item.TeacherID + ">Edit</a></td>");
                sb.Append("</tr>");
            }
            sb.Append("</tbody></table>");
            ltlTableDisplay.Text = sb.ToString();
        }
    }
}