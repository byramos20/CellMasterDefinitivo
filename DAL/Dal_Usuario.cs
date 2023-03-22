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
        public static Usuario InsertUsuarios (Usuario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Usuario.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }

        }

        public static bool UpdateUsuario (Usuario Entidad)
        {
            using(BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Usuario where tabla.Activo && tabla.IdUsuario == Entidad.IdUsuario select tabla).SingleOrDefault();
                Consulta.Nombre = Entidad.Nombre;
                Consulta.Login = Entidad.Login;
                Consulta.Password = Entidad.Password;
                Consulta.Cargo = Entidad.Cargo;
                Consulta.Email = Entidad.Email;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualiza = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
            public static bool AnularUsuario (Usuario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Usuario where tabla.Activo && tabla.IdUsuario == Entidad.IdUsuario select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualiza = DateTime.Now;
                return bd.SaveChanges() > 0;                    
            }
    }
        public static List<Usuario> ListarUsuarios (bool Activo=true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Usuario where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }

        public static Usuario ListarUsuario (bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Usuario where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
        public static Usuario ExisteCorreo(string Email)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Usuario.Where(a => a.Email.ToLower() == Email.ToLower()).SingleOrDefault();
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
                Registro.FechaActualiza = DateTime.Now;
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
                Registro.FechaActualiza = DateTime.Now;
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
            return Encripty.Encrypt(FlatString);
        }
    }


}

