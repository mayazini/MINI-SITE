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
        public string makeItInvisible= "style='display : none'";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["login_user"] != null)
            {
                //drop down menu if user logs in
                makeItInvisible = " ";
                //hello user
                userName = "hello " + this.Session["login_user"].ToString();
                //link to admin page only if admin
                if (Convert.ToBoolean(this.Session["user_isAdmin"]))
                {
                    forAdmin = "<a class='btn btn-warning' href='AdminManage.aspx' role='button'>Admin Page</a>";
                }
            }
        }
    }
}