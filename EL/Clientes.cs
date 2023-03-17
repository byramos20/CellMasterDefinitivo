using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace EL
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [MaxLength (200)]
        public String NombreCompleto { get; set; }

        [Required]
        [MaxLength(200)]
        public String Identificacion { get; set; }

        [Required]
        [MaxLength(8)]
        public String Celular { get; set; }

        [Required]
        [MaxLength(200)]
        public String Correo { get; set; }

        //pistas de auditoria
        [Required]
        public int IdUsuarioRegistro { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }

        public int IdUsuarioActualiza { get; set; }

        public DateTime FechaActualizacion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}
