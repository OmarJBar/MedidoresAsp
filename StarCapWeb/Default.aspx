<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>
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
                        <label for="nombreTxt">Numero medidor: </label>
                        <asp:TextBox ID="NumeroMed" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>                    
                    <div class="form-group">
                        <label for="fechaTxt">Tipo de medidor</label>
                        <asp:RadioButtonList runat="server" ID="tipoMed">
                            <asp:ListItem Selected="True" Value="1" Text="Luz"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Agua"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
