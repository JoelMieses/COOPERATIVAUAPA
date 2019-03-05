using System;
using System.Collections.Generic;

namespace COOPERATIVAUAPA.Models
{
    public class Garante: IContacto
    {
        public int GaranteId { get; set; }
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

        public virtual List<Clientes> Clientes { get; set; } = new List<Clientes>();
    }
}