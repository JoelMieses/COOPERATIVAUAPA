using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COOPERATIVAUAPA.Models
{
    public class Prestamos
    {

        //calcula el tiempo del prestamo, las cuotas e interes del prestamo del cliente
        [Key]
        public int IdPrestamos { get; set; }
        [Column(TypeName = "int")]
        [Required]
        public int IdCliente { get; set; }

        [Column(TypeName = "float")]
        [Required]
        public long Capital { get; set; }
        [Column(TypeName = "float")]
        [Required]
        public decimal TasaInteres { get; set; }
        [Column(TypeName = "float")]
        [Required]
        public decimal Periodo { get; set; }

        public virtual Clientes Clientes { get; set; }
   
    }
}
