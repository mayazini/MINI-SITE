<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MINI_SITE.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

button {
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

button:hover {
  opacity: 0.8;
}



.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
}

img.avatar {
  width: 20%;
  height:30%;
  border-radius: 50%;
}

.container {
  padding: 16px;
  width:50%;
}

.login{
    width:20%;
}

</style>

          <h2>Login Form</h2>
<form id="form1" runat="server" action="login.aspx" method="post">
  <div class="container">
       <div class="imgcontainer">
    <img src="images/avatar.jpg" alt="Avatar" class="avatar">
     </div>
    <label for="uname"><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="uname" required>

    <label for="password"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" required>
        
    <button type="submit" class="login">Login</button>
    <asp:Literal ID="loginError" runat="server"></asp:Literal>
  </div>

  <div class="container" style="background-color:#f1f1f1">   
   <a href="register.aspx">sign up??</a>
  </div>
</form>
</asp:Content>
