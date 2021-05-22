using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        public string nameCreator;
        public string projectDescription;
        public string projectName;
        public string msg;
        public string projectId;
        public string about;
        protected void Page_Load(object sender, EventArgs e)
        {
            projectName = Request.QueryString["queryProjectname"];
            projectId = Request.QueryString["projectId"];
            if (projectName != null && projectName != "")
            {
                DataRow row;
                DataTable dt = SQLHelper.SelectData(string.Format("select nameCreator, projectDescription,about from Projects where id = N'{0}'", projectId));
                int rows = dt.Rows.Count;// fix the row text dt.rows.count - doesnt work
                if (rows >= 1)
                {
                    row = dt.Rows[0];
                    nameCreator = row["nameCreator"].ToString();
                    projectDescription = row["projectDescription"].ToString();
                    about= row["about"].ToString();

                }
                if (Request["submitbtn"] != null)
                {
                    if (Session["login_user"] != null)
                    {
                        string userName = Session["login_user"].ToString();// keep the skill in session
                        string skill = SQLHelper.SelectScalarToString("select skill from users where userName = N'" + userName + "'");
                        int a = SQLHelper.DoQuery("insert into JobOffers (userName, userSkill, projectName,projectId, isApproved) values ('" + userName + "', '" + skill + "', '" + projectName + "', '"+projectId+"', 'false')");
                        if (a > 0)
                        {
                            msg = "application sent";
                        }
                        Session["userSkill"] = skill;

                    }
                    else
                    {
                        msg = "To apply you have to be logged in";
                    }
                }    
            }
        }
    }
}