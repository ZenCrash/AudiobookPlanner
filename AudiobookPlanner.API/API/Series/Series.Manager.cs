using AudiobookPlanner.API.API.Authors.Models;
using AudiobookPlanner.API.API.Series.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Series
{
  public class SeriesManager(AudiobookPlannerContext context) : ISeriesManager
  {
    public async Task<SeriesDto?> GetAsync(int id)
    {
      var result = await context.Series
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<SeriesDto>> GetAllAsync()
    {
      var result = await context.Series
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<SeriesDto> CreateAsync(SeriesDto seriesDto)
    {
      var model = seriesDto.ToModel();
      context.Series.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<SeriesDto?> UpdateAsync(int id, SeriesDto seriesDto)
    {
      var resultModel = await context.Series.FindAsync(id);
      if (resultModel == null)
        return null;

      seriesDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Series.FindAsync(id);
      if (entity == null)
        return false;

      context.Series.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
