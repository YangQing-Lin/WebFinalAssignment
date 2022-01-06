using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MySite
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mybind();
            }
        }

        private void mybind()
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = "server=(local);uid=lqc;pwd=123;database=SCMS";
            co.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from AdminInfo";
            cm.Connection = co;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;

            DataSet ds = new DataSet();
            da.Fill(ds, "AdminInfo");

            GridView1.DataSource = ds.Tables["AdminInfo"];
            GridView1.DataBind();
            co.Close();


        }

        SiteBLL sHelp = new SiteBLL();

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = "server=(local);uid=lqc;pwd=123;database=SCMS";
            co.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "delete from article where id=@id";
            cm.Parameters.Add("@id", SqlDbType.Int);
            Response.Write(e.RowIndex);
            Response.Write(GridView1.PageCount);
            cm.Parameters["@id"].Value = GridView1.DataKeys[e.RowIndex].Value;
            cm.Connection = co;
            cm.ExecuteNonQuery();
            co.Close();
            mybind();
        }

        // 每行数据的编辑
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            mybind();
        }

        public void bind()
        {
            DataSet myds = sHelp.GetUser("", txtIdOrName.Text);
            // 注释法查出这一行保存了用户信息
            GridView1.DataSource = myds;
            GridView1.DataKeyNames = new string[] { "Id" };
            GridView1.DataBind();
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            // bind();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bind();
        }
    }
}
