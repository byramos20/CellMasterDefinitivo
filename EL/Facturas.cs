using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Facturas")]
    public class Facturas
    {
        [Key]
        public int IdFactura{ get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public String CodigoFactura { get; set; }

        [Required]
        public DateTime FechaFactura { get; set; }

        [Required]
        public float TotalSinIVA { get; set; }

        [Required]
        public float Descuento { get; set; }

        [Required]
        public float IVA { get; set; }

        [Required]
        public float TotalPagar { get; set; }

        //pistas de auditoria 

        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }

    }
}
