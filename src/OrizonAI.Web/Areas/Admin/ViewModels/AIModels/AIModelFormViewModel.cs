using OrizonAI.Domain.Enums;

namespace OrizonAI.Web.Areas.Admin.ViewModels.AIModels;

public class AIModelFormViewModel
{
    public Guid Id { get; set; }

    public Guid AIProviderId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Identifier { get; set; } = string.Empty;

    public AIModelModality Modalities { get; set; } = AIModelModality.Text;

    public int ContextWindow { get; set; }

    public int MaxOutputTokens { get; set; }

    public decimal InputTokenPricePerMillion { get; set; }

    public decimal OutputTokenPricePerMillion { get; set; }

    public bool Active { get; set; } = true;
}