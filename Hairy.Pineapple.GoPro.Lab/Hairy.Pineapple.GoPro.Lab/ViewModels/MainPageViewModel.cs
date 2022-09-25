using Hairy.Pineapple.GoPro.Lab.DataAccess.Context;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Interfaces;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Repos;
using Hairy.Pineapple.GoPro.Lab.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Hairy.Pineapple.GoPro.Lab.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        //private readonly PresetHeaderRepo presetHeaderRepo;

        // TODO - change to a domain model
        public ObservableCollection<PresetHeader> PresetHeaders { get; set; } = new ObservableCollection<PresetHeader>();

        public int PresetHeaderCount => PresetHeaders.Count;

        //public MainPageViewModel(PresetHeaderRepo presetHeaderRepoType)
        public MainPageViewModel()
        {
            LoadPresetHeaders();
        }

        private async void LoadPresetHeaders()
        {
            try
            {
                // TODO: Remove temp code and fix DI
                using (GoProLabDbContext appDbContext = new GoProLabDbContext())
                {
                    IPresetHeaderRepo repo = new PresetHeaderRepo(appDbContext);

                    IEnumerable<PresetHeader> presetHeaders = await repo.GetAllPresetHeadersAsync();

                    if (presetHeaders is not null)
                    {
                        foreach (PresetHeader presetHeaderItem in presetHeaders)
                        {
                            PresetHeaders.Add(presetHeaderItem);
                        }

                        OnPropertyChanged(nameof(PresetHeaders));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
