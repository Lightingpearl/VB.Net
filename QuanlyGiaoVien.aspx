<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="QuanlyGiaoVien.aspx.vb" Inherits="QuanlyGiaoVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Quản lý Giáo Viên"></asp:Label>
    <br />
    <hr />
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenKhoa" DataValueField="TenKhoa" Height="16px" Width="219px" AutoPostBack="True">
        </asp:DropDownList>
        <asp:Button ID="Button4" runat="server" Text="Search" Width="161px" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        </asp:GridView>
    </div>
</div>
</asp:Content>

