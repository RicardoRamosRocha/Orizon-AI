using VeltisAI.Domain.Entities;

namespace VeltisAI.Application.Interfaces.Repositories;

public interface IAIProviderRepository
{
    Task<List<AIProvider>> GetAllAsync();

    Task<AIProvider?> GetByIdAsync(Guid id);

    Task AddAsync(AIProvider provider);

    Task UpdateAsync(AIProvider provider);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);

    Task SaveChangesAsync();
}