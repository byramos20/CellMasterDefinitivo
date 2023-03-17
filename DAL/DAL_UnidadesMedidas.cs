using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_UnidadesMedidas
    {
        public static UnidadesMedidas InsertUM(UnidadesMedidas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.UnidadesMedidas.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool UpdateUM(UnidadesMedidas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.UnidadesMedidas where tabla.Activo && tabla.IdUnidadMedida == Entidad.IdUnidadMedida select tabla).SingleOrDefault();
                Consulta.Descripcion = Entidad.Descripcion;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool AnularUM(UnidadesMedidas Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.UnidadesMedidas where tabla.Activo && tabla.IdUnidadMedida == Entidad.IdUnidadMedida select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<UnidadesMedidas> ListarUMS(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.UnidadesMedidas where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }
        public static UnidadesMedidas ListarUM(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.UnidadesMedidas where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}
