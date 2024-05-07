using MauiApp4.Controls;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
#if ANDROID
using MauiApp4.Platforms.Android.Handlers;
using MauiApp4.Renderers;
#elif IOS
using MauiApp4.Platforms.iOS.Handlers;
using MauiApp4.Renderers;
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
                handlers.AddHandler(typeof(AppShell), typeof(MyShellRenderer));
#elif IOS
                handlers.AddHandler(typeof(JustifiedLabel), typeof(MyJustifiedLabelHandler));
                handlers.AddHandler(typeof(AppShell), typeof(MyShellRenderer));
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

#if IOS
        LabelHandler.Mapper.AppendToMapping(nameof(ITextAlignment.HorizontalTextAlignment), (handler, view) =>
        {
            MyJustifiedLabelHandler.MapTextAlignment(handler, view);

        });
#endif  
        
        return builder.Build();
    }
}