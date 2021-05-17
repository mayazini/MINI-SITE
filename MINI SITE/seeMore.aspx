<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="seeMore.aspx.cs" Inherits="MINI_SITE.seeMore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>subject: <%=subject %></h1>
    <h1>from: <%=from %></h1>
    <h1>to: you</h1>
    <hr />
    <h1>message: <%=message %></h1>
    <a href="sendMsg.aspx?recieverName=<%=from %>" class="btn btn-danger">Reply</a>
</asp:Content>
