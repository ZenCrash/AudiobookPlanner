using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Application.Dtos
{
  public class NarratorDto
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
