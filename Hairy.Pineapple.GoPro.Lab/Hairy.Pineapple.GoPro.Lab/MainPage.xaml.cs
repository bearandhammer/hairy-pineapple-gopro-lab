using Hairy.Pineapple.GoPro.Lab.DataAccess.Context;
using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Hairy.Pineapple.GoPro.Lab;

public partial class MainPage : ContentPage
{
	private readonly GoProLabDbContext dbContext;
	int count = 0;

	public MainPage(GoProLabDbContext dbContextType)
	{
		InitializeComponent();
		dbContext = dbContextType;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnTestDbClicked(object sender, EventArgs e)
	{
		try
		{
			#region Sample Code (pre-DI)

			using (GoProLabDbContext dbContext = new())
			{
				// Migrate
				dbContext.Database.Migrate();

				string samplePresetDescription = "hello world";

				// Add sample record, if one does not exist
				if (dbContext.PresetHeaders.Count() == 0)
				{
					dbContext.PresetHeaders.Add(new PresetHeader
					{
						Description = samplePresetDescription,
						UniqueId = Guid.NewGuid()
					});

					dbContext.SaveChanges();
				}

				// Retrieve sample
				PresetHeader discoveredPresetHeader = 
					dbContext.PresetHeaders.FirstOrDefault(ph => ph.Description.Equals(samplePresetDescription));

				if (discoveredPresetHeader is not null)
				{
					TestDbBtn.Text = "DB call succeeded";
				}
			}

			#endregion Sample Code (pre-DI)
		}
        catch (Exception ex)
		{
			TestDbBtn.Text = "DB call failed";
			Console.WriteLine(ex.Message);
		}
	}
}

