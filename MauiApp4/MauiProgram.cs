using MauiApp4.Controls;
using Microsoft.Extensions.Logging;

#if IOS
using MauiApp4.Platforms.iOS.Handlers;
#endif

namespace MauiApp4;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiHandlers(handlers =>
            {
#if IOS
                handlers.AddHandler(typeof(JustifiedLabel), typeof(MyJustifiedLabelHandler));
                // handlers.AddHandler(typeof(AppShell), typeof(CustomSlideTabRenderer));
#endif
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}