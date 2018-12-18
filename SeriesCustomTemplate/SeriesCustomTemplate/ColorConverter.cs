using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SeriesCustomTemplate
{
    public class BubbleInteriorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as ChartSegment;

            if (segment != null)
            {
                if ((segment.Item as Model).Size > 30)
                {
                    return new SolidColorBrush(Colors.Red);
                }
                else
                {
                    return new SolidColorBrush(Colors.Green);
                }

            }

            return new SolidColorBrush(Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BubbleAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as BubbleSegment;

            if (segment != null)
            {
                if ((segment.Item as Model).Count > 20)
                {
                    return 180;
                }
                else
                {
                    return 360;
                }
            }

            return 360;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StepLineInteriorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as StepLineSegment;

            if (segment.YData > 25)
                return new SolidColorBrush(Colors.Red);
            else
                return new SolidColorBrush(Colors.Blue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class StepLineDashesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as StepLineSegment;

            if (segment.YData > 25)
                return new DoubleCollection { 2, 3 };
            else
                return new DoubleCollection { 2, 0 };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class ScatterInteriorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as ChartSegment;

            if (segment != null)
            {
                if ((segment.Item as Model).Count > 20)
                {
                    return new SolidColorBrush(Colors.Black);
                }
                else
                {
                    return new SolidColorBrush(Colors.Gray);
                }

            }

            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ScatterAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as BubbleSegment;

            if (segment != null)
            {
                if ((segment.Item as Model).Count > 20)
                {
                    return 180;
                }
                else
                {
                    return 360;
                }

            }

            return 360;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SplineColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value as Syncfusion.UI.Xaml.Charts.LineSegment).YData > 20)
                return new SolidColorBrush(Colors.Red);
            else
                return new SolidColorBrush(Colors.Blue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
