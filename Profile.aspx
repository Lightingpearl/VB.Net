<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Profile.aspx.vb" Inherits="Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 125px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
                                                      <div>
                                                          <table class="auto-style9">
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td colspan="2" style="border: 1px solid #000000">Hồ Sơ</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Họ Tên</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblname" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Giới tính</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblsex" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Ngày Sinh</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblbirth" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Quê Quán</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lbladdress" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Username</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblusername" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Mã Lớp </td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblidclass" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">Lớp</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblclass" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Mã Khoa</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblidgroup" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">Khoa</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblgroup" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">Giới thiệu</td>
                                                                  <td colspan="3" style="border: 1px solid #000000">
                                                                      <asp:Label ID="lblintroduce" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11" style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">
                                                                      <asp:Button ID="btnback" runat="server" Text="Back" />
                                                                  </td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                                  <td style="border: 1px solid #000000">&nbsp;</td>
                                                              </tr>
                                                          </table>
                                                          <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                                                          </asp:DataList>
                                                          <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                                                          <br />
                                                       </div>
                                                   </asp:Content>


