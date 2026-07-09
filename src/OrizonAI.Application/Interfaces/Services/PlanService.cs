using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Domain.Entities;

namespace OrizonAI.Application.Services;

public class PlanService : IPlanService
{
    private readonly IPlanRepository _repository;

    public PlanService(IPlanRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Plan>> GetAllAsync()
        => _repository.GetAllAsync();

    public Task<Plan?> GetByIdAsync(Guid id)
        => _repository.GetByIdAsync(id);

    public async Task CreateAsync(Plan plan)
    {
        await _repository.AddAsync(plan);
        await _repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Plan plan)
    {
        await _repository.UpdateAsync(plan);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        await _repository.SaveChangesAsync();
    }
}