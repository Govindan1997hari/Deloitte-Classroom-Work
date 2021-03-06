﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagementAndCaching
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["count"] = 0;

        }
        protected void Application_End(object sender,EventArgs e)
        {

        }
        protected void Session_Start(object sender,EventArgs e)
        {
            Session["count"] = 0;
            int hrs = DateTime.Now.Hour;
            if (hrs <= 12)
                Session["greet"] = "Good morning";
            else if (hrs > 12 && hrs <= 16)
                Session["greet"] = "Good afternoon";
            else if (hrs > 16 && hrs <= 19)
                Session["greet"] = "Good evening";
            else
                Session["greet"] = "Good night";
            Response.Write(Session["greet"].ToString());
        }
        protected void Session_End(object sender, EventArgs e)
        {

        }
    }
}