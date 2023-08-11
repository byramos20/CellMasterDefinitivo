using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using BL;
using System.Globalization;
using Utilidades;

namespace Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rol Roles  = new Rol();



            Roles.NombreRol = "Administrador Facturas";
            Roles.IdUsuarioRegistro = 15;

            Console.WriteLine(BL_Rol.Insert(Roles).IdRol);
            Console.ReadLine();






            //byte[] Key = Encoding.UTF8.GetBytes("S3Gur1d4d1nf0rm4t1c42o23");//24 Caracteres
            //byte[] IV = Encoding.UTF8.GetBytes("Pr0y3ct03J3mpl00");//16 Caracteres

            //Rol user = new Rol();
            //user.IdRol = 1;
            //user.IdUsuarioActualiza = 1;
            //user.NombreRol = "Administradores";
            //BL_Rol.Actualizar(user);    
            ////user.Password = Encripty.Encrypt("0702", Key, IV);
            ////BL_Usuario.PasswordUpdate(user);





        }

    }
}