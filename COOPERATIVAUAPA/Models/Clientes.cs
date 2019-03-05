using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COOPERATIVAUAPA.Models
{
    public class Clientes : IContacto
    {
        //registro de clientes

        [Key]
        public int IdCliente { get; set; }

        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string TelefonoResidencia { get; set; }
        public string CelularPersonal { get; set; }
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

        public virtual Garante Garante { get; set; }

        public virtual List<SolicitudPrestamos> Solicitudes { get; set; } = new List<SolicitudPrestamos>();

    }
}