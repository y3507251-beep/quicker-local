using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Common.QuickActions;
using Quicker.Domain.QuickActions;

namespace Quicker.Utilities.UI;

public class LongPressActionSummaryConverter : IValueConverter
{
	internal static LongPressActionSummaryConverter q2yP3bF7T6SSs0ScNEWu;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is PowerKeyActionItem powerKeyActionItem)
		{
			return powerKeyActionItem.CreateLongPressTempItem().GetSummary();
		}
		return "ERR!";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool sMlBDhF7mCbshiVRIxxh()
	{
		return q2yP3bF7T6SSs0ScNEWu == null;
	}
}
