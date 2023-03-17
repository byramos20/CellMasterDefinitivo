using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;  

namespace BL
{
    public static class BL_Inventario
    {
        public static Inventario InsertInventario(Inventario Entidad)
        {
            return DAL_Inventario.InsertInventario(Entidad);
        }
        public static bool UpdateInventario(Inventario Entidad)
        {
            return DAL_Inventario.UpdateInventario(Entidad);
        }
        public static bool AnularInventario(Inventario Entidad)
        {
            return DAL_Inventario.AnularInventario(Entidad);
        }
        public static List<Inventario> ListarInventarios(bool Activo = true)
        {
            return DAL_Inventario.ListarInventarios(Activo);
        }
        public static Inventario ListarInventario(bool Activo = true)
        {
            return DAL_Inventario.ListarInventario(Activo);
        }





    }
}
