using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.API.API.Authors.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Authors
{
  public class AuthorsManager(AudiobookPlannerContext context) : IAuthorsManager
  {
    public async Task<AuthorDto?> GetAsync(int id)
    {
      var result = await context.Authors
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<AuthorDto>> GetAllAsync()
    {
      var result = await context.Authors
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<AuthorDto> CreateAsync(AuthorDto authorDto)
    {
      var model = authorDto.ToModel();
      context.Authors.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<AuthorDto?> UpdateAsync(int id, AuthorDto authorDto)
    {
      var resultModel = await context.Authors.FindAsync(id);
      if (resultModel == null)
        return null;

      authorDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Authors.FindAsync(id);
      if (entity == null)
        return false;

      context.Authors.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
