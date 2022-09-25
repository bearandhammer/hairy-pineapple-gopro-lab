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
        private readonly IPresetHeaderRepo presetHeaderRepo;

        // TODO - change to a domain model
        public ObservableCollection<PresetHeader> PresetHeaders { get; set; } = new ObservableCollection<PresetHeader>();

        public int PresetHeaderCount => PresetHeaders.Count;

        public MainPageViewModel(IPresetHeaderRepo presetHeaderRepoType)
        {
            presetHeaderRepo = presetHeaderRepoType;

            LoadPresetHeaders();
        }

        private void LoadPresetHeaders()
        {
            try
            {
                Task runningTask = Task.Run(async () =>
                {
                    IEnumerable<PresetHeader> presetHeaders = await presetHeaderRepo.GetAllPresetHeadersAsync();

                    if (presetHeaders is not null)
                    {
                        foreach (PresetHeader presetHeaderItem in presetHeaders)
                        {
                            PresetHeaders.Add(presetHeaderItem);
                        }

                        OnPropertyChanged(nameof(PresetHeaders));
                    }
                });

                runningTask.Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
