using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.API.DbModels;
using AudiobookPlanner.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.Data
{
  public class AudiobookPlannerContext : DbContext
  {
    public DbSet<Audiobook> Audiobooks { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Narrator> Narrators { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Series> Series { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public AudiobookPlannerContext(DbContextOptions<AudiobookPlannerContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(AudiobookPlannerContext).Assembly);
    }
  }
}
