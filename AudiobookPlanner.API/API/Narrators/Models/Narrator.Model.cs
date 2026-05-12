using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.API.Narrators.Models
{
  public class Narrator
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
