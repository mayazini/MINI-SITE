<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="MINI_SITE.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" >

        function checkEmail() {
            var emailInput = document.getElementById("email");
            var bValidEmail = true;
            var notValidEmail;
            if (!/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.test(emailInput.value)) {
                bValidEmail = false;
                notValidEmail = "Email is not valid";
            }
            else {
                bValidEmail = true;
                notValidEmail = "";
            }
            document.getElementById("emailLabel").innerText = notValidEmail;
            return bValidEmail;
        }

        function checkPassword() {
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
                if (counterFollowing > 0)
                {
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
            else if ((counterCharacter >= 1 && counterNum >= 1 && counterLetter >=  1))
            {
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

        function checkId() {
            var id = document.getElementById("id");
            var bValidLengh = true;
            var bOnlyNumbers = true;
            var lengthError;
            var notOnlyNumbers;
            if (id.value.length != 9) {
                bValidLengh = false;
                lengthError = "Id needs to be 9 digits long";
            }
            else {
                bValidLengh = true;
                lengthError = "";
            }
            if (!/^[0-9]*$/.test(id.value)) {
                bOnlyNumbers = false;
                notOnlyNumbers = "Id can contain only numbers";
            }
            else {
                bOnlyNumbers = true;
                notOnlyNumbers = "";
            }
            document.getElementById("IdLabel").innerText = lengthError + "\n " + notOnlyNumbers;
            return bValidLengh && bOnlyNumbers;
        }

        function checkUserName(){
            var userName = document.getElementById("Uname");
            var bValidUnameLength = true;
            var bOnlyEnglishLetters = true;
            var notOnlyEnglishLetters="";
            var notValidLength="";
            if (userName.value.length < 5) {
                bValidUnameLength = false;
                notValidLength = "User name needs to be at least 5 letters long";
            }
            else {
                bValidUnameLength = true;
                notValidLength = "";
            }
            if (!/^[a-zA-Z]+$/.test(userName.value)) {
                bOnlyEnglishLetters = false;
                notOnlyEnglishLetters = "The user name can be only English letters";
            }
            else {
                bOnlyEnglishLetters = true;
                notOnlyEnglishLetters = "";
            }
            document.getElementById("UnameLabel").innerText = notValidLength + "\n " + notOnlyEnglishLetters;
            return bValidUnameLength && bOnlyEnglishLetters;
        }

        function checkForm() {
            var bValidPassword = checkPassword();
            var bValidEmail = checkEmail();
            var bValidusername = checkUserName();
            var bValidId = checkId();
            var vVerifyAll = bValidPassword && bValidEmail && bValidusername && bValidId;
            return vVerifyAll;
        }


    </script>
  <div class="container">
    <h1>Register</h1>
    <p>Please fill in this form to create an account.</p>
    <hr>
    
    <label for="uname"><b>User Name</b></label>
    <input  type="text" placeholder="Enter User Name" name="Uname" id="Uname" required/>
    <label for="uname" id="UnameLabel" style="color:red"></label>
       <br /><br />

    <label for="firstName"><b>Name</b></label>
    <input type="text" placeholder="Enter First Name" name="firstName" id="firstName" required/>

    <label for="lastName"><b>Last Name</b></label>
    <input type="text" placeholder="Enter Last Name" name="lastName" id="lastName" required/>

      <label for="email"><b>Email</b></label>
      <input type="text" placeholder="Enter Email" name="email" id="email" required />
      <label for="email" id="emailLabel" style="color:red"></label>
       <br /><br />

      <label for="id"><b>Id</b></label>
      <input type="text" placeholder="Enter Id" name="id" id="id" required />
       <label for="id" id="IdLabel" style="color:red"></label>
       <br /><br />

    <label for="Gender"><b>Gender</b></label><br />
    <input type="radio" id="male" name="gender" value="male">
    <label for="male">Male</label><br>
    <input type="radio" id="female" name="gender" value="female">
    <label for="female">Female</label><br>
    <input type="radio" id="other" name="gender" value="other">
    <label for="other">Other</label>

    <br /><br />

    <label for="phone"><b>Phone number</b></label>
    <input type="text" placeholder="Enter Phone Number" name="phone" id="phone" required/>
        <br /><br />

    <label for="age"><b>Age</b></label><br />
    <select name="age" id="age">
        <option><10</option>
        <option>>10</option>
    </select>

      <br /><br />
    <label for="interest"><b>Area of interest</b></label><br />
    <input type="checkbox" id="int1" name="int1" value="Bike" />
    <label for="int1"> I like biking</label><br>
    <input type="checkbox" id="int2" name="int2" value="Car" />
    <label for="int2"> I like driving</label><br>
      <br /><br />

    <label for="address"><b>Address</b></label><br /><br />
    <textarea placeholder="Enter address" name="address" id="address" required rows="3"></textarea>
        <br /><br />

      <label for="music"><b>Genres of music</b></label><br />
    <input type="checkbox" id="mus1" name="mus1" value="Rock" />
    <label for="mus1"> Rock music</label><br>
    <input type="checkbox" id="mus2" name="mus2" value="Clasical"/>
    <label for="mus2"> Clasical music</label><br /><br />

      <label for="feeling"><b>I'm feeling</b></label><br />
    <select name="feeling" id="feeling">
        <option>good</option>
        <option>bad</option>
    </select>
      <br /><br />

    <label for="psw"><b>Password</b></label>
    <input type="text" placeholder="Enter Password" name="password" id="password" required>
       <label for="psw" id="passwordLabel" style="color:red"></label>
       <br /><br />

    <label for="verifypsw"><b>Verify Password</b></label>
    <input type="text" placeholder="Verify password" name="verifypsw" id="verifypsw" required/>    
        <label for="verifypsw" id="verifyPasswordLabel" style="color:red"></label>
       <br /><br />
      <hr>
     <input type="submit" class="submitbtn" value="Register" onsubmit="return checkForm()"/>
      <asp:Literal ID="registerError" runat="server"></asp:Literal>
  </div>
  <div class="container signin">
      <button type="reset" class="cancelbtn" >Cancel</button><br />
      <p>Already have an account? <a href="login.aspx">Sign in</a>.</p>      
  </div>   
</asp:Content>
