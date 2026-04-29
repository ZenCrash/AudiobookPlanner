using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.Dtos
{
  public class LanguageDto
  {
    public int Id { get; set; }
    public string? LanguageName { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
