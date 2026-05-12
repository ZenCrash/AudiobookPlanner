using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.API.Genres.Models
{
  public class Genre
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
