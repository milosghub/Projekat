<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="WebApplication.Start" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label> 
    <asp:TextBox ID="TextBoxName" runat="server" OnTextChanged="TextBoxName_TextChanged" ControlToValidate="TextBoxName2"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label>
    <asp:TextBox ID="TextBoxSurname" runat="server" OnTextChanged="TextBoxSurname_TextChanged" ControlToValidate="TextBoxSurname2"></asp:TextBox><br /><br />
    <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="TextBoxUsername" runat="server" OnTextChanged="TextBoxUsername_TextChanged" ControlToValidate="TextBoxUsername"></asp:TextBox><br /><br />
    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBoxPassword" runat="server" OnTextChanged="TextBoxPassword_TextChanged" ControlToValidate="TextBoxPassword"></asp:TextBox><br /><br />
    <asp:Label ID="Label5" runat="server" Text="Date of birth"></asp:Label>
    <asp:TextBox ID="TextBoxDateOfBirth" runat="server" OnTextChanged="TextBoxDateOfBirth_TextChanged" ControlToValidate="TextBoxDateOfBirth"></asp:TextBox><br /><br />
    <asp:Label ID="Label6" runat="server" Text="Phone number"></asp:Label>
    <asp:TextBox ID="TextBoxPhoneNumber" runat="server" OnTextChanged="TextBoxPhoneNumber_TextChanged" ControlToValidate="TextBoxPhoneNumber"></asp:TextBox><br /><br />
    <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="TextBoxEmail" runat="server" OnTextChanged="TextBoxEmail_TextChanged" ControlToValidate="TextBoxEmail"></asp:TextBox><br /><br />
    <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="TextBoxAddress" runat="server" OnTextChanged="TextBoxAddress_TextChanged" ControlToValidate="TextBoxAddress"></asp:TextBox><br /><br /><br />
    <asp:Button ID="ButtonSignUp" runat="server" Text="Sign up" OnClick="ButtonSignUp_Click" />
    <br />
    <asp:ListBox ID="ListBoxShow" runat="server" Width="776px"></asp:ListBox>
    <br />
    



    </asp:Content>
