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
    public partial class EditStudent : System.Web.UI.Page
    {
        private IStudentRepository repo = new StudentRepository();
        private IDepartmentRepository deptRepo = new DepartmentRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);                
                var student = repo.GetStudent(id);
                hdStudentId.Value = id.ToString();
                txtName.Text = student.StudentName;

                var deptList = deptRepo.GetDepartmentList();
                
                ddlDept.DataSource = deptList;
                ddlDept.DataValueField = "Id";
                ddlDept.DataTextField = "Name";
                ddlDept.DataBind();
                ddlDept.SelectedValue = student.DepartmentId.ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        { 
            int id = Convert.ToInt32(hdStudentId.Value);
            int deptId = Convert.ToInt32(ddlDept.SelectedValue);

            StudentDTO dto = new StudentDTO()
            {
                StudentID = id,
                DepartmentId = deptId,
                StudentName = txtName.Text
            };

            repo.EditStudent(id, dto);
            Response.Redirect("ViewStudents.aspx");
        }
    }
}