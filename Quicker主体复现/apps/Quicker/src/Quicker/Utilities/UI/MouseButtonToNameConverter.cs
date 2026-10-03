using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Forms;

namespace Quicker.Utilities.UI;

internal class MouseButtonToNameConverter : IValueConverter
{
	private static MouseButtonToNameConverter uXKtWeF7CeqINRZhZ6un;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is MouseButtons mouseButtons_)
		{
			return wXGvSu4mqE4(mouseButtons_);
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	private static string wXGvSu4mqE4(MouseButtons mouseButtons_0)
	{
		if (mouseButtons_0 <= MouseButtons.Right)
		{
			switch (mouseButtons_0)
			{
			case MouseButtons.Right:
				return "右键";
			case MouseButtons.Left:
				return "左键";
			case MouseButtons.None:
				return "-无-";
			}
		}
		else
		{
			if (mouseButtons_0 == MouseButtons.Middle)
			{
				return "中键";
			}
			if (mouseButtons_0 == MouseButtons.XButton1)
			{
				return "X1键";
			}
			int num = 0;
			if (uXKtWeF7CeqINRZhZ6un != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (mouseButtons_0 == MouseButtons.XButton2)
			{
				return "X2键";
			}
		}
		return mouseButtons_0.ToString();
	}

	internal static bool wpBWNoF77aVI7beKaMa5()
	{
		return uXKtWeF7CeqINRZhZ6un == null;
	}
}
