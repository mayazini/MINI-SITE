﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sendMsg.aspx.cs" Inherits="MINI_SITE.sendMsg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<script type="text/javascript">

            <%=redirectJs%>

    </script>
    <div class="container contact" style="width:auto;height:auto;background-color:#313131">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image"/>
				<h1>send a message to any user!</h1>				
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				<div class="form-group">
				  <label class="control-label col-sm-2" for="subject">Subject:</label>
				  <div class="col-sm-10">          
					  <input type="text" class="form-control" id="subject" placeholder="Enter the subject" name="subject" value="<%=subject %>">
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="fname">From:</label>
				  <div class="col-sm-10">          
					  <input type="text" class="form-control" id="fName" placeholder="Enter your user name" name="fName" value="<%=from %>">
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="tName">To:</label>
				  <div class="col-sm-10">          
					<input type="text" class="form-control" id="tName" placeholder="Enter reciever user name" name="tName" value="<%=reciever %>">
				  </div>
				</div>
				<%--<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Email:</label>
				  <div class="col-sm-10">
					<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">
				  </div>
				</div>--%>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="message">Message:</label>
				  <div class="col-sm-10">
					<textarea class="form-control" rows="5" id="message" name="message"><%=message %></textarea>
				  </div>
				</div>
				<div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10">
					<input type="submit" class="btn " style="background-color:#aaaaaa; width:100%" name="submitbtn" value="send">
				  </div>
				</div>
				<label style="color:red"><%=alert %></label>
			</div>
		</div>
	</div>
</div>

</asp:Content>