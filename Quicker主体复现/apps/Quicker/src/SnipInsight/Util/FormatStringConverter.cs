using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace SnipInsight.Util;

public class FormatStringConverter : IValueConverter
{
	[CompilerGenerated]
	private string Yf63K208O;

	internal static FormatStringConverter alCCihW9uugvh9VK12P;

	public string FormatString
	{
		[CompilerGenerated]
		get
		{
			return Yf63K208O;
		}
		[CompilerGenerated]
		set
		{
			Yf63K208O = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string format = FormatString ?? (parameter as string);
		return string.Format(CultureInfo.InvariantCulture, format, value);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool eh5AU4WLjb0IX8rR5KW()
	{
		return alCCihW9uugvh9VK12P == null;
	}
}
