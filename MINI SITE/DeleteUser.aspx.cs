using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        public string userName;
        public string lastName;
        public string firstName;
        public string msg = "";
        public string makeTableInvisible;
        public bool admin;
        public string redirectJs;


        protected void Page_Load(object sender, EventArgs e)
        {
            userName = Request.QueryString["queryUsername"];
            if(userName != null )
            {
                if (Request["submitbtn"] == null)
                {
                    DataTable dt = SQLHelper.SelectData(string.Format("select lastName, firstName, admin from users where userName = N'{0}'", userName));
                    DataRow row;
                    if (dt.Rows.Count >= 1)
                    {
                        row = dt.Rows[0];
                        lastName = row["lastName"].ToString();
                        firstName = row["firstName"].ToString();
                        //בדיקה נוספת לאדמין
                        admin = Convert.ToBoolean(row["admin"]);
                        if (admin)
                        {
                            makeTableInvisible = "style='display : none'";
                            msg = "user " + userName + " is admin, can not be deleted";

                        }
                    }
                }
                else 
                {
                    string sql = "delete from users where userName = N'" + userName+"'";
                    SQLHelper.DoQuery(sql);
                    Response.Redirect("DeleteUser.aspx?message=User " + userName + " was deleted");
                }
            }
            else
            {
                msg = Request.QueryString["message"];
                makeTableInvisible = "style='display : none'";
                redirectJs = "setTimeout(\"location.href = 'AdminManage.aspx';\", 1500);";

            }
        }
    }
}