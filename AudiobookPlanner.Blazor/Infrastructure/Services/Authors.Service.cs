using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class AuthorsService(HttpClient http) : IAuthorsService
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<AuthorDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<AuthorDto>>("api/authors")
             ?? [];
    }

    public async Task<AuthorDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<AuthorDto>($"api/authors/{id}");
    }

    public async Task CreateAsync(AuthorDto author)
    {
      await _http.PostAsJsonAsync("api/authors", author);
    }

    public async Task UpdateAsync(AuthorDto author)
    {
      await _http.PutAsJsonAsync($"api/authors/{author.Id}", author);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/authors/{id}");
    }
  }
}
