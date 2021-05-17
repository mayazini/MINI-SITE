using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public string makeTableInvisible = null;
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["login_user"] == null)
            {
                makeTableInvisible = "style='display : none'";
                msg = "This page is for logged in users only";
            }
        }
    }
}