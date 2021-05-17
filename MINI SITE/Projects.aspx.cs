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
                usersList += "<div class='card' style='width: 22rem; height: auto;background-color:#313131'><h1 class='card-title' style= 'color:#ffc107; text-align:center'>" + dt.Rows[i]["projectName"] + "</h1><br /> <h5 style= 'color:#ffc107'>" + dt.Rows[i]["nameCreator"] + " </h5><p class='card-text' style= 'color:#ffc107'>" + dt.Rows[i]["projectDescription"] + "</p> <a href =' AboutProject.aspx?queryProjectname="+ dt.Rows[i]["projectName"] + "&projectId="+ dt.Rows[i]["id"] + "' class='btn ' style='background-color:#eff4f8; color:#313131'>More about the project</a></div>";
                usersList += "</td>";

                if (counter == 2)
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

            
                BuildTable("select * from projects");
            
        }
    }
}
