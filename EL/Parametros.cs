using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table ("Parametros")]
    public class Parametros
    {
        [Key]
        public int IdParametro { get; set; }

        [Required]
        public String Descripcion { get; set; }

        [Required]
        public String Parametro { get; set; }

        [Required]
        public int TipoDato { get; set; }

        public bool Activo { get; set; }

        public DateTime Fecharegistro { get; set; }

        public int Usuarioregistro { get; set; }

        public DateTime Fechaactualiza { get; set; }

        public int Usuarioactualiza { get; set; }
    }
}
