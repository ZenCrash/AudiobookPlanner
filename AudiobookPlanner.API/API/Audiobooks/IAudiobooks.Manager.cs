using AudiobookPlanner.DataAccess.Models;

namespace AudiobookPlanner.API.API.Audiobooks
{
  public interface IAudiobooksManager
  {
    Task<Audiobook?> GetByIdAsync(int id);
    Task<List<Audiobook>> GetAllAsync();
    Task<Audiobook> CreateAsync(Audiobook audiobook);
    Task<Audiobook> UpdateAsync(int id, Audiobook audiobook);
    Task<bool> DeleteAsync(int id);
  }
}
