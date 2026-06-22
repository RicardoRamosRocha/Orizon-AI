namespace VeltisAI.Domain.Entities;

public class Company
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool Active { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}