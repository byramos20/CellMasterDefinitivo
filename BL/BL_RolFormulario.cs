using System.Collections.Generic;
using EL;
using DAL;


namespace BL
{
    public class BL_RolFormulario
    {
        public static RolFormulario Insert(RolFormulario Entidad)
        {
            return DAL_RolFormulario.Insert(Entidad);
        }
        public static bool Update(RolFormulario Entidad)
        {
            return DAL_RolFormulario.Update(Entidad);
        }
        public static bool Delete(RolFormulario Entidad)
        {
            return DAL_RolFormulario.Delete(Entidad);
        }
        public static List<RolFormulario> List(int IdRol, bool Activo = true)
        {
            return DAL_RolFormulario.List(IdRol, Activo);
        }
        public static RolFormulario Registro(int IdRegistro)
        {
            return DAL_RolFormulario.Registro(IdRegistro);
        }
    }
}
