namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Entities
{
    public class PresetHeader
    {
        public int Id { get; set; }

        public Guid UniqueId { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
