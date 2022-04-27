using Personas1.Data.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Personas1.Data.Models
{
    public class Persona1 : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellidos { get; set; }

        [Required]
        public int TipoDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoDocumento { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoContacto { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string Direccion { get; set; }
    }
}
