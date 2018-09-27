<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productupdate.aspx.cs" Inherits="Assignment.Productupdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 341px">
                <asp:Label ID="lblid" runat="server" Text="ProductId"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtid" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 341px">
                <asp:Label ID="lblname" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 341px">
                <asp:Label ID="lblimg" runat="server" Text="Product Image"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtimage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 341px">
                <asp:Label ID="lblprice" runat="server" Text="Product Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 341px">
                <asp:Label ID="lbldesc" runat="server" Text="ProductDescription"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 341px">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Brand"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="UPDATE" />
                <br />
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
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
                <asp:Label ID="lblupdate" runat="server" Text="label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
