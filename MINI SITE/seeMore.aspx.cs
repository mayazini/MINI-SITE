using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class seeMore : System.Web.UI.Page
    {
        public string message="";
        public string from="";
        public string subject="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {           
                DataTable dt = SQLHelper.SelectData(string.Format("select message, sender,subject from Inbox where Id = '{0}'", Request.QueryString["Id"]));
                DataRow row;
                if (dt.Rows.Count >= 1)
                {
                    row = dt.Rows[0];
                    message = row["message"].ToString();
                    from = row["sender"].ToString();
                    subject = row["subject"].ToString();
                }
            }
        }
    }
}