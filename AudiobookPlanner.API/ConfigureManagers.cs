using AudiobookPlanner.API.API.Audiobooks;

namespace AudiobookPlanner.API
{
  public static class ConfigureManagers
  {
    public static void AddManagers(this IServiceCollection services)
    {
      services.AddScoped<IAudiobooksManager, AudiobooksManager>();
    }
  }
}
