<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSource.aspx.cs" Inherits="NHUB.EditSource" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <h3>
        <asp:Label ID="RenameLabel" runat="server" Text="Rename"></asp:Label>
        <asp:TextBox ID="RenameTextBox" runat="server" style="margin-left: 63px" Width="92px"></asp:TextBox>
    
        &nbsp;<asp:Label ID="status" runat="server"></asp:Label>
    </h3>
    <h3>
        &nbsp;</h3>
    <h3>
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" ToolTip="click to rename source" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="cancel" ToolTip="click to go back" />
        <asp:Label ID="StatusLabel" runat="server"></asp:Label>
    
    </h3>
    <h3>
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </h3>
    <p>
    </p>
    <p>
    </p>

</asp:Content>
