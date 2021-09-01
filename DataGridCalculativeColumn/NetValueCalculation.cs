using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataGridCalculativeColumn
{
    //public class NetValueCalculation : IMultiValueConverter
    //{
    //    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (values != null)
    //        {

    //            decimal NetStock = (short)values[0] * (short)values[1];
    //            return NetStock.ToString();
    //        }
    //        return "";
    //    }

    //    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class NetValueCalculation : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Product product = value as Product;
            decimal? NetStock = product.UnitPrice * product.UnitsInStock;
            return NetStock.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
