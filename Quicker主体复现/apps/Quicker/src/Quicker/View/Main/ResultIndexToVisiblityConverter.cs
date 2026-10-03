using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Quicker.View.Main;

public class ResultIndexToVisiblityConverter : IValueConverter
{
	private static ResultIndexToVisiblityConverter KZCDI8F1QiYC37IK0FWL;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return Visibility.Collapsed;
		}
		try
		{
			int num = ((!(value is int)) ? System.Convert.ToInt32(value) : ((int)value));
			return (num >= 9) ? Visibility.Collapsed : Visibility.Visible;
		}
		catch
		{
			return Visibility.Collapsed;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool T2tDacF1Ffev4BPLAdA1()
	{
		return KZCDI8F1QiYC37IK0FWL == null;
	}
}
