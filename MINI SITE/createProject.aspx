<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="createProject.aspx.cs" Inherits="MINI_SITE.WebForm16" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row centered-form">
            <div>

                <div class="panel-heading">
                    <h3 class="panel-title; siteTextColor">Create your own project <small style="color: white">Share your work and use this platform!</small></h3>
                </div>
                <hr />
                <div class="panel-body">

                    <div class="row">
                        <div class="col-xs-6 col-sm-6 col-md-6">
                            <div class="form-group">
                                <p class="siteTextColor">project name</p>
                                <input type="text" name="projectName" id="projectName" class="form-control input-sm" placeholder="Project Name">
                               
                            </div>
                        </div>
                        <div class="col-xs-6 col-sm-6 col-md-6">
                            <div class="form-group">
                                <p class="siteTextColor">creator user name</p>
                                <input type="text" name="creatorUserName" id="creatorUserName" class="form-control input-sm" placeholder="Creator User Name">
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <p class="siteTextColor">project description</p>
                        <textarea placeholder="Enter project details" name="description" id="description" required rows="3" style="width: 500px; height: 100px; color: black"></textarea>
                    </div>


                    <input type="submit" name="submitbtn" value="Create Project" class="btn btn-warning btn-block" >
                </div>
            </div>

        </div>
    </div>
</asp:Content>
