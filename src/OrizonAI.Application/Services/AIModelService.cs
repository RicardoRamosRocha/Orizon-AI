using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;


namespace OrizonAI.Application.Services;

public class AIModelService : IAIModelService
{
    private readonly IAIModelRepository _repository;

    public AIModelService(IAIModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<AIModel>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<AIModel?> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddAsync(AIModel model)
    {
        await _repository.AddAsync(model);
        await _repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(AIModel model)
    {
        await _repository.UpdateAsync(model);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        await _repository.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _repository.ExistsAsync(id);
    }
}