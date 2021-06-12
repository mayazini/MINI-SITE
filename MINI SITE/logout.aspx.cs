using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if user logs in and whants to log out
            Application["loggedUsers"] = (int)(Application["loggedUsers"]) - 1;
            Session.Abandon();
            Response.Redirect("homepage.aspx");

        }
    }
}