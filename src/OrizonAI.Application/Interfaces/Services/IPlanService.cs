using OrizonAI.Domain.Entities;

namespace OrizonAI.Application.Interfaces.Services;

public interface IPlanService
{
    Task<List<Plan>> GetAllAsync();

    Task<Plan?> GetByIdAsync(Guid id);

    Task CreateAsync(Plan plan);

    Task UpdateAsync(Plan plan);

    Task DeleteAsync(Guid id);
}