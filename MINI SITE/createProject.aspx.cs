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
        public string msg = "";
        public string redirectJs = "";
        public string user = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["login_user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            user = Session["login_user"].ToString();
            if (Request["submitbtn"] != null && this.Session["login_user"].ToString()== Request["creatorUserName"])
            {
                
                string pName = Request["projectName"];
                string cName = Request["creatorUserName"];
                string desc = Request["description"];
                string about = Request["about"];

                int working = SQLHelper.DoQuery("insert into Projects (nameCreator, projectDescription, projectName, about ) values (N'"+cName+"',N'"+desc+"',N'"+pName+"', N'"+ about + "')");
                if(working > 0)
                {
                    msg = "project created successfully";
                    redirectJs = "setTimeout(\"location.href = 'myProjects.aspx';\", 5000);";
                }
            }
        }
    }
}