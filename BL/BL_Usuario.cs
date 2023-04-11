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
        public static Usuario Insert(Usuario Entidad)
        {
            return Dal_Usuario.Insert(Entidad);
        }
        public static bool Update(Usuario Entidad)
        {
            return Dal_Usuario.Update(Entidad);
        }
        public static bool PasswordUpdate(Usuario Entidad)
        {
            return Dal_Usuario.PasswordUpdate(Entidad);
        }

        public static bool Delete(Usuario Entidad)
        {
            return Dal_Usuario.Delete(Entidad);
        }
        public static List<Usuario> List(bool Activo = true)
        {
            return Dal_Usuario.List(Activo);
        }
        public static Usuario Registro(int IdRegistro)
        {
            return Dal_Usuario.Registro(IdRegistro);
        }
        public static List<Usuario> Buscar(string Palabra)
        {
            return Dal_Usuario.Buscar(Palabra);
        }
        public static Usuario ExisteCorreo(string Email)
        {
            return Dal_Usuario.ExisteCorreo(Email);
        }
        public static bool SumarIntentosFallido(int IdRegistro)
        {
            return Dal_Usuario.SumarIntentosFallido(IdRegistro);

        }
        public static bool RestablecerIntentosFallido(int IdRegistro, int IdUsuarioActualiza)
        {
            return Dal_Usuario.RestablecerIntentosFallido(IdRegistro, IdUsuarioActualiza);
        }
        public static bool BloquearCuentaUsuario(int IdRegistro, bool Bloquear, int IdUsuarioActualiza)
        {
            return Dal_Usuario.BloquearCuentaUsuario(IdRegistro, Bloquear, IdUsuarioActualiza); 
        }
        public static bool ExisteUserName(string UserName)
        {
            return Dal_Usuario.ExisteUserName(UserName);
        }
        public static Usuario ExisteUsuario_x_UserName(string UserName)
        {
            return Dal_Usuario.ExisteUsuario_x_UserName(UserName);
        }
        public static bool ValidarCredenciales(string UserName, byte[] Password)
        {
            return Dal_Usuario.ValidarCredenciales(UserName, Password);
        }
        public static byte[] Encrypt(string FlatString)
        {
            return Dal_Usuario.Encrypt(FlatString);
        }
        public static bool VerificarCuentaBloqueada(string UserName)
        {
            return Dal_Usuario.VerificarCuentaBloqueada(UserName);
        }
        public static short CatidadIntentosFallidos(string UserName)
        {
            return Dal_Usuario.CatidadIntentosFallidos(UserName);
        }







    }
}
