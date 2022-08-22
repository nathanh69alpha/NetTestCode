<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateStudentNHVersion.aspx.cs" Inherits="EF6Demo.CreateStudentNHVersion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    
    <h4>Create Student</h4>
    <div class="row">
        <div class="col-3">
            <label style="font-size:medium;font-weight:bold">Student Name</label>
        </div>
        <div class="col-3">
            <label style="font-size:medium;font-weight:bold">Department</label>
        </div>

    </div>
    <div class="row">
        <div class="col-3">
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-3">
            <asp:DropDownList ID="ddlDept" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         
    </div>
   <br />
    <asp:Button CssClass="btn btn-primary btn-md" runat="server" Text="Create Student" OnClick="btnSubmit_Click" ID="btnSubmit" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <a href="ViewStudents.aspx" class="btn btn-success btn-md">Back To Students</a>
   

</asp:Content>
