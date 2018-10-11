<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginAndBackup.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 104px;
        }
        .auto-style2 {
            margin-left: 96px;
        }
        .auto-style3 {
            margin-left: 103px;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
        <div>
        </div>
            <asp:Label ID="SiteNameLabel" runat="server" Text="SiteName"></asp:Label>
            <asp:TextBox ID="SiteNameTextBox" runat="server" CssClass="auto-style1" Height="31px" Width="132px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="UserNameLabel" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="auto-style2" Height="28px" Width="136px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="auto-style3" Height="29px" Width="132px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="Button1_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
