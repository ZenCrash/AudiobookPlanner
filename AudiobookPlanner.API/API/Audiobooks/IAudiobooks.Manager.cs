using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.API.Common;
using AudiobookPlanner.DataAccess.Models;

namespace AudiobookPlanner.API.API.Audiobooks
{
  public interface IAudiobooksManager
  {
    Task<AudiobookDto?> GetAsync(int id);
    Task<AudiobookDto?> GetByNameAsync(string name);
    Task<ICollection<AudiobookDto>> GetAllAsync();
    Task<AudiobookDto> CreateAsync(AudiobookDto audiobookDto);
    Task<AudiobookDto?> UpdateAsync(int id, AudiobookDto audiobookDto);
    Task<bool> DeleteAsync(int id);
  }
}
