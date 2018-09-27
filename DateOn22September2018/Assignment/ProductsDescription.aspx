<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsDescription.aspx.cs" Inherits="Assignment.ProductsDescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="height: 276px">
        <tr>
            <td style="width: 240px">
    <asp:Image ID="ProductImage" runat="server" />
            </td>
            <td>
    <asp:Label ID="pid" runat="server" Text="ID-"></asp:Label>
    <asp:Label ID="ProductId" runat="server" Text="ID"></asp:Label>
                <br />
                <br />
     <asp:Label ID="Label1" runat="server" Text="NAME-"></asp:Label>
    <asp:Label ID="ProductName" runat="server" Text="NAME"></asp:Label>
                <br />
                <br />
     <asp:Label ID="Label2" runat="server" Text="PRICE-RS "></asp:Label>
    <asp:Label ID="ProductPrice" runat="server" Text="PRICE"></asp:Label>
                <br />
                <br />
    <asp:Label ID="Label3" runat="server" Text="DESCRIPTION-"></asp:Label>
                <asp:Label ID="ProductDescription" runat="server" Text="DESCRIPTION"></asp:Label>
            </td>
        </tr>
    </table>

    <asp:Button ID="btnback" runat="server" Text="back" OnClick="btnback_Click" />
    <p>
    </p>
    </asp:Content>
