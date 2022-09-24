namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models
{
    public class PresetHeader
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreationDateTimeUtc { get; set; } = DateTime.UtcNow;
    }
}
