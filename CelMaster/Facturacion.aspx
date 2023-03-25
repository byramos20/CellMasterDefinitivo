<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="CelMaster.Facturacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4">
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
                        <li><asp:LinkButton runat="server" ID="peincipal" OnClick="peincipal_Click">Inicio</asp:LinkButton></li>
 
                    </ul>
                </div>  
            </div>
        </div>
    </div> 



<div class="col-md-8">
                    <div class="product-content-right">
                        <div class="woocommerce">
                            <form method="post" action="#">
                                <table cellspacing="0" class="shop_table cart">
                                    <thead>
                                        <tr>
                                            <th class="product-remove">&nbsp;</th>
                                            <th class="product-thumbnail">&nbsp;</th>
                                            <th class="product-name">Producto</th>
                                            <th class="product-price">Precio</th>
                                            <th class="product-quantity">Cantidad</th>
                                            <th class="product-subtotal">Total a pagar</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="cart_item">
                                            <td class="product-remove">
                                                <a title="Remove this item" class="remove" href="#">×</a> 
                                            </td>

                                            <td class="product-thumbnail">
                                                <a href="single-product.html"><img width="145" height="145" alt="poster_1_up" class="shop_thumbnail" src="assets/estiloproyecto/img/product-1.jpg"></a>
                                            </td>

                                            <td class="product-name">
                                                <a href="single-product.html">Iphone 14 Pro Max</a> 
                                            </td>

                                            <td class="product-price">
                                                <span class="amount">1,500</span> 
                                            </td>

                                            <td class="product-quantity">
                                                <div class="quantity buttons_added">
                                                    <input type="button" class="minus" value="-">
                                                    <input type="number" size="4" class="input-text qty text" title="Qty" value="1" min="0" step="1">
                                                    <input type="button" class="plus" value="+">
                                                </div>
                                            </td>

                                            <td class="product-subtotal">
                                                <span class="amount">2,000 </span> 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="actions" colspan="6">
                                                <div class="coupon">
                                                    <label for="coupon_code">Descuento:</label>
                                                    <input type="text" placeholder="Código del descuento" value="" id="coupon_code" class="input-text" name="Código del descuento">
                                                    <input type="submit" value="Aplicar descuento" name="Aplicar descuento" class="button">
                                                </div>
                                                <input type="submit" value="Actualizar descuento" name="Actualizar descuento" class="button">
                                                <input type="submit" value="Verificar" name="Verificar" class="checkout-button button alt wc-forward">
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </form>

                             <div class="cart_totals ">
                                <h2>Total a pagar</h2>

                                <table cellspacing="0">
                                    <tbody>
                                        <tr class="cart-subtotal">
                                            <th>Subtotal a pagar</th>
                                            <td><span class="amount">$ </span></td>
                                        </tr>

                                        <tr class="shipping">
                                            <th>Envío gratis</th>
                                            <td>Envío gratis</td>
                                        </tr>

                                        <tr class="order-total">
                                            <th>Total de pedido</th>
                                            <td><strong><span class="amount">$ </span></strong> </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>



</asp:Content>
