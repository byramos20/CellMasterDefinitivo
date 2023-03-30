<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="CelMaster.Inventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-4" >
                    <div class="header-right">
                        <ul class="list-unstyled list-inline">
                            <li class="dropdown dropdown-small">
                                <a data-toggle="dropdown" data-hover="dropdown" class="dropdown-toggle" href="#"><span class="key">Divisa :</span><span class="value">USD </span><b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">USD</a></li>
                                </ul>
                            </li>

                            <li class="dropdown dropdown-small">
                                <a data-toggle="dropdown" data-hover="dropdown" class="dropdown-toggle" href="#"><span class="key">Lenguaje :</span><span class="value">Español </span><b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Español</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

<div class="site-branding-area">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    <div class="logo">
                        <h1><a href="./"><img src="assets/estiloproyecto/img/logo.png"></a></h1>
                    </div>
                </div>
                
                <div class="col-sm-6">
                    <div class="shopping-item">
                        <a href="cart.html">Compras - <span class="cart-amunt">$100</span> <i class="fa fa-shopping-cart"></i> <span class="product-count">5</span></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="mainmenu-area">
        <div class="container">
            <div class="row">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Barra de navegación</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                </div> 
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><asp:LinkButton runat="server" ID="peincipal2" OnClick="peincipal2_Click">Salir</asp:LinkButton></li>
 
                    </ul>
                </div>  
            </div>
        </div>
    </div> 

<h3 id="order_review_heading"margin-right="auto" margin-left="auto">Inventario de productos</h3>

                                <div id="order_review" style="position: relative;">
                                    <table class="shop_table">
                                        <thead>
                                            <tr>
                                                <th class="product-name">Productos</th>
                                                <th class="product-total">Cantidad</th>
                                            </tr>
                                        </thead>
                                        <tbody>

                                            <tr class="cart_item">
                                                <td class="product-name">
                                                    Iphone 14 Pro <strong class="product-quantity"></strong> </td>
                                                <td class="product-total">
                                                    <span class="amount"># </span> </td>
                                            </tr>
                                        </tbody>
                                        <tfoot>

                                            <tr class="iphone-14">
                                                <th>Iphone 14 </th>
                                                <td><span class="amount">20</span>
                                                </td>
                                            </tr>

                                            <tr class="iphone-13">
                                                <th>Iphone 13 </th>
                                                <td><span class="amount">10</span>
                                                </td>
                                            </tr>

                                          <tr class="samsung-zflip-4">
                                                <th>Samsung Z Flip 4 </th>
                                                <td><span class="amount">15</span>
                                                </td>
                                            </tr>

                                            <tr class="samsun-galaxy-note20-ultra">
                                                <th>Samsung Galaxy Note20 Ultra </th>
                                                <td><span class="amount">7</span>
                                                </td>
                                            </tr>

                                           <tr class="huawei-mate-50pro">
                                                <th>HUAWEI Mate 50 Pro </th>
                                                <td><span class="amount">8</span>
                                                </td>
                                            </tr>

                                               <tr class="huawei-nova-y70">
                                                <th>HUAWEI nova Y70 </th>
                                                <td><span class="amount">14</span>
                                                </td>
                                            </tr>

                                                <tr class="samsung-galaxy-m51">
                                                <th>Samsung Galaxy M51 </th>
                                                <td><span class="amount">6</span>
                                                </td>
                                            </tr>


                                               <tr class="samsung-galaxy-a73-5g">
                                                <th>Samsung Galaxy A73 5G </th>
                                                <td><span class="amount">12</span>
                                                </td>
                                            </tr>


                                              <tr class="vivo-x80-pro">
                                                <th>ViVo X80 Pro </th>
                                                <td><span class="amount">3</span>
                                                </td>
                                            </tr>

                                              <tr class="huawei-nova-9">
                                                <th>HUAWEI nova 9 </th>
                                                <td><span class="amount">35</span>
                                                </td>
                                            </tr>

                                             <tr class="huawei-mate-xs-2">
                                                <th>HUAWEI Mate Xs 2 </th>
                                                <td><span class="amount">45</span>
                                                </td>
                                            </tr>


                                        </tfoot>
                                    </table>


<
</asp:Content>
