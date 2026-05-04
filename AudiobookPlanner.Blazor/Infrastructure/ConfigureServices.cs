using AudiobookPlanner.Blazor.Infrastructure.Services;

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
    }
  }
}
