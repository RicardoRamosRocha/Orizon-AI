namespace OrizonAI.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }

    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Document { get; set; } = string.Empty;

    public decimal Credits { get; set; }

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}