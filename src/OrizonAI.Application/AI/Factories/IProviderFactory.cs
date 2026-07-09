using OrizonAI.Application.AI.Contracts;

namespace OrizonAI.Application.AI.Factories;

public interface IProviderFactory
{
    IAIProvider GetProvider(string providerName);
}