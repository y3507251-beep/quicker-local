using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Windows.Media;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities.UI;

public static class ColorBrushHelper
{
	private static IDictionary<Color, SolidColorBrush> LgHvSq0cYFt;

	private static object UphkJGF4ZfUDaC4OvBQ6;

	public static SolidColorBrush GetBrush(this Color color)
	{
		if (LgHvSq0cYFt.TryGetValue(color, out var value))
		{
			return value;
		}
		SolidColorBrush solidColorBrush = new SolidColorBrush(color);
		solidColorBrush.TryFreeze();
		LgHvSq0cYFt[color] = solidColorBrush;
		return solidColorBrush;
	}

	public static SolidColorBrush GetBrush(this string colorValue)
	{
		if (string.IsNullOrEmpty(colorValue))
		{
			return Brushes.Gray;
		}
		try
		{
			Color? color = ColorConverter.ConvertFromString(colorValue) as Color?;
			if (!color.HasValue)
			{
				AppHelper.ShowWarning("颜色值无法识别：" + colorValue);
				return Brushes.Gray;
			}
			return color.Value.GetBrush();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("颜色值无法识别：" + colorValue + " " + ex.Message);
			return Brushes.Gray;
		}
	}

	public static int GetBrightness(this Color c)
	{
		return (int)Math.Sqrt((double)(c.R * c.R) * 0.241 + (double)(c.G * c.G) * 0.691 + (double)(c.B * c.B) * 0.068);
	}

	static ColorBrushHelper()
	{
		LgHvSq0cYFt = new ConcurrentDictionary<Color, SolidColorBrush>();
	}

	internal static bool Hfa18cF45k3kt5USN9X4()
	{
		return UphkJGF4ZfUDaC4OvBQ6 == null;
	}
}
