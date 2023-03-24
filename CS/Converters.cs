using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailBottomSheet
{

    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            AppTheme currentTheme = Application.Current.RequestedTheme;
            if (value == null) return null;
            OrderStatus status = (OrderStatus)value;
            if (currentTheme == AppTheme.Light)
            {
                switch (status)
                {
                    case OrderStatus.New:
                        return Color.FromArgb("#60BA07");
                    case OrderStatus.Shipping:
                        return Color.FromArgb("#55ABDC");
                    case OrderStatus.Finished:
                        return Color.FromArgb("#3CAB76");
                    case OrderStatus.Cancelled:
                        return Color.FromArgb("#D46E60");
                }
            }
            else{
                switch (status)
                {
                    case OrderStatus.New:
                        return Color.FromArgb("#A0CD73");
                    case OrderStatus.Shipping:
                        return Color.FromArgb("#8FC3E0");
                    case OrderStatus.Finished:
                        return Color.FromArgb("#67C596");
                    case OrderStatus.Cancelled:
                        return Color.FromArgb("#D88074");
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
