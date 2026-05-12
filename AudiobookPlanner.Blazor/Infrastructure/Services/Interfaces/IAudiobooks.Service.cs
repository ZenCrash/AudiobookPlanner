using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface IAudiobooksService
  {
    Task<ICollection<AudiobookDto>> GetAllAsync();
    Task<AudiobookDto?> GetAsync(int id);
    Task CreateAsync(AudiobookDto audiobook);
    Task UpdateAsync(AudiobookDto audiobook);
    Task DeleteAsync(int id);
  }
}
