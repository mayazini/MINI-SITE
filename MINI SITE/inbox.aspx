<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="MINI_SITE.inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="myTable" style="background-color:transparent"> 
        <tr>
            <td>
                <div class="form-outline">
                    <input type="search" id="search3" class="form-control" placeholder="subject" name="subject" aria-label="Search" />
                </div>
            </td>
            <td>
                <div class="btncontainer">
                    <div class="vertical-center">
                        <button type="submit" class="btn btn-type1 type1-colorText" name="searchbtn">search </button>
                    </div>
                </div>
            </td>
        </tr>
    </table>
    <%=usersList %>
</asp:Content>
