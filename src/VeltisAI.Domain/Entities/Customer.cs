namespace VeltisAI.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }

    public Guid CompanyId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public decimal Credits { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}