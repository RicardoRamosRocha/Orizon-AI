using VeltisAI.Domain.Entities;

namespace VeltisAI.Application.Interfaces.Repositories;

public interface IAIModelRepository
{
    Task<List<AIModel>> GetAllAsync();

    Task<AIModel?> GetByIdAsync(Guid id);

    Task AddAsync(AIModel model);

    Task UpdateAsync(AIModel model);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);

    Task SaveChangesAsync();
}