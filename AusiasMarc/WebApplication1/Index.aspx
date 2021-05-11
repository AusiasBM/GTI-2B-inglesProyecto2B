<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron">
        <div class="container">
            <h1>Welcome to the hotel Ausias Marc</h1>
            <p>Here you can find the perfect place to disconnect.</p>
        </div>
    </div>
    <div class="container">
        <div class="row position-absolute top-50 start-50 translate-middle">
            <div class="card" style="width: 18rem;">
                <img src="https://csp-clients.s3.amazonaws.com/easttexasspa/wp-content/uploads/2016/12/700px-helo-ambiente-salt-sauna-2.png" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">Visit our sauna</h5>
                    <p class="card-text">If you want to enjoy a moment of relaxation, don't hesitate to come to our sauna.</p>
                    <a href="#" class="btn btn-primary">Visit</a>
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="https://alcomobi.com/wp-content/uploads/mobiliario-contract-hoteles-habitaciones-alcomobi-33.jpg" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">Small room</h5>
                    <p class="card-text">Come and enjoy our small but friendly room. Here you will be very well.</p>
                    <a href="#" class="btn btn-primary">Visit</a>
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="https://cf.bstatic.com/images/hotel/max1024x768/188/188487317.jpg" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">Medium sized room</h5>
                    <p class="card-text">Enjoy one of the best rooms, here you can enjoy a lot, do not hesitate to come!</p>
                    <a href="#" class="btn btn-primary">Visit</a>
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="https://media-magazine.trivago.com/wp-content/uploads/sites/3/2016/10/10104522/hoteles-jacuzzi-privado-barcelona-sb-plaza-europa-habitacion.jpg" class="card-img-top">
                    <div class="card-body">
                        <h5 class="card-title">Large room</h5>
                        <p class="card-text">Come and enjoy our best room, here you can spend as much time as you want.</p>
                        <a href="#" class="btn btn-primary">Visit</a>
                    </div>
            </div>
        </div>
    </div>

</asp:Content>
