using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.Dtos
{
  public class AuthorDto
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
