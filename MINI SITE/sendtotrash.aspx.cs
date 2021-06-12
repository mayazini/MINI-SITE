using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class sendtotrash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                SQLHelper.DoQuery("update inbox set trash='true' where id = '" + Request.QueryString["Id"] + "'");
                Response.Redirect("inbox.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}