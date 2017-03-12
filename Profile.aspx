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
                                                                  <td class="auto-style11">&nbsp;</td>
                                                                  <td colspan="2">Hồ Sơ</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Họ Tên</td>
                                                                  <td>
                                                                      <asp:Label ID="lblname" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Giới tính</td>
                                                                  <td>
                                                                      <asp:Label ID="lblsex" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Ngày Sinh</td>
                                                                  <td>
                                                                      <asp:Label ID="lblbirth" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Quê Quán</td>
                                                                  <td>
                                                                      <asp:Label ID="lbladdress" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Username</td>
                                                                  <td>
                                                                      <asp:Label ID="lblusername" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Mã Lớp </td>
                                                                  <td>
                                                                      <asp:Label ID="lblidclass" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>Lớp</td>
                                                                  <td>
                                                                      <asp:Label ID="lblclass" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Mã Khoa</td>
                                                                  <td>
                                                                      <asp:Label ID="lblidgroup" runat="server"></asp:Label>
                                                                  </td>
                                                                  <td>Khoa</td>
                                                                  <td>
                                                                      <asp:Label ID="lblgroup" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">Giới thiệu</td>
                                                                  <td colspan="3">
                                                                      <asp:Label ID="lblintroduce" runat="server"></asp:Label>
                                                                  </td>
                                                              </tr>
                                                              <tr>
                                                                  <td class="auto-style11">&nbsp;</td>
                                                                  <td>
                                                                      <asp:Button ID="btnback" runat="server" Text="Back" />
                                                                  </td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                          </table>
                                                          <br />
                                                       </div>
                                                   </asp:Content>


