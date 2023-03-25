using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using BL;

namespace Texe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rol rol = new Rol();

            rol.NombreRol = "Cellmaster";
            rol.Descripcion = "Administrador";
            rol.IdUsuarioRegistro = 1;

            Console.WriteLine(BL_Rol.InsertRol(rol).IdRol);
        }
    }
}
