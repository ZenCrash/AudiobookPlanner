using AudiobookPlanner.API.API.Genres.Models;
using AudiobookPlanner.API.API.Languages.Models;

namespace AudiobookPlanner.API.API.Languages
{
  public interface ILanguagesManager
  {
    Task<LanguageDto?> GetAsync(int id);
    Task<ICollection<LanguageDto>> GetAllAsync();
    Task<LanguageDto> CreateAsync(LanguageDto languageDto);
    Task<LanguageDto?> UpdateAsync(int id, LanguageDto languageDto);
    Task<bool> DeleteAsync(int id);
  }
}
