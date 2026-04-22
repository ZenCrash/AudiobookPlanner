using AudiobookPlanner.DataAccess.Models;

namespace AudiobookPlanner.DataAccess.Repositories
{
  public interface IAudioBookRepository
  {
    public Task<Audiobook?> GetAsync(int id);
    public Task<ICollection<Audiobook>> GetAllAsync();
    public Task<Audiobook> CreateAsync(Audiobook entity);
    public Task<Audiobook> UpdateAsync(Audiobook entity);
    public Task DeleteAsync(int id);
  }
}
