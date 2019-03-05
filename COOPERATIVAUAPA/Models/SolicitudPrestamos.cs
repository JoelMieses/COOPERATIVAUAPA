using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace COOPERATIVAUAPA.Models
{
    public class SolicitudPrestamos
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        #region InforCliente

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string PrimerApellido { get; set; }
        [Required]
        public string SegundoApellido { get; set; }
        [Required]
        public string NumeroIdentificacion { get; set; }
        public string Sexo { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string TelefonoResidencia { get; set; }
        public string CelularPersonal { get; set; }
        public string Email { get; set; }


        public string NombreConyugue { get; set; }


        public string ParienteCercano { get; set; }


        public string Parentesco { get; set; }


        public string TelefonoContactoPariente { get; set; }


        public string DireccionPariente { get; set; }


        public string OtroTelefonoContacto { get; set; }

        #endregion

        #region InfoGarante

        public string GaranteNombre { get; set; }
        public string GarantePrimerApellido { get; set; }
        public string GaranteSegundoApellido { get; set; }
        public string GaranteNumeroIdentificacion { get; set; }
        public string GaranteSexo { get; set; }
        public DateTime GaranteFechaNacimiento { get; set; }
        public string GaranteNacionalidad { get; set; }
        public string GaranteEstadoCivil { get; set; }
        public string GaranteDireccion { get; set; }
        public string GaranteTelefonoResidencia { get; set; }
        public string GaranteCelularPersonal { get; set; }
        public string GaranteEmail { get; set; }

        #endregion
 
        public float Monto { get; set; }

        public int DuracionMeses { get; set; }

        public float Tasa { get; set; }


        public int EstatusId { get; set; }

        [ForeignKey("EstatusId")]
        public EstatusSolicitud Estatus { get; set; }

        public int TipoPrestamoId { get; set; }

        [ForeignKey("TipoPrestamoId")]
        public TipoPrestamo TipoPrestamo { get; set; }

    }
}