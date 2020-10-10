using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String uname = Request["uname"];
            String password = Request["password"];
            Hashtable htUsers = null;
            if (uname != null & password != null)
            {
                if (Application["GlobalUsers"] != null)
                {
                    htUsers = this.Application["GlobalUsers"] as Hashtable;
                    if (htUsers.ContainsKey(uname) && ((String)htUsers[uname] == password))
                    {
                        this.Session["login_user"] = uname;
                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        Response.Write("Login failed! Try again<br/>");
                    }

                }
                else
                {

                    loginError.Text = "Login failed! Try again or register<br/>";
                }
            }
    }    }
}