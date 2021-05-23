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
        public string username="";
        public string projectName="";
        public string firstName = "";
        public string lastName = "";
        public string email = "";
        public string age = "";
        //private void BuildTable(string sql)
        //{
        //    DataTable dt = SQLHelper.SelectData(sql);
        //    usersList += "<table class='table table-dark'>";
        //    usersList += "<thead>";
        //    usersList += "<tr>";
        //    usersList += "<th scope = 'col'> # </th>";
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {
        //        usersList += "<th scope= 'col'>";
        //        usersList += dt.Columns[i].ColumnName; 
        //        usersList += "</th>";
        //    }
        //    usersList += "</tr>";
        //    usersList += "</thead>";

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        usersList += "<tr>";
        //        usersList += "<td>" + i + "</td>";
        //        for (int j = 0; j < dt.Columns.Count; j++)
        //        {
        //            usersList += "<td>";
        //            usersList += dt.Rows[i][j];
        //            usersList += "</td>";
        //        }
        //        usersList += "<td>";
        //        usersList += "</td>";
        //        usersList += "</tr>";
        //    }
        //    usersList += "</table>";
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.QueryString["queryUsername"];
            projectName = Request.QueryString["projectName"];           
            username = userName;
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
                if (Request["submitbtn"] != null)
            {
                SQLHelper.DoQuery("update JobOffers set isApproved = 'true' where userName= N'"+userName+"'");
            }
        }
    }
}