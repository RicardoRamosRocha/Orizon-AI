namespace OrizonAI.Application.AI.DTOs;

public class ChatRequest
{
    public string Model { get; set; } = string.Empty;

    public string Prompt { get; set; } = string.Empty;

    public decimal Temperature { get; set; } = 0.7m;

    public int MaxTokens { get; set; } = 4096;
}