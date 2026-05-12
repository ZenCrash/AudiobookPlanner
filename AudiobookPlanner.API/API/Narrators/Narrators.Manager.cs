using AudiobookPlanner.API.API.Authors.Models;
using AudiobookPlanner.API.API.Narrators.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Narrators
{
  public class NarratorsManager(AudiobookPlannerContext context) : INarratorsManager
  {
    public async Task<NarratorDto?> GetAsync(int id)
    {
      var result = await context.Narrators
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<NarratorDto>> GetAllAsync()
    {
      var result = await context.Narrators
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<NarratorDto> CreateAsync(NarratorDto narratorDto)
    {
      var model = narratorDto.ToModel();
      context.Narrators.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<NarratorDto?> UpdateAsync(int id, NarratorDto narratorDto)
    {
      var resultModel = await context.Narrators.FindAsync(id);
      if (resultModel == null)
        return null;

      narratorDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Narrators.FindAsync(id);
      if (entity == null)
        return false;

      context.Narrators.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
