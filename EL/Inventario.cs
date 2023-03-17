using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


namespace EL
{
    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int Lote { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public DateTime FechaCaducidad { get; set; }

        //PISTAS DE AUDITORIA 

        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }
    }
}
