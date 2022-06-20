﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="StarCapWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                     
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" runat="server" ID="grillaMedidores">

                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
