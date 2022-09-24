namespace Hairy.Pineapple.GoPro.Lab;

public partial class App : Application
{
	public App(MainPage mainPageType)
	{
		InitializeComponent();

		MainPage = mainPageType;
	}
}
