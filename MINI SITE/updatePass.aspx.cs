using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        public string userPass = "";
        public string msg = "";
        public string redirectJs = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            int affectedRows = 0;
            userPass = this.Session["login_userPass"].ToString();
            if (Request["submitbtn"] != null)
            {
                affectedRows=SQLHelper.DoQuery(string.Format("update users set password=N'{0}' where username=N'{1}'", Request["password"], this.Session["login_user"]));
                if (affectedRows == 1)
                {
                    msg = "Password was successfully changed";
                    redirectJs = "setTimeout(\"location.href = 'AdminManage.aspx';\", 5000);";
                }
            }
        }
    }
}