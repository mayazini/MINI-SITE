using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class myProjects : System.Web.UI.Page
    {
        public string usersList;
        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table  style = 'border: none;'>";
            int counter = 0;
            int i = 0;
            bool isNotClosed = true;
            while (i < dt.Rows.Count)
            {
                if (counter == 0)
                {
                    usersList += "<tr> <td style='width:100px'></td>";
                    isNotClosed = true;
                }

                usersList += "<td>";
                usersList += "<div class='card' style='width: 22rem; height: auto; background-color: #313131'><h1 class='card-title' style='color:#ffc107;text-align:center'>" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 style='color:#ffc107'>" + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text' style='color:#ffc107'>" + dt.Rows[i]["projectDescription"] + "</p> <a href = 'jobOffers.aspx?queryProjectname=" + dt.Rows[i]["projectName"] + "&projectId= "+ dt.Rows[i]["Id"] + "' class='btn ' style= 'background-color:#eff4f8; color:#313131'>See who would like to join</a></div>";
                usersList += "</td>";

                if (counter == 3)
                {
                    counter = -1;
                    usersList += "</tr> <tr style = 'height: 100px'></tr>";
                    isNotClosed = false;
                }

                counter++;
                i++;
            }
            if (isNotClosed)
            {
                usersList += "</tr>";
            }
            usersList += "<tr style = 'height: 50px'></tr>";
            usersList += "<tr> <td style='width:50px'></td>";
            usersList += "<td>";
            usersList += "<a href =' createProject.aspx' class='btn ' style= 'width:300px; height:50px; background-color:#ffc107;font-size: 20px;color:black'>create new project</a>";
            usersList += "</td>";
            usersList += "</tr>";
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
                BuildTable("select * from projects where nameCreator = N'" + Session["login_user"] + "'");
            }
            
        }
    }
}