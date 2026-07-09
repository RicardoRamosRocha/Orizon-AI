namespace OrizonAI.Domain.Entities;

public class CompanyProfile
{
    public Guid Id { get; set; }

    public Guid AccountId { get; set; }

    public Account? Account { get; set; }

    public string CorporateName { get; set; } = string.Empty;

    public string TradeName { get; set; } = string.Empty;

    public string? TaxDocument { get; set; }

    public string? StateRegistration { get; set; }

    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}