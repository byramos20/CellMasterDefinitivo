using System.Collections.Generic;
using EL;
using DAL;

namespace BL
{
    public static class BL_Formulario
    {
        public static Formulario Insert(Formulario Entidad)
        {
            return DAL_Formulario.Insert(Entidad);
        }

        public static bool Update(Formulario Entidad)
        {
            return DAL_Formulario.Update(Entidad);
        }
        public static bool Delete(Formulario Entidad)
        {
            return DAL_Formulario.Delete(Entidad);
        }
        public static List<Formulario> List(bool Activo = true)
        {
            return DAL_Formulario.List(Activo);
        }
        public static Formulario Registro(int IdRegistro)
        {
            return DAL_Formulario.Registro(IdRegistro);
        }
        public static List<Formulario> Buscar(string Palabra)
        {
            return DAL_Formulario.Buscar(Palabra);
        }


    }
}
