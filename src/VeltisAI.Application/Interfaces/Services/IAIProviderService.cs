using VeltisAI.Domain.Entities;
using VeltisAI.Application.Interfaces.Repositories;

namespace VeltisAI.Application.Interfaces.Services;

public interface IAIProviderService
{
    Task<List<AIProvider>> GetAllAsync();

    Task<AIProvider?> GetByIdAsync(Guid id);

    Task CreateAsync(AIProvider provider);

    Task UpdateAsync(AIProvider provider);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);
}