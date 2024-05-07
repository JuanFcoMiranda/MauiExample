using MauiApp4;
using MauiApp4.Renderers;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using UIKit;

[assembly: ExportRenderer(typeof(AppShell), typeof(MyShellRenderer))]

namespace MauiApp4.Renderers;

public class MyShellRenderer : ShellRenderer
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="shellSection"></param>
    /// <returns></returns>
    protected override IShellSectionRenderer CreateShellSectionRenderer(ShellSection shellSection)
    {
        var renderer = base.CreateShellSectionRenderer(shellSection);
        (renderer as ShellSectionRenderer)?.NavigationBar.SetBackgroundImage(UIImage.FromFile("monkey.png"), UIBarMetrics.Default);
        return renderer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker() => new MyiOSTabBarAppearanceTracker();
}