﻿<%@ Page Language="C#" MasterPageFile="~/site1.master"  AutoEventWireup="true" CodeBehind="Index2.aspx.cs" Inherits="MySite.index2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table border="0" bgcolor="#FFFFFF" width="100%"  cellspacing="0" cellpadding="0">    
    <tr><td>
        <asp:Label runat="server" Text="名称："></asp:Label>
        <asp:TextBox runat="server" ID="txtName" ></asp:TextBox> &nbsp; 
        <asp:Label runat="server" Text="检修日期："></asp:Label>
        <asp:TextBox runat="server" ID="txtJxrq" type="date"></asp:TextBox> 
        &nbsp;&nbsp; <asp:Button runat="server" Text="查询" ID="btnQuery" OnClick="btnQuery_Click"  />
        </td></tr>
</table>
    <hr/>
     <asp:GridView ID="GridView1" runat="server" BorderWidth="1"  Width="100%" AutoGenerateColumns="False" CellPadding="4" 
                        ForeColor="#333333" GridLines="None" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" >
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="编码" ReadOnly="True" />
                            <asp:BoundField DataField="Name" HeaderText="电梯" ReadOnly="True"/>
                            <asp:BoundField DataField="Jxnr" HeaderText="检修内容"/>
                            <asp:BoundField DataField="Jxrq" HeaderText="检修日期" />
                            <asp:BoundField DataField="Jxr" HeaderText="检修人" />
                            <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                        </Columns>
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <%--<PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />--%>
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
</asp:Content>