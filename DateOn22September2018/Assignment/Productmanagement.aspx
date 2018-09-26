<%@ Page Title="Productmanagement" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productmanagement.aspx.cs" Inherits="Assignment.Productmanagement" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ProductManagement Page</h2>
    <h2>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</h2>
    <h2>
        <asp:Button ID="btnproduct" runat="server" OnClick="Button1_Click" Text="Add New Product" />
    </h2>
    
   
   <%-- <a class="btn btn-default" href="ProductList.aspx.cs">ProductList</a>--%>
</asp:Content>
