using CommunityToolkit.Maui.Views;
using Bla.Views.Popups;

namespace Bla;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		this.ShowPopupAsync(new LoadingPopup()
		{

		});
    }
}


