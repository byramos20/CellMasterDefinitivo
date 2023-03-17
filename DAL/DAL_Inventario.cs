using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Inventario
    {
        public static Inventario InsertInventario(Inventario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Inventario.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool UpdateInventario(Inventario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Inventario where tabla.Activo && tabla.IdInventario == Entidad.IdInventario select tabla).SingleOrDefault();
                Consulta.IdProducto = Entidad.IdProducto;
                Consulta.Lote = Entidad.Lote;
                Consulta.Cantidad = Entidad.Cantidad;
                Consulta.FechaCaducidad = Entidad.FechaCaducidad;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static bool AnularInventario(Inventario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Inventario where tabla.Activo && tabla.IdInventario == Entidad.IdInventario select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static List<Inventario> ListarInventarios(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Inventario where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }

        public static Inventario ListarInventario(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Inventario where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}