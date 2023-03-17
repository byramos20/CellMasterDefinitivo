    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Productos
    {
        public static Productos InsertProductos(Productos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Productos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool UpdateProductos(Productos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Productos where tabla.Activo && tabla.IdProducto == Entidad.IdProducto select tabla).SingleOrDefault();
                Consulta.IdUnidadMedida = Entidad.IdUnidadMedida;
                Consulta.CodigoBarra = Entidad.CodigoBarra;
                Consulta.Descripcion = Entidad.Descripcion;
                Consulta.PrecioUnitario = Entidad.PrecioUnitario;
                Consulta.PorcentajeUtilidad = Entidad.PorcentajeUtilidad;
                Consulta.PorcentajeDescuento = Entidad.PorcentajeDescuento;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool AnularProductos(Productos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Productos where tabla.Activo && tabla.IdProducto == Entidad.IdProducto select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<Productos> ListarProductos(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Productos where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
                }
        }
        public static Productos ListarProducto(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Productos where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}
