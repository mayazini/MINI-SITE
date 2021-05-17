using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["login_user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (Request["submitbtn"] != null && this.Session["login_user"].ToString()== Request["creatorUserName"])
            {
                string pName = Request["projectName"];
                string cName = Request["creatorUserName"];
                string desc = Request["description"];

                SQLHelper.DoQuery("insert into Projects (nameCreator, projectDescription, projectName ) values (N'"+cName+"',N'"+desc+"',N'"+pName+"')");

            }
        }
    }
}