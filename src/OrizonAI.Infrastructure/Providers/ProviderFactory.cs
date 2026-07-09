using OrizonAI.Application.AI.Contracts;
using OrizonAI.Application.AI.Factories;

namespace OrizonAI.Infrastructure.Providers;

public class ProviderFactory : IProviderFactory
{
    private readonly IEnumerable<IAIProvider> _providers;

    public ProviderFactory(IEnumerable<IAIProvider> providers)
    {
        _providers = providers;
    }

    public IAIProvider GetProvider(string providerName)
    {
        var provider = _providers.FirstOrDefault(p =>
            p.ProviderName.Equals(providerName, StringComparison.OrdinalIgnoreCase));

        if (provider is null)
            throw new InvalidOperationException($"Provider '{providerName}' não encontrado.");

        return provider;
    }
}