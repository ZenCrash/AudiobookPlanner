using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.Dtos
{
  public class GenreDto
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
