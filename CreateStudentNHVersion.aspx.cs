using EF6Demo.Models;
using EF6Demo.Repository;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF6Demo
{
    public partial class CreateStudentNHVersion : System.Web.UI.Page
    {
        private IStudentRepository repo = new StudentRepository();
        private IDepartmentRepository deptRepo = new DepartmentRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //loading the Department dropdown
                var deptList = deptRepo.GetDepartmentList();

                ddlDept.DataSource = deptList;
                ddlDept.DataValueField = "Id";
                ddlDept.DataTextField = "Name";
                ddlDept.DataBind();                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(ddlDept.SelectedValue);

            StudentDTO dto = new StudentDTO()
            {
                DepartmentId = deptId,
                StudentName = txtName.Text
            };

            repo.CreateStudent(dto);
            Response.Redirect("ViewStudents.aspx");
        }
    }
}