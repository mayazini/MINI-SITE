<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="MINI_SITE.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
     .form{
         height:100%;
         width:100%;
     }
body {
  font-family: Arial, Helvetica, sans-serif;
  
 
}
/* Add padding to containers */
.container {
  padding: 20px;
  background-color: white;
  width:50%;
  height:100%;

}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
}
input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

hr {
  border: 1px solid #f1f1f1;
  margin-bottom: 25px;
}


.registerbtn {
  background-color: #4CAF50;
  color: white;
  padding: 16px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 20%;
  opacity: 0.9;
}

.registerbtn:hover {
  opacity: 1;
}

a {
  color: dodgerblue;
}

.signin {
  background-color: #f1f1f1;
  text-align: center;
}
</style>
    
<form id="form1" runat="server" action="register.aspx" class="form">
  <div class="container">
    <h1>Register</h1>
    <p>Please fill in this form to create an account.</p>
    <hr>
    
    <label for="uname"><b>User Name</b></label>
     <input type="text" placeholder="Enter User Name" name="Uname" id="Uname" required/>
    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" id="password" required>
    <hr>
    <button type="submit" class="registerbtn">Register</button>
      <asp:Literal ID="registerError" runat="server"></asp:Literal>
  </div>
  <div class="container signin">
    <p>Already have an account? <a href="login.aspx">Sign in</a>.</p>     
  </div>
</form>
</asp:Content>
