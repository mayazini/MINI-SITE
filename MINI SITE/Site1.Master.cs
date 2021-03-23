using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string userName = "";
        public string forAdmin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["login_user"] != null)
            {
                userName ="HELLO " + this.Session["login_user"].ToString();
                if (Convert.ToBoolean(this.Session["user_isAdmin"]))
                {
                    forAdmin = "<a class='btn btn-secondary' href='AdminManage.aspx' role='button'>Admin Page</a>";
                }
            }
           

        }
    }
}