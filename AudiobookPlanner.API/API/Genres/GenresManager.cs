using AudiobookPlanner.API.API.Authors.Models;
using AudiobookPlanner.API.API.Genres.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Genres
{
  public class GenresManager(AudiobookPlannerContext context) : IGenresManager
  {
    public async Task<GenreDto?> GetAsync(int id)
    {
      var result = await context.Genres
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<GenreDto>> GetAllAsync()
    {
      var result = await context.Genres
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<GenreDto> CreateAsync(GenreDto genreDto)
    {
      var model = genreDto.ToModel();
      context.Genres.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<GenreDto?> UpdateAsync(int id, GenreDto genreDto)
    {
      var resultModel = await context.Genres.FindAsync(id);
      if (resultModel == null)
        return null;

      genreDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Genres.FindAsync(id);
      if (entity == null)
        return false;

      context.Genres.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
