using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Application.Views.Audiobooks
{
  public interface IAudiobooksManager
  {
    Task<ICollection<Audiobook>> GetAllAsync();
    Task<Audiobook?> GetAsync(int id);
    Task CreateAsync(Audiobook audiobook);
    Task UpdateAsync(Audiobook audiobook);
    Task DeleteAsync(int id);
  }
}
