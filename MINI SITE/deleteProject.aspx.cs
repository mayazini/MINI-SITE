using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string nameCreator;
        public string projectDescription;
        public string projectName;
        public string msg;
        public string projectId;
        public string about;
        public string redirectJs;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null && Convert.ToBoolean(this.Session["user_isAdmin"]))
            {
                projectName = Request.QueryString["queryProjectname"];
                projectId = Request.QueryString["projectId"];
                if (projectName != null && projectName != "")
                {
                    DataRow row;
                    DataTable dt = SQLHelper.SelectData(string.Format("select nameCreator, projectDescription,about from Projects where id = N'{0}'", projectId));
                    int rows = dt.Rows.Count; // fix the row text dt.rows.count - doesnt work
                    if (rows >= 1)
                    {
                        row = dt.Rows[0];
                        nameCreator = row["nameCreator"].ToString();
                        projectDescription = row["projectDescription"].ToString();
                        about = row["about"].ToString();

                    }

                    if (Request["submitbtn"] != null)
                    {
                        int a = SQLHelper.DoQuery("delete from Projects where id ='" + projectId + "'");
                        if (a > 0)
                        {
                            msg = "project deleted, redirecting to projects";
                            redirectJs = "setTimeout(\"location.href ='projects.aspx';\", 3000);";
                        }
                    }

                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}