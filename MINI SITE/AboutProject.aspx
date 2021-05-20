<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutProject.aspx.cs" Inherits="MINI_SITE.WebForm18" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-dark">
        <thead>
            <tr>
                <th scope="col">name of Creator</th>
                <th scope="col">project Description</th>
                <th scope="col">project Name</th>
            </tr>
        </thead>
        <tbody>
            <tr style="color:white">
                <td><%=nameCreator %></td>
                <td><%=projectDescription %></td>
                <td><%=projectName %></td>
            </tr>
        </tbody>
        <tfoot style="border:none">
            <tr><td><input type="submit" name="submitbtn" value="apply" class="btn btn-type2 type2-colorText"/></td></tr>
            <tr style="color:white"><%=msg %></tr>
        </tfoot>
    </table>
</asp:Content>
