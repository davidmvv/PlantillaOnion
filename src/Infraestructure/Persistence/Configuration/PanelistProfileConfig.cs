using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Atos.EFCore.Extensions;
using Domian.Entities;

namespace Persistence.Configuration
{
    public class PanelistProfileConfig : IEntityTypeConfiguration<PanelistProfile>
    {
        public void Configure(EntityTypeBuilder<PanelistProfile> builder)
        {
            builder.ConfigurationBase<Guid, Guid, PanelistProfile>("PanelistProfile");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.IdUser).HasMaxLength(450).IsRequired();
            builder.Property(p => p.IdRol).HasMaxLength(450).IsRequired();
            builder.HasMany(s => s.Skills);
                
        }
    }
}