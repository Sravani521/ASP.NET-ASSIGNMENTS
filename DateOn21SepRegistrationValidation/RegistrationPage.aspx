<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="DateOn21SepRegistrationValidation.RegistrationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
           <table  style="background-color: #99CCFF">
               <tr>
                  
                       <td><asp:Label ID="lblfname" Text="FIRSTNAME" runat="server"></asp:Label></td>
                       <td><asp:TextBox ID="txtfname" runat="server" ToolTip="enter firstname"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="Please enter your firstname"></asp:RequiredFieldValidator>
                       </td>
                  

               </tr>
               <tr>
                  
                      <td>
                       <asp:Label ID="lbllname" runat="server" Text="LASTNAME"></asp:Label>
                   </td>
                       <td>
                           <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="please enter lastname"></asp:RequiredFieldValidator>
                   </td>

               </tr>
               <tr>
                 
                       <td>
                       <asp:Label ID="lbldob" runat="server" Text="DOB"></asp:Label>
                   </td>
                       <td>
                           <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="plz enter dob" ControlToValidate="txtdob"></asp:RequiredFieldValidator>
                   </td>

               </tr>
               <tr>
                  
                       <td>
                       <asp:Label ID="lblgender" runat="server" Text="GENDER"></asp:Label>
                   </td>
                       <td>
                           <asp:RadioButtonList ID="rdbgender" runat="server">
                               <asp:ListItem>Male</asp:ListItem>
                               <asp:ListItem>Female</asp:ListItem>
                           </asp:RadioButtonList>
                   </td>

               </tr>
               <tr>
                       <td>
                           <asp:Label ID="lblage" runat="server" Text="AGE"></asp:Label>
                   </td>
                       <td>
                           <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                           <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="age should be less than 30" ControlToValidate="txtage" MaximumValue="30" MinimumValue="22"></asp:RangeValidator>
                   </td>

               </tr>
               <tr>
                  
                       <td>
                       <asp:Label ID="lblnumber" runat="server" Text="PH.NO"></asp:Label>
                   </td>
                       <td>
                           <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="plz enter 10 digit number" ValidationExpression="[0-9]{10}" ControlToValidate="txtnumber"></asp:RegularExpressionValidator>
                   </td>

               </tr>
               <tr>
                 
                       <td>
                       <asp:Label ID="lblcountry" runat="server" Text="COUNTRY"></asp:Label>
                   </td>
                       <td>
                           <asp:DropDownList ID="ddlcountry" runat="server">
                               <asp:ListItem>INDIA</asp:ListItem>
                               <asp:ListItem>USA</asp:ListItem>
                               <asp:ListItem>AUS</asp:ListItem>
                           </asp:DropDownList>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="select your country" ControlToValidate="ddlcountry"></asp:RequiredFieldValidator>
                   </td>

               </tr>
              
           </table> 
           

        </div>

        <p>
            <asp:Button ID="btnsubmit" runat="server" Text="Register" OnClick="btnsubmit_Click" />
        </p>
    
            <asp:Label ID="Label1" runat="server" Text="Registration Details"></asp:Label>
            <asp:ListBox ID="lb1" runat="server" Width="300px" ></asp:ListBox>
    

            <asp:GridView ID="gvc" runat="server" OnSelectedIndexChanged="gvc_SelectedIndexChanged">
               <Columns>
                   <asp:BoundField />
                   <asp:BoundField />
               </Columns>
            </asp:GridView>

    
     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="display" />

    
    </asp:Content>
