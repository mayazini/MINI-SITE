<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applicantResume.aspx.cs" Inherits="MINI_SITE.resume" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%=usersList %>
    
    <a href="sendMsg.aspx?recieverName=<%= username%>&isApproved=true&projectName=<%=projectName %>" type="submit"  class="btn btn-type2 type2-colorText" name ="submitbtn">approve</a>
</asp:Content>
