using Android.OS;
using Android.Text;
using MauiApp4.Controls;
using Microsoft.Maui.Handlers;

namespace MauiApp4.Platforms.Android.Handlers;

public class MyJustifiedLabelHandler() : LabelHandler(PropertyMapper)
{
    private static readonly IPropertyMapper<JustifiedLabel, MyJustifiedLabelHandler> PropertyMapper = new PropertyMapper<JustifiedLabel, MyJustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = MapJustificationMode
    };

    public static void MapJustificationMode(ILabelHandler handler, ILabel label)
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.O) // O == API level 26.0
        {
            handler.PlatformView.JustificationMode = JustificationMode.InterWord;
        }
    }
}