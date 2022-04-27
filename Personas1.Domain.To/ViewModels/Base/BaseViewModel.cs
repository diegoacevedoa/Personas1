using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Personas1.Domain.To.ViewModels.Base
{
    public class BaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        [Display(Name = "Eliminado")]
        public bool Eliminado { get; set; }

        [Display(Name = "Usuario Registra")]
        public int? UsuarioRegistra { get; set; }

        [Display(Name = "Usuario Elimina")]
        public int? UsuarioElimina { get; set; }

        [Display(Name = "Usuario Modifica")]
        public int? UsuarioUltimaModificacion { get; set; }

        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Fecha Eliminado")]
        public DateTime? FechaEliminado { get; set; }

        [Display(Name = "Fecha Última Modificación")]
        public DateTime? FechaUltimaModificacion { get; set; }
    }
}
