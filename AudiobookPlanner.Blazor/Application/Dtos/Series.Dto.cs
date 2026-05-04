using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Application.Dtos
{
  public class SeriesDto
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
