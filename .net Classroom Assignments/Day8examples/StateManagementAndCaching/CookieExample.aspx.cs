using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementAndCaching
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            HttpCookie namecookie = new HttpCookie("NAME");
            namecookie.Value = tbusername.Text;
            namecookie.Expires = DateTime.Now.AddMinutes(5);
            HttpCookie passcookie = new HttpCookie("PASS");
            passcookie.Value = tbpassword.Text;
            passcookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(namecookie);
            Response.Cookies.Add(passcookie);
            Response.Write("Cookie Added");
        }

        protected void btnreadcookie_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbpassword.Text = "";
            tbpassword.TextMode = TextBoxMode.SingleLine;
            tbusername.Text = Request.Cookies["NAME"].Value.ToString();
            tbpassword.Text = Request.Cookies["PASS"].Value.ToString();
        }
    }
}