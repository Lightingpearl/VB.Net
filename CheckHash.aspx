<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CheckHash.aspx.vb" Inherits="CheckHash" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        #Text1 {
            width: 354px;
        }
        #TextArea1 {
            width: 352px;
            height: 90px;
        }
        .auto-style7 {
            width: 387px;
        }
        .auto-style8 {
            width: 101px;
        }
        #plainPasswordTxt {
            width: 351px;
        }
        #hashedPasswordText {
            width: 348px;
            height: 56px;
        }
        #txtpass {
            width: 355px;
        }
        #txthashed {}
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div>
    </div>
    <div>
    </div>
    <div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Key</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtpass" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td>Press Key/Password in heare</td>
            </tr>
            <tr>
                <td class="auto-style8">Salt</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtsalt" runat="server" Width="343px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Hash</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txthashed" runat="server" EnableTheming="True" Height="142px" TextMode="MultiLine" Width="345px"></asp:TextBox>
                </td>
                <td>This is Hash created</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btnhash" runat="server" style="width: 56px" Text="Hash" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    <div>
    </div>
    <div>
    </div>
    <div>
    </div>
</asp:Content>


