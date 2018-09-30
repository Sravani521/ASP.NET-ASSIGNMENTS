<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteSource.aspx.cs" Inherits="NHUB.DeleteSource" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <br />
    
        <br />
        <br />
        <br />
        <br />
        <br />
    <h3>
        Are you sure want to delete
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h3>
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
        &nbsp;
   
       <h3> <asp:Button ID="DeleteSourceButton" runat="server" Height="53px" Text="Delete" Width="166px" OnClick="DeleteSourceButton_Click" ToolTip="click to delete" />
        <asp:Button ID="CancelSourceButton" runat="server" Height="51px" style="margin-left: 65px; margin-top: 0" Text="Cancel" Width="176px" OnClick="CancelSourceButton_Click" ToolTip="click to go back" />
           <asp:Label ID="DeleteSourceLabel" runat="server"></asp:Label>
        </h3>
   
        &nbsp;
    
        &nbsp;
    
        &nbsp;
   
</asp:Content>
