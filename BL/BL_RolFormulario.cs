using System.Collections.Generic;
using EL;
using DAL;


namespace BL
{
    public class BL_RolFormulario
    {
        public static List<RolFormulario> Formularios_x_Rol(int IdRol)
        {
            return DAL_RolFormulario.Formularios_x_Rol(IdRol);
        }
    }
}
