using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace MauiApp4.Renderers;

public class MyTabLayoutAppearanceTracker : ShellTabLayoutAppearanceTracker
{
    public MyTabLayoutAppearanceTracker(IShellContext shellContext) : base(shellContext)
    {
    }

    public override void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
    {
        base.SetAppearance(tabLayout, appearance);
        tabLayout.TabGravity = TabLayout.GravityFill;
        tabLayout.TabMode = TabLayout.ModeFixed;
    }
}