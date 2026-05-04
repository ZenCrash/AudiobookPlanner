using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class AudiobooksService(HttpClient http) : IAudiobooksService
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<AudiobookDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<AudiobookDto>>("api/audiobooks")
               ?? [];
    }

    public async Task<AudiobookDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<AudiobookDto>($"api/audiobooks/{id}");
    }

    public async Task CreateAsync(AudiobookDto audiobook)
    {
      await _http.PostAsJsonAsync("api/audiobooks", audiobook);
    }

    public async Task UpdateAsync(AudiobookDto audiobook)
    {
      await _http.PutAsJsonAsync($"api/audiobooks/{audiobook.Id}", audiobook);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/audiobooks/{id}");
    }
  }
}
