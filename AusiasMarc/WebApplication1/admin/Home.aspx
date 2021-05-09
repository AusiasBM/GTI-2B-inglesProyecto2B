<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.admin.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="idnLabel" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>

            <asp:ListBox ID="ReservasList" runat="server" Height="470px" Width="441px" OnSelectedIndexChanged="ReservasList_SelectedIndexChanged"></asp:ListBox>

            <asp:TextBox ID="clientTextBox" runat="server" Height="16px" Width="693px"></asp:TextBox>
            <asp:Calendar ID="arrivalDateCalendar" runat="server"></asp:Calendar>
            <select id="typeRoomSelect" name="D1">
                <option></option>
            </select><asp:Calendar ID="finishDateCalendar" runat="server"></asp:Calendar>

        </div>
        
    </form>
</body>
</html>
