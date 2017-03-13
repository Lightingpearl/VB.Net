<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>QuanLySinhVien</title>
    <style type="text/css">
        .auto-style1 {
            width: 47%;
            height: 102px;
            text-align:center;
            margin-left :250px;
            border: 3px groove ;
        }
        .auto-style2 {
            width: inherit;
            text-align:center;
        }
        .auto-style4 {
            width: inherit;
            
            text-align:center;
        }
        .auto-style5 {
            width: inherit;
            text-align: center;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"  style="text-align: center;">
    <div style="text-align: center">
    
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="time new roman" Font-Overline="False" Font-Size="XX-Large" ForeColor="#993399" Text="Chào các bạn đến với trang quản lý Sinh viên"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Italic="True" Font-Names="Arial" Font-Overline="False" Font-Size="X-Small" Font-Underline="False" Text="Chương trình được viết bằng ngôn ngữ VB ASP.NET"></asp:Label>
&nbsp;<asp:Localize ID="Localize1" runat="server"></asp:Localize>
        <br />
    
    </div>
    <div style="text-align: center">
    
        <br />
    
    </div>
        <div>
            <div>
        <table class="auto-style1" border="1"  >
            <tr>
                <td class="auto-style2">User name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txuser" runat="server" Width="287px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtpass" runat="server" Width="284px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
        <asp:Button ID="btnlogin" runat="server" BackColor="#66FF66" BorderColor="#00CC66" BorderStyle="Outset" Font-Names="Times New Roman" ForeColor="#FF3300" Text="Login" Width="140px" />
    
                </td>
            </tr>
        </table>
            </div>
        </div>
    </form>
</body>
</html>
