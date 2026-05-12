using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class GenresService(HttpClient http) : IGenresService
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<GenreDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<GenreDto>>("api/genres")
             ?? [];
    }

    public async Task<GenreDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<GenreDto>($"api/genres/{id}");
    }

    public async Task CreateAsync(GenreDto genre)
    {
      await _http.PostAsJsonAsync("api/genres", genre);
    }

    public async Task UpdateAsync(GenreDto genre)
    {
      await _http.PutAsJsonAsync($"api/genres/{genre.Id}", genre);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/genres/{id}");
    }
  }
}
