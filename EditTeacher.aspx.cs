using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EF6Demo.Repository.Interfaces;
using EF6Demo.Repository;
using EF6Demo.Data;
using EF6Demo.Models;

namespace EF6Demo
{
    public partial class EditTeacher : System.Web.UI.Page
    {
        private ITeacherRepository repo = new TeacherRepository();
        private IDepartmentRepository deptRepo = new DepartmentRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                var teacher = repo.GetTeacher(id);
                hdTeacherId.Value = id.ToString();
                txtName.Text = teacher.TeacherName;

                var deptList = deptRepo.GetDepartmentList();

                ddlDept.DataSource = deptList;
                ddlDept.DataValueField = "Id";
                ddlDept.DataTextField = "Name";
                ddlDept.DataBind();
                ddlDept.SelectedValue = teacher.DepartmentId.ToString();
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hdTeacherId.Value);
            int deptId = Convert.ToInt32(ddlDept.SelectedValue);

            TeacherDTO dto = new TeacherDTO()
            {
                TeacherID = id,
                DepartmentId = deptId,
                TeacherName = txtName.Text
            };

            repo.EditTeacher(id, dto);
            Response.Redirect("ViewTeachers.aspx");
        }
    }
}