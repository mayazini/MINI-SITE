using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        public string usersList;
        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table  >";
            int counter = 0;
            int i = 0;
            bool isNotClosed = true;
            while (i< dt.Rows.Count)
            {
                if (counter == 0)
                {
                    usersList += "<tr >";
                    usersList += "<td style='width:100px'></td>";
                    isNotClosed = true;
                }

                usersList += "<td>";
                usersList += "<div class='card card-backgroundcolor' style='width: 22rem; height: auto'><h1 class='card-title-TextColor' >" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 class= 'card-TextColor'>by: " + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text card-TextColor' >description: " + dt.Rows[i]["projectDescription"] + "</p> <a href =' AboutProject.aspx?queryProjectname="+ dt.Rows[i]["projectName"] + "&projectId="+ dt.Rows[i]["id"] + "&approved=' class='btn btn-card card-btn-TextColor' >More about the project</a></div>";
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
           
            usersList += "</table>";
        }
        private void BuildTable1(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table  >";
            int counter = 0;
            int i = 0;
            bool isNotClosed = true;
            while (i < dt.Rows.Count)
            {
                if (counter == 0)
                {
                    usersList += "<tr >";
                    usersList += "<td style='width:100px'></td>";
                    isNotClosed = true;
                }

                usersList += "<td>";
                usersList += "<div class='card card-backgroundcolor' style='width: 22rem; height: auto'><a href='deleteProject.aspx?queryProjectname=" + dt.Rows[i]["projectName"] + "&projectId=" + dt.Rows[i]["Id"] + "' class='btn btn-danger' style='decoration:none; height:30px;width:100px'>delete</a><h1 class='card-title-TextColor' >" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 class= 'card-TextColor'>by: " + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text card-TextColor' >description: " + dt.Rows[i]["projectDescription"] + "</p> <a href =' AboutProject.aspx?queryProjectname=" + dt.Rows[i]["projectName"] + "&projectId=" + dt.Rows[i]["id"] + "&approved=' class='btn btn-card card-btn-TextColor' >More about the project</a></div>";
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

            usersList += "</table>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Convert.ToBoolean(this.Session["user_isAdmin"]))
            {
                BuildTable("select * from projects");
            }
            else
            {
                BuildTable1("select * from projects");
            }
                
            
        }
    }
}
