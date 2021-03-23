<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="MINI_SITE.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
   
</style>
    <table>
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
                <a name="interstellar"><h2 >Interstellar</h2>
                   A movie by Christopher Nolan,about travel through space and time.<br /> It's a great movie that takes the idea of times and breaks it into little pieces so our minds can somewhat undestand the scale of the universe and our own lives.</a>
                    <br /><br />
                Other movies by Christopher Nolan
                <ul >
                    <li>Memento (2000)</li>
                    <li>Dark Night (2008)</li>
                    <li>Inception (20010)</li>
                    <li>Dunkirk (2017)</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <a name="jojo rabbit"><h2 >Jojo Rabbit</h2>movie by Taika Waititi,a comedy-drama film set in Germany. It takes us through a funny and sad journey and lets us see world war II through a different point of view.</a>
                <br /><br/>
            </td>
        </tr>
        <tr>
            <td>
                <a name="the social network"><h2> The Social Network</h2> movie directed by David Fincher, it shows the process of making the famous Facebook through Mark Zuckerberg’s point of view.</a>
                <br /><br />
            </td>
        </tr>
        <tr>
            <td>
                <a name="parasite"><h2 >Parasite</h2> movie by Bong Joon Ho, it tells the story of two Korean families, one is poor and the other is wealthy.<br />
                  It reveals the sad truth about society and opens a very interesting discussion on the subject with a very surprising end.</a>
                 <br /><br/>   
            </td>
        </tr>
        <tr>
            <td>
                <a name="la la land"><h2>La La Land</h2> movie by Damien Chazelle, a great story about two artists falling in love and having to sacrifice their love for their dreams</a>
                <br /><br/>  
            </td>
        </tr>
        <tr>
            <td>
                <a name="once upon a time"><h2>Once Upon A Time In Hollywood</h2> A movie by Quentin Tarantino, a film that takes place in 70's Hollywood.<br /> It's based on a real story with a Quentin Tarantino ending </a>
                <br /><br/>  
            </td>  
        </tr>
    </table>
</asp:Content>
