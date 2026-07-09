namespace OrizonAI.Application.AI.DTOs;

public class ChatResponse
{
    public bool Success { get; set; }

    public string Response { get; set; } = string.Empty;

    public string? ErrorMessage { get; set; }

    public TokenUsage Usage { get; set; } = new();
}