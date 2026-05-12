using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface ILanguagesService
  {
    Task<ICollection<LanguageDto>> GetAllAsync();
    Task<LanguageDto?> GetAsync(int id);
    Task CreateAsync(LanguageDto language);
    Task UpdateAsync(LanguageDto language);
    Task DeleteAsync(int id);
  }
}
