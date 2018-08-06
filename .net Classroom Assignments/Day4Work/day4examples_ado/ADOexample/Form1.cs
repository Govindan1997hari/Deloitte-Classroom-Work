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

namespace ADOexample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False";

        private void btnregister_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string gender = cbgender.SelectedItem.ToString();
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbfree.Text;
            string shopping = "";
            foreach (var d in clbshop.CheckedItems)
                shopping += d + " ";
            string cod = "";
            if (cbcod.Checked)
                cod = "Yes";
            else
                cod = "no";
            string pass = txtpassword.Text;
            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod + "\n" + pass);


            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into RegisterShopping values (@nm,@gen,@mem,@pref,@cod,@pw)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@pref", shopping);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@pw", pass);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    MessageBox.Show("data Inserted:" + res);
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
                string query = "select * from RegisterShopping";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                        
                    }
                    lbselect.Items.Add("********");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbid.SelectedValue;
                MessageBox.Show("id is " + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from RegisterShopping where ID=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    MessageBox.Show("Data deleted:" + res);
                this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
                //update the dateset and remove the deleted user from combobox.


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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet1.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter1.Fill(this.trainingDBDataSet1.RegisterShopping);
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string membership = "";
                if (rbpaid.Checked)
                    membership = rbpaid.Text;
                if (rbfree.Checked)
                    membership = rbfree.Text;
                string shop = "";
                foreach (var s in clbshop.CheckedItems)
                    shop += s + ",";
                string pass = txtpassword.Text;
                int id = (int)cbid.SelectedValue;
                con = new SqlConnection(constr);
                con.Open();
                string query = "Update RegisterShopping set membership=@mem,shoppingpreference=@shop,passw=@pass where id=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@mem", membership);
                cmd.Parameters.AddWithValue("@shop", shop);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@id", id);
                int str = cmd.ExecuteNonQuery();
                if (str> 0)
                    MessageBox.Show("Updated:"+str);

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
