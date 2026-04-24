using AudiobookPlanner.DataAccess.Data;
using AudiobookPlanner.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.DataAccess.Repositories
{
  public class AudioBookRepository(AudiobookPlannerContext context) : IAudioBookRepository
  {
    public async Task<Audiobook?> GetAsync(int id)
    {
      return await context.Audiobooks
        .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<ICollection<Audiobook>> GetAllAsync()
    {
      return await context.Audiobooks
        .ToListAsync();
    }

    public async Task<Audiobook> CreateAsync(Audiobook entity)
    {
      await context.Audiobooks.AddAsync(entity);
      await context.SaveChangesAsync();
      return entity;
    }

    public async Task<Audiobook> UpdateAsync(Audiobook entity)
    {
      context.Audiobooks.Update(entity);
      await context.SaveChangesAsync();
      return entity;
    }

    public async Task DeleteAsync(int id)
    {
      await context.Audiobooks
        .Where(p => p.Id == id)
        .ExecuteDeleteAsync();
    }
  }
}
