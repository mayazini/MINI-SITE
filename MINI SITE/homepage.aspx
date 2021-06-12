<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="MINI_SITE.noName" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<div  style="background-image: url('vintagePicCinema.jpg');background-repeat: no-repeat;background-attachment: fixed; background-size: cover;">
        <img src="images/vintagePicCinema.jpg" style="width:70%;height:20%"/>
    </div>--%>

    <h1 class="center"></h1>
    <div class="container center" style="width: auto; height: auto;">
        <div class="row">
            <div class="col" style="font-size:34px">
               <h1 class="title-color">Project Creator</h1>
                <br />
                <p>You can create your own project.</p>
                <br />
                <p>By creating your own project you can share your movie/show</p>
                <p>And let other creators join your project</p>
                <p>To create your own project  <a href="register.aspx" style="text-decoration:none">register</a></p>
                <p>Then go to <a href="createProject.aspx" style="text-decoration:none">create new project</a> and write your idea</p>
                <hr />
                <p>Register now and make cool projects that people can be a part of</p>
            </div>
            <div class="vl"></div>
            <div class="col" style="font-size:34px">
               <h1 class="title-color">An independent artist </h1>  
                <br />

                <p>If you are an independent actor/ filmer/ director and more...</p>
                <p>Looking for a job</p>
                <p>Here you can find independent projects looking for artists</p>
                <p>You can apply to join projects by  <a href="register.aspx" style="text-decoration:none">registering</a> and going to <a href="Projects.aspx" style="text-decoration:none">projects page</a></p>
                <p>And applying</p>
                <hr />
                <p>Register now and find cool projects to be a part of</p>
            </div>
        </div>
    </div>

</asp:Content>
