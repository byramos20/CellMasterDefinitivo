using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Permisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Permisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Permisos.Find(Entidad.IdPermiso);
                RegistroBD.Permiso = Entidad.Permiso;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(Permisos Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Permisos.Find(Entidad.IdPermiso);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<Permisos> List(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Permisos.Where(a => a.Activo == Activo).ToList();
            }
        }
        public static Permisos Registro(int IdRegistro)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Permisos.Find(IdRegistro);
            }
        }
        public static List<Permisos> Buscar(string Palabra)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = bd.Permisos.Where(a => a.Permiso.Contains(Palabra)).ToList();
                return Consulta;
            }
        }

    }
}
