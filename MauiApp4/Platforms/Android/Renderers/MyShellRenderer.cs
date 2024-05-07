using MauiApp4;
using MauiApp4.Renderers;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

[assembly: ExportRenderer(typeof(AppShell), typeof(MyShellRenderer))]

namespace MauiApp4.Renderers;

public class MyShellRenderer : ShellRenderer
{
    protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection) => new MyTabLayoutAppearanceTracker(this);
}