<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MINI_SITE.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         
  <div class="container">
       <div class="imgcontainer">
    <img src="images/avatar.jpg" alt="Avatar" class="avatar">
     </div>
    <label for="uname"><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="uname" required/>

    <label for="password"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" required/>
        
    <input type="submit" class="submitbtn" value="login"/>
      <br />
    <%=errorMsg %>
  </div>

  <div class="container" style="background-color:#f1f1f1">   
   <a href="register.aspx">sign up??</a>
  </div>       
</asp:Content>
