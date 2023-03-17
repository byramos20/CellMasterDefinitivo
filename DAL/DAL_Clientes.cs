using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Clientes
    {
        public static Clientes InsertClientes(Clientes Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
                
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Clientes.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool UpdateClientes(Clientes Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Clientes where tabla.Activo && tabla.IdCliente == Entidad.IdCliente select tabla).SingleOrDefault();
                Consulta.NombreCompleto = Entidad.NombreCompleto;
                Consulta.Identificacion = Entidad.Identificacion;
                Consulta.Celular = Entidad.Celular;
                Consulta.Correo = Entidad.Correo;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static bool AnularClientes(Clientes Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Clientes where tabla.Activo && tabla.IdCliente == Entidad.IdCliente select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Consulta.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }

        public static List<Clientes> ListarClientes(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Clientes where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }

        public static Clientes ListarCliente(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Clientes where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}