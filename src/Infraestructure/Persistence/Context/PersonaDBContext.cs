using Domain.Entities;
using Domian.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class PersonaDBContext :DbContext
    {
        public PersonaDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<PanelistProfile> PanelistProfiles { get; set; }
        public DbSet<PanelistSkills> PanelistSkills { get; set; }

        public DbSet<Colaborador> Colaborador { get; set; }
    }
}
