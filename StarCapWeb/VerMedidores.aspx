<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="StarCapWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="card">
                    <div class="card-header bg-danger text-white">
                        <h3>Ver Medidores</h3>
                    </div>
                    <div class="card-body">
                     
                         <div class="card-body">
                        <div class="form-group">
                            <label for ="tipofil"> Filtrar por Tipo: </label>
                            <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipofil_SelectedIndexChanged" runat="server" ID="tipofil">                                
                                <asp:ListItem Value="1" Text="luz"></asp:ListItem>
                                <asp:ListItem Value="2" Text="agua"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
               
                        <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                            EmptyDataText="No Existen Medidores" ShowHeader="true"
                            AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                           <Columns>
                               <asp:BoundField DataField="MedidorNro" HeaderText="Numero Medidor" />
                               <asp:BoundField DataField="TipoTxt" HeaderText="Tipo" />
                           </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
