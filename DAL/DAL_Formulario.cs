using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Formulario
    {
        public static Formulario Insert(Formulario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Formulario.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Formulario Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Formulario.Find(Entidad.IdFormulario);
                RegistroBD.NombreFormulario = Entidad.NombreFormulario;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualiza = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(Formulario Entidad)
        {
            using ( BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var RegistroBD = bd.Formulario.Find(Entidad.IdFormulario);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualiza = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<Formulario> List(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Formulario.Where(a => a.Activo == Activo).ToList();
            }
        }
        public static Formulario Registro(int IdRegistro)
        {
            using ( BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return bd.Formulario.Find(IdRegistro);
            }
        }
        public static List<Formulario> Buscar(string Palabra)
        {
            using ( BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = bd.Formulario.Where(a => a.NombreFormulario.Contains(Palabra)).ToList();
                return Consulta;
            }
        }

    }
}
