<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="MINI_SITE.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">

        function AreUsure()
        {
            ret = confirm("are you sure you want to delete user <%=userName %> ?"); 
            return ret;        
        }

            <%=redirectJs%>

    </script>
    <table class="table table-dark" <%= makeTableInvisible %>>
          <thead>
            <tr>
              <th scope="col">User Name</th>
              <th scope="col">First Name</th>
              <th scope="col">Last Name</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td><%=userName %></td>
              <td><%=firstName %></td>
              <td><%=lastName %></td>
            </tr> 
              <tr>
                  <td colspan="3" style="text-align: left">
                          <button type="submit" name="submitbtn" onclick="return AreUsure()" class="btn btn-outline-primary">delete</button>
                  </td>
              </tr>
          </tbody>
    </table>
    <%=msg %>
</asp:Content>
