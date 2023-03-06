using Domian.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistence.Configuration
{
    public class PanelistSkillsConfig : IEntityTypeConfiguration<PanelistSkills>
    {
        public void Configure(EntityTypeBuilder<PanelistSkills> builder)
        {
            builder.ToTable("PanelistSkiils");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Skill).HasMaxLength(80).IsRequired();
            builder.Property(p => p.LevelKnowledge).HasMaxLength(80).IsRequired();
            builder.Property(p => p.PanelistProfileId).HasMaxLength(450).IsRequired();            
                
        }
    }
}
