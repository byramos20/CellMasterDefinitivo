<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="CelMaster.usiariosAdmon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         
    <div class="site-branding-area">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <div class="logo">
                        <h1><a href="./"><img src="assets/estiloproyecto/img/logo.png"></a></h1>
                    </div>
                </div>

               
                            
    <div class="promo-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
                <asp:Panel runat="server" ID="panelfac" Visible="true" class="col-md-3 col-sm-6">
                    <div class="single-promo promo1">
                        <asp:Linkbutton runat="server" ID="fac" OnClick="fac_Click" class="fa fa-refresh"></asp:Linkbutton>
                        <p>Facturacion</p>
                    </div>
                </asp:Panel>

                 <asp:Panel runat="server" ID="panelInv" Visible="true"    class="col-md-3 col-sm-6">
                    <div class="single-promo promo3">
                        <asp:LinkButton runat="server" ID="Inv" OnClick="Inv_Click" class="fa fa-lock"></asp:LinkButton>
                        <p>Inventario</p>
                    </div>
                </asp:Panel>

                <asp:Panel runat="server" ID="panelnuevopro" Visible="true" class="col-md-3 col-sm-6">
                    <div class="single-promo promo4">
                        <asp:LinkButton runat="server" ID="nuevopro" OnClick="nuevopro_Click" class="fa fa-gift"></asp:LinkButton>
                        <p>Nuevos Productos</p>
                    </div>
                </asp:Panel>

                 <asp:Panel runat="server" ID="panelEnvios" Visible="true" class="col-md-3 col-sm-6">
                    <div class="single-promo promo2">
                        <asp:LinkButton runat="server" ID="Envios" OnClick="Envios_Click" class="fa fa-truck"></asp:LinkButton>
                        <p>Envios</p>
                    </div>
                </asp:Panel>

                <asp:Panel runat="server" ID="panelAdministracionususarios" Visible="true" class="col-md-3 col-sm-6">
                    <div class="single-promo promo2">
                        <asp:LinkButton runat="server" ID="AdminUser" OnClick="AdminUser_Click" class="fa fa-truck"></asp:LinkButton>
                        <p>Administracion de Ususarios</p>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </div>
               
    
   

</asp:Content>
