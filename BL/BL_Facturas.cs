using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BL
{
    public static class BL_Facturas
    {
        public static Facturas InsertFacturas (Facturas Entidad)
        {
            return DAL_Facturas.InsertFacturas(Entidad);
        }

        public static bool UpdateFacturas (Facturas Entidad)
        {
            return DAL_Facturas.UpdateFacturas(Entidad);
        }

        public static bool AnularFacturas (Facturas Entidad)
        {
            return DAL_Facturas.AnularFacturas(Entidad);
        }
        public static List<Facturas> ListarFacturas (bool Activo  = true)
        {
            return DAL_Facturas.ListarFacturas(Activo);
        }
        public static Facturas ListarFactura (bool Activo = true)
        {
            return DAL_Facturas.ListarFactura(Activo);
        }
    }
}
