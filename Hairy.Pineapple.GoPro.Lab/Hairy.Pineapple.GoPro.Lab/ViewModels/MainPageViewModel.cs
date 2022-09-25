using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Repos;
using Hairy.Pineapple.GoPro.Lab.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Hairy.Pineapple.GoPro.Lab.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly PresetHeaderRepo presetHeaderRepo;

        // TODO - change to a domain model
        public ObservableCollection<PresetHeader> PresetHeaders { get; set; } = new ObservableCollection<PresetHeader>();

        public MainPageViewModel(PresetHeaderRepo presetHeaderRepoType)
        {
            presetHeaderRepo = presetHeaderRepoType;

            LoadPresetHeaders();
        }

        private async void LoadPresetHeaders()
        {
            IEnumerable<PresetHeader> presetHeaders = await presetHeaderRepo.GetAllPresetHeadersAsync();

            if (presetHeaders is not null)
            {
                foreach (PresetHeader presetHeaderItem in presetHeaders)
                {
                    PresetHeaders.Add(presetHeaderItem);
                }
            }
        }
    }
}
