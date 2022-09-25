using Hairy.Pineapple.GoPro.Lab.DataAccess.Context;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Interfaces;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Repos
{
    public class PresetHeaderRepo : IPresetHeaderRepo
    {
        private readonly GoProLabDbContext appDbContext;

        public PresetHeaderRepo(GoProLabDbContext dbContextType)
        {
            appDbContext = dbContextType;
        }

        public Task<PresetHeader> DeletePresetHeaderByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PresetHeader>> GetAllPresetHeadersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PresetHeader> GetPresetHeaderByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
