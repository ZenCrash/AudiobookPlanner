using AudiobookPlanner.API.API.Languages.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Languages
{
  public class LanguagesManager(AudiobookPlannerContext context) : ILanguagesManager
  {
    public async Task<LanguageDto?> GetAsync(int id)
    {
      var result = await context.Languages
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<LanguageDto>> GetAllAsync()
    {
      var result = await context.Languages
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<LanguageDto> CreateAsync(LanguageDto languageDto)
    {
      var model = languageDto.ToModel();
      context.Languages.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<LanguageDto?> UpdateAsync(int id, LanguageDto languageDto)
    {
      var resultModel = await context.Languages.FindAsync(id);
      if (resultModel == null)
        return null;

      languageDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Languages.FindAsync(id);
      if (entity == null)
        return false;

      context.Languages.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
