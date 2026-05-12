using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface IGenresService
  {
    Task<ICollection<GenreDto>> GetAllAsync();
    Task<GenreDto?> GetAsync(int id);
    Task CreateAsync(GenreDto genre);
    Task UpdateAsync(GenreDto genre);
    Task DeleteAsync(int id);
  }
}
