using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace StarPan.Model
{
    public class DateTimeConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            DateTime date = (DateTime)value;
            return date.ToString("yyyy-MM-dd HH:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;
            DateTime txtDate;
            if (DateTime.TryParse(str, out txtDate))
            {
                return txtDate;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
