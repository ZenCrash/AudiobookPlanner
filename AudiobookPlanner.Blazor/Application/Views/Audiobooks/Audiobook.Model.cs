using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Application.Views.Audiobooks
{
  public class Audiobook
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? BookNo { get; set; }
    public string? Description { get; set; }
    public int LengthInMinutes { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public int? PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public int? SeriesId { get; set; }
    public Series? Series { get; set; }
    public ICollection<Author> Authors { get; set; } = [];
    public ICollection<Narrator> Narrators { get; set; } = [];
    public ICollection<Language> Languages { get; set; } = [];
    public ICollection<Genre> Genres { get; set; } = [];
    public ICollection<Tag> Tags { get; set; } = [];
    public ICollection<Rating> Ratings { get; set; } = [];
  }
}
