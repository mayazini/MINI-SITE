<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jobOffers.aspx.cs" Inherits="MINI_SITE.jobOffers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="title-color">Would like to join</h1>
    <%=usersList %>
    <br /><br />
    <h1 class="title-color">Approved</h1>
    <%=usersList1 %>
</asp:Content>
