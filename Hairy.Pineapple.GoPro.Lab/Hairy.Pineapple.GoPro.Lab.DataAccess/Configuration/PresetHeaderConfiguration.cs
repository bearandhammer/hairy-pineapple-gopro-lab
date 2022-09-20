using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Configuration
{
    public class PresetHeaderConfiguration : IEntityTypeConfiguration<PresetHeader>
    {
        public void Configure(EntityTypeBuilder<PresetHeader> builder)
        {
            builder.HasKey(presetHeader => presetHeader.Id);

            builder
                .HasIndex(presetHeader => presetHeader.UniqueId)
                .IsUnique();
        }
    }
}
