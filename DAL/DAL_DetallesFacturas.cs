using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_DetallesFacturas
    {
        public static DetallesFacturas InsertDetallesF(DetallesFacturas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.DetallesFacturas.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool UpdatedetallesF(DetallesFacturas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.DetallesFacturas where tabla.Activo && tabla.IdDetalleFactura == Entidad.IdDetalleFactura select tabla).SingleOrDefault();
                Consulta.IdProducto = Entidad.IdProducto;
                Consulta.IdFactura = Entidad.IdFactura;
                Consulta.PrecioUnitario = Entidad.PrecioUnitario;
                Consulta.Cantidad = Entidad.Cantidad;
                Consulta.TotalSinIVA = Entidad.TotalSinIVA;
                Consulta.IVA = Entidad.IVA;
                Consulta.Descuento = Entidad.Descuento;
                Consulta.TotalPagar = Entidad.TotalPagar;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static bool AnularDetallesF(DetallesFacturas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.DetallesFacturas where tabla.Activo && tabla.IdDetalleFactura == Entidad.IdDetalleFactura select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static List<DetallesFacturas> ListarDetallesFa(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.DetallesFacturas where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }

        public static DetallesFacturas ListarDetallesF(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.DetallesFacturas where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}
