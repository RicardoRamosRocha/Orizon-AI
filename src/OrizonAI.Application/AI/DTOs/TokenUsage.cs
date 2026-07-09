namespace OrizonAI.Application.AI.DTOs;

public class TokenUsage
{
    public int PromptTokens { get; set; }

    public int CompletionTokens { get; set; }

    public int TotalTokens =>
        PromptTokens + CompletionTokens;
}