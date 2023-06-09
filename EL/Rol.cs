﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        [Required]
        public String NombreRol { get; set; }
        [Required]
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool Activo { get; set; }
    }
}
