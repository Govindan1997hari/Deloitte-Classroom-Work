using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;

namespace StateManagementAndCaching
{
    public partial class cachingexample : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework");
            da = new SqlDataAdapter("select * from UserInfo", con);
            if(Cache["data"]==null)
            {
                ds = new DataSet();
                da.Fill(ds, "UserInfo");
                Cache.Add("data", ds, null, DateTime.Now.AddMinutes(2), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "From DB";
            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "from cache";
            }
            GridView1.DataSource = ds.Tables;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework");
            da = new SqlDataAdapter("select * from UserInfo", con);
            if (Cache["data"] == null)
            {
                ds = new DataSet();
                da.Fill(ds, "UserInfo");
                CacheDependency cd = new CacheDependency("c:\\files\\data.txt");
                Cache.Add("data", ds, cd, DateTime.MaxValue, TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "From DB";
            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "from cache";
            }
            GridView1.DataSource = ds.Tables;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=TrainingDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework");
            da = new SqlDataAdapter("select * from UserInfo", con);
            if (Cache["data"] == null)
            {
                ds = new DataSet();
                da.Fill(ds, "UserInfo");
                Cache.Add("data", ds, null, DateTime.Now.AddMinutes(2), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
                Label1.Text = "From DB";
            }
            else
            {
                ds = (DataSet)Cache["data"];
                Label1.Text = "from cache";
            }
            GridView1.DataSource = ds.Tables;
            GridView1.DataBind();
        }
    }
}