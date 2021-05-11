<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="HomeClient.aspx.cs" Inherits="WebApplication1.client.HomeClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shadow p-3 m-5 bg-body rounded row">
        
        <div class="col-11">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-1">
            <asp:Button ID="logout" runat="server" class="btn btn-danger" Text="Logout" OnClick="logout_Click" />
        </div>
        <br />
    </div>
    <div class="shadow p-3 m-5 bg-body rounded row">
        <div class="col-12">
            <asp:ListBox ID="Reservas" runat="server" class="mb-2" Height="427px" Width="100%" style="margin-right: 0px"></asp:ListBox>
        </div>
        
    </div>

</asp:Content>
