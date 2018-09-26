<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="Assignment.ProductDescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="ProductImage" runat="server" />
    <p>
    </p>
    <asp:Label ID="ProductId" runat="server" Text="ID"></asp:Label>
    <asp:Label ID="ProductName" runat="server" Text="NAME"></asp:Label>
    <asp:Label ID="ProductPrice" runat="server" Text="PRICE"></asp:Label>
    <asp:Label ID="ProductsDescription" runat="server" Text="DESCRIPTION"></asp:Label>
</asp:Content>
