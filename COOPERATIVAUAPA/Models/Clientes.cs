using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COOPERATIVAUAPA.Models
{
    public class Clientes
    {
               
            //registro de clientes

            [Key]
            public int IdCliente { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]


        public string Nombre { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]


        public string PrimerApellido { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string SegundoApellido { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string NumeroIdentificacion { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string Sexo { get; set; }
        [Column(TypeName = "date")]
        [Required]

        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Nacionalidad { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string EstadoCivil { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string Direccion { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]


        public string TelefonoResidencia { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]


        public string CelularPersonal { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string Email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string NombreConyugue { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string ParienteCercano { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string Parentesco { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string TelefonoContactoPariente { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string DireccionPariente { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]

        public string OtroTelefonoContacto { get; set; }

     

    
        }
}
