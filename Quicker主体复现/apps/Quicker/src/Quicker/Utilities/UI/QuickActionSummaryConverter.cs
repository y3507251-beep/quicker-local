using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Common.QuickActions;
using Quicker.Domain.QuickActions;

namespace Quicker.Utilities.UI;

public class QuickActionSummaryConverter : IValueConverter
{
	private static QuickActionSummaryConverter SvCCX3F4so23kiSPxMeu;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		try
		{
			if (value is IQuickActionItem actionItem)
			{
				string text = actionItem.GetSummary();
				if (!string.IsNullOrEmpty(text))
				{
					text = text.Replace("\r\n", " ").Replace("\n", " ");
				}
				return text;
			}
			return "ERR!";
		}
		catch (Exception)
		{
			return "ERR!";
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool wntQLEF4CyLfV2wopqXF()
	{
		return SvCCX3F4so23kiSPxMeu == null;
	}
}
