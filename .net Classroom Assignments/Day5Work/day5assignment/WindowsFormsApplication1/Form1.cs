using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //int rollno = int.Parse(tbrollno.Text);
            string name = tbname.Text;
            DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
            string gender = "";
            if (rbfemale.Checked)
                gender=rbfemale.Text;
            if (rbmale.Checked)
                gender=rbmale.Text;
            string dept = cbdept.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsem.SelectedItem.ToString();
            string address = tbaddrs.Text;
            string phno = tbphno.Text;
            MessageBox.Show(name + "\n " + dob + "\n " + gender + "\n " + dept + "\n " + course + "\n " + semester + "\n " + address + "\n " + phno);
            StudentInfo si = new StudentInfo();
            si.name = name;
            si.DOJ = dob;
            si.gender = gender;
            si.dept = dept;
            si.course = course;
            si.sem = semester;
            si.addrs = address;
            si.phno = phno;
            db.StudentInfoes.Add(si);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Inserted");
            else
                MessageBox.Show("Error");
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            lbshow.Items.Clear();
            foreach(var t in db.StudentInfoes)
            {
                lbshow.Items.Add(t.rollno);
                lbshow.Items.Add(t.name);
                lbshow.Items.Add(t.DOJ);
                lbshow.Items.Add(t.gender);
                lbshow.Items.Add(t.dept);
                lbshow.Items.Add(t.course);
                lbshow.Items.Add(t.sem);
                lbshow.Items.Add(t.addrs);
                lbshow.Items.Add(t.phno);
                lbshow.Items.Add("**************");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            int rollno = int.Parse(tbrollno.Text);
            var temp = (from t in db.StudentInfoes
                        where t.rollno == rollno
                        select t).SingleOrDefault();
            lbshow.Items.Clear();
                lbshow.Items.Add(temp.rollno);
                lbshow.Items.Add(temp.name);
                lbshow.Items.Add(temp.DOJ);
                lbshow.Items.Add(temp.gender);
                lbshow.Items.Add(temp.dept);
                lbshow.Items.Add(temp.course);
                lbshow.Items.Add(temp.sem);
                lbshow.Items.Add(temp.addrs);
                lbshow.Items.Add(temp.phno);
                lbshow.Items.Add("**************");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string dept = cbdept.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsem.SelectedItem.ToString();
            string address = tbaddrs.Text;
            string phno = tbphno.Text;
            int rollno = int.Parse(tbrollno.Text);
            var old = db.StudentInfoes.Where(x => x.rollno == rollno).SingleOrDefault();
            old.dept = dept;
            old.course = course;
            old.sem = semester;
            old.addrs = address;
            old.phno = phno;
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Successfully Updated");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rollno = int.Parse(tbrollno.Text);
            var del = (from t in db.StudentInfoes
                       where t.rollno == rollno
                       select t).SingleOrDefault();
            db.StudentInfoes.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Successfully deleted");
        }
    }
}
