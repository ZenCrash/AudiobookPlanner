using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class LanguagesService(HttpClient http) : ILanguagesService
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<LanguageDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<LanguageDto>>("api/languages")
             ?? [];
    }

    public async Task<LanguageDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<LanguageDto>($"api/languages/{id}");
    }

    public async Task CreateAsync(LanguageDto language)
    {
      await _http.PostAsJsonAsync("api/languages", language);
    }

    public async Task UpdateAsync(LanguageDto language)
    {
      await _http.PutAsJsonAsync($"api/languages/{language.Id}", language);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/languages/{id}");
    }
  }
}
