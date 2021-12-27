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

namespace MySite
{
    public partial class AddSafe : System.Web.UI.Page
    {
        string id = "";
        SiteBLL help = new SiteBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    id = Request.QueryString["id"];
                    DataSet ds = help.GetSafe(id,"",null);
                    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                    {
                        txtId.Text = ds.Tables[0].Rows[0]["Id"].ToString();
                        txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                        txtJxnr.Text = ds.Tables[0].Rows[0]["Jxnr"].ToString();
                        txtJxr.Text = ds.Tables[0].Rows[0]["Jxr"].ToString();
                        txtJxrq.Text = DateTime.Parse(ds.Tables[0].Rows[0]["Jxrq"].ToString()).ToString("yyyy-MM-dd");
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                int rs= help.AddSafe(txtName.Text, txtJxnr.Text, DateTime.Parse(txtJxrq.Text), txtJxr.Text);
                if (rs > 0)
                {
                    Response.Redirect("Index2.aspx");
                }
                else
                {
                    Response.Write("<script>alert('保存失败');</script>");
                }
            }
            else
            {
                int result= help.UpdateSafe(int.Parse(txtId.Text), txtName.Text, txtJxnr.Text, DateTime.Parse(txtJxrq.Text), txtJxr.Text);
                if (result > 0)
                {
                    Response.Redirect("Index2.aspx");
                }
                else
                {
                    Response.Write("<script>alert('保存失败');</script>");
                }
            }
        }
    }
}
