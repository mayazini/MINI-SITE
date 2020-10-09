<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="MINI_SITE.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%">
        <tr>
            <td style="text-align:left;vertical-align:top">
               <a href="#interstellar"><img src="images/interstellar.jpg"style="width: 400px;height:300px"/></a>   
            </td>
            <td style="text-align:center;vertical-align:top">
                <a href="#jojo rabbit"><img src="images/jojo%20rabbit.jpg"style="width: 400px; height:300px"/></a>    
            </td>
            <td style="text-align:right;vertical-align:top">
                <a href="#la la land"><img src="images/la%20la%20land.jpg"style="width: 300px; height:400px"/></a>  
            </td>
        </tr>
        <tr>
            <td style="text-align:left">
               <a href="#parasite"><img src="images/parasite.jpg"style="width: 400px; height:300px"/></a>      
            </td>
            <td style="text-align:center">
                <a href="#the social network"><img src="images/the%20social%20network.jpeg"style="width: 400px; height:300px"/></a>     
            </td>
            <td style="text-align:right">
                <a href="#once upon a time"><img src="images/once%20upon%20a%20time%20in%20hollywood.jpg"style="width: 300px; height:400px"/></a>  
           </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <a name="interstellar">A movie by christopher nolan, it's about travel through space and time. It's a great movie that takes the idea of times and breaks it into little pieces so our minds can somewhat undestand the scale of the universe and our own lives</a>
            </td>
        </tr>
        <tr>
            <td>
                <a name="jojo rabbit">A movie by hen</a> 
            </td>
        </tr>
        <tr>
            <td>
                <a name="the social network">a movie by christopher nolan</a>
            </td>
        </tr>
        <tr>
            <td>
                <a name="parasite">a movie by christopher nolan</a>
            </td>
        </tr>
        <tr>
            <td>
                <a name="la la land">a movie by christopher nolan</a>
            </td>
        </tr>
        <tr>
            <td>
                <a name="once upon a time">a movie by christopher nolan</a>
            </td>
        </tr>
    </table>
</asp:Content>
