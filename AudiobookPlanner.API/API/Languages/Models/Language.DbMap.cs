using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AudiobookPlanner.API.API.Languages.Models
{
  public class LanguageDbMap : IEntityTypeConfiguration<Language>
  {
    public void Configure(EntityTypeBuilder<Language> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.LanguageName)
        .HasMaxLength(200)
        .IsRequired();

      /* Many to Many - relationships */

      //Audiobooks
      builder
        .HasMany(x => x.Audiobooks)
        .WithMany(x => x.Languages);
    }
  }
}
