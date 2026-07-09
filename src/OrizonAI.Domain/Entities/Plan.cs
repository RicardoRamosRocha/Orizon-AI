namespace OrizonAI.Domain.Entities;

public class Plan
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal MonthlyPrice { get; set; }

    public int CreditsIncluded { get; set; }

    public int MaxUsers { get; set; }

    public int MaxTokensPerMonth { get; set; }

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}