using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Formulario")]
    public class Formulario
    {
        [Key]
        public int IdFormulario { get; set; }
        [MaxLength(100), Required]
        public string NombreFormulario { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int Usuarioregistro { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
    }
}
