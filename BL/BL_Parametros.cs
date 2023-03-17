using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;


namespace BL
{
    public static class BL_Parametros
    {
        public static Parametros InsertParametros(Parametros Entidad)
        {
            return DAL_Parametros.InsertParametros(Entidad);
        }
        public static bool UpdateParametros(Parametros Entidad)
        {
            return DAL_Parametros.UpdateParametros(Entidad);
        }
        public static bool AnularParametros(Parametros Entidad)
        {
            return DAL_Parametros.AnularParametros(Entidad);
        }
        public static List<Parametros> Listarparametros(bool Activo = true)
        {
            return DAL_Parametros.Listarparametros(Activo);
        }
        public static Parametros ListarParametro(bool Activo = true)
        {
            return DAL_Parametros.ListarParametro(Activo);
        }
    }
}
