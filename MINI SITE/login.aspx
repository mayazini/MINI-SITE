<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MINI_SITE.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         
  <div class="container">
       <div class="imgcontainer">
    <img src="images/avatar.jpg" alt="Avatar" class="avatar">
     </div>

    <label for="uname" ><p class="siteTextColor" >Username</p></label>
    <input type="text" placeholder="Enter Username" name="uname" required/>

    <label for="password" ><p class="siteTextColor">Password</p></label>
    <input type="password" placeholder="Enter Password" name="password" required/>
        
   <%-- <input name="submitbtn" type="submit" class="submitbtn" value="login" />--%>
      <div class="form-group">
			<input name="submitbtn" type="submit" value="Login" class="btn float-right login_btn" style="background-color: #ffc107">
      </div>
      <br />
    <%=errorMsg %>
  </div>

  <div class="container" style="background-color:black">   
   <a href="register.aspx">sign up??</a>
  </div> 
    <%--/////--%>

    

</asp:Content>
