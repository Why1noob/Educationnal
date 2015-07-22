<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 230px;
        }
        .auto-style4 {
            width: 230px;
            height: 23px;
            text-align: right;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 230px;
            text-align: right;
        }
        .auto-style7 {
            height: 23px;
            width: 248px;
        }
        .auto-style8 {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align: center">Login Page</h1>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">UserName</td>
                <td class="auto-style7">
                    <asp:TextBox ID="lUserName" runat="server" Width="241px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your username." ControlToValidate="lUserName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="lPassword" runat="server" Width="242px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your password." ControlToValidate="lPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log In" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="text-align: right" Text="Registration" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
