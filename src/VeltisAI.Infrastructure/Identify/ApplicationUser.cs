using Microsoft.AspNetCore.Identity;

namespace VeltisAI.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}