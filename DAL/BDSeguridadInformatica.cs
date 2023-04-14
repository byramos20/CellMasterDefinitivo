using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EL;

namespace DAL
{
    public class BDSeguridadInformatica : DbContext
    {
        public BDSeguridadInformatica():base(Conexion.ConexionString())
        {
        }

        public virtual DbSet<Rol> Rol { get; set; }


        public virtual DbSet<Usuario> Usuario { get; set; }

        public virtual DbSet<Parametros> Parametros { get; set; }

        public virtual DbSet<Productos> Productos { get; set; }

        public virtual DbSet<UnidadesMedidas> UnidadesMedidas { get; set; }

        public virtual DbSet<Inventario> Inventario { get; set; }

        public virtual DbSet<Clientes> Clientes { get; set; }

        public virtual DbSet<Facturas> Facturas { get; set; }

        public virtual DbSet<DetallesFacturas> DetallesFacturas { get; set; }
        public virtual DbSet<RolFormulario> RolFormularios { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<RolPermisos> RolPermisos { get; set; }


    }
}
