using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.Dtos
{
  public class RatingDto
  {
    public int Id { get; set; }
    public string? Source { get; set; }
    public double RatingAvg { get; set; }
    public int RatingCount { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
