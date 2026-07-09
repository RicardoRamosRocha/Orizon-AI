using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;



namespace OrizonAI.Application.Services;

public class AIProviderService : IAIProviderService
{
    private readonly IAIProviderRepository _repository;

    public AIProviderService(IAIProviderRepository repository)
    {
        _repository = repository;
    }

    public Task<List<AIProvider>> GetAllAsync()
        => _repository.GetAllAsync();

    public Task<AIProvider?> GetByIdAsync(Guid id)
        => _repository.GetByIdAsync(id);

    public async Task CreateAsync(AIProvider provider)
    {
        provider.Id = Guid.NewGuid();
        provider.CreatedAt = DateTime.UtcNow;

        await _repository.AddAsync(provider);
        await _repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(AIProvider provider)
    {
        provider.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(provider);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        await _repository.SaveChangesAsync();
    }

    public Task<bool> ExistsAsync(Guid id)
        => _repository.ExistsAsync(id);
}