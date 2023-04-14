using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_RolPermisos
    {
        public static RolPermisos Insert(RolPermisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.RolPermisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolPermisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                RegistroBD.IdRol = Entidad.IdRol;
                RegistroBD.IdPermiso= Entidad.IdPermiso;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(RolPermisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<RolPermisos> List(int IdRol, bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.RolPermisos.Where(a =>a.IdRol==IdRol && a.Activo == Activo).ToList();
            }
        }
        public static RolPermisos Registro(int IdRegistro)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.RolPermisos.Find(IdRegistro);
            }
        }
    }
}
