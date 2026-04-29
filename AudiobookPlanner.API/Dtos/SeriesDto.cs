using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.Dtos
{
  public class SeriesDto
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
