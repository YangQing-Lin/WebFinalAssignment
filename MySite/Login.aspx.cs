using System;
using System.Data;
using System.Web.Security;

namespace MySite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SiteBLL help = new SiteBLL();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string Pwd = txtPwd.Text;
            DataSet ds = help.GetUser(Id, "", "全部");
            if (ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                if (ds.Tables[0].Rows[0]["Pwd"].ToString() == Pwd)
                {
                    Session["Id"] = Id;
                    Response.Redirect("index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('登录失败，密码错误');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('登录失败，用户名不存在');</script>");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
