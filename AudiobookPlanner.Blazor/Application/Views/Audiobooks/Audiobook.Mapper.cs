using AudiobookPlanner.Blazor.Application.Dtos;
using AudiobookPlanner.Blazor.Application.Models;
using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.Blazor.Application.Views.Audiobooks
{
  [Mapper]
  public static partial class AudiobookMapper
  {
    /* To Model */
    public static partial Audiobook ToModel(this AudiobookDto dto);
    public static partial void ToModel(this AudiobookDto source, Audiobook target);
    public static partial ICollection<Audiobook> ToModels(this ICollection<AudiobookDto> dtos);

    /* To Dto */
    public static partial AudiobookDto ToDto(this Audiobook model);
    public static partial ICollection<AudiobookDto> ToDtos(this ICollection<Audiobook> models);

  }
}
