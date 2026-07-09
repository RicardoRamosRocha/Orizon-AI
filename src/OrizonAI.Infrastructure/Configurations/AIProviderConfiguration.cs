using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Infrastructure.Configurations;

public class AIProviderConfiguration : IEntityTypeConfiguration<AIProvider>
{
    public void Configure(EntityTypeBuilder<AIProvider> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(x => x.DisplayName)
            .IsRequired()
            .HasMaxLength(120);

        builder.Property(x => x.BaseUrl)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(x => x.ApiKey)
            .HasMaxLength(500);

        builder.Property(x => x.OrganizationId)
            .HasMaxLength(120);

        builder.Property(x => x.ApiVersion)
            .HasMaxLength(80);

        builder.HasMany(x => x.Models)
            .WithOne(x => x.AIProvider)
            .HasForeignKey(x => x.AIProviderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.Type);
        builder.HasIndex(x => x.Active);
    }
}