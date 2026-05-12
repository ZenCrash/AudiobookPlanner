using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Narrators.Models
{
  [Mapper]
  public static partial class NarratorMapper
  {
    /* To Model */
    public static partial Narrator ToModel(this NarratorDto dto);
    public static partial void ToModel(this NarratorDto source, Narrator target);

    /* To Dto */
    public static partial NarratorDto ToDto(this Narrator model);
    public static partial ICollection<NarratorDto> ToDtos(this ICollection<Narrator> models);
  }
}
