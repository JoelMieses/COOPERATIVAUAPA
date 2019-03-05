using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COOPERATIVAUAPA.Models
{
    public interface IContacto
    {
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string Nombre { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string PrimerApellido { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string SegundoApellido { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string NumeroIdentificacion { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string Sexo { get; set; }

        [Column(TypeName = "date")]
        [Required]
        DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string Nacionalidad { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string EstadoCivil { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string Direccion { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        string TelefonoResidencia { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
         string CelularPersonal { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
         string Email { get; set; }
    }
}