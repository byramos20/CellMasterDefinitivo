using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelMaster
{
    public partial class usiariosAdmon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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