using AudiobookPlanner.Blazor.Components;

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
      builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri("https://localhost:5234/") });

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
