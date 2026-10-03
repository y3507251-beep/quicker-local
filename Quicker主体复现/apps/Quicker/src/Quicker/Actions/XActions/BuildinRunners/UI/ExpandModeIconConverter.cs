using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Actions.XActions.BuildinRunners.UI;

public class ExpandModeIconConverter : IValueConverter
{
	private static ExpandModeIconConverter yCySqFQ4kQyySLC0hDFw;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return null;
		}
		return (ExpandMode)value switch
		{
			ExpandMode.Expanded => "fa:Light_ChevronDown", 
			ExpandMode.Collapsed => "fa:Light_ChevronUp", 
			ExpandMode.Auto => "fa:Light_ChevronRight", 
			_ => "", 
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool e2DGDFQ4a21M7amsxg5c()
	{
		return yCySqFQ4kQyySLC0hDFw == null;
	}
}
