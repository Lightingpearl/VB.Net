<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="QuanlyGiaoVien.aspx.vb" Inherits="QuanlyGiaoVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style12 {
            width: 115px;
        }
        .auto-style13 {
            width: 115px;
            height: 26px;
        }
        .auto-style14 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Quản lý Giáo Viên"></asp:Label>
    <br />
    <hr />
    <div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style12">Mã Giáo Viên </td>
                <td>
                    <asp:TextBox ID="txtmagv" runat="server" Enabled="False" ReadOnly="True" Width="211px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">Tên Giáo Viên</td>
                <td>
                    <asp:TextBox ID="txtTenGv" runat="server" Enabled="False" Width="207px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnthem" runat="server" Text="Thêm" Width="81px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Ngày Sinh</td>
                <td>
                    <asp:TextBox ID="txtdate" runat="server" Enabled="False" Width="207px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="Sửa" Width="84px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Mã Khoa</td>
                <td>
                    <asp:TextBox ID="txtmakhoa" runat="server" Enabled="False" Width="214px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">Mã Lớp</td>
                <td>
                    <asp:TextBox ID="txtmalop" runat="server" Enabled="False" Width="209px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="Xóa" Width="85px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Quyền</td>
                <td>
                    <asp:TextBox ID="txtquyen" runat="server" Enabled="False" Width="208px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button7" runat="server" Text="Tìm Kiếm" Width="84px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style13">Giới Thiệu</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtgioithieu" runat="server" Height="77px" TextMode="MultiLine" Width="437px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:Button ID="btnrefresh" runat="server" Text="Refress" Width="84px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Username</td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server" Enabled="False" Width="216px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">Password</td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" Enabled="False" ReadOnly="True" Width="213px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="MaGV" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="MaGV" HeaderText="Mã Giáo Viên" ReadOnly="True" SortExpression="MaGV" />
                    <asp:BoundField DataField="TenGV" HeaderText="Tên Giáo Viên" SortExpression="TenGV" />
                    <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" SortExpression="NgaySinh" />
                    <asp:BoundField DataField="Makhoa" HeaderText="Mã Khoa" SortExpression="Makhoa" />
                    <asp:BoundField DataField="Malop" HeaderText="Mã Lớp" SortExpression="Malop" />
                    <asp:BoundField DataField="Quyen" HeaderText="Quyền" SortExpression="Quyen" />
                    <asp:BoundField DataField="GioiThieu" HeaderText="Giới Thiệu" SortExpression="GioiThieu" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="Password" DataFormatString="************" HeaderText="Password" SortExpression="Password" Visible="False" />
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSVConnectionString<officical> %>" SelectCommand="SELECT DISTINCT * FROM [GiaoVien]"></asp:SqlDataSource>
        </div>
        <br />
        <br />
    </div>
</div>
</asp:Content>

