<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackupPage.aspx.cs" Inherits="LoginAndBackup.BackupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 159px">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <asp:Label ID="SiteNameLabel" runat="server" Text="SiteName"></asp:Label>
            <asp:TextBox ID="SiteNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ListNameLabel" runat="server" Text=" "></asp:Label>
            <asp:PlaceHolder ID="PlaceHolderLabel" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <asp:Button ID="BackupButton" runat="server" OnClick="BackupButton_Click" Text="Backup" />
        </div>
    </form>
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style1">
        &nbsp;</p>
</body>
</html>
