using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VeltisAI.Domain.Entities;
using VeltisAI.Infrastructure.Identity;

namespace VeltisAI.Infrastructure.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts => Set<Account>();

    public DbSet<CompanyProfile> CompanyProfiles => Set<CompanyProfile>();

    public DbSet<Company> Companies => Set<Company>();

    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<Plan> Plans => Set<Plan>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Account>()
            .HasOne(x => x.CompanyProfile)
            .WithOne(x => x.Account)
            .HasForeignKey<CompanyProfile>(x => x.AccountId);

        builder.Entity<ApplicationUser>()
            .HasOne(x => x.Account)
            .WithMany()
            .HasForeignKey(x => x.AccountId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}