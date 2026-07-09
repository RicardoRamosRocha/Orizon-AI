using OrizonAI.Domain.Entities;

namespace OrizonAI.Application.Interfaces.Services;

public interface IAIModelService
{
    Task<List<AIModel>> GetAllAsync();

    Task<AIModel?> GetByIdAsync(Guid id);

    Task AddAsync(AIModel model);

    Task UpdateAsync(AIModel model);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);
}