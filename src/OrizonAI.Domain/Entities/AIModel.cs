using OrizonAI.Domain.Enums;

namespace OrizonAI.Domain.Entities;

public class AIModel
{
    public Guid Id { get; set; }

    public Guid AIProviderId { get; set; }

    public AIProvider? AIProvider { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Identifier { get; set; } = string.Empty;

    public AIModelModality Modalities { get; set; } = AIModelModality.Text;

    public int ContextWindow { get; set; }

    public int MaxOutputTokens { get; set; }

    public decimal InputTokenPricePerMillion { get; set; }

    public decimal OutputTokenPricePerMillion { get; set; }

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}