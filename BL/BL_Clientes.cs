using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using DAL;

namespace BL
{
    public static class BL_Clientes
    {
        public static Clientes InsertClientes(Clientes Entidad)
        {
            return DAL_Clientes.InsertClientes(Entidad);
        }

        public static bool UpdateClientes(Clientes Entidad)
        {
            return DAL_Clientes.UpdateClientes(Entidad);
        }

        public static bool AnularClientes(Clientes Entidad)
        {
            return DAL_Clientes.AnularClientes(Entidad);
        }

        public static List<Clientes> Listarclientes(bool Activo = true)
        {
            return DAL_Clientes.ListarClientes(Activo);
        }
        public static Clientes listarCliente(bool Activo = true)
        {
            return DAL_Clientes.ListarCliente(Activo);
        }
    }
}
