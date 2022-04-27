using AutoMapper;
using Personas1.Data.Models;
using Personas1.Domain.To.ViewModels;

namespace Personas1.Data.Mapping
{
    public class Mapeos : Profile
    {
        public Mapeos()
        {
            #region Persona1  

            CreateMap<Persona1, Persona1ViewModel>()
                 .ForMember(m => m.Nombres, map => map.MapFrom(vm => vm.Nombres))
                 .ForMember(m => m.Apellidos, map => map.MapFrom(vm => vm.Apellidos))
                 .ForMember(m => m.TipoDocumento, map => map.MapFrom(vm => vm.TipoDocumento))
                 .ForMember(m => m.NoDocumento, map => map.MapFrom(vm => vm.NoDocumento))
                 .ForMember(m => m.FechaNacimiento, map => map.MapFrom(vm => vm.FechaNacimiento))
                 .ForMember(m => m.NoContacto, map => map.MapFrom(vm => vm.NoContacto))
                 .ForMember(m => m.Email, map => map.MapFrom(vm => vm.Email))
                 .ForMember(m => m.Direccion, map => map.MapFrom(vm => vm.Direccion))
                 .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
                 .ForMember(m => m.Activo, map => map.MapFrom(vm => vm.Activo))
                 .ForMember(m => m.Eliminado, map => map.MapFrom(vm => vm.Eliminado))
                 .ForMember(m => m.UsuarioRegistra, map => map.MapFrom(vm => vm.UsuarioRegistra))
                 .ForMember(m => m.UsuarioElimina, map => map.MapFrom(vm => vm.UsuarioElimina))
                 .ForMember(m => m.UsuarioUltimaModificacion, map => map.MapFrom(vm => vm.UsuarioUltimaModificacion))
                 .ForMember(m => m.FechaRegistro, map => map.MapFrom(vm => vm.FechaRegistro))
                 .ForMember(m => m.FechaEliminado, map => map.MapFrom(vm => vm.FechaEliminado))
                 .ForMember(m => m.FechaUltimaModificacion, map => map.MapFrom(vm => vm.FechaUltimaModificacion))
                 .ReverseMap();

            #endregion
        }
    }
}
