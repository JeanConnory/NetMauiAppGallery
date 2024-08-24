using System.Globalization;

namespace AppMauiGallery.Views.Utils.Converters;

public class MoreThanZeroConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var valueInt = (int)value;
        return valueInt > 0 ? true : false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
