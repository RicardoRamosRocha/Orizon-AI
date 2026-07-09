using OrizonAI.Domain.Enums;

namespace OrizonAI.Domain.Entities;

public class Account
{
    public Guid Id { get; set; }

    public AccountType Type { get; set; }

    public AccountStatus Status { get; set; } = AccountStatus.Active;

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Document { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public CompanyProfile? CompanyProfile { get; set; }
}