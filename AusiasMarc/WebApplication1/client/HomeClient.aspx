<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="HomeClient.aspx.cs" Inherits="WebApplication1.client.HomeClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:ListBox ID="Reservas" runat="server" Height="427px" Width="506px" style="margin-right: 0px"></asp:ListBox>
    </div>

</asp:Content>
