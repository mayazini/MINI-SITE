<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteProject.aspx.cs" Inherits="MINI_SITE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body style="height: 571px" class="siteBackgroundColor">
    <form id="form1" runat="server">
        <script type="text/javascript">
            <%=redirectJs%>
        </script>
        <div class="container siteTextColor" style="font-size: 30px; height: auto; width: auto">
        <h1 class="title-color">project Name: </h1>
        <p class="siteTextColor"><%=projectName %></p>
        <h1 class="title-color">name of Creator:</h1>
        <p class="siteTextColor"><%=nameCreator %></p>
        <hr />
        <h1 class="title-color">project Description: </h1>
        <p class="siteTextColor"><%=projectDescription %></p>
        <h1 class="title-color">project story: </h1>
        <p class="siteTextColor"><%=about %></p>
        <br />
        <input type="submit" name="submitbtn" value="delete" class="btn btn-danger"/>
        <br />
        <p style="color: black"><%=msg %></p>
    </div>
    </form>
</body>
</html>
