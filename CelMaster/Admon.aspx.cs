using BL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilidades;
using static EL.Enum;

namespace CelMaster
{
    public partial class Admon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarSesion();

            if (!IsPostBack)
            {
                cargarGird();
                CargarDDLRol();
            }

        }
        #region Metodos y Funciones
        private void Mensaje(string Message, eMessage tipoMensaje, string Encabezado = "", bool Html = false, bool Fondo = false, bool returnLogin = false, string UrlReturn = "", bool CerrarClick = true)
        {
            //icon -->      success,warning, error,  info
            //btnColor -->  #32A525,#E38618,#F27474,#3FC3EE

            //Parametros que recibe el metodo
            //function Mensaje(title, mensaje, icon = 'success', btnConfirmText = 'Aceptar', btnConfirmColor = '#32A525', html = false, fondo = false, ReturnLogin = false, UrlReturn)

            switch (tipoMensaje)
            {
                case eMessage.Exito:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Exito", "Mensaje('" + Encabezado + "', '" + Message + "','success','Aceptar','#32A525'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case eMessage.Alerta:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Alerta", "Mensaje('" + Encabezado + "', '" + Message + "','warning','Aceptar','#E38618'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case eMessage.Error:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Error", "Mensaje('" + Encabezado + "', '" + Message + "','error','Aceptar','#F27474'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case eMessage.Info:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Info", "Mensaje('" + Encabezado + "', '" + Message + "','info','Aceptar','#3FC3EE'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
            }
        }
        private string Justify(string msj)
        {
            string Html = "<div style = text-align:justify> " + msj + " </div>";
            return Html;
        }
        private void AbandonarSesion(bool MostrarMensaje = true)
        {
            //Session.Abandon();
            //Session.RemoveAll();
            //HttpCookie CookieSesion = new HttpCookie("ASP.NET_SessionId", "");
            //Response.Cookies.Add(CookieSesion);
            //if (MostrarMensaje)
            //{
            //    Mensaje("Inicie Sesión Nuevamente", eMessage.Info, "Datos de Sesión Incompletos", false, true, true, "/Login.aspx", false);
            //}
        }
        private bool ValidarSesion()
        {
            try
            {
                int IdUsuarioGl = (int)General.ValidarEnteros(Session["IdUsuarioGl"]);
                int IdRolGl = (int)General.ValidarEnteros(Session["IdRolGl"]);
                if (!(IdUsuarioGl > 0))
                {
                    AbandonarSesion();
                    return false;
                }

                if (!(IdRolGl > 0))
                {
                    AbandonarSesion();
                    return false;
                }

                Usuario User = BL_Usuario.Registro(IdUsuarioGl);
                if (User == null)
                {
                    AbandonarSesion();
                    return false;
                }

                if (User.IdRol != IdRolGl)
                {
                    AbandonarSesion();
                    return false;
                }

                List<RolFormulario> FormulariosUser = BL_RolFormulario.List(IdRolGl);
                if (!(FormulariosUser.Count > 0))
                {
                    AbandonarSesion(false);
                    Mensaje("Estimado usuario, no cuenta con permisos necesarios para ingresar a ningún formulario", eMessage.Info, "", false, true, true, "/Login.aspx", false);
                    return false;
                }

                Session["RolFormulariosGl"] = FormulariosUser;

                List<RolPermisos> PermisosUser = BL_RolPermisos.List(IdRolGl);
                panelBtnActualizar.Visible = false;
                panelBtnGuardar.Visible = true;
                panelBtnAnular.Visible = false;
                panelBtnDesbloquear.Visible = false;

                if (PermisosUser.Count > 0)
                {
                    foreach (var PermisoUser in PermisosUser)
                    {
                        if (PermisoUser.IdPermiso == (int)ePermisos.Escribir)
                        {
                            panelBtnActualizar.Visible = true;
                            panelBtnGuardar.Visible = true;
                        }

                        if (PermisoUser.IdPermiso == (int)ePermisos.Anular)
                        {
                            panelBtnAnular.Visible = true;
                        }

                    }


                }
                return true;
            }
            catch
            {
                AbandonarSesion();
                return false;
            }
        }
        private void cargarGird()
        {
            griddUsuario.DataSource = BL_Usuario.vUsuario();
            griddUsuario.DataBind();
        }
        private void CargarDDLRol()
        {
            try
            {
                ddlRol.Items.Clear();
                ddlRol.Items.Insert(0, new ListItem("--Seleccione--"));
                ddlRol.DataSource = BL_Rol.List();
                ddlRol.DataValueField = "IdRol";
                ddlRol.DataTextField = "NombreRol";
                ddlRol.DataBind();
            }
            catch 
            {
                Mensaje("Error al cargar los Roles", eMessage.Error);
                
            }
        }
        private void ResetControles()
        {
            txtNombre.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtEmail.Text = string.Empty;
            ddlRol.SelectedIndex = 0;
            HF_IdUsuario.Value = "0";

        }

        private bool Validarinsertar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                Mensaje("Ingrese el nombre completo del usuario", eMessage.Alerta);
                return false;
            }
            if (String.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                Mensaje("Ingrese el UserName del usuario", eMessage.Alerta);
                return false;
            }
            if (String.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                Mensaje("Ingrese la Contraseña del usuario", eMessage.Alerta);
                return false;
            }
            if (!General.validarComplejidadPassword(txtContraseña.Text))
            {
                Mensaje(Justify("La contraseña no cumple con los requerimientos minimos: <br> <ol> <li>Longitud minima de 8 caractees</li><li>Una Letra mayuscula</li><li>Una letra minuscula</li> <li>Un Numero</li></ol>"),eMessage.Alerta,"",true);
                return false;
            }
            if (BL_Usuario.ExisteUserName(txtUserName.Text))
            {
                Mensaje("Este UserName Ya esxiste",eMessage.Alerta);
                return false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                Mensaje("Ingrese el Correo del usuario", eMessage.Alerta);
                return false;
            }
            //if (!General.CorreoEsValido(txtEmail.Text))
            //{
            //    Mensaje("Ingrese un correo Valido", eMessage.Alerta);
            //    return false;
            //}
            if (ddlRol.SelectedIndex == 0)
            {
                Mensaje("Selecciones el Rol del Usuario", eMessage.Alerta);
                return false;
            }
            return true;
        }
        private bool ValidarActualizar()
        {
            return true;
        }

        private void Guardar()
        {
            try
            {
                int IdUsuariosistema = (int)General.ValidarEnteros(Session["IdUsuarioGl"]);
                if (!(IdUsuariosistema > 0))
                {
                    Mensaje("Datso dek usuario del sistema no encontrados", eMessage.Alerta);
                    return;
                }
                int IdRegistro = (int)General.ValidarEnteros(HF_IdUsuario.Value);
                if (IdRegistro > 0)
                {
                    //Actualizando
                    return;
                }
                //Insertar 
                if (Validarinsertar())
                {
                    Usuario user = new Usuario();
                    user.NombreCompleto = txtNombre.Text;
                    user.UserName = txtUserName.Text;
                    user.Password = BL_Usuario.Encrypt(txtContraseña.Text);
                    user.Correo = txtEmail.Text;
                    user.IdRol = (int)General.ValidarEnteros(ddlRol.SelectedValue);
                    user.IdUsuarioRegistra = IdUsuariosistema;

                    if(BL_Usuario.Insert(user).IdUsuario>0)
                    {
                        ResetControles();
                        cargarGird();
                        Mensaje("Registro guardado correctamente", eMessage.Exito);
                        return;
                    }
                    Mensaje("Regstro no se pudo Guardar", eMessage.Error);
                    return;
                }

            }
            catch
            {
                //mandar un mesaja operacion no realizada
            }
        }

        private void cargarControles(int IdRegisttro)
        {
            try
            {
                vUsuario vUsuarios = BL_Usuario.vUsuarios(IdRegisttro);
                if (vUsuarios == null)
                {
                    Mensaje("No se encontraron datos para el registro seleccionado", eMessage.Error);
                    return;
                }
                txtNombre.Text = vUsuarios.NombreCompleto;
                txtUserName.Text = vUsuarios.UserName;
                txtContraseña.Text = string.Empty;
                txtEmail.Text = vUsuarios.Correo;
                ddlRol.SelectedValue = vUsuarios.IdRol.ToString();  
            }
            catch 
            {

                Mensaje("Error al cargar los datos del registro", eMessage.Error);
            }
        }
        #endregion



        #region Evento de controles

        protected void lnkMostrarPassword_Click(object sender, EventArgs e)
        {

        }

        protected void ddlRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlRol_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void lnkVolver_Click(object sender, EventArgs e)
        {

        }

        protected void lnkGuardar_Click1(object sender, EventArgs e)
        {
            Guardar();
        }

        protected void lnkAnular_Click1(object sender, EventArgs e)
        {

        }

        protected void lnkDesbloquear_Click1(object sender, EventArgs e)
        {
            ResetControles();

        }

        protected void lnkActualizar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}