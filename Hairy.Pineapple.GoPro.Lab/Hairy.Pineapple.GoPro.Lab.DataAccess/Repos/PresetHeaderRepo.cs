using Hairy.Pineapple.GoPro.Lab.DataAccess.Context;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Repos
{
    public class PresetHeaderRepo : IPresetHeaderRepo
    {
        private readonly GoProLabDbContext appDbContext;

        public PresetHeaderRepo(GoProLabDbContext dbContextType)
        {
            appDbContext = dbContextType;
        }

        public async Task<PresetHeader?> DeletePresetHeaderByIdAsync(long id)
        {
            PresetHeader? presetHeaderToDelete = await GetPresetHeaderByIdAsync(id);

            if (presetHeaderToDelete is not null)
            {
                appDbContext.PresetHeaders.Remove(presetHeaderToDelete);
                await appDbContext.SaveChangesAsync();
            }

            return presetHeaderToDelete;
        }

        public async Task<IEnumerable<PresetHeader>> GetAllPresetHeadersAsync() =>
            await appDbContext.PresetHeaders.ToListAsync();

        public async Task<PresetHeader?> GetPresetHeaderByIdAsync(long id) =>
            await appDbContext.PresetHeaders.FindAsync(id);
    }
}
