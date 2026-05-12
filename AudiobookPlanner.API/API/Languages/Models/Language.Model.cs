using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.API.Languages.Models
{
  public class Language
  {
    public int Id { get; set; }
    public string? LanguageName { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
