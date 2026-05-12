using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AudiobookPlanner.API.API.Publishers.Models
{
  public class PublisherDbMap : IEntityTypeConfiguration<Publisher>
  {
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name)
        .HasMaxLength(200)
        .IsRequired();

      /* Many to One - relationships */

      //Audiobooks
      builder
        .HasMany(p => p.Audiobooks)
        .WithOne(a => a.Publisher);
    }
  }
}
