<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Envios.aspx.cs" Inherits="CelMaster.Envios" %>

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
                        <li><asp:LinkButton runat="server" ID="peincipal" OnClick="peincipal_Click" >Salir</asp:LinkButton></li>
 
                    </ul>
                </div>  
            </div>
        </div>
    </div> 

    <form enctype="multipart/form-data">

        <div id="customer_details" class="col2-set">
            <div class="col-1">
                <div class="woocommerce-billing-fields">
                    <h3>Detalles del envio</h3>

                    <p id="billing_first_name_field" class="form-row form-row-first validate-required">
                        <label class="" for="billing_first_name">
                            Nombre
                            <abbr title="required" class="required">*</abbr>
                        </label>
                        <input type="text" value="" placeholder="" id="billing_first_name" name="billing_first_name" class="input-text ">
                    </p>

                    <p id="billing_last_name_field" class="form-row form-row-last validate-required">
                        <label class="" for="billing_last_name">
                            Apellido
                            <abbr title="required" class="required">*</abbr>
                        </label>
                        <input type="text" value="" placeholder="" id="billing_last_name" name="billing_last_name" class="input-text ">
                    </p>
                    <div class="clear"></div>


                    <p id="billing_address_1_field" class="form-row form-row-wide address-field validate-required">
                        <label class="" for="billing_address_1">
                            Dirección
                            <abbr title="required" class="required">*</abbr>
                        </label>
                        <input type="text" value="" placeholder="Street address" id="billing_address_1" name="billing_address_1" class="input-text ">
                    </p>

                    <p id="billing_country_field" class="form-row form-row-wide address-field update_totals_on_change validate-required woocommerce-validated">
                        <label class="" for="billing_country">
                            Departamento
                            <abbr title="required" class="required">*</abbr>
                        </label>
                        <select class="country_to_state country_select" id="billing_country" name="billing_country">
                            <option value="">Selecciona el departamento…</option>
                            <option value="MN">Managua</option>
                            <option value="MS">Masaya</option>
                            <option value="LE">León</option>
                            <option value="GR">Granada</option>
                            <option value="JI">Jinotega</option>
                            <option value="ES">EstelÍ</option>
                            <option value="CO">Chontales</option>
                            <option value="CI">Chinandega</option>
                            <option value="CA">Carazo</option>
                            <option value="BO">Boaco</option>
                            <option value="MT">Matagalpa</option>
                            <option value="NS">Nueva Segovia</option>
                            <option value="SJ">RÍo San Juan</option>
                            <option value="RI">Rivas</option>
                            <option value="CN">Costa Caribe Norte</option>
                            <option value="CS">Costa Caribe Sur</option>
                        </select>
                    </p>

                 
                    <div class="clear"></div>

                    <p id="billing_phone_field" class="form-row form-row-last validate-required validate-phone">
                        <label class="" for="billing_phone">
                            Celular
                            <abbr title="required" class="required">*</abbr>
                        </label>
                        <input type="text" value="" placeholder="" id="billing_phone" name="billing_phone" class="input-text ">
                    </p>
                    <div class="clear"></div>

                    <div class="col-2">
                        <div class="woocommerce-shipping-fields">
                            <h3 id="ship-to-different-address">
                                <label class="checkbox" for="ship-to-different-address-checkbox">Cambio de direccion?</label>
                                <input type="checkbox" value="1" name="ship_to_different_address" checked="checked" class="input-checkbox" id="ship-to-different-address-checkbox">
                            </h3>

                            <p id="billing_first_name_field" class="form-row form-row-first validate-required">
                                <label class="" for="billing_first_name">
                                    Nombre
                                    <abbr title="required" class="required">*</abbr>
                                </label>
                                <input type="text" value="" placeholder="" id="billing_first_name" name="billing_first_name" class="input-text ">
                            </p>

                            <p id="billing_last_name_field" class="form-row form-row-last validate-required">
                                <label class="" for="billing_last_name">
                                    Apellido
                                    <abbr title="required" class="required">*</abbr>
                                </label>
                                <input type="text" value="" placeholder="" id="billing_last_name" name="billing_last_name" class="input-text ">
                            </p>
                            <div class="clear"></div>


                            <p id="billing_address_1_field" class="form-row form-row-wide address-field validate-required">
                                <label class="" for="billing_address_1">
                                    Dirección
                                    <abbr title="required" class="required">*</abbr>
                                </label>
                                <input type="text" value="" placeholder="Street address" id="billing_address_1" name="billing_address_1" class="input-text ">
                            </p>

                            <p id="billing_country_field" class="form-row form-row-wide address-field update_totals_on_change validate-required woocommerce-validated">
                                <label class="" for="billing_country">
                                    Departamento
                                    <abbr title="required" class="required">*</abbr>
                                </label>
                                <select class="country_to_state country_select" id="billing_country" name="billing_country">
                                    <option value="">Selecciona el departamento…</option>
                                    <option value="MN">Managua</option>
                                    <option value="MS">Masaya</option>
                                    <option value="LE">León</option>
                                    <option value="GR">Granada</option>
                                    <option value="JI">Jinotega</option>
                                    <option value="ES">EstelÍ</option>
                                    <option value="CO">Chontales</option>
                                    <option value="CI">Chinandega</option>
                                    <option value="CA">Carazo</option>
                                    <option value="BO">Boaco</option>
                                    <option value="MT">Matagalpa</option>
                                    <option value="NS">Nueva Segovia</option>
                                    <option value="SJ">RÍo San Juan</option>
                                    <option value="RI">Rivas</option>
                                    <option value="CN">Costa Caribe Norte</option>
                                    <option value="CS">Costa Caribe Sur</option>
                                </select>
                            </p>


                            <div class="clear"></div>

                            <p id="billing_phone_field" class="form-row form-row-last validate-required validate-phone">
                                <label class="" for="billing_phone">
                                    Celular
                                    <abbr title="required" class="required">*</abbr>
                                </label>
                                <input type="text" value="" placeholder="" id="billing_phone" name="billing_phone" class="input-text ">
                            </p>
                            <div class="clear"></div>


                            <h3 id="order_review_heading">Orden</h3>

                            <div id="order_review" style="position: relative;">
                                <table class="shop_table">
                                    <thead>
                                        <tr>
                                            <th class="product-name">Producto</th>
                                            <th class="product-total">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="cart_item">
                                            <td class="product-name">Iphone 14 Pro Max <strong class="product-quantity">× 1</strong> </td>
                                            <td class="product-total">
                                                <span class="amount">$800</span> </td>
                                        </tr>
                                    </tbody>
                                    <tfoot>

                                        <tr class="cart-subtotal">
                                            <th>Subtotal</th>
                                            <td><span class="amount">$850</span>
                                            </td>
                                        </tr>

                                        <tr class="shipping">
                                            <th>Envio gratis</th>
                                            <td>
                                                <input type="hidden" class="shipping_method" value="free_shipping" id="shipping_method_0" data-index="0" name="shipping_method[0]">
                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>


                                <div id="payment">
                                    <ul class="payment_methods methods">
                                        <li class="payment_method_bacs">
                                            <input type="radio" data-order_button_text="" checked="checked" value="bacs" name="payment_method" class="input-radio" id="payment_method_bacs">
                                            <label for="payment_method_bacs">Transferencia de pago</label>
                                            <div class="payment_box payment_method_bacs">
                                                <p>Realiza tu pago directamente en nuestra cuenta bancaria. Utilice su ID de pedido como referencia de pago. Su pedido no se enviará hasta que los fondos se hayan liquidado en nuestra cuenta.</p>
                                            </div>
                                        </li>

                                        <li class="payment_method_cheque">
                                            <input type="radio" data-order_button_text="" value="cheque" name="payment_method" class="input-radio" id="payment_method_cheque">
                                            <label for="payment_method_cheque">Cheque de pago</label>
                                            <div style="display: none;" class="payment_box payment_method_cheque">
                                                <p>Envíe su cheque al nombre de la tienda.</p>
                                            </div>
                                        </li>
                                        <li class="payment_method_paypal">
                                            <input type="radio" data-order_button_text="Proceed to PayPal" value="paypal" name="payment_method" class="input-radio" id="payment_method_paypal">
                                            <label for="payment_method_paypal">
                                                PayPal
                                                <img alt="PayPal Acceptance Mark" src="https://www.paypalobjects.com/webstatic/mktg/Logo/AM_mc_vs_ms_ae_UK.png"><a title="Qué es PayPal?" onclick="javascript:window.open('https://www.paypal.com/gb/webapps/mpp/paypal-popup','WIPaypal','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=1060, height=700'); return false;" class="about_paypal" href="https://www.paypal.com/gb/webapps/mpp/paypal-popup">What is PayPal?</a>
                                            </label>


                                            <div style="display: none;" class="payment_box payment_method_paypal">
                                                <p>Pay via PayPal; puede pagar con su tarjeta de crédito si no tiene una cuenta de PayPal.</p>
                                            </div>
                                        </li>
                                    </ul>

                                    <div class="form-row place-order">

                                        <input type="submit" data-value="Hacer envío" value="Hacer envío" id="place_order" name="woocommerce_checkout_place_order" class="button alt">
                                    </div>

                                    <div class="clear"></div>

                                </div>
                            </div>
    </form>

    </div>                       
                    </div>                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
