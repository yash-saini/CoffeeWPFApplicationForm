using CustomersCoffeeApp.ViewModel;
using System.Globalization;
using System.Windows.Data;

namespace CustomersCoffeeApp.Converter
{
    internal class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navSide = (CustomersViewModel.NavigationDirection)value;
            return navSide switch
            {
                CustomersViewModel.NavigationDirection.Left => 0,
                CustomersViewModel.NavigationDirection.Right => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(value))
            };
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
