using Microsoft.AspNetCore.Mvc;
using Personas1.Domain.To.ViewModels;
using Personas1.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Personas1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        private readonly IEnumsService _IEnumsService;
        public EnumsController(IEnumsService enumsService)
        {
            _IEnumsService = enumsService;
        }

        [HttpGet]
        [Route(nameof(GetEnumTipoDocumento))]
        public JsonResult GetEnumTipoDocumento()
        {
            IEnumerable<EnumViewModel> enumeraciones = _IEnumsService.GetEnumTipoDocumento();

            return new JsonResult(enumeraciones.ToList());
        }
    }
}
