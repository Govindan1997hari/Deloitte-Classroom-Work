using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlsexamples
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbnclick_Click(object sender, EventArgs e)
        {
            Visible = false;
            Response.Write("<font color='red'>" + "First ASP.NET Example" + "</font>");
        }
    }
}