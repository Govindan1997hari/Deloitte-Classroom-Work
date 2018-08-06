using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string pass =textBox2.Text;
            try
            {
                ServiceReference1.iloginClient cc = new ServiceReference1.iloginClient();
                var res = cc.authenticate(id, pass);
                if (res == true)
                    MessageBox.Show("Authorized");
                else
                    MessageBox.Show("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
