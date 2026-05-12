using Riok.Mapperly.Abstractions;

namespace AudiobookPlanner.API.API.Authors.Models
{
  [Mapper]
  public static partial class AuthorMapper
  {
    /* To Model */
    public static partial Author ToModel(this AuthorDto dto);
    public static partial void ToModel(this AuthorDto source, Author target);

    /* To Dto */
    public static partial AuthorDto ToDto(this Author model);
    public static partial ICollection<AuthorDto> ToDtos(this ICollection<Author> models);
  }
}
