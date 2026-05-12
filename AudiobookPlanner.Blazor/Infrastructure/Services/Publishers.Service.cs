using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure.Services
{
  public class PublishersService(HttpClient http) : IPublishersService
  {
    private readonly HttpClient _http = http;

    public async Task<ICollection<PublisherDto>> GetAllAsync()
    {
      return await _http.GetFromJsonAsync<ICollection<PublisherDto>>("api/publishers")
             ?? [];
    }

    public async Task<PublisherDto?> GetAsync(int id)
    {
      return await _http.GetFromJsonAsync<PublisherDto>($"api/publishers/{id}");
    }

    public async Task CreateAsync(PublisherDto publisher)
    {
      await _http.PostAsJsonAsync("api/publishers", publisher);
    }

    public async Task UpdateAsync(PublisherDto publisher)
    {
      await _http.PutAsJsonAsync($"api/publishers/{publisher.Id}", publisher);
    }

    public async Task DeleteAsync(int id)
    {
      await _http.DeleteAsync($"api/publishers/{id}");
    }
  }
}
