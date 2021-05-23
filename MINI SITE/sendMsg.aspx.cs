using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class sendMsg : System.Web.UI.Page
    {
        public string from="";
        public string reciever="";
        public string message="";
        public string alert="";
        public string redirectJs = "";
        public string subject = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                int msg=0;
                from = Session["login_user"].ToString();
                if (Request.QueryString["recieverName"] != null && Request.QueryString["recieverName"] != "")
                {
                    subject = Request.QueryString["projectName"];
                    reciever = Request.QueryString["recieverName"];
                    if (Request.QueryString["isApproved"] == "true")
                    {
                        message = "Congratulations, "+ reciever +".Welcome to our project";
                    }
                }

                if (Request["submitbtn"] != null)
                {
                    msg = SQLHelper.DoQuery("insert into Inbox (sender,reciever,message,Subject) values (N'"+Request["fName"]+"', N'"+Request["tName"]+"', N'"+ Request["message"] + "' , N'"+ Request["subject"] + "')");
                }

                if (msg > 0)
                {
                    alert = "Message sent successfully";
                    redirectJs = "setTimeout(\"location.href = 'Projects.aspx';\", 5000);";
                }
                else
                {
                    alert = "";
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
           
        }
    }
}