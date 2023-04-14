using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;

namespace EL
{
    [Table("Usuario")]

    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [MaxLength(200)]
        public string NombreCompleto { get; set; }
        [Required]
        [MaxLength(200)]
        public string Correo { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        public byte[] Password { get; set; }
        [Required]
        public bool Bloqueado { get; set; }
        [Required]
        public short IntentosFallidos { get; set; }
        [Required]
        public int IdRol { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
    public class vUsuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }

        public string Correo { get; set; }

        public string UserName { get; set; }
        public bool Bloqueado { get; set; }
        public String CuentaBloqueada { get; set; }
        public short IntentosFallidos { get; set; }
        public int IdRol { get; set; }
        public String NombreRol { get; set; }


    }
}
