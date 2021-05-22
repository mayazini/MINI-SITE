<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="seeMore.aspx.cs" Inherits="MINI_SITE.seeMore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container siteTextColor" style="font-size:30px">
         <h1 class="title-color">subject: </h1> <%=subject %>
        <h1 class="title-color">from: </h1> <%=from %>
        <h1 class="title-color">to: </h1>you
        <hr />
        <h1 class="title-color">message: </h1>
        <%=message %>
        <br />
        <a href="sendMsg.aspx?recieverName=<%=from %>" class="btn btn-type2 type2-colorText">Reply</a>
    </div>

</asp:Content>
