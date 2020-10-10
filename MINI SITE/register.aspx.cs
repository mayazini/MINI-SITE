using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String password = Request["password"];
            String uname = Request["uname"];

            Hashtable htUsers = null;

            if (password != null && uname != null)
            {
                if (Application["GlobalUsers"] == null)
                {

                    htUsers = new Hashtable();
                    this.Application["GlobalUsers"] = htUsers;
                }
                else
                {
                    htUsers = this.Application["GlobalUsers"] as Hashtable;
                }
                if (!htUsers.ContainsKey(uname))
                {
                    htUsers.Add(uname, password);
                    Response.Redirect("login.aspx");
                }
                else
                {
                    registerError.Text = "<br/> user already exists";
                }
                
                
            }            
        }
    }
}