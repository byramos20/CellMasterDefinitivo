using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Facturas
    {
        public static Facturas InsertFacturas(Facturas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Facturas.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

            public static bool UpdateFacturas(Facturas Entidad)
            {
                using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
                {
                    var Consulta = (from tabla in bd.Facturas where tabla.Activo && tabla.IdFactura == Entidad.IdFactura select tabla).SingleOrDefault();
                    Consulta.IdCliente = Entidad.IdCliente;
                    Consulta.CodigoFactura = Entidad.CodigoFactura;
                    Consulta.FechaFactura = Entidad.FechaFactura;
                    Consulta.TotalSinIVA = Entidad.TotalSinIVA;
                    Consulta.Descuento = Entidad.Descuento;
                    Consulta.IVA = Entidad.IVA;
                    Consulta.TotalPagar = Entidad.TotalPagar;
                    Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                    Consulta.FechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
            }

        public static bool AnularFacturas(Facturas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Facturas where tabla.Activo && tabla.IdFactura == Entidad.IdFactura select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static List<Facturas> ListarFacturas(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Facturas where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }

        public static Facturas ListarFactura(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Facturas where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}
