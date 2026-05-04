using AudiobookPlanner.Blazor.Application.Views.Audiobooks;

namespace AudiobookPlanner.Blazor.Application.Models
{
  public class Rating
  {
    public int Id { get; set; }
    public string? Source { get; set; }
    public double RatingAvg { get; set; }
    public int RatingCount { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
