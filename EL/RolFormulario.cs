using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("RolFormulario")]
    public partial class RolFormulario
    {
        [Key]
        public int IdRolFormulario { get; set; }
        public int IdRol { get; set; }
        public int IdFormulario { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<int> IdUsuarioActualiza { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
    }
}
