using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Enum
    {
        public enum eMessage
        {
            Exito = 1,
            Alerta = 2,
            Error = 3,
            Info = 4
        }
        public enum eRol
        {
            Administrador = 1,
            Gestor = 2,
           
        }
        public enum eParametro
        {
            IntentosFallidos = 1
        }
        public enum eFormulario
        {
            Administracionususarios = 1,
            Facturacion = 2,
            Inventario = 3,
            NuevosProductos = 4,
            Envios = 5,
    
           
        }
        public enum ePermisos
        {
            Escribir = 1,
            Anular = 2
        }
    }
}
