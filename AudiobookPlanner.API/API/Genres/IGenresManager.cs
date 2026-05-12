using AudiobookPlanner.API.API.Genres.Models;

namespace AudiobookPlanner.API.API.Genres
{
  public interface IGenresManager
  {
    Task<GenreDto?> GetAsync(int id);
    Task<ICollection<GenreDto>> GetAllAsync();
    Task<GenreDto> CreateAsync(GenreDto genreDto);
    Task<GenreDto?> UpdateAsync(int id, GenreDto genreDto);
    Task<bool> DeleteAsync(int id);
  }
}
