<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="QuanLySinhVien.aspx.vb" Inherits="DanhsachSV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style11 {
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ THÔNG TIN SINH VIÊN"></asp:Label>
&nbsp;<br />
<div>
    <hr />
    <div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Điểm Môn Học Của Sinh Viên "></asp:Label>
                    <asp:Label ID="lblname" runat="server"></asp:Label>
                    <div>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                        <hr />
                        <asp:Label ID="Label3" runat="server" Text="Chọn Môn học :"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenMon" DataValueField="Tên Môn ">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSVConnect %>" SelectCommand="SELECT [Masv], [Mamon], [Lanthi], [Diem] FROM [KetQua]"></asp:SqlDataSource>
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Close" />
                </td>
            </tr>
        </table>
    </div>
</div>
&nbsp;
</asp:Content>

