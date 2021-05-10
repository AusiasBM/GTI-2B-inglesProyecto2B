<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center mt-5">
        
        <div class="card mr-4 shadow-lg p-3 mb-5 bg-body rounded" style="width: 30rem;">
            <div class="card-body">
            <asp:Label ID="Label1" runat="server" Text="Recepcionist"></asp:Label>
            <div>
                <asp:TextBox ID="TextBox1" class="form-control d-inline mt-2" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                <asp:TextBox ID="TextBox2" class="form-control d-inline mt-2" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            </div> 
            <div>
                <asp:Button ID="Button1" class="btn btn-primary mt-2" runat="server"  OnClick="Button1_Click" Text="SIGN IN" />
            </div> 
                </div>
        </div>

        <div class="card shadow-lg p-3 mb-5 bg-body rounded" style="width: 30rem;">
            <div class="card-body">
             <asp:Label ID="Label2" runat="server" Text="Client"></asp:Label>
            <div>
                <asp:TextBox ID="TextBox3" class="form-control d-inline mt-2" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                <asp:TextBox ID="TextBox4" class="form-control d-inline mt-2" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            </div> 
            <div>
                <asp:Button ID="Button2" runat="server" class="btn btn-primary mt-2"  OnClick="Button2_Click" Text="SIGN IN" />
            </div>
                </div>
        </div>
       
    </div>
 

</asp:Content>
