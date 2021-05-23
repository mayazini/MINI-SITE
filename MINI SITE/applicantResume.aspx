<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applicantResume.aspx.cs" Inherits="MINI_SITE.resume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%=usersList %>
    <div class="container siteTextColor" style="font-size: 30px">
        <h1 class="title-color">user name: </h1>
        <%=username %>
        <h1 class="title-color">firstName: </h1>
        <%=firstName %>
        <h1 class="title-color">lastName: </h1>
        <%=lastName %>
        <hr />
        <h1 class="title-color">email: </h1>
        <%=email %>
        <h1 class="title-color">age: </h1>
        <%=age %>
        <br />
        <a href="sendMsg.aspx?recieverName=<%= username%>&isApproved=true&projectName=<%=projectName %>" type="submit" class="btn btn-type2 type2-colorText" name="submitbtn">approve</a>
    </div>
</asp:Content>
