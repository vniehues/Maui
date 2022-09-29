namespace Bla.Views.Popups;

public partial class LoadingPopup : CommunityToolkit.Maui.Views.Popup
{
	public LoadingPopup()
	{
		InitializeComponent();

		verticalStackLayout.Loaded += (s, e) =>
		{
			if (verticalStackLayout.Window is null)
			{
				_ = true;
			}

			verticalStackLayout.BackgroundColor = Colors.Red;
		};

		label.Loaded += (s, e) =>
		{
			label.Text = "label.Loaded FIRE";
		};

		Content!.Loaded += (s, e) =>
		{
			Content.BackgroundColor = Colors.Green;
		};

		Content!.Unloaded += (s, e) =>
		{
			if (Content?.Window is null)
			{
				_ = true;
			}
		};
	}

    void chkDismiss_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		if (chkDismiss.IsChecked)
		{
			CanBeDismissedByTappingOutsideOfPopup = true;
		}
		else
		{
			CanBeDismissedByTappingOutsideOfPopup = false;
		}
	}

	private void label_Clicked(object sender, EventArgs e)
	{
		this.Close();
	}
}
