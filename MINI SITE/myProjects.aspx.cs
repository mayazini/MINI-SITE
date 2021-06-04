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
        public string usersList1;
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
                usersList += "<div class='card card-backgroundcolor' style='width: 22rem; height: auto'><h1 class='card-title-TextColor' >" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 class='card-TextColor'>by: " + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text card-TextColor'>description: " + dt.Rows[i]["projectDescription"] + "</p> <a href = 'jobOffers.aspx?queryProjectname=" + dt.Rows[i]["projectName"] + "&projectId= "+ dt.Rows[i]["Id"] + "' class='btn btn-card card-btn-TextColor' >See who would like to join</a></div>";
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
            usersList += "<a href =' createProject.aspx' class='btn btn-type1 type1-colorText' style= 'width:300px; height:50px;font-size: 20px'>create a new project</a>";
            usersList += "</td>";
            usersList += "</tr>";
            usersList += "</table>";
        }

        private void BuildTable1(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList1 += "<table  >";
            int counter = 0;
            int i = 0;
            bool isNotClosed = true;
            while (i < dt.Rows.Count)
            {
                if (counter == 0)
                {
                    usersList1 += "<tr >";
                    usersList1 += "<td style='width:100px'></td>";
                    isNotClosed = true;
                }

                usersList1 += "<td>";
                usersList1 += "<div class='card card-backgroundcolor' style='width: 22rem; height: auto'><h1 class='card-title-TextColor' >" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 class= 'card-TextColor'>by: " + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text card-TextColor' >description: " + dt.Rows[i]["projectDescription"] + "</p> <a href =' AboutProject.aspx?queryProjectname=" + dt.Rows[i]["projectName"] + "&projectId=" + dt.Rows[i]["id"] + "%approved=true' class='btn btn-card card-btn-TextColor' >More about the project</a></div>";
                usersList1 += "</td>";

                if (counter == 3)
                {
                    counter = -1;
                    usersList1 += "</tr> <tr style = 'height: 100px'></tr>";
                    isNotClosed = false;
                }

                counter++;
                i++;
            }
            if (isNotClosed)
            {
                usersList1 += "</tr>";
            }

            usersList1 += "</table>";
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
                BuildTable1("SELECT * from projects INNER JOIN JobOffers ON projects.id = JobOffers.projectId and JobOffers.isApproved='true' and JobOffers.userName = N'" + Session["login_user"] + "'");
            }
            
        }
    }
}