using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexion
    {
        public static string ConexionString()
        {
            return "Data Source=BRYAN\\SQLEXPRESS;Initial Catalog=BDSeguridadInformatica;Integrated Security=True";
        }
    }
}
