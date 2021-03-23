using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        public string usersList;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from users";
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table class='table table-striped'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList +="<th scope = 'col'> # </th>";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                usersList += "<th scope= 'col'>";
                usersList += dt.Columns[i].ColumnName;
                usersList += "</th>";
            }
            usersList += "<th scope= 'col'>update</th>";
            usersList += "<th scope= 'col'>delete</th>";
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
                usersList += "<a href=update.aspx?queryUsername=" + dt.Rows[i]["Username"] +
                    ">Update</a>";
                usersList += "</td>";
                usersList += "<td>";
                usersList += "<a href=delete.aspx?queryUsername=" + dt.Rows[i]["Username"] +
                    ">Delete</a>";
                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }
    }
}