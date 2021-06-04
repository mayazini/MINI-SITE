<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sendMsg.aspx.cs" Inherits="MINI_SITE.sendMsg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<script type="text/javascript">

            <%=redirectJs%>

    </script>
    <div class="container contact" style="width:auto;height:auto;">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image"/>
				<h1 class="title-color">send a message to any user!</h1>				
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				<div class="form-group">
				  <label class="control-label col-sm-2 siteTextColor" for="subject">Subject:</label>
				  <div class="col-sm-10">          
					  <input type="text" class="form-control" id="subject" placeholder="Enter the subject" name="subject" value="<%=subject %>" required>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2 siteTextColor" for="fname">From:</label>
				  <div class="col-sm-10">          
					  <input type="text" class="form-control" id="fName" placeholder="Enter your user name" name="fName" value="<%=from %>" required>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2 siteTextColor" for="tName">To:</label>
				  <div class="col-sm-10">          
					<input type="text" class="form-control" id="tName" placeholder="Enter reciever user name" name="tName" value="<%=reciever %>" required>
				  </div>
				</div>
				<%--<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Email:</label>
				  <div class="col-sm-10">
					<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">
				  </div>
				</div>--%>
				<div class="form-group">
				  <label class="control-label col-sm-2 siteTextColor" for="message">Message:</label>
				  <div class="col-sm-10">
					<textarea class="form-control" rows="5" id="message" name="message"><%=message %></textarea>
				  </div>
				</div>
				<div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10">
					<input type="submit" class="btn btn-type2" style="width:100%" name="submitbtn" value="send">
				  </div>
				</div>
				<label style="color:red"><%=alert %></label>
			</div>
		</div>
	</div>
</div>

</asp:Content>
