<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applicantResume.aspx.cs" Inherits="MINI_SITE.resume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%=usersList %>
    <div class="container siteTextColor" style="font-size: 30px">
        <h1 class="title-color">user name: </h1>
        <p class="siteTextColor"><%=username %></p>
        <h1 class="title-color">firstName: </h1>
        <p class="siteTextColor"><%=firstName %></p>
        <h1 class="title-color">lastName: </h1>
        <p class="siteTextColor"><%=lastName %></p>
        <hr />
        <h1 class="title-color">email: </h1>
        <p class="siteTextColor"><%=email %></p>
        <h1 class="title-color">age: </h1>
        <p class="siteTextColor"><%=age %></p>
        <br />
        <button type="submit" class="btn btn-type2 type2-colorText" name="approve"><a href="sendMsg.aspx?recieverName=<%= username%>&isApproved=true&projectName=<%=projectName %>" >approve</a></button>
    </div>
</asp:Content>
