<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="EF6Demo.ViewStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h4>Students</h4>

    <div>
      <a class='btn btn-primary btn-sm' href="../CreateStudentNHVersion.aspx">Create New Student</a>
     </div>   
    <br />
     <div style="width:60%">
        <asp:Literal ID="ltlTableDisplay" runat="server"></asp:Literal>
     </div>

</asp:Content>
