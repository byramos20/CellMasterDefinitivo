using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BL
{
    public static class BL_Productos
    {
        public static Productos InsertProductos(Productos Entidad)
        {
            return DAL_Productos.InsertProductos(Entidad);
        }
        public static bool UpdateProductoss(Productos Entidad)
        {
            return DAL_Productos.UpdateProductos(Entidad);
        }
        public static bool AnularProductos(Productos Entidad)
        {
            return DAL_Productos.AnularProductos(Entidad);
        }
        public static List<Productos> ListarProductos(bool Activo = true)
        {
            return DAL_Productos.ListarProductos(Activo);
        }
        public static Productos ListarProducto(bool Activo = true)
        {
            return DAL_Productos.ListarProducto(Activo);
        }
    }
}
