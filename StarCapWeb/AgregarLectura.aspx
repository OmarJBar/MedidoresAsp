<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="StarCapWeb.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-8 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
                <asp:Label runat="server" ID="mensajeLbler" CssClass="table-warning"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Numero lectura: 
                        <asp:RequiredFieldValidator ID="numeroRfv" runat="server" ControlToValidate="NumeroLectura" Display="Dynamic" ErrorMessage="*" ForeColor="#993399" ValidationGroup="vg" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="numeroRv" runat="server" ControlToValidate="NumeroLectura" Display="Dynamic" ErrorMessage="Solo enteros" ForeColor="#990033" MaximumValue="1000" MinimumValue="0" Type="Integer" ValidationGroup="vg"></asp:RangeValidator>
                        </label>
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
                        <label for="horaTxt">Hora:</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="horaTxt" Display="Dynamic" ErrorMessage="*" ForeColor="#993399" ValidationGroup="vg" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="horaTxt" Display="Dynamic" ErrorMessage="Error en hora" MaximumValue="60" MinimumValue="0" Type="Integer" ValidationGroup="vg"></asp:RangeValidator>
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <label for="minutoTxt">Minuto:</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="minutoTxt" Display="Dynamic" ErrorMessage="*" ForeColor="#993399" ValidationGroup="vg" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="minutoTxt" Display="Dynamic" ErrorMessage="Error en minuto" MaximumValue="60" MinimumValue="0" Type="Integer" ValidationGroup="vg"></asp:RangeValidator>
                        <asp:TextBox ID="minutoTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="consumoTxt">Consumo:</label><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="consumoLectura" Display="Dynamic" ErrorMessage="*" ForeColor="#993399" ValidationGroup="vg" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="consumoLectura" Display="Dynamic" ErrorMessage="Fuera del rango" MaximumValue="600" MinimumValue="1" Type="Integer" ValidationGroup="vg"></asp:RangeValidator>
                        &nbsp;<asp:TextBox ID="consumoLectura" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>