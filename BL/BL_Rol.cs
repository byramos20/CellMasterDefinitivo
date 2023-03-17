using System;
using System.Collections.Generic;
        using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public static class BL_Rol
    {
        public static Rol InsertRol(Rol Entidad)
        {
            return DAL_Rol.InsertRol(Entidad);
        }
        public static bool UpdateRol(Rol Entidad)
        {
            return DAL_Rol.UpdateRol(Entidad);
        }
        public static bool AnularRol(Rol Entidad)
        {
            return DAL_Rol.AnularRol(Entidad);
        }
        public static List<Rol> ListarRoles(bool Activo = true)
        {
            return DAL_Rol.ListarRoles(Activo);
        }
        public static Rol ListarRol(bool Activo = true)
        {
            return DAL_Rol.ListarRol(Activo);
        }
    }
}
