using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Platform;

namespace CommunityToolkit.Maui.Views;

/// <summary>
/// Extension methods for <see cref="Popup"/>.
/// </summary>
public static partial class PopupExtensions
{
	static void PlatformShowPopup(Popup popup, IMauiContext mauiContext)
	{
		var window = mauiContext.GetPlatformWindow().GetWindow() ?? throw new NullReferenceException("Window is null.");
		
		var page = ((Page)window.Content).GetCurrentPage();
		page.InternalChildren.Add(popup);
		popup.Parent = page;
		//if (popup.Content is not null)
		//{
		//	popup.Content.Parent = popup;
		//}
		var platform = popup.ToHandler(mauiContext);
		platform?.Invoke(nameof(IPopup.OnOpened));
		var x = page.InternalChildren;
	}

	static Task<object?> PlatformShowPopupAsync(Popup popup, IMauiContext mauiContext)
	{
		PlatformShowPopup(popup, mauiContext);
		return popup.Result;
	}
}