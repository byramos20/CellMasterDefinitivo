using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static EL.Enum;
using BL;
using System.Data.Entity.Infrastructure;
using System.Web.Configuration;
using EL;

namespace CelMaster
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        #region Metodos y Funciones
        
        private void Mensaje(string Message, int tipoMensaje, string Encabezado = "", bool Html = false, bool Fondo = false, bool returnLogin = false, string UrlReturn = "", bool CerrarClick = true)
        {
            //icon -->      success,warning, error,  info
            //btnColor -->  #32A525,#E38618,#F27474,#3FC3EE

            //Parametros que recibe el metodo
            //function Mensaje(title, mensaje, icon = 'success', btnConfirmText = 'Aceptar', btnConfirmColor = '#32A525', html = false, fondo = false, ReturnLogin = false, UrlReturn)

            switch (tipoMensaje)
            {
                case (int)eMessage.Exito:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Exito", "Mensaje('" + Encabezado + "', '" + Message + "','success','Aceptar','#32A525'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case (int)eMessage.Alerta:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Alerta", "Mensaje('" + Encabezado + "', '" + Message + "','warning','Aceptar','#E38618'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case (int)eMessage.Error:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Error", "Mensaje('" + Encabezado + "', '" + Message + "','error','Aceptar','#F27474'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
                case (int)eMessage.Info:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert Info", "Mensaje('" + Encabezado + "', '" + Message + "','info','Aceptar','#3FC3EE'," + Html.ToString().ToLower() + "," + Fondo.ToString().ToLower() + "," + returnLogin.ToString().ToLower() + ",'" + UrlReturn.ToString().ToLower() + "'," + CerrarClick.ToString().ToLower() + ");", true);
                    break;
            }
        }
        private string Justify(string msj)
        {
            string Html = "<div style = text-align:justify> " + msj + " </div>";
            return Html;
        }
      


        private bool ValidarControles()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Mensaje("Ingrese su usuario", (int)eMessage.Alerta);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Mensaje("Ingrese su contraseña", (int)eMessage.Alerta);
                return false;
            }

            if (!BL_Usuario.ExisteUserName(txtUsuario.Text))
            {
                Mensaje("Credenciales Incorrectas", (int)eMessage.Alerta);
                return false;
            }
            if (BL_Usuario.VerificarCuentaBloqueada(txtUsuario.Text))
            {
                Mensaje("Su cuenta ha sido bloqueada por multiples intentos fallidos de iniciar sesión", (int)eMessage.Error);
                return false;
            }
            byte[] Password = BL_Usuario.Encrypt(txtPassword.Text);
            if (!BL_Usuario.ValidarCredenciales(txtUsuario.Text, Password))
            {
                Usuario User = BL_Usuario.ExisteUsuario_x_UserName(txtUsuario.Text);
                if (BL_Usuario.CatidadIntentosFallidos(txtUsuario.Text) >= 2)
                {
                    BL_Usuario.BloquearCuentaUsuario(User.IdUsuario, true, User.IdUsuario);
                    Mensaje(Justify("La cuenta fue bloqueada por multiples intentos fallidos de iniciar sesión. Por favor comuniquese con un administrador del sistema."), (int)eMessage.Error, "", true);
                }
                if (User != null)
                {
                    BL_Usuario.SumarIntentosFallido(User.IdUsuario);
                }
                Mensaje(Justify("Credenciales incorrectas, si supera 3 intentos fallidos de inicio de sesión, su cuenta será bloqueada"), (int)eMessage.Alerta, "", true);
                return false;
            }

            Usuario UsuarioAutenticado = BL_Usuario.ExisteUsuario_x_UserName(txtUsuario.Text);
            if (UsuarioAutenticado != null)
            {
                if (UsuarioAutenticado.IntentosFallidos > 0)
                {
                    BL_Usuario.RestablecerIntentosFallido(UsuarioAutenticado.IdUsuario, UsuarioAutenticado.IdUsuario);
                }

                if (!(UsuarioAutenticado.IdRol > 0))
                {
                    Mensaje("Estimado usuario usted no tiene ul rol asignado en el sistema, por favor comuniquese con un administrador.", (int)eMessage.Error);
                    return false;
                }
                Session["IdUsuarioGl"] = UsuarioAutenticado.IdUsuario;
                Session["IdRolGl"] = UsuarioAutenticado.IdRol;
                //Redireccionar
                Response.Redirect("~/Principal.aspx");
            }

            return true;
        }


        #endregion
        #region Evento de controles 
        protected void inicar_Click(object sender, EventArgs e)
        {
            ValidarControles();
        }
        #endregion
    }

}
