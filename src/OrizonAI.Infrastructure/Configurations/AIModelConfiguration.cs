using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Infrastructure.Configurations;

public class AIModelConfiguration : IEntityTypeConfiguration<AIModel>
{
    public void Configure(EntityTypeBuilder<AIModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(120);

        builder.Property(x => x.Identifier)
            .IsRequired()
            .HasMaxLength(120);

        builder.Property(x => x.InputTokenPricePerMillion)
            .HasPrecision(18, 6);

        builder.Property(x => x.OutputTokenPricePerMillion)
            .HasPrecision(18, 6);

        builder.HasOne(x => x.AIProvider)
            .WithMany()
            .HasForeignKey(x => x.AIProviderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.AIProviderId,
            x.Identifier
        }).IsUnique();

        builder.HasIndex(x => x.Active);
    }
}