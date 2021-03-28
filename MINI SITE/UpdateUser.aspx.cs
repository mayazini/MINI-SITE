using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public string firstName = null;
        public string lastName = null;
        public string age = null;
        public string msg = null;
        public string makeTableInvisible = null;
        public string redirectJs = null;

 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(this.Session["user_isAdmin"]))
            {
                msg = "this page is for admin only, will redirect to home page";
                makeTableInvisible = "style='display : none'";
                redirectJs = "setTimeout(\"location.href = 'AdminManage.aspx';\", 5000);";
            }
            else
            {
                string userName = Request.QueryString["queryUsername"];
                if (userName != null && userName != "")
                {
                    if (Request["submitbtn"] == null)
                    {
                        DataTable dt = SQLHelper.SelectData(string.Format("select lastName, firstName, age from users where userName = N'{0}'", userName));
                        DataRow row;
                        if (dt.Rows.Count >= 1)
                        {
                            row = dt.Rows[0];
                            if (row["lastName"] != null)
                            {
                                lastName = row["lastName"].ToString();
                            }
                            if (row["firstName"] != null)
                            {
                                firstName = row["firstName"].ToString();
                            }
                            if (row["age"] != null)
                            {
                                age = row["age"].ToString();
                            }

                        }
                    }
                    else
                    {
                        string firstNameFrom = Request["firstName"];
                        string lastNameFrom = Request["lastName"];
                        string ageFrom = Request["age"];
                        SQLHelper.DoQuery(string.Format("update users set firstname=N'{0}', lastname=N'{1}', age='{2}' where username=N'{3}'", firstNameFrom, lastNameFrom, ageFrom, userName));
                        Response.Redirect("AdminManage.aspx");
                    }
                }
            }

        }
    }
}