<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Admon.aspx.cs" Inherits="CelMaster.Admon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assets/estiloproyecto/css/grid.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="margin-top: 20px">
        <div class="card">
            <div class="card card-header" style="background-color: #ed82ed">
                <h5 style="color: #fff">Administración de usuarios</h5>
            </div>
            <div class="card-body">
                <div class="row">

                    <div class="col-md-3" style="margin-top: 10px">
                        <label>Nombre Completo</label><label style="color: firebrick">*</label>
                        <asp:TextBox ID="txtNombre" runat="server" MaxLength="250" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-3" style="margin-top: 10px">
                        <label>UserName</label><label style="color: firebrick">*</label>
                        <asp:TextBox ID="txtUserName" runat="server" MaxLength="20" onkeypress="return blockCaracteresEspeciales(event)" CssClass="form-control" AutoCompleteType="None" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="col-md-3" style="margin-top: 10px">
                        <label>Password</label><label style="color: firebrick">*</label>
                        <div class="input-group">
                            <asp:TextBox runat="server" ID="txtContraseña" MaxLength="60" AutoPostBack="false" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-append">
                                <asp:LinkButton ID="lnkMostrarPassword" OnClick="lnkMostrarPassword_Click" UseSubmitBehavior="false" runat="server" class="btn btn-block btn-primary"><i runat="server" id="iconoverpassword" class="fas fa-eye"></i></asp:LinkButton>
                            </span>
                        </div>
                    </div>
                    <div class="col-md-3" style="margin-top: 10px">
                        <label>Correo</label><label style="color: firebrick">*</label>
                        <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-3" style="margin-top: 10px">
                        <label>Rol</label><label style="color: firebrick">*</label>
                        <asp:DropDownList runat="server" ID="ddlRol"  AppendDataBoundItems="true" Cssclass="form-control form-select" ></asp:DropDownList>
                        </asp:ListItem></asp:ListItem>
                        </asp.DropDownList>
                        </div>
                    </div>
                    
                <br />
               

                    <%-- Botones --%>
                    <div class="row">
                        <div class="col-md-2">
                            <asp:LinkButton runat="server" ID="lnkVolver" CssClass="w-100 btn " BackColor="#6699CC" ForeColor="White" OnClick="lnkVolver_Click">Volver</asp:LinkButton>
                        </div>
                        <asp:Panel runat="server" ID="panelBtnActualizar" class="col-md-2" Visible="true">
                            <asp:LinkButton runat="server" ID="lnkActualizar" CssClass="w-100 btn " BackColor="#6699CC" ForeColor="White" OnClick="lnkActualizar_Click" >Actualizar</asp:LinkButton>
                        </asp:Panel>
                        <asp:Panel runat="server" ID="panelBtnGuardar" class="col-md-2" Visible="true">
                            <asp:LinkButton runat="server" ID="lnkGuardar" CssClass="w-100 btn btn-primary" ForeColor="White" OnClientClick="confirmGuardar('','Seguro desea guardar el usuario.','lnkGuardar',true);return false;" OnClick="lnkGuardar_Click1">Guardar</asp:LinkButton>
                        </asp:Panel>
                        <asp:Panel runat="server" ID="panelBtnAnular" class="col-md-2" Visible="true">
                            <asp:LinkButton runat="server" ID="lnkAnular" CssClass="w-100 btn btn-warning" ForeColor="White" OnClientClick="Confirmar('Seguro desea anular el registro','lnkAnular','');return false;" OnClick="lnkAnular_Click1">Anular</asp:LinkButton>
                        </asp:Panel>
                        <asp:Panel runat="server" ID="panelBtnDesbloquear" class="col-md-2" Visible="true">
                            <asp:LinkButton runat="server" ID="lnkDesbloquear" CssClass="form-control btn btn-primary" ForeColor="White" OnClientClick="confirmDesbloquear('','Seguro desea desbloquear el usuario.','lnkDesbloquear',true);return false;" OnClick="lnkDesbloquear_Click1">Limpiar</asp:LinkButton>
                        </asp:Panel>
                    </div>
                    <div class="row"></div>
                     <div class="row">

                         <br />
                         <br />
                        
                         <%-- Gri  --%>
                         <div class="row" style="margin-top: 15px; overflow:scroll">
                             <asp:HiddenField runat="server" ID="HF_IdUsuario" />
                             <asp:Gridview runat="server" 
                                 ID="gridUsuario" 
                                 AllowPaging ="true" 
                                 PageSize="5" 
                                 CssClass="table table-bordered table-hover" 
                                 AutoGenerateColumns="false" 
                                 EmtyDataText="Sin regisrtros Para Mostrar" 
                                 DataKeyNames="IdUsuario, IdRol" 
                                 AutoGenerateSelectButton="true" OnSelectedIndexChanged="griddUsuario_SelectedIndexChanged1">
                                 <HeaderStyle BackColor="#0099cc" ForeColor="White" />
                                 <SelectedRowStyle BackColor="#999999" ForeColor="#666666" />
                                 <AlternatingRowStyle ForeColor="Yellow" BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" />
                                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                                    <asp:BoundField DataField="UserName" HeaderText="Usuario" />
                                    <asp:BoundField DataField="CuentaBloqueada" HeaderText="Bloqueado" />
                                    <asp:BoundField DataField="Intentosfallidos" HeaderText="Intentos Fallidos" />
                                    <asp:BoundField DataField="NombreRol" HeaderText="Nombre Rol" />
                                </Columns>

                             </asp:Gridview>
                         </div>
</asp:Content>
