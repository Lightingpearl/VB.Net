<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EditProfile.aspx.vb" Inherits="EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 125px;
        }
        .auto-style12 {
            width: 253px;
        }
        .auto-style13 {
            width: 125px;
            height: 26px;
        }
        .auto-style14 {
            width: 253px;
            height: 26px;
        }
        .auto-style15 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
                                                      <div>
                                                          <table class="auto-style9">
                                                              <tr>
                                                                  <td class="auto-style11">&nbsp;</td>
                                                                  <td colspan="2">Hồ Sơ</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Mã Sinh Viên</td>
                                                                  <td class="auto-style12">
                                                                      <asp:TextBox ID="txtidsv" runat="server" ReadOnly="True" Visible="False" Width="299px"></asp:TextBox>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Họ Tên</td>
                                                                  <td class="auto-style12">
                                                                      <asp:TextBox ID="txtname" runat="server" Width="292px"></asp:TextBox>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Giới tính</td>
                                                                  <td class="auto-style12">
                                                                      <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="81px">
                                                                          <asp:ListItem>Nam</asp:ListItem>
                                                                          <asp:ListItem Value="Nu">Nữ</asp:ListItem>
                                                                      </asp:DropDownList>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Ngày Sinh</td>
                                                                  <td class="auto-style12">
                                                                      <asp:Calendar ID="Calendar1" runat="server" Height="133px"></asp:Calendar>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Quê Quán</td>
                                                                  <td class="auto-style12">
                                                                      <asp:TextBox ID="txtaddress" runat="server" Height="49px" TextMode="MultiLine" Width="325px"></asp:TextBox>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Username</td>
                                                                  <td class="auto-style12">
                                                                      <asp:TextBox ID="txtusername" runat="server" Width="320px"></asp:TextBox>
                                                                  </td>
                                                                  <td>Password</td>
                                                                  <td>
                                                                      <asp:TextBox ID="txtpass" runat="server" Width="222px"></asp:TextBox>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style13">&nbsp;Lớp </td>
                                                                  <td class="auto-style14">
                                                                      <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="TenLop" DataValueField="Tên Lớp">
                                                                      </asp:DropDownList>
                                                                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSVConnect %>" SelectCommand="SELECT [TenLop] FROM [Lop]"></asp:SqlDataSource>
                                                                  </td>
                                                                  <td class="auto-style15">Mã Lớp</td>
                                                                  <td class="auto-style15">
                                                                      <asp:TextBox ID="txtmalop" runat="server" ReadOnly="True" Width="221px"></asp:TextBox>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Khoa</td>
                                                                  <td class="auto-style12">
                                                                      <asp:TextBox ID="txtkhoa" runat="server" ReadOnly="True"></asp:TextBox>
                                                                  </td>
                                                                  <td>Mã Khoa</td>
                                                                  <td>
                                                                      <asp:TextBox ID="txtmakhoa" runat="server" ReadOnly="True" Width="216px"></asp:TextBox>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Giới thiệu</td>
                                                                  <td colspan="3">
                                                                      <asp:TextBox ID="TextBox7" runat="server" Height="75px" TextMode="MultiLine" Width="707px"></asp:TextBox>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">&nbsp;</td>
                                                                  <td class="auto-style12">
                                                                      <asp:Button ID="btnback" runat="server" Text="Back" />
                                                                  </td>
                                                                  <td>
                                                                      <asp:Button ID="btnsave" runat="server" Text="Save" />
                                                                  </td>
                                                                  <td>
                                                                      <asp:Button ID="btnreset" runat="server" Text="Reset" />
                                                                  </td>
                                                              </tr>
                                                          </table>
                                                          <br />
                                                       </div>
                                                   </asp:Content>


