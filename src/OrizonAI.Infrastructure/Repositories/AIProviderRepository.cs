using Microsoft.EntityFrameworkCore;
using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Domain.Entities;
using OrizonAI.Infrastructure.Data;

namespace OrizonAI.Infrastructure.Repositories;

public class AIProviderRepository : IAIProviderRepository
{
    private readonly AppDbContext _context;

    public AIProviderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AIProvider>> GetAllAsync()
    {
        return await _context.AIProviders
            .OrderBy(x => x.DisplayName)
            .ToListAsync();
    }

    public async Task<AIProvider?> GetByIdAsync(Guid id)
    {
        return await _context.AIProviders
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(AIProvider provider)
    {
        await _context.AIProviders.AddAsync(provider);
    }

    public Task UpdateAsync(AIProvider provider)
    {
        _context.AIProviders.Update(provider);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(Guid id)
    {
        var provider = await GetByIdAsync(id);

        if (provider != null)
            _context.AIProviders.Remove(provider);
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        return _context.AIProviders.AnyAsync(x => x.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}