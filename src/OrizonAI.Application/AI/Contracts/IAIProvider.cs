using OrizonAI.Application.AI.DTOs;

namespace OrizonAI.Application.AI.Contracts;

public interface IAIProvider
{
    string ProviderName { get; }

    Task<ChatResponse> ChatAsync(
        ChatRequest request,
        CancellationToken cancellationToken = default);
}