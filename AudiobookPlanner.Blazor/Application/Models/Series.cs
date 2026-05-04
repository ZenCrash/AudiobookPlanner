using AudiobookPlanner.Blazor.Application.Views.Audiobooks;

namespace AudiobookPlanner.Blazor.Application.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
