using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_RolFormulario
    {



        public static List<RolFormulario> Formularios_x_Rol(int IdRol)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.RolFormularios where tabla.Activo == true && tabla.IdRol == IdRol select tabla).ToList();
                return Consulta;
            }
        }
    }
}
