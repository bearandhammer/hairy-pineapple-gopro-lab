using Hairy.Pineapple.GoPro.Lab.DataAccess.Constants;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Configuration
{
    public class PresetHeaderConfiguration : IEntityTypeConfiguration<PresetHeader>
    {
        public void Configure(EntityTypeBuilder<PresetHeader> builder)
        {
            // Define table name
            builder.ToTable(TableName.PresetHeaders);

            // Define table PK
            builder.HasKey(presetHeader => presetHeader.Id);

            // Define data type constraints
            builder.Property(presetHeader => presetHeader.Name)
                .IsRequired()
                .HasMaxLength(ColumnLength.StandardNameColumn);

            builder.Property(presetHeader => presetHeader.Description)
                .IsRequired()
                .HasMaxLength(ColumnLength.StandardDescriptionColumn);

            builder.Property(presetHeader => presetHeader.CreationDateTimeUtc)
                .IsRequired()
                .HasDefaultValueSql("DATETIME('now')");        
        }
    }
}
