using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{   
   public static class BL_Usuario
    {
        public static Usuario InsertUsuarios(Usuario Entidad)
        {
            return Dal_Usuario.InsertUsuarios(Entidad);
        }
        public static bool UpdateUsuario(Usuario Entidad)
        {
            return Dal_Usuario.UpdateUsuario(Entidad);
        }
        public static bool AnularUsuario(Usuario Entidad)
        {
            return Dal_Usuario.AnularUsuario(Entidad);
        }
        public static List<Usuario> ListarUsuarios(bool Activo = true)
        {
            return Dal_Usuario.ListarUsuarios(Activo);
        }
        public static Usuario ListarUsuario(bool Activo = true)
        {
            return Dal_Usuario.ListarUsuario(Activo);
        }





    }
}
