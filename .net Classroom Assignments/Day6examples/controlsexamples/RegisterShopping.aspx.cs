using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlsexamples
{
    
    public partial class RegisterShopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //textbox
            string name = tbname.Text;
            string pass = tbpass.Text;
            //dropdownlist
            string gender = dplgender.SelectedItem.Text;
            //radiobutton
            string membership="";
            if (rbmale.Checked)
                membership = rbmale.Text;
            if (rbfemale.Checked)
                membership = rbfemale.Text;
            //checkboxlist
            string shopping = "" ;
            foreach(ListItem li in cblshopping.Items)
            {
                if (li.Selected)
                    shopping += li.Text + " ";

            }
            string COD = "";
            if (cbcod.Checked)
                COD = "Yes";
            else
                COD = "No";
            lb1.Visible = true;
            lb1.Text = name + "<br/>" + gender + "<br/>" + membership + "<br/>" + shopping + "<br/>" + COD + "<br/>" + pass;
            

        }
    }
}