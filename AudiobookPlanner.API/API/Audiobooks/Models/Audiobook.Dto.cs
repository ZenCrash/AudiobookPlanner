using AudiobookPlanner.API.DbModels;
using AudiobookPlanner.API.Dtos;
using AudiobookPlanner.DataAccess.Models;

namespace AudiobookPlanner.API.API.Audiobooks.Models
{
  public class AudiobookDto
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? BookNo { get; set; }
    public string? Description { get; set; }
    public int LengthInMinutes { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public int? PublisherId { get; set; }
    public PublisherDto? Publisher { get; set; }
    public int? SeriesId { get; set; }
    public SeriesDto? Series { get; set; }
    public ICollection<AuthorDto> Authors { get; set; } = [];
    public ICollection<NarratorDto> Narrators { get; set; } = [];
    public ICollection<LanguageDto> Languages { get; set; } = [];
    public ICollection<GenreDto> Genres { get; set; } = [];
    public ICollection<TagDto> Tags { get; set; } = [];
    public ICollection<RatingDto> Ratings { get; set; } = [];
  }
}
