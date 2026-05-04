using AudiobookPlanner.Blazor.Application.Views.Audiobooks;

namespace AudiobookPlanner.Blazor.Application
{
  public static class RegisterServices
  {
    public static void AddManagers(this IServiceCollection services)
    {
      services.AddScoped<IAudiobooksManager, AudiobooksManager>();
    }

  }
}
