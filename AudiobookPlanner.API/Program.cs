using AudiobookPlanner.API.API.Audiobooks.Resources;
using AudiobookPlanner.API.Data;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Resources;

namespace AudiobookPlanner.API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);


      // Add services to the container.

      builder.Services.AddControllers();

      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      //Localization
      builder.Services.AddLocalization();
      builder.Services.AddSingleton<IStringLocalizer<Localization>, StringLocalizer<Localization>>();

      //DbContext
      builder.Services.AddDbContext<AudiobookPlannerContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

      //Project Services
      builder.Services.AddManagers();

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      //Localization
      var localizationSection = builder.Configuration.GetSection("Localization");
      var supportedCultures = localizationSection.GetSection("SupportedCultures").Get<string[]>();
      var localizationOptions = new RequestLocalizationOptions
      {
        DefaultRequestCulture = new RequestCulture(localizationSection["DefaultCulture"]),
        SupportedCultures = supportedCultures.Select(c => new CultureInfo(c)).ToList(),
        SupportedUICultures = supportedCultures.Select(c => new CultureInfo(c)).ToList(),
      };
      app.UseRequestLocalization(localizationOptions);

      app.UseAuthorization();

      app.MapControllers();

      app.Run();
    }
  }
}
