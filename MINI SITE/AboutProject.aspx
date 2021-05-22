<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutProject.aspx.cs" Inherits="MINI_SITE.WebForm18" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container siteTextColor" style="font-size:30px; height:auto;width:auto">
        <h1 class="title-color">project Name: </h1> <%=projectName %>
        <h1 class="title-color">name of Creator:</h1> <%=nameCreator %>
        <hr />
        <h1 class="title-color">project Description: </h1>
       <%=projectDescription %>
        <h1 class="title-color">project story: </h1>
       <%=about %>
        <br />
        <input type="submit" name="submitbtn" value="apply" class="btn btn-type2 type2-colorText"/>
        <br />
        <p style="color:black"><%=msg %></p> 
    </div>

</asp:Content>
