using CommunityToolkit.Maui.Sample.Pages.Views;
using Application = Microsoft.Maui.Controls.Application;

namespace CommunityToolkit.Maui.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	protected override void OnStart()
	{
		base.OnStart();
	}
}