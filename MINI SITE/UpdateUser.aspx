<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="MINI_SITE.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
         <%= redirectJs%>
    </script>
    <table class="table table-dark" <%=makeTableInvisible %>>
        <tr>
            <td>
                <label for="firstName"><b>first name</b></label>
                <input type="text" id="firstName" name="firstName" value="<%=firstName %>" style="color:black"/>
            </td>
        </tr>

        <tr>
            <td>
                <label for="lastName"><b>last name</b></label>
                <input type="text" id="lastName" name="lastName" value="<%=lastName %>" style="color:black" />
            </td>
        </tr>
        <tr>
            <td>
                <label for="age"><b>age</b></label>
                <input type="text" id="age" name="age" value="<%=age %>" style="color:black"/>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: left">
                <button type="submit" name="submitbtn" class="btn btn-type1">update</button>
            </td>
        </tr>
    </table>
    <p style="color: white"><%=msg %></p>
</asp:Content>
