using Personas1.Data.Models;
using Personas1.Domain.To.ViewModels;
using System.Collections.Generic;

namespace Personas1.Service.Interface
{
    public interface IPersona1Service
    {
        public List<Persona1> GetAll();

        public Persona1 GetById(int id);

        public int Save(Persona1 model);

        public bool Delete(int id);

        public List<Persona1> SearchAll(Persona1ViewModel search);
    }
}
