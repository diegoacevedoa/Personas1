using Personas1.Domain.To.Helpers;
using Personas1.Domain.To.ViewModels.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Personas1.Domain.To.ViewModels
{
    public class Persona1ViewModel : BaseViewModel
    {
        [Display(Name = "Nombres")]
        [StringLength(200)]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [StringLength(200)]
        public string Apellidos { get; set; }

        [Display(Name = "TipoDocumento")]
        [DefaultValue((int)EnumTipoDocumento.CC)]
        public int TipoDocumento { get; set; }

        [Display(Name = "Tipo Documento")]

        public string NombreTipoDocumento
        {
            get
            {
                return ((EnumTipoDocumento)TipoDocumento).ToString();
            }
            set { }
        }

        [Display(Name = "NoDocumento")]
        [StringLength(50)]
        public string NoDocumento { get; set; }

        [Display(Name = "FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "NoContacto")]
        [StringLength(50)]
        public string NoContacto { get; set; }

        [Display(Name = "Email")]
        [StringLength(300)]
        public string Email { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(300)]
        public string Direccion { get; set; }
    }
}
