using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Infrastructure.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Phone)
            .HasMaxLength(30);

        builder.Property(x => x.Document)
            .HasMaxLength(30);

        builder.HasOne(x => x.CompanyProfile)
            .WithOne(x => x.Account)
            .HasForeignKey<CompanyProfile>(x => x.AccountId);
    }
}