using Microsoft.AspNetCore.Identity;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public Guid? AccountId { get; set; }

    public Account? Account { get; set; }

    public string FullName { get; set; } = string.Empty;

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}