using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface INarratorsService
  {
    Task<ICollection<NarratorDto>> GetAllAsync();
    Task<NarratorDto?> GetAsync(int id);
    Task CreateAsync(NarratorDto narrator);
    Task UpdateAsync(NarratorDto narrator);
    Task DeleteAsync(int id);
  }
}
