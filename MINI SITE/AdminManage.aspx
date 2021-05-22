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
                <input type="search" id="search3" class="form-control" placeholder="Last Name" name="lastName"aria-label="Search" />
                 </div>
            </td>
            <td >
                <div class="btncontainer">
                  <div class="vertical-center">
                     <button type="submit" class="btn btn-type1 type1-colorText" name="searchbtn" > search </button>
                  </div>
                </div>
               
            </td>
        </tr>

    </table>
   

    <div>
         <%=usersList %>
    </div>
   
</asp:Content>
