using Microsoft.EntityFrameworkCore;
using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Domain.Entities;
using OrizonAI.Infrastructure.Data;

namespace OrizonAI.Infrastructure.Repositories;

public class AIModelRepository : IAIModelRepository
{
    private readonly AppDbContext _context;

    public AIModelRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AIModel>> GetAllAsync()
    {
        return await _context.AIModels
            .Include(x => x.AIProvider)
            .OrderBy(x => x.Name)
            .ToListAsync();
    }

    public async Task<AIModel?> GetByIdAsync(Guid id)
    {
        return await _context.AIModels
            .Include(x => x.AIProvider)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(AIModel model)
    {
        await _context.AIModels.AddAsync(model);
    }

    public Task UpdateAsync(AIModel model)
    {
        _context.AIModels.Update(model);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(Guid id)
    {
        var model = await GetByIdAsync(id);

        if (model != null)
            _context.AIModels.Remove(model);
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        return _context.AIModels.AnyAsync(x => x.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}