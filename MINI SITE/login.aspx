<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MINI_SITE.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <h1 class="title-color">Log In</h1>
        <div class="imgcontainer">
            <img src="images/הורדה.png" alt="Avatar" class="avatar">
        </div>

        <label for="uname">
            <p class="siteTextColor">Username</p>
        </label>
        <input type="text" placeholder="Enter User name" name="uname" style="color: black" required />

        <label for="password">
            <p class="siteTextColor">Password</p>
        </label>
        <input type="password" placeholder="Enter Password" name="password" style="color: black" required />

        <%-- <input name="submitbtn" type="submit" class="submitbtn" value="login" />--%>
        <div class="form-group">
            <input name="submitbtn" type="submit" value="Login" class="btn float-right login_btn btn-type2 type2-colorText">
        </div>
        <br />
        <%=errorMsg %>
    </div>

    <div class="container footerBackgroundColor">
        <%--////  --%>
        <a href="register.aspx" class="footerTitleColor">sign up</a>
        <br />
        

    </div>
    <%--/////--%>
</asp:Content>
