using AudiobookPlanner.API.API.Audiobooks.Models;

namespace AudiobookPlanner.API.API.Publishers.Models
{
  public class Publisher
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Audiobook> Audiobooks { get; set; } = [];
  }
}
