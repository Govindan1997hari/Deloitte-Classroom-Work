using System;                       
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using entity;
using bal;
namespace webUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login1.UserNameLabelText = "User Id";
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            loginentity le = new loginentity();
            le.userid=int.Parse(Login1.UserName);
            le.password=Login1.Password;
            loginbal bal = new loginbal();
            try
            {
                var res = bal.Authenticate(le);
                if (res)
                    //Login1.FailureText = "Login Details Valid";
                    FormsAuthentication.RedirectFromLoginPage(le.userid.ToString(),true);
            }
            catch(Exception ex)
            {
                Login1.FailureText = ex.Message;
            }
        }
    }
}