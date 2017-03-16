<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="QuanLySinhVien.aspx.vb" Inherits="DanhsachSV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ THÔNG TIN SINH VIÊN"></asp:Label>
&nbsp;<br />
<div>
    <hr />
    <div>
        <table class="auto-style9">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Mã Sinh Viên"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</div>
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Masv" DataSourceID="QuanlySV_officical">
            <Columns>
                <asp:BoundField DataField="Masv" HeaderText="Masv" ReadOnly="True" SortExpression="Masv" />
                <asp:BoundField DataField="Hoten" HeaderText="Hoten" SortExpression="Hoten" />
                <asp:BoundField DataField="Quequan" HeaderText="Quequan" SortExpression="Quequan" />
                <asp:BoundField DataField="Ngaysinh" HeaderText="Ngaysinh" SortExpression="Ngaysinh" />
                <asp:BoundField DataField="Gioitinh" HeaderText="Gioitinh" SortExpression="Gioitinh" />
                <asp:BoundField DataField="Makhoa" HeaderText="Makhoa" SortExpression="Makhoa" />
                <asp:BoundField DataField="Malop" HeaderText="Malop" SortExpression="Malop" />
                <asp:BoundField DataField="Quyen" HeaderText="Quyen" SortExpression="Quyen" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            </Columns>
        </asp:GridView>
        &nbsp;<asp:SqlDataSource ID="QuanlySV_officical" runat="server" ConnectionString="<%$ ConnectionStrings:QLSVConnectionString<officical> %>" SelectCommand="SELECT [Masv], [Hoten], [Quequan], [Ngaysinh], [Gioitinh], [Makhoa], [Malop], [Quyen], [Username] FROM [SinhVien]"></asp:SqlDataSource>
    </asp:Content>

