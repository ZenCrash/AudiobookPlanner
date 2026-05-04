using AudiobookPlanner.Blazor.Application.Models;

namespace AudiobookPlanner.Blazor.Application.Dtos
{
  public class LanguageDto
  {
    public int Id { get; set; }
    public string? LanguageName { get; set; }
    public ICollection<AudiobookDto> Audiobooks { get; set; } = [];
  }
}
