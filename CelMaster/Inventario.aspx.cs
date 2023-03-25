using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CelMaster
{
    public partial class Inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void peincipal2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Principal.aspx");
        }
    }
}