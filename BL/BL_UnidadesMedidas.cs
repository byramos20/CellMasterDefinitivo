using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BL
{
    public static class BL_UnidadesMedidas
    {
        public static UnidadesMedidas InsertUM(UnidadesMedidas Entidad)
        {
            return DAL_UnidadesMedidas.InsertUM(Entidad);
        }
        public static bool UpdateUM(UnidadesMedidas Entidad)
        {
            return DAL_UnidadesMedidas.UpdateUM(Entidad);
        }
        public static bool AnularUM(UnidadesMedidas Entidad)
        {
            return DAL_UnidadesMedidas.AnularUM(Entidad);
        }
        public static List<UnidadesMedidas> ListarUMS(bool Activo = true)
        {
            return DAL_UnidadesMedidas.ListarUMS(Activo);
        }
        public static UnidadesMedidas ListarUM(bool Activo = true)
        {
            return DAL_UnidadesMedidas.ListarUM(Activo);
        }
    }
}
