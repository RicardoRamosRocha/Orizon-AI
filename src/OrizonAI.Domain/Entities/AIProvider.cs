using OrizonAI.Domain.Enums;

namespace OrizonAI.Domain.Entities;

public class AIProvider
{
    public Guid Id { get; set; }

    public AIProviderType Type { get; set; }

    public string Name { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string BaseUrl { get; set; } = string.Empty;

    public string? ApiKey { get; set; }

    public string? OrganizationId { get; set; }

    public string? ApiVersion { get; set; }

    public int Priority { get; set; } = 1;

    public int TimeoutSeconds { get; set; } = 60;

    public int RetryCount { get; set; } = 2;

    public bool SupportsStreaming { get; set; }

    public bool SupportsVision { get; set; }

    public bool SupportsAudio { get; set; }

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public ICollection<AIModel> Models { get; set; } = new List<AIModel>();
}