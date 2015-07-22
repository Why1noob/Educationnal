<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User's Page.aspx.cs" Inherits="User_s_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Welcomelabel" runat="server" Text="Welcome:"></asp:Label>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" style="height: 26px" />
    </form>
</body>
</html>
