using System;
using System.ComponentModel.DataAnnotations;

namespace Personas1.Data.Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Activo = true;
            FechaRegistro = DateTime.Now;
            Eliminado = false;
        }

        public int Id { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public bool Eliminado { get; set; }           
       
        public int? UsuarioRegistra { get; set; }
       
        public int? UsuarioElimina { get; set; }
       
        public int? UsuarioUltimaModificacion { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
    }
}
