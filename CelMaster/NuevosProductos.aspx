<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="NuevosProductos.aspx.cs" Inherits="CelMaster.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header-area">
        <div class="container">
            <div class="row">
                <div class="col-md-8">
                    <div class="user-menu">
                        <ul>
                        </ul>
                    </div>
                </div>

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
                        <h1><a href="./">
                            <img src="assets/estiloproyecto/img/logo.png"></a></h1>
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
                        <li>
                            <asp:LinkButton runat="server" ID="inicio" OnClick="inicio_Click">Salir</asp:LinkButton></li>

                    </ul>
                </div>
            </div>
        </div>
    </div>

    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Productos</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <div class="single-sidebar">
                        <h2 class="sidebar-title">Buscar producto</h2>
                        <form action="">
                            <input type="text" placeholder="Buscar productos...">
                            <input type="submit" value="Buscar">
                        </form>
                    </div>

                     <div class="single-sidebar">
                        <h2 class="sidebar-title">Productos</h2>
                        <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.1.jpg" class="recent-thumb" alt="">
                            <h2><a href="">iPhone 14 Pro</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$550.00</ins> 
                            </div>    
                            <hr />
                                                                           
                        <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.2.jpg" class="recent-thumb" alt="">
                            <h2><a href="">iPhone 14</a></h2> iPhone 14 Plus
                            <div class="product-sidebar-price">
                                <ins>$400.00</ins> 
                            </div>  

                         
                        </div>
                            <hr />
                        <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.3.jpg" class="recent-thumb" alt="">
                            <h2><a href="">Iphone 13</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>   
                            <hr />
                            
                              <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.4.png" class="recent-thumb" alt="">
                            <h2><a href="">Samsung Galaxy Note20 Ultra</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>  

                                  <hr />
                              <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.5.jpg" class="recent-thumb" alt="">
                            <h2><a href="">HUAWEI Mate 50 Pro</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>               
                                  <hr />

                             <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.6.jpg" class="recent-thumb" alt="">
                            <h2><a href="">HUAWEI nova Y70</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div> 
                                 <hr />

                                  <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.7.jpg" class="recent-thumb" alt="">
                            <h2><a href="">Samsung Galaxy M51</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>  
                                      <hr />


                                 <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.8.jpg" class="recent-thumb" alt="">
                            <h2><a href="">Samsung Galaxy A52</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>   
                                     <hr />

                             <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.9.jpg" class="recent-thumb" alt="">
                            <h2><a href="">ViVo X80 Pro</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div> 
                                 <hr />

                                  <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.10.jpg" class="recent-thumb" alt="">
                            <h2><a href="">HUAWEI nova 9</a></h2>
                            <div class="product-sidebar-price">
                                <ins>$600.00</ins>
                            </div>  
                                      <hr />

                        </div>
                        <div class="thubmnail-recent">
                            <img src="assets/estiloproyecto/img/product-thumb-1.1.11.jpg" class="recent-thumb" alt="">
                            <h2><a href="">Samsung Z Flip 4 </a></h2> 
                            <div class="product-sidebar-price">
                                <ins>$380.00</ins> 
                            </div>                 
                    </div>
</asp:Content>
