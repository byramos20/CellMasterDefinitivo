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
        public DateTime Fecharegistro { get; set; }
        public int? Usuarioactualiza { get; set; }
        public DateTime? Fechaactualiza { get; set; }
    }
}
