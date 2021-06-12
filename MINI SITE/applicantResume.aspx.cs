using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class resume : System.Web.UI.Page
    {
        public string usersList;
        public string username = "";
        public string projectName = "";
        public string firstName = "";
        public string lastName = "";
        public string email = "";
        public string age = "";
        public string msg;
        public string redirectJs;
        public string btn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                string userName = Request.QueryString["queryUsername"];
                projectName = Request.QueryString["projectName"];
                string projectId = Request.QueryString["projectId"];
                username = userName;
                if (Request["isApproved"] == "false")
                {
                    btn = "approve";
                    if (Request["btn"] != null)
                    {
                        string sql = "update JobOffers set isApproved = 'true' where userName= N'" + userName + "' and id='" + projectId + "'";
                        SQLHelper.DoQuery(sql);
                        Response.Redirect("sendMsg.aspx?projectName=" + projectName + "&recieverName=" + userName + "&isApproved=true");
                    }
                }
                else if(Request["isApproved"] == "true")
                {
                    btn = "unapprove";
                    if (Request["btn"] != null)
                    {
                        string sql = "update JobOffers set isApproved = 'false' where userName= N'" + userName + "' and id='" + projectId + "'";
                        SQLHelper.DoQuery(sql);
                        Response.Redirect("sendMsg.aspx?projectName=" + projectName + "&recieverName=" + userName + "&isApproved=false");
                    }
                }

                //BuildTable("select userName, firstName, lastName, email, age from users where userName = N'"+userName+"'");
                DataTable dt = SQLHelper.SelectData("select userName, firstName, lastName, email, age from users where userName = N'" + userName + "'");
                DataRow row;
                if (dt.Rows.Count >= 1)
                {
                    row = dt.Rows[0];
                    firstName = row["firstName"].ToString();
                    lastName = row["lastName"].ToString();
                    email = row["email"].ToString();
                    age = row["age"].ToString();
                }
                //if (Request["isApproved"] == "false")
                //{
                //    if (Request["approve"] != null)
                //    {
                //        string sql = "update JobOffers set isApproved = 'true' where userName= N'" + userName + "' and id='" + projectId + "'";
                //        SQLHelper.DoQuery(sql);
                //        Response.Redirect("sendMsg.aspx?projectName=" + projectName + "&recieverName=" + userName + "&isApproved=true");
                //    }
                //}
                //else
                //{
                //    if (Request["approve"] != null)
                //    {
                //        string sql = "update JobOffers set isApproved = 'true' where userName= N'" + userName + "' and id='" + projectId + "'";
                //        SQLHelper.DoQuery(sql);
                //        Response.Redirect("sendMsg.aspx?projectName=" + projectName + "&recieverName=" + userName + "&isApproved=true");
                //    }
                //}
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}