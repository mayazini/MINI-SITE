﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteMsg.aspx.cs" Inherits="MINI_SITE.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body style="height: 571px" class="siteBackgroundColor">
    <form id="form1" runat="server" >
        <script type="text/javascript">
            <%=redirectJs%>
        </script>
            <table  class="table" >
                <tr>
                    <td>
                        <h5 class="title-color">subject: </h5> <%=subject %>                       
                    </td>
                    <td>
                        <h5 class="title-color">from:</h5>
                        <%=sender1 %>
                    </td>
                    <td> 
                        <h5 class="title-color">message:</h5> <%=message %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <button type="submit" name="submitbtn" class="btn btn-type1 type1-colorText">delete message</button>
                    </td>                   
                </tr>
            </table>

        <%=msg %>
    </form>
</body>
</html>
