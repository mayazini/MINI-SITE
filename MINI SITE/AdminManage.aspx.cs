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
        private void BuildTable(string sql)
        {
            DataTable dt = SQLHelper.SelectData(sql);
            usersList += "<table class='table table-dark'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList += "<th scope = 'col'> # </th>";
            int adminColumnIndex = -1;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                usersList += "<th scope= 'col'>";
                usersList += dt.Columns[i].ColumnName;
                if (dt.Columns[i].ColumnName == "admin")
                {
                    adminColumnIndex = i;
                }
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
                usersList += "<a href=UpdateUser.aspx?queryUsername=" + dt.Rows[i]["Username"] +
                    ">Update</a>";
                usersList += "</td>";
                usersList += "<td>";

                if ((bool)dt.Rows[i][adminColumnIndex])
                {
                    usersList += "<a href = '#' style='color:#696969'>admin can't be deleted</a>";
                }
                else
                {
                    usersList += "<a href=DeleteUser.aspx?queryUsername=" + dt.Rows[i]["Username"] +
                    ">Delete</a>";
                }               
                usersList += "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(this.Session["user_isAdmin"]))
            {
                Response.Redirect("homepage.aspx");
                return;
            }
            if (Request["searchbtn"] == null)
            {
                BuildTable("select * from users");
            }
            else
            {
                string sqlComma = " ";
                int counter = 0;
                string sql = "select * from users where ";
                string userName = Request["userName"];
                if (userName != "")
                {
                    sql += " username like N'%"+ userName + "%'";
                    counter++;
                }
                string firstName = Request["firstName"];
                if (firstName != "")
                {
                    if (counter > 0)
                    {
                        sqlComma = "and";
                    }
                    sql += sqlComma+  " firstname like N'%" + firstName + "%'";
                    counter++;
                }
                string lastName = Request["lastName"];
                if(lastName!= "")
                {
                    if (counter > 0)
                    {
                        sqlComma = "and";
                    }
                    sql += sqlComma+" lastname like N'%" + lastName + "%'";
                }
                BuildTable(sql);
            }
        }

    }
}