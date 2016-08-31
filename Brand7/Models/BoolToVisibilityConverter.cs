using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Brand7
{
    /// <summary>
    /// 值转换器：布尔值转换为Visibility
    /// </summary>
    class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
