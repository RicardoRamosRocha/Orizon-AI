using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Infrastructure.Configurations;

public class CompanyProfileConfiguration : IEntityTypeConfiguration<CompanyProfile>
{
    public void Configure(EntityTypeBuilder<CompanyProfile> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CorporateName)
            .IsRequired()
            .HasMaxLength(180);

        builder.Property(x => x.TradeName)
            .HasMaxLength(150);

        builder.Property(x => x.TaxDocument)
            .HasMaxLength(30);

        builder.Property(x => x.StateRegistration)
            .HasMaxLength(50);

        builder.Property(x => x.Address)
            .HasMaxLength(250);
    }
}