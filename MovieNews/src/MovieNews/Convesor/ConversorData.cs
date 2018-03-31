using System;
using System.Globalization;
using Xamarin.Forms;

namespace MovieNews.Convesor
{
    public class ConversorData:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTimeOffset dt = (DateTimeOffset)value;

            return dt.ToString("dd/mm/yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

       
    }
}