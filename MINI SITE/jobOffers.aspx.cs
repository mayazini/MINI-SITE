using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class jobOffers : System.Web.UI.Page
    {
        public string usersList;
        public string usersList1;

        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table class='table table-dark'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList += "<th scope = 'col'> # </th>";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                usersList += "<th scope= 'col'>";
                usersList += dt.Columns[i].ColumnName;
                usersList += "</th>";
            }
            usersList += "<th scope= 'col'>More Information</th>";
            usersList += "</tr>";
            usersList += "</thead>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                usersList += "<tr>";
                usersList += "<td>" + i + "</td>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    usersList += "<td>";
                    usersList += dt.Rows[i][j];
                    usersList += "</td>";
                }

                usersList += "<td>";
                usersList += "<a href='applicantResume.aspx?queryUsername=" + dt.Rows[i]["Username"] + "&projectName=" + dt.Rows[i]["projectName"] + "&projectId=" + dt.Rows[i]["id"] + "&isApproved=false'>More Info</a>";
                usersList += "</td>";
                usersList += "<td>";


                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }
        private void BuildTable1(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList1 += "<table class='table table-dark'>";
            usersList1 += "<thead>";
            usersList1 += "<tr>";
            usersList1 += "<th scope = 'col'> # </th>";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                usersList1 += "<th scope= 'col'>";
                usersList1 += dt.Columns[i].ColumnName;
                usersList1 += "</th>";
            }
            usersList1 += "<th scope= 'col'>More Information</th>";
            usersList1 += "</tr>";
            usersList1 += "</thead>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                usersList1 += "<tr>";
                usersList1 += "<td>" + i + "</td>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    usersList1 += "<td>";
                    usersList1 += dt.Rows[i][j];
                    usersList1 += "</td>";
                }

                usersList1 += "<td>";
                usersList1 += "<a href='applicantResume.aspx?queryUsername=" + dt.Rows[i]["Username"] + "&projectName=" + dt.Rows[i]["projectName"] + "&isApproved=true'>More Info</a>";
                usersList1 += "</td>";
                usersList1 += "<td>";


                usersList1 += "</td>";
                usersList1 += "</tr>";
            }
            usersList1 += "</table>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                BuildTable("select userName,projectName,userSkill,id from jobOffers where projectId = N'" + Request.QueryString["projectId"] + "' and isApproved='false'");
                BuildTable1("select userName,projectName,userSkill from jobOffers where projectId = N'" + Request.QueryString["projectId"] + "' and isApproved='true'");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}