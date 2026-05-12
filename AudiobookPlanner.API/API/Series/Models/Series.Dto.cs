using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.API.Series.Models
{
  public class SeriesDto
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
  }
}
