<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="StarCapWeb.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Numero lectura: </label>
                        <asp:TextBox ID="NumeroLectura" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>                    
                    <div class="form-group">
                        <label for="fechaTxt">Medidor serie:</label>
                        <asp:DropDownList ID="medidorSerieDd" runat="server">

                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="fechaTxt">Fecha:</label>
                        <asp:Calendar ID="fechaLectura" CssClass="form-control" runat="server"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="consumoTxt">Consumo:</label>
                        <asp:TextBox ID="consumoLectura" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>