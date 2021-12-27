<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MySite.Login" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>唐山市居民电梯安全管理信息系统</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" height="100%">
                <tr>
                    <td align="center" bgcolor="#409BE5">
                        <table id="__01" width="505" height="296" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td colspan="3">
                                    <img src="images/Login_01.gif" width="505" height="40
                                        " alt=""></td>
                            </tr>
                            <tr>
                                <td colspan="3" background="images/Login_02.gif" width="505" height="74" style="text-align:center;font-size:30px">
                                    登录</td>
                            </tr>
                            <tr>
                                <td>
                                    <img src="images/Login_03.gif" width="130" height="121" alt=""></td>
                                <td background="images/Login_04.gif" width="324" height="121">
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td height="28" width="90">用户ID：</td>
                                            <td align="left">
                                                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                                    ControlToValidate="txtId" Display="Dynamic" ErrorMessage="不能输入空值"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="28" width="90">密&nbsp;&nbsp; 码：</td>
                                            <td align="left">
                                                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                                    ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height="28" width="90">&nbsp;</td>
                                            <td align="left">
                                                <asp:Button ID="btnLogin" runat="server" Text="登录"
                                                    OnClick="btnLogin_Click" />
                                                <asp:Button ID="btnRegister" runat="server" Text="注册"
                                                    OnClick="btnRegister_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    <img src="images/Login_05.gif" width="51" height="121" alt=""></td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <img src="images/Login_06.gif" width="505" height="61" alt=""></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
