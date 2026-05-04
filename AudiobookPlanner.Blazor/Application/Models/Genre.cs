using AudiobookPlanner.Blazor.Application.Views.Audiobooks;

namespace AudiobookPlanner.Blazor.Application.Models
{
  public class Genre
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
