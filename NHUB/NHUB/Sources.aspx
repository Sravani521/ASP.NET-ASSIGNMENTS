<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sources.aspx.cs" Inherits="NHUB.Sources" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
    <p>
        <br />
        <h1><asp:Label ID="SourceLabel" runat="server" Text="Sources"></asp:Label></h1>
    </p>
    <p>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <h3><asp:Button ID="SourceButton" runat="server" Height="44px" style="margin-top: 0" Text="Add Source" Width="205px" OnClick="SourceButton_Click" /></h3>
    </p>
    <p>
        &nbsp;</p>
    
    
    
</asp:Content>
