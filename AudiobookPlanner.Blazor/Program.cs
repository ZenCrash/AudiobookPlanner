using AudiobookPlanner.Blazor.Application;
using AudiobookPlanner.Blazor.Components;
using AudiobookPlanner.Blazor.Infrastructure;
using AudiobookPlanner.Blazor.Infrastructure.Services;

namespace AudiobookPlanner.Blazor
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.
      builder.Services.AddRazorComponents()
          .AddInteractiveServerComponents();

      // Register HttpClient for API calls
      //builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri("https://localhost:5234/") });

      builder.Services.AddServices(builder.Configuration);
      builder.Services.AddManagers();

      //Culture settings
      var localizationSection = builder.Configuration.GetSection("Localization");
      var defaultCulture = localizationSection["DefaultCulture"];
      var supportedCultures = localizationSection
        .GetSection("SupportedCultures")
        .Get<string[]>();

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (!app.Environment.IsDevelopment())
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
      app.UseHttpsRedirection();

      app.UseAntiforgery();

      app.MapStaticAssets();
      app.MapRazorComponents<App>()
          .AddInteractiveServerRenderMode();

      app.Run();
    }
  }
}
