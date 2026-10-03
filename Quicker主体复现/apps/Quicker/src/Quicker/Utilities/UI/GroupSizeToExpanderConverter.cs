using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class GroupSizeToExpanderConverter : IValueConverter
{
	private static GroupSizeToExpanderConverter Hh03akFhUKaVRPLHSmnB;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return ((CollectionViewGroup)value).Items.Count() > 1;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool cQMGXJFhx4srg7jBaPnF()
	{
		return Hh03akFhUKaVRPLHSmnB == null;
	}
}
