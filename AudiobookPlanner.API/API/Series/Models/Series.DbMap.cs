using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AudiobookPlanner.API.API.Series.Models
{
  public class SeriesDbMap : IEntityTypeConfiguration<Series>
  {
    public void Configure(EntityTypeBuilder<Series> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Title)
        .HasMaxLength(200)
        .IsRequired();
      builder.Property(x => x.Description)
        .HasMaxLength(2000);

      /* Many to Many - relationships */

      //Audiobooks
      builder
        .HasMany(x => x.Audiobooks)
        .WithOne(x => x.Series);
    }
  }
}
