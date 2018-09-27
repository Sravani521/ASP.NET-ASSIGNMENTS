<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="Assignment.NewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="height: 257px">
    <tr>
        <td class="modal-sm" style="width: 243px">
            <asp:Label ID="Label1" runat="server" Text="ADD NEW PRODUCT"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 243px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 243px">
            <asp:Label ID="pname" runat="server" Text="Product Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 243px">
            <asp:Label ID="pimg" runat="server" Text="Product Image"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtimg" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 243px">
            <asp:Label ID="pprice" runat="server" Text="Product Price"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 243px">
            <asp:Label ID="pdesc" runat="server" Text="Product Description"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblbrd" runat="server" Text="BrandName"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add Product " />
            <br />
        </td>
        <td>
            <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="ddlid" runat="server" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
                <asp:ListItem>select the brand</asp:ListItem>
                <asp:ListItem>IPhone</asp:ListItem>
                <asp:ListItem>vivo</asp:ListItem>
                <asp:ListItem>samsung</asp:ListItem>
                <asp:ListItem>oppo</asp:ListItem>
                <asp:ListItem>micromax</asp:ListItem>
                <asp:ListItem>redmi</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="lbltxt" runat="server">label</asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
