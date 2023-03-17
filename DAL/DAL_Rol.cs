using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Rol
    {

        public static Rol InsertRol(Rol Entidad)
            {
                using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
                {
                    Entidad.FechaRegistro = DateTime.Now;
                    Entidad.Activo = true;
                    bd.Rol.Add(Entidad);
                    bd.SaveChanges();
                    return Entidad;
                }
            }
                
        public static bool UpdateRol(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Rol where tabla.Activo  && tabla.IdRol == Entidad.IdRol select tabla).SingleOrDefault();
                Consulta.Descripcion = Entidad.Descripcion;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;        
                return bd.SaveChanges()>0;
            }
        }

        public static bool AnularRol(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Rol where tabla.Activo && tabla.IdRol == Entidad.IdRol select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static List<Rol> ListarRoles(bool Activo=true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Rol where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }
        public static Rol ListarRol(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Rol where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }

    }
}
