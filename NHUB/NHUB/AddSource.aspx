<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSource.aspx.cs" Inherits="NHUB.AddSource" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
   
        <h1>Add New Source</h1>
    <h3>
        <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTextBox" runat="server" Height="42px" style="margin-left: 42px" Width="186px"></asp:TextBox>
        <asp:Label ID="status" runat="server"></asp:Label>
   
       
    
       <br />
   
       
    </h3>
        &nbsp;
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
   
       <h3> <asp:Button ID="CancelSourceButton" runat="server" Text="Cancel" Height="45px" Width="138px" OnClick="CancelSourceButton_Click" ToolTip=" click to go back" /><asp:Button ID="CreateSourceButton" runat="server" Text="Create" Height="43px" Width="142px" style="margin-left: 49px" OnClick="CreateSourceButton_Click" ToolTip="click to create the source" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="AddSuccessLabel" runat="server"></asp:Label>
        </h3>
    &nbsp;&nbsp;
    
</asp:Content>
