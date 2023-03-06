using Domian.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ColaboradorConfig : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaborador");
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id).HasColumnType("UNIQUEIDENTIFIER");
            builder.Property(p => p.emailAtos).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.emailClient).HasColumnType("varchar(80)");

            builder.Property(p => p.FullName).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.BirthDate).HasColumnType("datetime").IsRequired();

            builder.Property(p => p.DASid).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.TimeSheet).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.GCMDetails).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.ShippingAddress).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.Device).HasColumnType("varchar(80)");
            builder.Property(p => p.DeviceSerialNumber).HasColumnType("varchar(80)");
            builder.Property(p => p.ProfilePhoto).HasColumnType("varchar(80)");
            builder.Property(p => p.PID).HasColumnType("varchar(80)").IsRequired();
            builder.Property(p => p.JoiningDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.EndDate).HasColumnType("datetime");
            builder.Property(p => p.ReasonOut).HasColumnType("varchar(80)");
            builder.Property(p => p.CurrentPosition).HasColumnType("varchar(80)");
            builder.Property(p => p.CandidateId).HasColumnType("UNIQUEIDENTIFIER");

            builder.Property(p => p.UserCreatorId).HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(p => p.ModifiedDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.ModifiedBy).HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(p => p.ModifiedDate).HasColumnType("datetime").IsRequired();

            builder.Property(p => p.State).HasColumnType("bit").IsRequired();
        }
    }
}
