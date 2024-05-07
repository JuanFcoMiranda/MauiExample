using CoreGraphics;
using Microsoft.Maui.Controls.Platform.Compatibility;
using UIKit;

namespace MauiApp4.Renderers;

public class MyiOSTabBarAppearanceTracker : ShellTabBarAppearanceTracker, IShellTabBarAppearanceTracker
{
    void IShellTabBarAppearanceTracker.SetAppearance(UITabBarController controller, ShellAppearance appearance)
    {
        var width = DeviceDisplay.Current.MainDisplayInfo.Width;
        controller.TabBar.Frame = new CGRect(0, 0, width, 49);
        controller.TabBar.ItemWidth = (float)(width / 3.0);
        controller.TabBar.ItemPositioning = UITabBarItemPositioning.Fill;
    }
}