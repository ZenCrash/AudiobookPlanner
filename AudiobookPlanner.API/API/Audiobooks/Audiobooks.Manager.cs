using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Audiobooks
{
  public class AudiobooksManager(AudiobookPlannerContext context) : IAudiobooksManager
  {
    public async Task<AudiobookDto?> GetByIdAsync(int id)
    {
      var result = await context.Audiobooks
        .FirstOrDefaultAsync(a => a.Id == id);
      if(result == null)
        return null;

      return result.ToDto();
    }

    public async Task<AudiobookDto?> GetByNameAsync(string name)
    {
      var result = await context.Audiobooks
        .FirstOrDefaultAsync(a => a.Title == name);
      if (result == null)
        return null;

      return result.ToDto();
    }

    public async Task<ICollection<AudiobookDto>> GetAllAsync()
    {
      var result = await context.Audiobooks
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<AudiobookDto> CreateAsync(AudiobookDto audiobookDto)
    {
      var model = audiobookDto.ToModel();
      context.Audiobooks.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<AudiobookDto?> UpdateAsync(int id, AudiobookDto audiobookDto)
    {
      var resultModel = await context.Audiobooks.FindAsync(id);
      if (resultModel == null)
        return null;

      audiobookDto.ToModel(resultModel);
      await context.SaveChangesAsync();

      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Audiobooks.FindAsync(id);

      if (entity == null)
        return false;

      context.Audiobooks.Remove(entity);
      await context.SaveChangesAsync();

      return true;
    }
  }
}