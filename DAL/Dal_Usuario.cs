using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using Utilidades;

namespace DAL
{
    public static class Dal_Usuario
    {
        private static byte[] Key = Encoding.UTF8.GetBytes("S3Gur1d4d1nf0rm4t1c42o23");//24 Caracteres
        private static byte[] IV = Encoding.UTF8.GetBytes("Pr0y3ct03J3mpl00");//16 Caracteres
        public static Usuario Insert(Usuario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Usuario.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Usuario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Usuario.Find(Entidad.IdUsuario);
                RegistroBD.NombreCompleto = Entidad.NombreCompleto;
                RegistroBD.Correo = Entidad.Correo;
                RegistroBD.UserName = Entidad.UserName;
                if (Entidad.Password != null)
                {
                    RegistroBD.Password = Entidad.Password;
                }
                RegistroBD.IdRol = Entidad.IdRol;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool PasswordUpdate(Usuario Entidad)
        {
            using (BDSeguridadInformatica  bd = new BDSeguridadInformatica())
            {
                var Consulta = bd.Usuario.Find(Entidad.IdUsuario);
                Consulta.Password = Entidad.Password;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(Usuario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Usuario.Find(Entidad.IdUsuario);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<Usuario> List(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.Activo == Activo).ToList();
            }
        }
        public static Usuario Registro(int IdRegistro)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Find(IdRegistro);
            }
        }
        public static List<Usuario> Buscar(string Palabra)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.
                      Where(a => a.NombreCompleto.Contains(Palabra)
                              || a.Correo.Contains(Palabra)
                              || a.UserName.Contains(Palabra)
                      ).ToList();
            }
        }
        public static Usuario ExisteCorreo(string Email)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.Correo.ToLower() == Email.ToLower()).SingleOrDefault();
            }
        }
        public static bool SumarIntentosFallido(int IdRegistro)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Registro = bd.Usuario.Find(IdRegistro);
                Registro.IntentosFallidos = Convert.ToByte(Registro.IntentosFallidos + 1);
                return bd.SaveChanges() > 0;
            }
        }
        public static bool RestablecerIntentosFallido(int IdRegistro, int IdUsuarioActualiza)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Registro = bd.Usuario.Find(IdRegistro);
                Registro.IntentosFallidos = 0;
                Registro.IdUsuarioActualiza = IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool BloquearCuentaUsuario(int IdRegistro, bool Bloquear, int IdUsuarioActualiza)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Registro = bd.Usuario.Find(IdRegistro);
                Registro.Bloqueado = Bloquear;
                if (!Bloquear) { Registro.IntentosFallidos = 0; }
                Registro.IdUsuarioActualiza = IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool ExisteUserName(string UserName)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.UserName.ToLower() == UserName.ToLower()).Count() > 0;
            }
        }
        public static Usuario ExisteUsuario_x_UserName(string UserName)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.UserName.ToLower() == UserName.ToLower()).SingleOrDefault();
            }
        }
        public static bool ValidarCredenciales(string UserName, byte[] Password)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.UserName.ToLower() == UserName.ToLower() && a.Password == Password).Count() > 0;
            }
        }
        public static byte[] Encrypt(string FlatString)
        {
            return Encripty.Encrypt(FlatString, Key, IV);
        }
    }


}

