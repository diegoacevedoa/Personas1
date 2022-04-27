using Personas1.Domain.To.Helpers;
using Personas1.Domain.To.ViewModels;
using Personas1.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personas1.Service.Implementacion
{
    public class EnumsService : IEnumsService
    {
        public IEnumerable<EnumViewModel> GetEnumTipoDocumento()
        {
            var enumeraciones = (from EnumTipoDocumento e in Enum.GetValues(typeof(EnumTipoDocumento))
                                 select new EnumViewModel { Id = (int)e, Nombre = e.Description() });            

            return enumeraciones;
        }
    }
}
