using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        public string subject;
        public string message;
        public string sender1;
        public string msg;
        public string makeTableInvisible;
        public string redirectJs;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                string id = Request.QueryString["Id"];
                if (id != null && id != "")
                {
                    if (Request["submitbtn"] == null)
                    {
                        DataTable dt = SQLHelper.SelectData(string.Format("select subject, message, sender from inbox where id = N'{0}'", id));
                        DataRow row;
                        if (dt.Rows.Count >= 1)
                        {
                            row = dt.Rows[0];
                            subject = row["subject"].ToString();
                            message = row["message"].ToString();
                            sender1 = row["sender"].ToString();
                        }
                    }
                    else
                    {
                        string sql = "delete from inbox where id = N'" + id + "'";
                        SQLHelper.DoQuery(sql);
                        Response.Redirect("deleteMsg.aspx?message=message " + subject + " was deleted, redirecting to inbox page");
                    }
                }
                else
                {
                    msg = Request.QueryString["message"];
                    makeTableInvisible = "style='display : none'";
                    redirectJs = "setTimeout(\"location.href ='inbox.aspx';\", 3000);";

                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}