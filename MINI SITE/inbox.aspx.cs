using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class inbox : System.Web.UI.Page
    {
        public string usersList;
        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table class='table table-dark'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList += "<th scope = 'col'>  </th>";
                usersList += "<th scope= 'col'>";
            usersList += "Subject";
            usersList += "</tr>";
            usersList += "</thead>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                usersList += "<tr>";
                usersList += "<td>" + i + "</td>";
                usersList += "<td style='width:10%'>";
                usersList += dt.Rows[i]["Subject"];
                usersList += "</td>";
                usersList += "<td style='width:80%'> </td>";
                usersList += "<td style='width:10%'>";
                usersList += "<a href= 'seeMore.aspx?Id= " + dt.Rows[i]["Id"] + "'>see more</a>";
                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                BuildTable("select Subject,Id from Inbox where reciever= '" + Session["login_user"]+"'");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}