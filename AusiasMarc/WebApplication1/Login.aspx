<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Recepcionist"></asp:Label>
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>

    </div> 
    <div>
        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="INICIAR SESIÓN" />
    </div> 
    <asp:Label ID="Label2" runat="server" Text="Client"></asp:Label>
    <div>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
    </div> 
    <div>
        <asp:Button ID="Button2" runat="server"  OnClick="Button2_Click" Text="INICIAR SESIÓN" />
    </div> 

</asp:Content>
