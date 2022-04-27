using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Personas1.Data.Models;
using Personas1.Domain.To.ViewModels;
using Personas1.Service.Interface;
using System;
using System.Collections.Generic;

namespace Personas1.WebApi.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]")]
    public class Persona1Controller : ControllerBase
    {
        private readonly IPersona1Service _IPersona1Service;
        private readonly IMapper _IMapper;

        public Persona1Controller(IPersona1Service persona1Service, IMapper mapper)
        {
            _IPersona1Service = persona1Service;
            _IMapper = mapper;
        }

        [HttpGet]
        [Route(nameof(GetAllPersonas))]
        public JsonResult GetAllPersonas()
        {
            try
            {
                List<Persona1> list = _IPersona1Service.GetAll();
                var mapped = _IMapper.Map<List<Persona1>, List<Persona1ViewModel>>(list);

                return new JsonResult(mapped);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route(nameof(SavePersona))]
        public JsonResult SavePersona([FromBody] Persona1 model)
        {
            try
            {
                if (model == null)
                {
                    throw new ArgumentException("Se ha encontrado un error al tratar de guardar la persona ya que no se ha envidado el model.");
                }

                int id = _IPersona1Service.Save(model);

                return new JsonResult(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route(nameof(DeletePersona))]
        public JsonResult DeletePersona([FromBody] int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Se ha encontrado un error al tratar de eliminar la persona ya que no se ha envidado el id del registro.");
                }

                bool eliminado = _IPersona1Service.Delete(id);

                return new JsonResult(eliminado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]        
        [Route(nameof(SearchAllPersonas))]
        public JsonResult SearchAllPersonas([FromBody] Persona1ViewModel search)
        {
            try
            {               
                List<Persona1> list = _IPersona1Service.SearchAll(search);
                var mapped = _IMapper.Map<List<Persona1>, List<Persona1ViewModel>>(list);

                return new JsonResult(mapped);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
