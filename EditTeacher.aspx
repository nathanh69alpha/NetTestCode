<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTeacher.aspx.cs" Inherits="EF6Demo.EditTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <asp:HiddenField ID="hdTeacherId" runat="server" />
    <h4>Edit Teacher</h4>
    <div class="row">
        <div class="col-3">
            <label style="font-size:medium;font-weight:bold">Teacher Name</label>
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
    <asp:Button CssClass="btn btn-primary btn-md" runat="server" Text="Update Teacher" OnClick="btnSubmit_Click" ID="btnSubmit" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <a href="ViewTeachers.aspx" class="btn btn-success btn-md">Back To Teachers</a>
   
</asp:Content>
