using MauiApp4.Controls;
using Microsoft.Extensions.Logging;
#if ANDROID
using MauiApp4.Platforms.Android.Handlers;
#elif IOS
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
#if ANDROID
                handlers.AddHandler<JustifiedLabel, MyJustifiedLabelHandler>();
#elif IOS
                handlers.AddHandler(typeof(JustifiedLabel), typeof(MyJustifiedLabelHandler));
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