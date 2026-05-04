using AudiobookPlanner.Blazor.Application.Views.Audiobooks;

namespace AudiobookPlanner.Blazor.Application.Models
{
  public class Narrator
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
