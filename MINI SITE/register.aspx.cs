using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public string errorMsg="";
        protected void Page_Load(object sender, EventArgs e)
        {
            String uname = Request["uname"];


            if (uname != null)
            {
                string userNamedb = SQLHelper.SelectScalarToString("select username from users where username=N'" + uname + "'");
                if (userNamedb != "")
                {
                    errorMsg = "userName already exists, try again";
                }
                else
                {
                    string fName = Request["firstName"];
                    string lName = Request["lastName"];
                    string pass = Request["password"];
                    string id = Request["id"];
                    SQLHelper.DoQuery("insert into users (userName, firstName, lastName, password, id, admin) values (N'" + uname + "',N'" + fName + "',N'" + lName + "',N'" + pass + "','" + id + "','false')");
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}