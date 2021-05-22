<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="MINI_SITE.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div <%=makeTableInvisible %>>

        <img src="images/interstellar.jpg" style="width: 400px; height: 300px" />

        <h2 class="siteTextColor">Interstellar</h2>
        <p style="color: white">
            movie by Christopher Nolan,about travel through space and time.<br />
            It's a great movie that takes the idea of times and breaks it into little pieces so our minds can somewhat undestand the scale of the universe and our own lives.
        </p>

        <br />
        <br />
        <p style="color: white">Other movies by Christopher Nolan</p>
        <ul>
            <li>
                <p style="color: white">Memento (2000)</p>
            </li>
            <li>
                <p style="color: white">Dark Night (2008)</p>
            </li>
            <li>
                <p style="color: white">Inception (20010)</p>
            </li>
            <li>
                <p style="color: white">Dunkirk (2017)</p>
            </li>
        </ul>
        <br />


        <img src="images/jojo%20rabbit.jpg" style="width: 400px; height: 300px" />

        <h2 class="siteTextColor">Jojo Rabbit</h2>
        <p style="color: white">movie by Taika Waititi,a comedy-drama film set in Germany. It takes us through a funny and sad journey and lets us see world war II through a different point of view.</p>
        <br />

        <img src="images/lala-1%20(1).png" style="width: 400px; height: 300px" />

        <h2 class="siteTextColor">La La Land</h2>
        <p style="color: white">movie by Damien Chazelle, a great story about two artists falling in love and having to sacrifice their love for their dreams</p>

        <br />
        <img src="images/parasite.jpg" style="width: 400px; height: 300px" />

        <h2 class="siteTextColor">Parasite</h2>
        <p style="color: white">
            movie by Bong Joon Ho, it tells the story of two Korean families, one is poor and the other is wealthy.<br />
            It reveals the sad truth about society and opens a very interesting discussion on the subject with a very surprising end.
        </p>
        <br />

        <img src="images/the%20social%20network.jpeg" style="width: 400px; height: 300px" />

        <h2 class="siteTextColor">The Social Network</h2>
        <p style="color: white">movie directed by David Fincher, it shows the process of making the famous Facebook through Mark Zuckerberg’s point of view.</p>
        <br />

        <img src="images/once%20upon%20a%20time%20in%20hollywood%20img.jfif" style="width: 400px; height: 300px" />
        <h2 class="siteTextColor">Once Upon A Time In Hollywood</h2>
        <p style="color: white">
            movie by Quentin Tarantino, a film that takes place in 70's Hollywood.<br />
            It's based on a real story with a Quentin Tarantino ending
        </p>
    </div>
    <p style="color: white"><%=msg %></p>
</asp:Content>
