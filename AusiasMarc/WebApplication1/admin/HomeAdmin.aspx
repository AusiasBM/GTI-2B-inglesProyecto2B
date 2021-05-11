<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="WebApplication1.admin.HomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="shadow p-3 m-5 bg-body rounded row">
        <div class="col-11">
            <asp:Label ID="Label3" class="fw-bold" runat="server" Text="IDN: "></asp:Label>
        
            <asp:Label ID="idnLabel" runat="server" Text="Label"></asp:Label>

            <asp:Label ID="Label4" class="fw-bold" runat="server" Text="  Nombre: "></asp:Label>

            <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
        </div>

        <div class="col-1">
            <asp:Button ID="logout" class="btn btn-danger" runat="server" Text="Logout" OnClick="logout_Click" />
        </div>
        

    </div>
    <br />
<!-- ------------------------------------------------------------------------------------------------>
    <div class="d-flex justify-content-center m-4">

         <div class="card mr-2 shadow-lg p-3 mb-5 bg-body rounded" style="width: 50rem;">
            <div class="card-body">
        
                <h1> Reserves </h1>

                <asp:ListBox ID="ListBox1" runat="server"  class="shadow mb-2" Height="137px" Width="495px"></asp:ListBox>
                <br />
                <asp:Button ID="jsonButton" class="btn btn-secondary" runat="server" OnClick="jsonButton_Click" Text="Export JSON" />

                <hr />
        
                <h6 class="col-8">ID reserve:</h6>
                <div class="row">
                    <div class="col-6">
                        <asp:TextBox ID="idReserveTextBox" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-2">
                        <asp:Button ID="searchButtonReserve" class="btn btn-info" runat="server" OnClick="searchButtonReserve_Click" Text="SEARCH RESERVE" />
                    </div>
                </div>

                <asp:Label ID="noticeReserveLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
                <hr />
        
                <div>
                    <h6 class="col-8">Client:</h6>
                    <asp:TextBox ID="clientTextBox" class="form-control" runat="server"></asp:TextBox>   
                </div>
                <br />
                <div>
                    <h6 class="col-8">Arrival Date:</h6>
                    <asp:TextBox ID="arrivalDateTextBox" class="form-control" runat="server" TextMode="Date"></asp:TextBox>   
                </div>
                <br />
                <div>
                    <h6 class="col-8">Finish Date:</h6>
                    <asp:TextBox ID="finishDateTextBox" class="form-control" runat="server" TextMode="Date"></asp:TextBox>   
                </div>
                <br />
                <div>
                    <h6 class="col-8">Type Room:</h6>
                    <asp:TextBox ID="typeRoomTextBox" class="form-control" runat="server"></asp:TextBox>  

                </div>

                <hr />

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
            
            <br />
            <hr />
        
            <h6 class="col-8">ID reserve:</h6>
            <div class="row">
                <div class="col-6">
                    <asp:TextBox ID="idClientTextBox" runat="server"  class="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Button ID="searchButtonClient" runat="server" class="btn btn-info" Text="SEARCH CLIENT" OnClick="searchButtonClient_Click" />
                </div>
            </div>
            
    
            <asp:Label ID="noticeClientLabel" runat="server" ForeColor="#CC3300"></asp:Label>
    
            <hr />
        
            <div>
                <h6 class="col-8">Idn:</h6>
                <asp:TextBox ID="idnTextBox" class="form-control" runat="server" TextMode="Number"></asp:TextBox>   
            </div>
            <br />
            <div>
                <h6 class="col-8">Name:</h6>
                <asp:TextBox ID="nameTextBox" class="form-control" runat="server"></asp:TextBox>   
            </div>
            <br />
            <div>
                <h6 class="col-8">surname:</h6>
                <asp:TextBox ID="surnameTextBox" class="form-control" runat="server"></asp:TextBox>   
            </div>
            <br />
            <div>
                <h6 class="col-8">Password:</h6>
                <asp:TextBox ID="passTextBox" class="form-control" runat="server" TextMode="Number"></asp:TextBox>  

            </div>
            <br />
            <div>
                <h6 class="col-8">Credit Card:</h6>
                <asp:TextBox ID="creditcardTextBox" class="form-control" runat="server" TextMode="Number"></asp:TextBox>  
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
