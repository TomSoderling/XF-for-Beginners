using System;
using System.Globalization;
using Xamarin.Forms;

namespace XFforBeginners.Converters
{
    [ValueConversion(typeof(DateTime), typeof(Color))]
    public class DateTimeToColorConverter : IValueConverter
    {
        // The Convert method is called when a value is transferred from source to target
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime == false)
            {
                return default(Color);
            }

            var theDate = (DateTime)value;

            if (theDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Color.Red;
            }
            else
            {
                return default(Color);
            }
        }

        // The ConvertBack method is called when a value is transferred from target back to source in OneWayToSource or TwoWay bindings
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return default(Color);
        }
    }
}