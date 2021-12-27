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
    public partial class index2 : System.Web.UI.Page
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
            int result = sHelp.DeleteSafe(GridView1.DataKeys[e.RowIndex].Value.ToString());
            if (result > 0)
            {
                bind();
            }
            else
            {
                Response.Write("<script>alert('删除出错');</script>");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Response.Redirect("AddSafe.aspx?id=" + GridView1.DataKeys[e.NewEditIndex].Value.ToString());
        }

        public void bind()
        {
            DateTime? dJxrq = null;
            if (!string.IsNullOrEmpty(txtJxrq.Text))
            {
                dJxrq = DateTime.Parse(txtJxrq.Text);
            }
            DataSet myds = sHelp.GetSafe("",txtName.Text, dJxrq);
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
