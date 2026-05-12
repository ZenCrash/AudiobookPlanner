using AudiobookPlanner.API.API.Audiobooks.Models;
using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Series.Models
{
  [Mapper]
  public static partial class SeriesMapper
  {
    /* To Model */
    public static partial Series ToModel(this SeriesDto dto);
    public static partial void ToModel(this SeriesDto source, Series target);

    /* To Dto */
    public static partial SeriesDto ToDto(this Series model);
    public static partial ICollection<SeriesDto> ToDtos(this ICollection<Series> models);
  }
}
