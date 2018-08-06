using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojects
{
    public partial class InsertUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TrainingDBEntities db = new TrainingDBEntities();
            UserInfo ui = new UserInfo();
            ui.name = TextBox1.Text;
            ui.status = TextBox2.Text;
            db.UserInfoes.Add(ui);
            var res = db.SaveChanges();
            if (res > 0)
                Response.Write("Data Inserted");
        }
    }
}