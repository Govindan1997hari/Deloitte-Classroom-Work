using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=AssignmentDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbname.Text;
                DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
                string gender = "";
                if (rbmale.Checked)
                    gender = rbmale.Text;
                if (rbfemale.Checked)
                    gender = rbfemale.Text;
                string dept = cbdept.SelectedItem.ToString();
                string course = cbcourse.SelectedItem.ToString();
                string semester = cbsem.SelectedItem.ToString();
                string address = tbaddrs.Text;
                string phone = tbphno.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo(name,DOJ,gender,dept,course,sem,addrs,phno) values(@nm,@dob,@gen,@dep,@cours,@semes,@adds,@phone)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dep", dept);
                cmd.Parameters.AddWithValue("@cours", course);
                cmd.Parameters.AddWithValue("@semes", semester);
                cmd.Parameters.AddWithValue("@adds", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                int str = cmd.ExecuteNonQuery();
                if (str > 0)
                    MessageBox.Show("Successfully Inserted :" + str);
                else
                    MessageBox.Show("Error");
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "Select * from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbshow.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbshow.Items.Add(r[i]);
                    }
                    lbshow.Items.Add("********************");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = int.Parse(tbrollno.Text);
                con = new SqlConnection(constr);
                con.Open();
                string query = "Select * from StudentInfo where rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", rollno);
                r = cmd.ExecuteReader();
                lbshow.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbshow.Items.Add(r[i]);
                    }

                    tbname.Text = r["name"].ToString();
                    dtpdob.Value = DateTime.Parse(r["DOJ"].ToString());
                    if (r["gender"].ToString() == "Male")
                        rbmale.Checked = true;
                    else if (r["gender"].ToString() == "Female")
                        rbfemale.Checked = true;
                    cbdept.SelectedItem= r["dept"].ToString();
                    cbcourse.SelectedItem = r["course"].ToString();
                    cbsem.SelectedItem= r["sem"].ToString();
                    tbaddrs.Text = r["addrs"].ToString();
                    tbphno.Text = r["phno"].ToString();
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = int.Parse(tbrollno.Text);
                string name = tbname.Text;
                DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
                string gender = "";
                if (rbmale.Checked)
                    gender = rbmale.Text;
                if (rbfemale.Checked)
                    gender = rbfemale.Text;
                string dept = cbdept.SelectedItem.ToString();
                string course = cbcourse.SelectedItem.ToString();
                string semester = cbsem.SelectedItem.ToString();
                string address = tbaddrs.Text;
                string phone = tbphno.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set name=@name,DOJ=@dob,gender=@gender,dept=@dept,course=@course,sem=@sem,addrs=@addrs,phno=@phno where rollno=@rollno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rollno", rollno);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@addrs", address);
                cmd.Parameters.AddWithValue("@phno", phone);
                int str = cmd.ExecuteNonQuery();
                if (str > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                    MessageBox.Show("Error"); 

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = int.Parse(tbrollno.Text);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", rollno);
                int str = cmd.ExecuteNonQuery();
                if (str > 0)
                    MessageBox.Show("Successfulyl deleted");
                else
                    MessageBox.Show("Error");
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
