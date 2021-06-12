using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class trash : System.Web.UI.Page
    {
        public string usersList;
        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table class='myTable'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList += "<th scope = 'col'>  </th>";
            usersList += "<th scope= 'col'>";
            usersList += "trash";
            usersList += "</tr>";
            usersList += "</thead>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                usersList += "<tr>";
                usersList += "<td style='width:20%'>";
                usersList += dt.Rows[i]["Subject"];
                usersList += "</td>";
                usersList += "<td style='width:10%'>";
                usersList += "</td>";
                usersList += "<td style='width:20%'>";
                usersList += "<a href='deleteMsg.aspx?Id= " + dt.Rows[i]["Id"] + "' style='color: red!important'>delete message permenately</a>";
                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                BuildTable("select Subject,Id from Inbox where reciever= N'" + Session["login_user"] + "' and trash='true'");
            }
        }
    }
}