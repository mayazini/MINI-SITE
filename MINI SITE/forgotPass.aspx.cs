using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm15 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //SmtpClient smtpClient = new SmtpClient("mail.CinemaLovers.com", 25);

            //smtpClient.Credentials = new System.Net.NetworkCredential("mayazini2005@gmail.com", "mzini2005");
            //// smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = true;
            //MailMessage mail = new MailMessage();
            //string pass = SQLHelper.SelectScalarToString(string.Format("select password from users where email=N''", Request["email"]));
            ////Setting From , To and CC
            //mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            //mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            //smtpClient.Send(mail);
        }
    }
}