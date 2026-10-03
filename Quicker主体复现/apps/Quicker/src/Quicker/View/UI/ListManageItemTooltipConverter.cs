using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.View.UI;

public class ListManageItemTooltipConverter : IValueConverter
{
	internal static ListManageItemTooltipConverter TNa6loFE8Ohqjup72xjk;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is SimpleOperationItem simpleOperationItem))
		{
			return null;
		}
		return "值：" + simpleOperationItem.Key + "\r\n提示内容：" + simpleOperationItem.Description + "\r\n原始文本：" + simpleOperationItem.OriginText;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool EvSUdoFER8kXeFp7C9nK()
	{
		return TNa6loFE8Ohqjup72xjk == null;
	}
}
