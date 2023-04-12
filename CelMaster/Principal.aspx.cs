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
    public partial class usiariosAdmon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarSesion();
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
            Session.Abandon();
            Session.RemoveAll();
            HttpCookie CookieSesion = new HttpCookie("ASP.NET_SessionId", "");
            Response.Cookies.Add(CookieSesion);
            if (MostrarMensaje)
            {
                Mensaje("Inicie Sesión Nuevamente", eMessage.Info, "Datos de Sesión Incompletos", false, true, true, "/Login.aspx", false);
            }
        }
        private void VerificarPermisosFormularios(List<RolFormulario> RolFormularios)
        {
            panelFormulario_1.Visible = false;
            panelFormulario_2.Visible = false;
            panelFormulario_3.Visible = false;
            panelFormulario_4.Visible = false;

            foreach (var RolFormulario in RolFormularios)
            {
                if (RolFormulario.IdFormulario == (int)eFormulario.Facturacion)
                {
                    panelFormulario_1.Visible = true;
                }
                if (RolFormulario.IdFormulario == (int)eFormulario.Inventario)
                {
                    panelFormulario_2.Visible = true;
                }
                if (RolFormulario.IdFormulario == (int)eFormulario.nuevos_Productos)
                {
                    panelFormulario_3.Visible = true;
                }
                if (RolFormulario.IdFormulario == (int)eFormulario.Envios)
                {
                    panelFormulario_4.Visible = true;
                }
            }

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

                VerificarPermisosFormularios(FormulariosUser);
                Session["RolFormulariosGl"] = FormulariosUser;
                return true;
            }
            catch
            {
                AbandonarSesion();
                return false;
            }
        }
        #endregion






        protected void Inv_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inventario.aspx");
        }

        protected void Envios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Envios.aspx");
        }

        protected void fac_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Facturacion.aspx");
       

        }

        protected void nuevopro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NuevosProductos.aspx");

        }
    }
}