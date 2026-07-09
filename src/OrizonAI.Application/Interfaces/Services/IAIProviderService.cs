using OrizonAI.Domain.Entities;
using OrizonAI.Application.Interfaces.Repositories;

namespace OrizonAI.Application.Interfaces.Services;

public interface IAIProviderService
{
    Task<List<AIProvider>> GetAllAsync();

    Task<AIProvider?> GetByIdAsync(Guid id);

    Task CreateAsync(AIProvider provider);

    Task UpdateAsync(AIProvider provider);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);
}