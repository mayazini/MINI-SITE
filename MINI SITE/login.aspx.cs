using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MINI_SITE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string errorMsg;
        public string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMsg = "";
            String uname = Request["uname"];
            String password = Request["password"];
  
            if (uname != null & password != null)
            {
                errorMsg = "";
                DataTable dtUser = SQLHelper.SelectData("select * from users where userName=N'" + uname + "' and password=N'" + password + "'");
                DataRow row;
                if (dtUser.Rows.Count >= 1)
                {
                    row = dtUser.Rows[0];
                    user = row["userName"].ToString();
                    if (user != "")
                    {
                        this.Session["login_user"] = uname;
                        if (Convert.ToBoolean(row["admin"]))
                        {
                            this.Session["user_isAdmin"] = true;
                            Response.Redirect("AdminManage.aspx");
                        }
                        else
                        {
                            this.Session["user_isAdmin"] = false;
                            Response.Redirect("homepage.aspx");
                        }
                    }                 
                }
                else
                {
                    errorMsg = "Login failed! Try again or register<br/>";
                }
            }
    }    }
}