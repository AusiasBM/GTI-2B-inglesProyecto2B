<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="WebApplication1.admin.HomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <strong>
        <asp:Label ID="Label3" runat="server" Text="IDN: "></asp:Label>
        </strong>
        <asp:Label ID="idnLabel" runat="server" Text="Label"></asp:Label>
        <strong>
        <asp:Label ID="Label4" runat="server" Text="  Nombre: "></asp:Label>
        </strong>
        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
        
    </div>
    <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
    <br />
<!-- ------------------------------------------------------------------------------------------------>
    <div>

        <div style="float:left;width: 40%;outline: green solid thin">
        
            <h1> Reserves </h1>

            <asp:ListBox ID="ListBox1" runat="server" Height="137px" Width="495px"></asp:ListBox>
        
            <asp:Button ID="jsonButton" runat="server" OnClick="jsonButton_Click" Text="Export JSON" />
        
            <hr />
            <br />
        
            ID reserve:
            <asp:TextBox ID="idReserveTextBox" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="searchButtonReserve" runat="server" OnClick="searchButtonReserve_Click" Text="SEARCH RESERVE" />
        
            <br />
    
            <asp:Label ID="noticeReserveLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
            <hr />
        
            <div>
                Client:
                <asp:TextBox ID="clientTextBox" runat="server"></asp:TextBox>   
            </div>
    
            <div>
                Arrival Date:
                <asp:TextBox ID="arrivalDateTextBox" runat="server" TextMode="Date"></asp:TextBox>   
            </div>
       
            <div>
                Finish Date:
                <asp:TextBox ID="finishDateTextBox" runat="server" TextMode="Date"></asp:TextBox>   
            </div>
       
            <div>
                Type Room:
                <asp:TextBox ID="typeRoomTextBox" runat="server"></asp:TextBox>  
                <hr />
            </div>
        
            <div>
                <asp:Button ID="addReserve" runat="server" Text="ADD" OnClick="addReserve_Click" />
                <asp:Button ID="modReserve" runat="server" Text="MODIFY" OnClick="modReserve_Click" />
                <asp:Button ID="delReserve" runat="server" Text="DELETE" OnClick="delReserve_Click" />
            </div>

        </div>

<!-- ------------------------------------------------------------------------------------------------>

        <div style="float:right;width: 40%;outline: red solid thin">
            
            <h1> Clients </h1>

            <asp:ListBox ID="ListBox2" runat="server" Height="139px" Width="502px"></asp:ListBox>
        
            <hr />
            <br />
        
            ID client:
            <asp:TextBox ID="idClientTextBox" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="searchButtonClient" runat="server" Text="SEARCH CLIENT" OnClick="searchButtonClient_Click" />
        
            <br />
    
            <asp:Label ID="noticeClientLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
            <hr />
        
            <div>
                Idn:
                <asp:TextBox ID="idnTextBox" runat="server" TextMode="Number"></asp:TextBox>   
            </div>
    
            <div>
                Name:
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>   
            </div>
       
            <div>
                surname:
                <asp:TextBox ID="surnameTextBox" runat="server"></asp:TextBox>   
            </div>
       
            <div>
                Password:
                <asp:TextBox ID="passTextBox" runat="server" TextMode="Number"></asp:TextBox>  

            </div>

            <div>
                Credit Card:
                <asp:TextBox ID="creditcardTextBox" runat="server" TextMode="Number"></asp:TextBox>  
            </div>
        
            <hr />
            <div>
                <asp:Button ID="addClient" runat="server" Text="ADD" OnClick="addClient_Click" />
                <asp:Button ID="modClient" runat="server" Text="MODIFY" OnClick="modClient_Click" />
                <asp:Button ID="delClient" runat="server" Text="DELETE" OnClick="delClient_Click" />
            </div>

        </div>    
    </div>
</asp:Content>
