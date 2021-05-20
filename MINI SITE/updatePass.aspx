<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="updatePass.aspx.cs" Inherits="MINI_SITE.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function checkForm() {
            debugger;
            var password = document.getElementById("password");
            var bValidLength = true;
            var bStrongPass = true;
            var bValidPassSameValue = true;
            var bNotFollowing = true;
            var lengthError;
            var notStrong;
            var notFollowing;

            //not following
            var counterFollowing = 0;
            for (var i = 0; i < password.value.length - 1; i++) {
                if ((password.value.charCodeAt(i) + 1) == password.value.charCodeAt(i + 1) && i != password.value.length - 1) {
                    counterFollowing++;
                }
            }
            if (counterFollowing > 0) {
                bNotFollowing = false;
                notFollowing = "The password can not have following numbers or letters";
            }
            else {
                bNotFollowing = true;
                notFollowing = "";
            }


            //at least....
            var counterCharacter = 0;
            var counterNum = 0;
            var counterLetter = 0;
            for (var i = 0; i <= password.value.length - 1; i++) {
                var passValue = password.value.charCodeAt(i);
                if ((passValue >= 65 && passValue <= 90) || (passValue >= 97 && passValue <= 122)) {
                    counterLetter++;
                }
                if (passValue == 125 || passValue == 123 || passValue == 33 || passValue == 64 || passValue == 35 || passValue == 36 || passValue == 37 || passValue == 94 || passValue == 38 || passValue == 42 || passValue == 41) {
                    counterCharacter++;
                }
                if (passValue >= 48 && passValue <= 57) {
                    counterNum++;
                }
            }
            if (counterCharacter < 1 || counterNum < 1 || counterLetter < 1) {
                bStrongPass = false;
                notStrong = "Pass needs at least one English letter, one number and one of these:{!@#$%^&*(}";
            }
            else if ((counterCharacter >= 1 && counterNum >= 1 && counterLetter >= 1)) {
                bStrongPass = true;
                notStrong = "";
            }

            //length
            if (password.value.length < 3) {
                bValidLength = false;
                lengthError = "password needs to be at least 3 digits long";
            }
            else {
                bValidLength = true;
                lengthError = "";
            }

            //innerText
            document.getElementById("passwordLabel").innerText = lengthError + " \n" + notStrong + " \n" + notFollowing;
            
            //verifyPass
            var verifyPassword = document.getElementById("verifypsw");
            if (password.value != verifyPassword.value) {
                bValidPassSameValue = false;
                document.getElementById("verifyPasswordLabel").innerText = "Verify Password needs to be the same as the password";
            }
            else {
                bValidPassSameValue = true;
                document.getElementById("verifyPasswordLabel").innerText = "";
            }

            return bValidLength && bStrongPass && bValidPassSameValue && bNotFollowing;
        }
        <%= redirectJs%>
    </script>
       
     <div class="container">
	<div class="row">
		<div >
		    
		    <label class="siteTextColor">Current Password</label>
		    <div class="form-group pass_show"> 
                <input type="password"  class="form-control" value="<%=userPass %>" placeholder="<%=userPass %>">
            </div> 
		       <label class="siteTextColor">New Password</label>
            <div class="form-group pass_show"> 
                <input type="password"  class="form-control" placeholder="New Password" id="password" name="password">
                <label for="psw" id="passwordLabel" style="color:red"></label>
            </div> 
		       <label class="siteTextColor">Confirm Password</label>
            <div class="form-group pass_show"> 
                <input type="password"  class="form-control" placeholder="Confirm Password" id="verifypsw" name="verifypsw"> 
                 <label for="verifypsw" id="verifyPasswordLabel" style="color:red"></label>
            </div> 
            <div>
                <input type="submit" name="submitbtn" class="btn btn-type2 type2-colorText" onsubmit ="return checkForm()" value="update pass"/>
                <b style="color:white"><%=msg %></b>
            </div>
            
		</div>  
	</div>
</div>

</asp:Content>
