using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface IAuthorsService
  {
    Task<ICollection<AuthorDto>> GetAllAsync();
    Task<AuthorDto?> GetAsync(int id);
    Task CreateAsync(AuthorDto author);
    Task UpdateAsync(AuthorDto author);
    Task DeleteAsync(int id);
  }
}
