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
        public string errorMsg="";
        public string user ="";
        protected void Page_Load(object sender, EventArgs e)
        {
            //add different msgs if user doesn't exist or doesn't match pass
            String userNameForm = Request["uname"];
            String passwordFrom = Request["password"];
  
            if (Request["submitbtn"]!=null)
            {
                errorMsg = "";
                DataTable dtUser = SQLHelper.SelectData("select * from users where userName=N'" + userNameForm + "' and password=N'" + passwordFrom + "'");
                DataRow row;
                if (dtUser.Rows.Count >= 1)
                {
                    row = dtUser.Rows[0];
                    user = row["userName"].ToString();
                    if (user != "")
                    {
                        Session["login_user"] = userNameForm;
                        Session["login_userPass"] = passwordFrom;
                        if (Convert.ToBoolean(row["admin"]))
                        {
                           Session["user_isAdmin"] = true;
                            Response.Redirect("AdminManage.aspx");
                        }
                        else
                        {
                            Session["user_isAdmin"] = false;
                            Response.Redirect("noName.aspx");
                        }
                    }                 
                }
                else
                {
                    errorMsg = "Login failed! Try again or register<br/>";
    
                }
            }
    }   }
}