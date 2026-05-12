using AudiobookPlanner.API.API.Audiobooks;
using AudiobookPlanner.API.API.Authors;
using AudiobookPlanner.API.API.Genres;
using AudiobookPlanner.API.API.Languages;
using AudiobookPlanner.API.API.Narrators;
using AudiobookPlanner.API.API.Publishers;
using AudiobookPlanner.API.API.Series;

namespace AudiobookPlanner.API
{
  public static class ConfigureManagers
  {
    public static void AddManagers(this IServiceCollection services)
    {
      services.AddScoped<IAudiobooksManager, AudiobooksManager>();
      services.AddScoped<IAuthorsManager, AuthorsManager>();
      services.AddScoped<IGenresManager, GenresManager>();
      services.AddScoped<ILanguagesManager, LanguagesManager>();
      services.AddScoped<INarratorsManager, NarratorsManager>();
      services.AddScoped<IPublishersManager, PublishersManager>();
      services.AddScoped<ISeriesManager, SeriesManager>();
    }
  }
}
