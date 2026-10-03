using System;
using System.Globalization;
using System.Windows.Data;
using WindowsInput.Native;

namespace Quicker.Utilities.UI;

public class VirtualKeyCodeNameConverter : IValueConverter
{
	internal static VirtualKeyCodeNameConverter aaQn7vFhVJB51K1pTkGm;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return "";
		}
		return KeyboardHelper.GetKeyName((VirtualKeyCode)value);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool uL2xtMFhQw9vPcYmF6JL()
	{
		return aaQn7vFhVJB51K1pTkGm == null;
	}
}
