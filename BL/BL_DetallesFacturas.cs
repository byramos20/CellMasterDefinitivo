using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BL
{
    public static class BL_DetallesFacturas
    {
        public static DetallesFacturas InsertdetallesF (DetallesFacturas Entidad)
        {
            return DAL_DetallesFacturas.InsertDetallesF(Entidad);
        }
        public static bool UpdateDetallesF (DetallesFacturas Entidad)
        {
            return DAL_DetallesFacturas.UpdatedetallesF(Entidad);  
        }
        public static bool AnularDetallesF (DetallesFacturas Entidad)
        {
            return DAL_DetallesFacturas.AnularDetallesF(Entidad);
        }
        public static List<DetallesFacturas> ListarDetallesFa (bool Activo = true)
        {
            return DAL_DetallesFacturas.ListarDetallesFa(Activo);
        }
        public static DetallesFacturas listarDetallesF (bool Activo = true)
        {
            return DAL_DetallesFacturas.ListarDetallesF(Activo);
        }
            
    }
}
