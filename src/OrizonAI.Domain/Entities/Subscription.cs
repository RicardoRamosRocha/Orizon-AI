using OrizonAI.Domain.Enums;

namespace OrizonAI.Domain.Entities;

public class Subscription
{
    public Guid Id { get; set; }

    public Guid AccountId { get; set; }
    public Account? Account { get; set; }

    public Guid PlanId { get; set; }
    public Plan? Plan { get; set; }

    public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Active;

    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    public DateTime? EndDate { get; set; }

    public bool AutoRenew { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}