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
            usersList += "<table class='myTable'>";
            usersList += "<thead>";
            usersList += "<tr>";
            usersList += "<th scope = 'col'>  </th>";
            usersList += "<th scope= 'col'>";
            usersList += "Subject";
            usersList += "</tr>";          
            usersList += "</thead>";
            usersList += "<td style='width:150px'>";
            usersList += "<div class='sidebar' style='outline: 1px solid black'>";
            usersList += "<a href='trash.aspx' style='text-decoration:none;color:black'><svg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='currentColor' class='bi bi-trash' viewBox='0 0 16 16'><path d='M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z'/><path fill-rule='evenodd' d='M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z'/></svg><i class='bi bi-trash  red-text pr-3'></i>trash</a>";
            usersList += "<br/>";
            usersList += "<a href='sendMsg.aspx' style='text-decoration:none;color:black'>+ new message</a>";
            usersList += "<br/>";
            usersList += "<a href='sent.aspx' style='text-decoration:none;color:black'>=> sent messages</a>";
            usersList += "</div>";

            usersList += "</td>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              
                usersList += "<tr>";
                usersList += "<td style='width:150px'></td>";
                usersList += "<td>" + i + "</td>";
                usersList += "<td style='width:20%'>";
                usersList += dt.Rows[i]["Subject"];
                usersList += "</td>";
                usersList += "<td style='width:30%'> </td>";
                usersList += "<td style='width:10%'>";
                usersList += "<a href= 'seeMore.aspx?Id= " + dt.Rows[i]["Id"] + "'>see more</a>";
                usersList += "</td>";
                usersList += "<td style='width:10%'>";
                usersList += "</td>";
                usersList += "<td style='width:10%'>";
                usersList += "<a href='sendtotrash.aspx?Id= " + dt.Rows[i]["Id"] + "' style='color: red!important'><svg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='currentColor' class='bi bi-trash' viewBox='0 0 16 16'><path d='M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z'/><path fill-rule='evenodd' d='M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z'/></svg><i class='bi bi-trash  red-text pr-3'></i></a>";
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
                if (Request["searchbtn"] == null)
                {
                    BuildTable("select Subject,Id from Inbox where reciever= N'" + Session["login_user"] + "' and trash='false'");
                }
                else
                {
                    string sql = "select Subject,Id from Inbox where reciever= N'" + Session["login_user"] + "' and ";
                    string subject = Request["subject"];
                    if (subject != "")
                    {
                        sql += " subject like N'%" + subject + "%'";
                    }                  
                    BuildTable(sql);

                }


            }
        }
    }
}