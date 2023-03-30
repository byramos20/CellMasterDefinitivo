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
            Usuario usuario = new Usuario();

            usuario.NombreCompleto = "Bryan Ramos";
            usuario.UserName = "Bramos10";
            usuario.Password = "123456789BR";
            usuario.Correo = "ramos102013gmail.com";

            usuario.IdUsuarioRegistra = 1;

            Console.WriteLine(BL_Usuario.Insert(usuario).IdUsuario);
        }
    }
}
