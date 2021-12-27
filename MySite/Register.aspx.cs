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
    public partial class Register : System.Web.UI.Page
    {
        string id = "";
        SiteBLL help = new SiteBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    txtId.Text = "";
                    txtName.Text = "";
                    txtPwd.Attributes["value"] = "";
                }
                else
                {
                    id = Request.QueryString["id"];
                    DataSet ds = help.GetUser(id, "", "全部");
                    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                    {
                        txtId.ReadOnly = true;
                        txtId.Enabled = false;
                        txtId.Text = ds.Tables[0].Rows[0]["Id"].ToString();
                        txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                        txtPwd.Attributes["value"] = ds.Tables[0].Rows[0]["Pwd"].ToString();
                        if (ds.Tables[0].Rows[0]["Sex"].ToString() == "男")
                        {
                            RadioButtonList1.SelectedIndex = 0;
                        }
                        else
                        {
                            RadioButtonList1.SelectedIndex = 1;
                        }
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                int rs= help.AddUser(txtId.Text,txtName.Text,txtPwd.Text,RadioButtonList1.SelectedValue);
                if (rs > 0)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('保存失败');</script>");
                }
            }
            else
            {
                int result= help.UpdateUser(txtId.Text, txtName.Text, txtPwd.Text, RadioButtonList1.SelectedValue);
                if (result > 0)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('保存失败');</script>");
                }
            }
        }
    }
}
