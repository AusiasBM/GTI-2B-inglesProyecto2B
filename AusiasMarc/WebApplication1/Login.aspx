<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Recepcionist
         <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </div> 
        <div>
            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="INICIAR SESIÓN" />
        </div> 
        Client
         <div>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        </div> 
        <div>
            <asp:Button ID="Button2" runat="server"  OnClick="Button2_Click" Text="INICIAR SESIÓN" />
        </div> 
    </form>
</body>
</html>
