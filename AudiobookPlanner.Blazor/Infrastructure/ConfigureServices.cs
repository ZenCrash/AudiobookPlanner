using AudiobookPlanner.Blazor.Infrastructure.Services;
using AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces;

namespace AudiobookPlanner.Blazor.Infrastructure
{
  public static class ConfigureServices
  {
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
      var apiBaseUrl = configuration["ApiSettings:BaseUrl"];
      if (apiBaseUrl == null)
        throw new InvalidOperationException("API base URL is not configured. Please set 'ApiSettings'");

      services.AddHttpClient<IAudiobooksService, AudiobooksService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
      services.AddHttpClient<IAuthorsService, AuthorsService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
      services.AddHttpClient<IPublishersService, PublishersService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
      services.AddHttpClient<INarratorsService, NarratorsService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
      services.AddHttpClient<ILanguagesService, LanguagesService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
      services.AddHttpClient<IGenresService, GenresService>(client => { client.BaseAddress = new Uri(apiBaseUrl); });
    }
  }
}
