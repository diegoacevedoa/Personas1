using Microsoft.EntityFrameworkCore;
using Personas1.Data.Context;
using Personas1.Data.Models;
using Personas1.Domain.To.ViewModels;
using Personas1.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Personas1.Service.Implementacion
{
    public class Persona1Service : IPersona1Service
    {
        private readonly Personas1Context _context;

        public Persona1Service(Personas1Context context)
        {
            _context = context;
        }

        public List<Persona1> GetAll()
        {
            return _context.Persona1.Where(x => x.Eliminado == false).OrderByDescending(x => x.FechaRegistro).ToList();
        }

        public Persona1 GetById(int id)
        {
            try
            {
                return _context.Persona1.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save(Persona1 model)
        {
            try
            {
                if (model.Id <= 0)
                {
                    model.UsuarioRegistra = 1;
                    model.FechaRegistro = DateTime.Now;

                    _context.Persona1.Add(model);
                }
                else
                {
                    var entity = GetById(model.Id);

                    entity.Nombres = model.Nombres;
                    entity.Apellidos = model.Apellidos;
                    entity.TipoDocumento = model.TipoDocumento;
                    entity.NoDocumento = model.NoDocumento;
                    entity.FechaNacimiento = model.FechaNacimiento;
                    entity.NoContacto = model.NoContacto;
                    entity.Email = model.Email;
                    entity.Direccion = model.Direccion;
                    entity.UsuarioUltimaModificacion = 1;
                    entity.FechaUltimaModificacion = DateTime.Now;

                    _context.Persona1.Update(entity);
                }

                _context.SaveChanges();

                return model.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = GetById(id);

                if (entity == null)
                {
                    throw new ArgumentException($"No se ha encontrado ninuna persona con el Id {id}.");
                }

                entity.Eliminado = !entity.Eliminado;
                entity.UsuarioElimina = 1;
                entity.FechaEliminado = DateTime.Now;

                _context.Persona1.Update(entity);

                _context.SaveChanges();

                return entity.Eliminado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Persona1> SearchAll(Persona1ViewModel search)
        {
            var query = _context.Persona1.AsNoTracking().Where(x => x.Eliminado == false);

            if (!string.IsNullOrEmpty(search.NoDocumento.ToString()))
            {
                query = query.Where(x => x.NoDocumento.ToLower() == search.NoDocumento.ToLower());
            }

            if (!string.IsNullOrEmpty(search.Nombres))
            {
                query = query.Where(x => x.Nombres.Contains(search.Nombres));
            }

            var data = query.OrderByDescending(x => x.FechaRegistro).ToList();

            return data;
        }
    }
}
