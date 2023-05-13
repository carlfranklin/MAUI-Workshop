using System.Globalization;

namespace MyMauiApp;

public class DateToColorValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var date = (DateTime)value;
        Color color = null;

        switch (date.Month)
        {
            case 0:
                color = Colors.Snow;
                break;
            case 1:
                color = Colors.AliceBlue;
                break;
            case 2:
                color = Colors.LightYellow;
                break;
            case 3:
                color = Colors.GreenYellow;
                break;
            case 4:
                color = Colors.YellowGreen;
                break;
            case 5:
                color = Colors.Green;
                break;
            case 6:
                color = Colors.IndianRed;
                break;
            case 7:
                color = Colors.Red;
                break;
            case 8:
                color = Colors.Orange;
                break;
            case 9:
                color = Colors.DarkOrange;
                break;
            case 10:
                color = Colors.SandyBrown;
                break;
            case 11:
                color = Colors.Tan;
                break;
        }
        return color;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
