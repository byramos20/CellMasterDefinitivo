using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        public int IdUnidadMedida { get; set; }

        [Required]
        public int CodigoBarra { get; set; }

        [Required]
        public String Descripcion { get; set; }

        [Required]
        public double PrecioUnitario { get; set; }

        [Required]
        public double PorcentajeUtilidad { get; set; }

        [Required]
        public float PorcentajeDescuento { get; set; }

        //pistas de auditoria 
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }
    }
}
