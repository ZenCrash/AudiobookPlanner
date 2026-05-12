using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Audiobooks.Models
{
  [Mapper]
  public static partial class AudiobookMapper
  {
    /* To Model */
    public static partial Audiobook ToModel(this AudiobookDto dto);
    public static partial void ToModel(this AudiobookDto source, Audiobook target);

    /* To Dto */
    public static partial AudiobookDto ToDto(this Audiobook model);
    public static partial ICollection<AudiobookDto> ToDtos(this ICollection<Audiobook> models);
  }
}
