<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <section>
            <div class="container">
               
                <div class="inner">
                    <h3>Sign up</h3>
                    <asp:TextBox ID="TextBoxName" placeholder="Name" runat="server"  OnTextChanged="TextBoxName_TextChanged" ControlToValidate="TextBoxName2"></asp:TextBox>
                    <asp:TextBox ID="TextBoxSurname" placeholder="Surname" TextMode="Password" runat="server" OnTextChanged="TextBoxSurname_TextChanged" ControlToValidate="TextBoxSurname2"></asp:TextBox>
                    <asp:TextBox ID="TextBoxUsername" placeholder="Username" runat="server" OnTextChanged="TextBoxUsername_TextChanged" ControlToValidate="TextBoxUsername"></asp:TextBox>
                    <asp:TextBox ID="TextBoxPassword" placeholder="Password" runat="server" OnTextChanged="TextBoxPassword_TextChanged" ControlToValidate="TextBoxPassword"></asp:TextBox>
                    <asp:TextBox ID="TextBoxDateOfBirth" placeholder="Date of birth" runat="server" OnTextChanged="TextBoxDateOfBirth_TextChanged" ControlToValidate="TextBoxDateOfBirth"></asp:TextBox>
                    <asp:TextBox ID="TextBoxPhoneNumber" placeholder="Phone number" runat="server" OnTextChanged="TextBoxPhoneNumber_TextChanged" ControlToValidate="TextBoxPhoneNumber"></asp:TextBox>
                    <asp:TextBox ID="TextBoxEmail" placeholder="E-mail" runat="server" OnTextChanged="TextBoxEmail_TextChanged" ControlToValidate="TextBoxEmail"></asp:TextBox>
                    <asp:TextBox ID="TextBoxAddress" placeholder="Address" runat="server" OnTextChanged="TextBoxAddress_TextChanged" ControlToValidate="TextBoxAddress"></asp:TextBox>
                    <asp:Button ID="ButtonSignUp" CssClass="btn" runat="server" Text="Sign up" />          
                    <asp:ListBox ID="ListBox" runat="server" ></asp:ListBox>
 <asp:ListBox ID="ListBoxShow" runat="server" Width="776px"></asp:ListBox>
                </div>
            </div>
        </section>
        <div>
        </div>
    </form>
</body>
</html>
