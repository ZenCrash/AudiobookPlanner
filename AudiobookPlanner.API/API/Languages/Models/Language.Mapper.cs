using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Languages.Models
{
  [Mapper]
  public static partial class LanguageMapper
  {
    /* To Model */
    public static partial Language ToModel(this LanguageDto dto);
    public static partial void ToModel(this LanguageDto source, Language target);

    /* To Dto */
    public static partial LanguageDto ToDto(this Language model);
    public static partial ICollection<LanguageDto> ToDtos(this ICollection<Language> models);
  }
}
