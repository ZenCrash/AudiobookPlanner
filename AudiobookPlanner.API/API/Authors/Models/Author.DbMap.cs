using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AudiobookPlanner.API.API.Authors.Models
{
  public class AuthorDbMap : IEntityTypeConfiguration<Author>
  {
    public void Configure(EntityTypeBuilder<Author> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name)
        .HasMaxLength(200)
        .IsRequired();

      /* Many to Many - relationships */

      //Audiobooks
      builder
        .HasMany(x => x.Audiobooks)
        .WithMany(x => x.Authors);
    }
  }
}
