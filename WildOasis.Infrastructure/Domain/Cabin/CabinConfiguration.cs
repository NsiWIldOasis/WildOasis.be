using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WildOasis.Infrastructure.Domain.Cabin;

public class CabinsConfiguration : IEntityTypeConfiguration<WildOasis.Domain.Entities.Cabin>
{
    public void Configure(EntityTypeBuilder<WildOasis.Domain.Entities.Cabin> builder)
    {
        builder.ToTable("Cabins");
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property<Guid>("ResortId");
        builder.HasIndex("ResortId");
        builder.HasOne(p => p.Resort).
            WithMany(r => r.Cabins).HasForeignKey("ResortId").IsRequired();
    }
}