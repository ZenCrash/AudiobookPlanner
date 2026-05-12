using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class NarratorsService(HttpClient http) : INarratorsService  
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<NarratorDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<NarratorDto>>("api/narrators")
             ?? [];
    }

    public async Task<NarratorDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<NarratorDto>($"api/narrators/{id}");
    }

    public async Task CreateAsync(NarratorDto narrator)
    {
      await _http.PostAsJsonAsync("api/narrators", narrator);
    }

    public async Task UpdateAsync(NarratorDto narrator)
    {
      await _http.PutAsJsonAsync($"api/narrators/{narrator.Id}", narrator);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/narrators/{id}");
    }
  }
}
