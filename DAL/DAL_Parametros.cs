using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Parametros
    {
        public static Parametros InsertParametros(Parametros Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                Entidad.Fecharegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Parametros.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool UpdateParametros(Parametros Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Parametros where tabla.Activo && tabla.IdParametro == Entidad.IdParametro select tabla).SingleOrDefault();
                Consulta.Descripcion = Entidad.Descripcion;
                Consulta.Usuarioactualiza = Entidad.Usuarioactualiza;
                Consulta.Fechaactualiza = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool AnularParametros(Parametros Entidad)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Parametros where tabla.Activo && tabla.IdParametro == Entidad.IdParametro select tabla).SingleOrDefault();
                Consulta.Activo = false;
                Consulta.Usuarioactualiza = Entidad.Usuarioactualiza;
                Consulta.Fechaactualiza = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static List<Parametros> Listarparametros(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                var Consulta = (from tabla in bd.Parametros where tabla.Activo == Activo select tabla).ToList();
                return Consulta;
            }
        }
        public static Parametros ListarParametro(bool Activo = true)
        {
            using (BDSeguridadInformatica bd = new BDSeguridadInformatica())
            {
                return (from tabla in bd.Parametros where tabla.Activo == Activo select tabla).SingleOrDefault(); ;
            }
        }
    }
}
