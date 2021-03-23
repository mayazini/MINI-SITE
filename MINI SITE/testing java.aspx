<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="testing java.aspx.cs" Inherits="MINI_SITE.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;color:blue">
    <h1>מכולת</h1>
    <h2>חשבונית</h2>
    </div> 
<script type="text/javascript">
    var productAcost = 7;
    var productA =parseInt(prompt("the cost of the drink is 7$  how many drinks do u want? ", ""));
    var productBcost = 4;
    var productB = parseInt(prompt("the cost of the snack is 4$  how many snacks do u want? ", ""));
    var finalCost = (productAcost * productA) + (productBcost * productB); 
    var payment = parseInt(prompt("your finale payment is: " + finalCost + "  please enter payment:", "") ); 
    document.write("<table hight=100%><center>");
    document.write("<tr><center>");
    document.write("<td id='productA'><center>");
    var str = "drink: 7$ <br> " + "7" + "*" + productA + "=" + productAcost * productA;
    var result = str.fontcolor("green");
    document.write(result);
    document.write("</td>");
    document.write("</tr>");
    document.write("<tr><center>");
    document.write("<td><center>");
    document.write("snack: 4$ <br> " + "4" + "*" + productB + "=" + productBcost * productB);
    document.write("</td>");
    document.write("</tr>");
    document.write("</table>");
    document.write("<tr><center>");
    document.write("<td><center>");
    document.write("PAYMENT: " + finalCost);
    document.write("</td>");
    document.write("</tr>");
    document.write("<tr><center>");
    document.write("<td><center>");
    document.write("u payed: " + payment);
    document.write("</td>");
    document.write("</tr>");
    document.write("<tr><center>");
    document.write("<td><center>");
    if (payment - finalCost > 0) {
        document.write("ur change: " + (payment - finalCost));
    }
    else if (payment - finalCost < 0) {
        document.write("u need to pay : " + (finalCost - payment));
    }
    else {
        document.write("u payed exactly what was needed :)");
    }
    document.write("</td>");
    document.write("</tr>");
    document.write("</table>");

</script>
</asp:Content>
