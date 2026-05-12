using AudiobookPlanner.API.API.Audiobooks.Models;
using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Genres.Models
{
  [Mapper]
  public static partial class GenreMapper
  {
    /* To Model */
    public static partial Genre ToModel(this GenreDto dto);
    public static partial void ToModel(this GenreDto source, Genre target);

    /* To Dto */
    public static partial GenreDto ToDto(this Genre model);
    public static partial ICollection<GenreDto> ToDtos(this ICollection<Genre> models);
  }
}
