using AudiobookPlanner.API.API.Audiobooks.Models;
using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Publishers.Models
{
  [Mapper]
  public static partial class PublisherMapper
  {
    /* To Model */
    public static partial Publisher ToModel(this PublisherDto dto);
    public static partial void ToModel(this PublisherDto source, Publisher target);

    /* To Dto */
    public static partial PublisherDto ToDto(this Publisher model);
    public static partial ICollection<PublisherDto> ToDtos(this ICollection<Publisher> models);
  }
}
