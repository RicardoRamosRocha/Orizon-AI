using OrizonAI.Domain.Entities;

namespace OrizonAI.Application.Interfaces.Repositories;

public interface IPlanRepository
{
    Task<List<Plan>> GetAllAsync();

    Task<Plan?> GetByIdAsync(Guid id);

    Task AddAsync(Plan plan);

    Task UpdateAsync(Plan plan);

    Task DeleteAsync(Guid id);

    Task SaveChangesAsync();
}