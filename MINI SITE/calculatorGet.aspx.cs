using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        string input1;
        string input2;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            input1 = Request.QueryString["input1"];
            input2 = Request.QueryString["input2"];
            if(input1 != null && input2 != null)
            {
                int num1 = Int32.Parse(input1);
                int num2 = Int32.Parse(input2);
                int output = num1 + num2;
                Response.Write(output);
            }
            

        }
    }
}