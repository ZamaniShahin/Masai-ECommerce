using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.SlideAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class SlideMapping : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {

            builder.ToTable("Slides");
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x=>x.PictureAlt).HasMaxLength(1000).IsRequired();
            builder.Property(x=>x.PictureTitle).HasMaxLength(1000).IsRequired();
        }
    }
}