using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Usuario")]

    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Login { get; set; }

        [Required]
        public Byte[] Password { get; set; }

        [Required]
        public String Email { get; set; }
        public string UserName { get; set; }

        [Required]
        public String Cargo { get; set; }
        public bool Bloqueado { get; set; }
        [Required]
        public byte IntentosFallidos { get; set; }
        [Required]
        public int IdRol { get; set; }
        public int IdUsuarioRegisrtro { get; set; }

        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaActualiza { get; set; }

        public int IdUsuarioActualiza { get; set; }
    }
}
