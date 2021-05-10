<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-around container-xl">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Recepcionist"></asp:Label>
            <div>
                <asp:TextBox ID="TextBox1" class="form-control d-inline" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                <asp:TextBox ID="TextBox2" class="form-control d-inline" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            </div> 
            <div>
                <asp:Button ID="Button1" class="btn btn-primary" runat="server"  OnClick="Button1_Click" Text="INICIAR SESIÓN" />
            </div> 
        </div>

        <div>
             <asp:Label ID="Label2" runat="server" Text="Client"></asp:Label>
            <div>
                <asp:TextBox ID="TextBox3" class="form-control d-inline" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                <asp:TextBox ID="TextBox4" class="form-control d-inline" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            </div> 
            <div>
                <asp:Button ID="Button2" runat="server" class="btn btn-primary"  OnClick="Button2_Click" Text="SIGN IN" />
            </div>
        </div>
       
    </div>
 

</asp:Content>
