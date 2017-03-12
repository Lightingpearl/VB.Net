<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HomePage.aspx.vb" Inherits="Home_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
                                                      <div>
                                                          <table class="auto-style9">
                                                              <tr>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                                  <td>&nbsp;</td>
                                                              </tr>
                                                              <tr>
                                                                  <td>
                                                                      <asp:Button ID="btnSV" runat="server" Text="Quản lý Sinh Viên" />
                                                                  </td>
                                                                  <td>
                                                                      <asp:Button ID="btnGV" runat="server" Text="Quản lý giáo viên" />
                                                                  </td>
                                                                  <td>
                                                                      <asp:Button ID="btnMon" runat="server" Text="Quản lý môn" />
                                                                  </td>
                                                                  <td>
                                                                      <asp:Button ID="btnKhoa" runat="server" Text="Quản lý khoa " />
                                                                  </td>
                                                              </tr>
                                                          </table>
                                                          <br />
                                                       </div>
                                                   </asp:Content>




