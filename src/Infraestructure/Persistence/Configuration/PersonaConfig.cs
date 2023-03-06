using Atos.EFCore.Extensions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class PersonaConfig: IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ConfigurationBase<Guid, Guid, Persona>("Persona");
            builder.Property(p => p.Nombre).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.Apellido).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.FechaDeNacimiento).HasColumnType("datetime").IsRequired();
        }
    }
}
