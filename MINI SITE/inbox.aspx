<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="MINI_SITE.inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%--link with an icon --%>
   <%--<a href="deleteMsg.aspx"><i class='bi bi-trash'></i></a>--%>
   <%-- <a href="deleteMsg.aspx" style="color:red !important"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16"><path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/><path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/></svg><i class="bi bi-trash " ></i></a>--%>
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
