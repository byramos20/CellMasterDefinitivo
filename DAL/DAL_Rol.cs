using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace DAL
{
    public static class DAL_Rol
    {

        //Insert
        public static Rol Insert(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Rol.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static Rol Insertar(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Rol Registro_a_Guardar = new Rol();

                Registro_a_Guardar.NombreRol = Entidad.NombreRol;
                Registro_a_Guardar.IdUsuarioRegistro = Entidad.IdUsuarioRegistro;
                Registro_a_Guardar.Activo = true;
                Registro_a_Guardar.FechaRegistro = DateTime.Now;

                bd.Rol.Add(Registro_a_Guardar);
                bd.SaveChanges();
                return Registro_a_Guardar;

            }
        }

        //Update
        public static bool Update(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Rol.Find(Entidad.IdRol);
                RegistroBD.NombreRol = Entidad.NombreRol;
                RegistroBD.UsuarioActualiza = Entidad.UsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Actualizar(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = (from tabla in bd.Rol where tabla.IdRol == Entidad.IdRol select tabla).SingleOrDefault();
                if (RegistroBD != null)
                {
                    RegistroBD.NombreRol = Entidad.NombreRol;
                    RegistroBD.UsuarioActualiza = Entidad.UsuarioActualiza;
                    RegistroBD.FechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
                return false;
            }
        }

        //Delete
        public static bool Delete(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Rol.Find(Entidad.IdRol);
                RegistroBD.Activo = false;
                RegistroBD.UsuarioActualiza = Entidad.UsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Eliminar(Rol Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = (from tabla in bd.Rol where tabla.IdRol == Entidad.IdRol select tabla).SingleOrDefault();
                if (RegistroBD != null)
                {
                    RegistroBD.Activo = false;
                    RegistroBD.UsuarioActualiza = Entidad.UsuarioActualiza;
                    RegistroBD.FechaActualizacion = DateTime.Now;
                    return bd.SaveChanges() > 0;
                }
                return false;
            }
        }

        //Select Todos los Registros
        public static List<Rol> List(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Rol.Where(a => a.Activo == Activo).ToList();
            }
        }
        public static List< Rol> Lista(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Rol where tabla.Activo == Activo select tabla).ToList();
            }
        }

        //Select Un solo registro
        public static Rol Registro(int IdRegistro)
        {
            using ( BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Rol.Find(IdRegistro);
            }
        }
        public static Rol Registro_(int IdRegistro)
        {
            using ( BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Rol where tabla.IdRol == IdRegistro select tabla).SingleOrDefault();
                return Consulta;
            }
        }

        //Select Buscar coincidencia de Palabras (Búsqueda Dinámica)
        public static List<Rol> Buscar(string Palabra)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = bd.Rol.Where(a => a.NombreRol.Contains(Palabra)).ToList();
                return Consulta;
            }
        }
        public static List<Rol> Buscar_(string Palabra)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Rol where tabla.NombreRol.Contains(Palabra) select tabla).ToList();
                return Consulta;
            }
        }

    }
}
