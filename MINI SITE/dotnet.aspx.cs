using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MINI_SITE
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public string myDate;
        public string devidedByThree;
        public string myName;
        protected void Page_Load(object sender, EventArgs e)
        {
            //1
            myDate = DateTime.Now.ToString();
            //2
            for(int i = 1; i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    devidedByThree += i + " ";
                }
            }
            //3
            
        }
    }
}