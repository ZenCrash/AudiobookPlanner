using AudiobookPlanner.DataAccess.Data;
using AudiobookPlanner.DataAccess.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Audiobooks
{
  public class AudiobooksManager(AudiobookPlannerContext context) : IAudiobooksManager
  {
    public async Task<Audiobook?> GetByIdAsync(int id)
    {
      return await context.Audiobooks
        .Include(a => a.Authors)
        .Include(a => a.Genres)
        .Include(a => a.Tags)
        .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<List<Audiobook>> GetAllAsync()
    {
      return await context.Audiobooks
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<Audiobook> CreateAsync(Audiobook audiobook)
    {
      context.Audiobooks.Add(audiobook);
      await context.SaveChangesAsync();
      return audiobook;
    }

    public async Task<Audiobook?> UpdateAsync(int id, Audiobook updated)
    {
      if (id == null || updated == null)
        throw new BadHttpRequestException("Response id or object id is null");
      if (updated == null)
        throw new BadHttpRequestException("Response id and object id does not match");

      var existing = await context.Audiobooks.FindAsync(id);
      if (existing == null) 
        return null;

      await context.SaveChangesAsync();
      return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Audiobooks.FindAsync(id);
      if (entity == null) return false;

      context.Audiobooks.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
