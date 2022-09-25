using Hairy.Pineapple.GoPro.Lab.DataAccess.Context;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Interfaces;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Repos;
using Hairy.Pineapple.GoPro.Lab.ViewModels;

namespace Hairy.Pineapple.GoPro.Lab;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddDbContext<GoProLabDbContext>();
		builder.Services.AddSingleton<IPresetHeaderRepo, PresetHeaderRepo>();
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
