using Microsoft.EntityFrameworkCore;
using Personas1.Data.Models;

namespace Personas1.Data.Context
{
    public class Personas1Context : DbContext
    {
        public Personas1Context(DbContextOptions<Personas1Context> options) : base(options)
        {

        }

        #region DataSets

        public DbSet<Persona1> Persona1 { get; set; }

        #endregion
    }
}
