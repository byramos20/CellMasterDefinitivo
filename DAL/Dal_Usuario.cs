using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

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
                Consulta.UsuarioActualiza = Entidad.UsuarioActualiza;
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
                Consulta.UsuarioActualiza = Entidad.UsuarioActualiza;
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
            
    }
}
