<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminManage.aspx.cs" Inherits="MINI_SITE.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td>
                <div class="form-outline">
                <input type="search" id="search1" class="form-control" placeholder="User Name" name="userName"
                aria-label="Search" />
                </div>
            </td>
            <td>
                <div class="form-outline">
                <input type="search" id="search2" class="form-control" placeholder="First Name" name="firstName"
                   aria-label="Search" />
                    </div>
            </td>
            <td>
                <div class="form-outline">
                <input type="search" id="search3" class="form-control" placeholder="Last Name" name="lastName"
                 aria-label="Search" />
                 </div>
            </td>
            <td>
                <button type="submit" class="btn btn-outline-primary" name="searchbtn">search</button>
            </td>
        </tr>

    </table>
    <%--<div class="input-group">
    <input type="text" class="form-control" placeholder="Search this blog">
    <input type="text" class="form-control" placeholder="Search this blog">
    <input type="text" class="form-control" placeholder="Search this blog">
    <div class="input-group-append">
      <button class="btn btn-secondary" type="button">
        <i class="fa fa-search"></i>
      </button>
    </div>
  </div>--%>

    <div>
         <%=usersList %>
    </div>
   
</asp:Content>
