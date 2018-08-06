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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btniis_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tbnum1.Text);
            int num2 = int.Parse(tbnum2.Text);
            try
            {
                ServiceReference1.icalculatorClient cc = new ServiceReference1.icalculatorClient();
                var add = cc.add(num1, num2);
                var sub = cc.sub(num1, num2);
                MessageBox.Show("Addition:" + add);
                MessageBox.Show("Subtraction:" + sub);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(tbnum1.Text);
            int num2 = int.Parse(tbnum2.Text);
            try
            {
                ServiceReference2.icalculatorClient cc = new ServiceReference2.icalculatorClient();
                var add = cc.add(num1, num2);
                var sub = cc.sub(num1, num2);
                MessageBox.Show("Addition:" + add);
                MessageBox.Show("Subtraction:" + sub);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
