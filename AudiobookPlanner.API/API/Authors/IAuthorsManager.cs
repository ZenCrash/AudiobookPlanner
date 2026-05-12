using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.API.API.Authors.Models;

namespace AudiobookPlanner.API.API.Authors
{
  public interface IAuthorsManager
  {
    Task<AuthorDto?> GetAsync(int id);
    Task<ICollection<AuthorDto>> GetAllAsync();
    Task<AuthorDto> CreateAsync(AuthorDto authorDto);
    Task<AuthorDto?> UpdateAsync(int id, AuthorDto authorDto);
    Task<bool> DeleteAsync(int id);
  }
}
