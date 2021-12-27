<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddSafe.aspx.cs" Inherits="MySite.AddSafe" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:TextBox runat="server" ID="txtId" Visible="false"></asp:TextBox>

    <table border="0" width="100%">
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="电梯："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="电梯不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="检修内容："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtJxnr"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtJxnr" Display="Dynamic" ErrorMessage="检修内容不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="检修日期："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtJxrq" type="date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtJxrq" Display="Dynamic" ErrorMessage="检修日期不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="检修人："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtJxr"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="txtJxr" Display="Dynamic" ErrorMessage="检修人不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left" width="100%">
                <asp:Button ID="btnSave" runat="server" Text="保  存"  Width="76px" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
