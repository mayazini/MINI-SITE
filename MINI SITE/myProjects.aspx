<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="myProjects.aspx.cs" Inherits="MINI_SITE.myProjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="siteTextColor">projects you created</h1>
    <br />
    <%=usersList %>
    <hr />
    <br />
    <h1 class="siteTextColor">projects that approved you</h1>
    <br />
    <%=usersList1 %>
</asp:Content>
