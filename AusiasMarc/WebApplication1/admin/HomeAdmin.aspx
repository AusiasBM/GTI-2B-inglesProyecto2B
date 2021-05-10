<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="WebApplication1.admin.HomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="shadow p-3 m-5 bg-body rounded">

        <asp:Label ID="Label3" class="fw-bold" runat="server" Text="IDN: "></asp:Label>
        
        <asp:Label ID="idnLabel" runat="server" Text="Label"></asp:Label>

        <asp:Label ID="Label4" runat="server" Text="  Nombre: "></asp:Label>

        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
        
    </div>
    <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
    <br />
<!-- ------------------------------------------------------------------------------------------------>
    <div class="d-flex justify-content-center m-4">

         <div class="card mr-2 shadow-lg p-3 mb-5 bg-body rounded" style="width: 50rem;">
            <div class="card-body">
        
            <h1> Reserves </h1>

            <asp:ListBox ID="ListBox1" runat="server"  class=" shadow mb-2" Height="137px" Width="495px"></asp:ListBox>
        <br />
            <asp:Button ID="jsonButton" runat="server" OnClick="jsonButton_Click" Text="Export JSON" />
        
            <hr />
            <br />
        
            ID reserve:
            <asp:TextBox ID="idReserveTextBox" class="rounded" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="searchButtonReserve" runat="server" OnClick="searchButtonReserve_Click" Text="SEARCH RESERVE" />
        
            <br />
    
            <asp:Label ID="noticeReserveLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
            <hr />
        
            <div>
                Client:
                <asp:TextBox ID="clientTextBox" class="rounded mb-2" runat="server"></asp:TextBox>   
            </div>
    
            <div>
                Arrival Date:
                <asp:TextBox ID="arrivalDateTextBox" class="rounded mb-2" runat="server" TextMode="Date"></asp:TextBox>   
            </div>
       
            <div>
                Finish Date:
                <asp:TextBox ID="finishDateTextBox" class="rounded mb-2" runat="server" TextMode="Date"></asp:TextBox>   
            </div>
       
            <div>
                Type Room:
                <asp:TextBox ID="typeRoomTextBox" class="rounded mb-2" runat="server"></asp:TextBox>  
                <hr />
            </div>
        
            <div>
                <asp:Button ID="addReserve" class="btn btn-primary" runat="server" Text="ADD" OnClick="addReserve_Click" />
                <asp:Button ID="modReserve" class="btn btn-warning" runat="server" Text="MODIFY" OnClick="modReserve_Click" />
                <asp:Button ID="delReserve" class="btn btn-danger" runat="server" Text="DELETE" OnClick="delReserve_Click" />
            </div>

        </div>
                    </div>

<!-- ------------------------------------------------------------------------------------------------>

        <div class="card ml-2 shadow-lg p-3 mb-5 bg-body rounded" style="width: 50rem;">
            <div class="card-body">
            
            <h1> Clients </h1>

            <asp:ListBox ID="ListBox2"  class="shadow rounded mb-2"  runat="server" Height="139px" Width="502px"></asp:ListBox>
        
            <hr />
            <br />
        
            ID client:
            <asp:TextBox ID="idClientTextBox" runat="server"  class="rounded mb-2" TextMode="Number"></asp:TextBox>
            <asp:Button ID="searchButtonClient" runat="server" Text="SEARCH CLIENT" OnClick="searchButtonClient_Click" />
        
            <br />
    
            <asp:Label ID="noticeClientLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
            <hr />
        
            <div>
                Idn:
                <asp:TextBox ID="idnTextBox" class="rounded mb-2" runat="server" TextMode="Number"></asp:TextBox>   
            </div>
    
            <div>
                Name:
                <asp:TextBox ID="nameTextBox" class="rounded mb-2" runat="server"></asp:TextBox>   
            </div>
       
            <div>
                surname:
                <asp:TextBox ID="surnameTextBox" class="rounded mb-2" runat="server"></asp:TextBox>   
            </div>
       
            <div>
                Password:
                <asp:TextBox ID="passTextBox" class="rounded mb-2" runat="server" TextMode="Number"></asp:TextBox>  

            </div>

            <div>
                Credit Card:
                <asp:TextBox ID="creditcardTextBox" class="rounded mb-2" runat="server" TextMode="Number"></asp:TextBox>  
            </div>
        
            <hr />
            <div>
                <asp:Button ID="addClient" class="btn btn-primary" runat="server" Text="ADD" OnClick="addClient_Click" />
                <asp:Button ID="modClient" class="btn btn-warning" runat="server" Text="MODIFY" OnClick="modClient_Click" />
                <asp:Button ID="delClient" class="btn btn-danger"  runat="server" Text="DELETE" OnClick="delClient_Click" />
            </div>
                



        </div>  
            </div>
    </div>
</asp:Content>
