<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Admon.aspx.cs" Inherits="CelMaster.Admon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                                <label>Login</label><label style="color: firebrick">*</label>
                                <asp:TextBox ID="txtLogin" runat="server" MaxLength="20" onkeypress="return blockCaracteresEspeciales(event)" CssClass="form-control" AutoCompleteType="None" autocomplete="off"></asp:TextBox>
                            </div>
                            <div class="col-md-3" style="margin-top: 10px">
                                <label>Contraseña</label><label style="color: firebrick">*</label>
                                <div class="input-group">
                                    <asp:TextBox runat="server" ID="txtContraseña" MaxLength="60" AutoPostBack="false" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-append">
                                        <asp:LinkButton ID="lnkMostrarPassword" OnClick="lnkMostrarPassword_Click"  UseSubmitBehavior="false" runat="server" class="btn btn-block btn-primary"><i runat="server" id="iconoverpassword" class="fas fa-eye"></i></asp:LinkButton>
                                    </span>
                                </div>
                            </div>
                            <div class="col-md-3" style="margin-top: 10px">
                                <label>Correo</label><label style="color: firebrick">*</label>
                                <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3" style="margin-top: 10px">
                                <label>Rol</label><label style="color: firebrick">*</label>
                                <asp:DropDownList ID="ddlRol" runat="server" AppendDataBoundItems="true" class="form-control form-select" AutoPostBack="true" OnSelectedIndexChanged="ddlRol_SelectedIndexChanged1"></asp:DropDownList>
                            </div>



                            <div class="col-md-3" style="margin-top: 10px">
                                <label>Cargo</label><label style="color: firebrick">*</label>
                                <asp:TextBox ID="txtCargo" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
                                <br />
                            </div>
                            <div class="col-sm-1" style="margin-top: 10px">
                                <label>Baja</label>
                                <asp:DropDownList ID="ddlBaja" runat="server" AppendDataBoundItems="true" class="form-control form-select" AutoPostBack="true" OnSelectedIndexChanged="ddlBaja_SelectedIndexChanged"></asp:DropDownList>
                            </div>

                            <%-- Botones --%>
                            <div class="row">
                                <div class="col-md-2">
                                    <asp:LinkButton runat="server" ID="lnkVolver" CssClass="w-100 btn " BackColor="#6699CC" ForeColor="White" OnClick="lnkVolver_Click" >Volver</asp:LinkButton>
                                </div>
                                <asp:Panel runat="server" ID="panelBtnNuevo" class="col-md-2" Visible="true">
                                   <asp:LinkButton runat="server" ID="lnkNuevo" CssClass="w-100 btn " BackColor="#6699CC" ForeColor="White" OnClick="lnkNuevo_Click">Nuevo</asp:LinkButton>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="panelBtnGuardar" class="col-md-2">
                                    <asp:LinkButton runat="server" ID="lnkGuardar" CssClass="w-100 btn btn-primary" ForeColor="White" OnClientClick="confirmGuardar('','Seguro desea guardar el usuario.','lnkGuardar',true);return false;" OnClick="lnkGuardar_Click">Guardar</asp:LinkButton>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="panelBtnAnular" class="col-md-2">
                                    <asp:LinkButton runat="server" ID="lnkAnular" CssClass="w-100 btn btn-warning" ForeColor="White" OnClientClick="Confirmar('Seguro desea anular el registro','lnkAnular','');return false;" OnClick="lnkAnular_Click">Anular</asp:LinkButton>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="panelBtnDesbloquear" class="col-md-2">
                                    <asp:LinkButton runat="server" ID="lnkDesbloquear" CssClass="form-control btn btn-primary" ForeColor="White" OnClientClick="confirmDesbloquear('','Seguro desea desbloquear el usuario.','lnkDesbloquear',true);return false;" OnClick="lnkDesbloquear_Click">Desbloquear</asp:LinkButton>
                                </asp:Panel>
                            </div>
                            <div class="row"></div>

                            <div class="row">

                                <%-- Encabezado Grid --%>
                              
                                <%-- Grid --%>
                                <div class="row" id="DivGrid" style="width: 100%;margin-top:20px">
                                    <div class="col-md-12" style="overflow-y: scroll; overflow-x: scroll; max-height: 500px;">
                                        <asp:HiddenField runat="server" ID="HF_IdUsuario" Value="0" />
                                        <asp:HiddenField runat="server" ID="HF_CodigoMunicipio" Value="0" />
                                        <asp:HiddenField runat="server" ID="HF_Nombre" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Login" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Email" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_IdAreaEjecutora" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Cargo" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_IdRol" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Intentos" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Bloqueado" Value="" />
                                        <asp:HiddenField runat="server" ID="HF_Baja" Value="" />
                                        <div>
                                            <asp:Label ID="lblCantidadRegistros" runat="server" Text="" Font-Bold="true" ForeColor="Orange"></asp:Label>
                                            <%--<asp:GridView ID="gridUsuarios"--%>
                                                AllowPaging="true"
                                                AllowSorting="true"
                                                PageSize="5"
                                                runat="server"
                                                CssClass="table table-bordered table-hover"
                                                AutoGenerateColumns="False"
                                                EmptyDataText="No se encontraron registros"
                                                DataKeyNames="IdUsuario,NombreCompleto,Login,Email,Cargo,IdRol,Bloqueado,Baja"
                                                OnSelectedIndexChanged="gridUsuarios_SelectedIndexChanged"
                                                OnPageIndexChanging="gridUsuarios_PageIndexChanging"
                                                OnRowCommand="gridUsuarios_RowCommand" OnRowDataBound="gridUsuarios_RowDataBound1" CellPadding="4" ForeColor="#333333">
                                                <HeaderStyle BackColor="#2B6F97" Font-Bold="True" ForeColor="White" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                <AlternatingRowStyle BackColor="White" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <Columns>

                                                    <asp:TemplateField HeaderText="Seleccionar" Visible="true" ItemStyle-Width="20px">
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Select" Height="15px" ImageUrl="~/assets/Images/empty.png" />
                                                        </ItemTemplate>
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:TemplateField>

                                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Completo" SortExpression="Nombre" ItemStyle-Wrap="false"></asp:BoundField>
                                                    <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" ItemStyle-Wrap="false"></asp:BoundField>
                                                    <asp:BoundField DataField="Email" HeaderText="Correo" SortExpression="Correo" ItemStyle-Wrap="false"></asp:BoundField>
                                                    <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" Visible="false" ItemStyle-Wrap="false"></asp:BoundField>
                                                    <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol" ItemStyle-Wrap="false"></asp:BoundField>
                                                    <asp:BoundField DataField="Intentos" HeaderText="Intentos Fallidos" SortExpression="Intentos" ItemStyle-Wrap="false"></asp:BoundField>

                                                    <asp:TemplateField HeaderText="Bloqueado" Visible="true">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblBloqueado" Text='<%#Eval("Bloqueado")%>'></asp:Label>
                                                        </ItemTemplate>
                                                        <ControlStyle CssClass="lblbox2" />
                                                        <HeaderStyle CssClass="lblbox2" Wrap="false" />
                                                        <ItemStyle CssClass="lblbox2" Wrap="false" />
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Baja" Visible="true">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblBaja" Text='<%#Eval("Baja")%>'></asp:Label>
                                                        </ItemTemplate>
                                                        <ControlStyle CssClass="lblbox2" />
                                                        <HeaderStyle CssClass="lblbox2" Wrap="false" />
                                                        <ItemStyle CssClass="lblbox2" Wrap="false" />
                                                    </asp:TemplateField>

                                                </Columns>
                                                <PagerStyle CssClass="pagination-ys" />
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>


                            </div>
                        </div>
                    </div>
                </div>
</asp:Content>
