using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Interfaces
{
    public interface IPresetHeaderRepo
    {
        Task<PresetHeader> DeletePresetHeaderByIdAsync(long id);

        Task<IEnumerable<PresetHeader>> GetAllPresetHeadersAsync();

        Task<PresetHeader> GetPresetHeaderByIdAsync(long id);
    }
}
