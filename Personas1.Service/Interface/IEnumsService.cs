using Personas1.Domain.To.ViewModels;
using System.Collections.Generic;

namespace Personas1.Service.Interface
{
    public interface IEnumsService
    {
        public IEnumerable<EnumViewModel> GetEnumTipoDocumento();
    }
}
