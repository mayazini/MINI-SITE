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
                usersList += "<a href='applicantResume.aspx?queryUsername=" + dt.Rows[i]["Username"] +"&projectName=" + dt.Rows[i]["projectName"] + "'>More Info</a>";
                usersList += "</td>";
                usersList += "<td>";

                
                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BuildTable("select userName,isApproved,projectName,userSkill from jobOffers where projectId = N'"+Request.QueryString["projectId"] + "'");
        }
    }
}