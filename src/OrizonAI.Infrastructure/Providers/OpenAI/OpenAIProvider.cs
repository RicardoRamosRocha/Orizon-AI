using OrizonAI.Application.AI.Contracts;
using OrizonAI.Application.AI.DTOs;

namespace OrizonAI.Infrastructure.Providers.OpenAI;

public class OpenAIProvider : IAIProvider
{
    public string ProviderName => "OpenAI";

    public async Task<ChatResponse> ChatAsync(
        ChatRequest request,
        CancellationToken cancellationToken = default)
    {
        // Implementação virá na próxima Sprint

        await Task.CompletedTask;

        return new ChatResponse
        {
            Success = false,
            ErrorMessage = "Provider ainda não implementado."
        };
    }
}