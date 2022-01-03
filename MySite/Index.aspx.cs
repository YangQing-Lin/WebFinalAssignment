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
                bind();
            }
        }

        SiteBLL sHelp = new SiteBLL();

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int result = sHelp.DeleteUser(GridView1.DataKeys[e.RowIndex].Value.ToString());
            if (result > 0)
            {
                bind();
            }
            else
            {
                Response.Write("<script>alert('删除出错');</script>");
            }
        }

        // 每行数据的编辑
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            // 将当前行的id作为参数传入AddUser.Aspx页面
            Response.Redirect("AddUser.aspx?id=" + GridView1.DataKeys[e.NewEditIndex].Value.ToString());
            // Response.Write(e.NewEditIndex); // 0
            // Response.Write(GridView1.DataKeys[e.NewEditIndex].Value.ToString()); // admin
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
            bind();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}
