using System;
using System.Globalization;
using Xamarin.Forms;

namespace ImageButtonSample
{
    public class LockStateToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? "locked_100.png" : "unlocked_100.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
