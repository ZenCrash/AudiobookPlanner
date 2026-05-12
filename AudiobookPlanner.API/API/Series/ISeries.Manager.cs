using AudiobookPlanner.API.API.Narrators.Models;
using AudiobookPlanner.API.API.Series.Models;

namespace AudiobookPlanner.API.API.Series
{
  public interface ISeriesManager
  {
    Task<SeriesDto?> GetAsync(int id);
    Task<ICollection<SeriesDto>> GetAllAsync();
    Task<SeriesDto> CreateAsync(SeriesDto seriesDto);
    Task<SeriesDto?> UpdateAsync(int id, SeriesDto seriesDto);
    Task<bool> DeleteAsync(int id);
  }
}
