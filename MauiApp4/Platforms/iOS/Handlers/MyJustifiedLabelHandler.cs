using MauiApp4.Controls;
using Microsoft.Maui.Handlers;
using UIKit;

namespace MauiApp4.Platforms.iOS.Handlers;

public class MyJustifiedLabelHandler() : LabelHandler(PropertyMapper)
{
    private static readonly IPropertyMapper<JustifiedLabel, MyJustifiedLabelHandler> PropertyMapper = new PropertyMapper<JustifiedLabel, MyJustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = MapTextAlignment
    };

    public static void MapTextAlignment(ILabelHandler handler, ILabel label)
    {
        if (label is JustifiedLabel { JustifyText: true })
        {
            handler.PlatformView.TextAlignment = UITextAlignment.Justified;
        }
    }
}