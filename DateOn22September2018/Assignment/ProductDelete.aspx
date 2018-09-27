<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDelete.aspx.cs" Inherits="Assignment.ProductDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="height: 215px">
    <tr>
        <td class="modal-lg" style="width: 220px">
            <asp:Label ID="lblid" runat="server" Text="ProductId"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" style="margin-left: 0px" Text="DELETE" Width="175px" />
        </td>
        <td>
            <asp:TextBox ID="txtid" runat="server" Width="68px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lbldelete" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
