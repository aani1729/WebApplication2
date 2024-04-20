<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
     <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <div class="form-group">
                <label for="txtUsername">Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
            <table>
                <tr>
                    <td>
                        <div class="form-group">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-primary" />
                        </div>
                    </td>
                    <td>
                        <div class="form-group">
                        <asp:Button ID="btnSignup" runat="server" Text="Signup" OnClick="btnsignup_Click" CssClass="btn btn-primary" />
                        </div>
                    </td>
                </tr>
            </table>
            
            
            <div class="error-message">
                <asp:Label ID="lblErrorMessage" runat="server" Visible="false" />
            </div>
        </div>
    </form>
</body>
</html>
