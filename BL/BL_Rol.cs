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
        public static Rol Insert(Rol Entidad)
        {
            return DAL_Rol.Insert(Entidad);
        }

        public static Rol Insertar(Rol Entidad)
        {
            return DAL_Rol.Insertar(Entidad);
        }
        public static bool Update(Rol Entidad)
        {
            return DAL_Rol.Update(Entidad);
        }
        public static bool Actualizar(Rol Entidad)
        {
            return DAL_Rol.Actualizar(Entidad);
        }
        public static bool Delete(Rol Entidad)
        {
            return DAL_Rol.Delete(Entidad);
        }
        public static bool Eliminar(Rol Entidad)
        {
            return DAL_Rol.Eliminar(Entidad);
        }
        public static List<Rol> List(bool Activo = true)
        {
            return DAL_Rol.List(Activo);
        }
        public static List<Rol> Lista(bool Activo = true)
        {
            return DAL_Rol.Lista(Activo);
        }
        public static Rol Registro(int IdRegistro)
        {
            return DAL_Rol.Registro(IdRegistro);
        }
        public static Rol Registro_(int IdRegistro)
        {
            return DAL_Rol.Registro_(IdRegistro);
        }
        public static List<Rol> Buscar(string Palabra)
        {
            return DAL_Rol.Buscar(Palabra);
        }
        public static List<Rol> Buscar_(string Palabra)
        {
            return DAL_Rol.Buscar_(Palabra);
        }
    }
}
