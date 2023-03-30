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
            TecnicoSede = 3,
            TecnicoCID = 4,
            TecnicoCIM = 5,
            Lectura = 6
        }
        public enum eParametro
        {
            IntentosFallidos = 1
        }
        public enum eFormularios
        {
            SiteMaster = 1,
            Principal = 2,
            CambiarPassword = 3,
            Formularios = 4,
            Catalogos = 5,
            Usuarios = 6,
            Formulario_1 = 7,
            Formulario_2 = 8,
            Formulario_3 = 9,
            Catalogo_1 = 10,
            Catalogo_2 = 11,
            Catalogo_3 = 12
        }
        public enum ePermisos
        {
            Escribir = 1,
            Anular = 2
        }
    }
}
