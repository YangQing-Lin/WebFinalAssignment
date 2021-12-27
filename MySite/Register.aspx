<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MySite.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table border="0" width="100%">
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="Id："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtId"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtId" Display="Dynamic" ErrorMessage="用户Id不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="姓名："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="姓名不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="密码："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtPwd" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="性别："></asp:Label>
            </td>
            <td align="left">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" >
                    <asp:ListItem Selected="True">男</asp:ListItem>
                    <asp:ListItem>女</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left" width="100%">
                <asp:Button ID="btnSave" runat="server" Text="注  册"  Width="76px" OnClick="btnSave_Click" />               
            </td>
        </tr>
    </table>
</asp:Content>
