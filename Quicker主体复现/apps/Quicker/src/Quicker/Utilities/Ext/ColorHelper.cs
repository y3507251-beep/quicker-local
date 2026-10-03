using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Media;
using Quicker.Utilities.UI;

namespace Quicker.Utilities.Ext;

public static class ColorHelper
{
	private static object WyiFNuFIj5KXwXWE7lWR;

	public static System.Windows.Media.Color StringToColor(string colorStr)
	{
		if (string.IsNullOrWhiteSpace(colorStr))
		{
			return Colors.Gray;
		}
		try
		{
			return (System.Windows.Media.ColorConverter.ConvertFromString(colorStr) as System.Windows.Media.Color?) ?? Colors.Gray;
		}
		catch
		{
			return Colors.Gray;
		}
	}

	public static System.Drawing.Color StringToWinformColor(string colorStr)
	{
		if (string.IsNullOrEmpty(colorStr))
		{
			return System.Drawing.Color.Black;
		}
		colorStr = colorStr.Trim().ToLower();
		if (colorStr.StartsWith("rgb(", StringComparison.OrdinalIgnoreCase))
		{
			string[] array = colorStr.Substring("rgb(".Length).TrimEnd(')', ';').Split(',');
			if (!scamCWFIDijswWrp55MP())
			{
				switch (0)
				{
				}
			}
			return System.Drawing.Color.FromArgb(255, int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
		if (colorStr.StartsWith("rgba("))
		{
			string[] array2 = colorStr.Substring("rgba(".Length).TrimEnd(')', ';').Split(',');
			return System.Drawing.Color.FromArgb((int)(double.Parse(array2[3]) * 255.0), int.Parse(array2[0]), int.Parse(array2[1]), int.Parse(array2[2]));
		}
		if (colorStr.StartsWith("cmyk", StringComparison.OrdinalIgnoreCase))
		{
			colorStr = colorStr.Substring("cmyk".Length).TrimStart('(', ';', ':', ' ').TrimEnd(')', ';');
			string[] array3 = colorStr.Split(',');
			double num = double.Parse(array3[0]) / 100.0;
			double num2 = double.Parse(array3[1]) / 100.0;
			double num3 = double.Parse(array3[2]) / 100.0;
			double num4 = double.Parse(array3[3]) / 100.0;
			byte red = (byte)(255.0 * (1.0 - num) * (1.0 - num4));
			byte green = (byte)(255.0 * (1.0 - num2) * (1.0 - num4));
			byte blue = (byte)(255.0 * (1.0 - num3) * (1.0 - num4));
			return System.Drawing.Color.FromArgb(red, green, blue);
		}
		System.Windows.Media.Color color = StringToColor(colorStr);
		return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
	}

	public static System.Windows.Media.Color ToMediaColor(this System.Drawing.Color drawingColor)
	{
		return System.Windows.Media.Color.FromArgb(drawingColor.A, drawingColor.R, drawingColor.G, drawingColor.B);
	}

	public static System.Drawing.Color ToSystemDrawingColor(this System.Windows.Media.Color color)
	{
		return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

	public static System.Drawing.Color GetColorAt(Point location)
	{
		using Bitmap bitmap = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			using Graphics graphics2 = Graphics.FromHwnd(IntPtr.Zero);
			IntPtr hdc = graphics2.GetHdc();
			BitBlt(graphics.GetHdc(), 0, 0, 1, 1, hdc, location.X, location.Y, 13369376);
			graphics.ReleaseHdc();
			graphics2.ReleaseHdc();
		}
		return bitmap.GetPixel(0, 0);
	}

	public static string ToArgbHexString(this System.Drawing.Color color)
	{
		return $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";
	}

	public static string ToRgbHexString(this System.Drawing.Color color)
	{
		return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
	}

	public static (double hue, double saturation, double lightness) GetHSL(this System.Drawing.Color color)
	{
		float hue = color.GetHue();
		float saturation = color.GetSaturation();
		float brightness = color.GetBrightness();
		return (hue: hue, saturation: saturation, lightness: brightness);
	}

	public static System.Windows.Media.Color HSL2RGB(double h, double sl, double l)
	{
		double num = l;
		double num2 = l;
		int num3 = 0;
		if (!scamCWFIDijswWrp55MP())
		{
			int num4 = default(int);
			num3 = num4;
		}
		double num12 = default(double);
		double num7 = default(double);
		double num11 = default(double);
		double num13 = default(double);
		double num6 = default(double);
		int num9 = default(int);
		double num5 = default(double);
		while (true)
		{
			switch (num3)
			{
			case 1:
				num12 = num7 + num11;
				num13 = num6 - num11;
				switch (num9)
				{
				case 5:
					break;
				case 0:
					num = num6;
					num2 = num12;
					num5 = num7;
					goto end_IL_00ea;
				case 1:
					num = num13;
					num2 = num6;
					num5 = num7;
					goto end_IL_00ea;
				case 3:
					num = num7;
					num2 = num13;
					num5 = num6;
					goto end_IL_00ea;
				case 4:
					num = num12;
					num2 = num7;
					num5 = num6;
					goto end_IL_00ea;
				case 2:
					goto IL_0147;
				default:
					goto end_IL_00ea;
				}
				num = num6;
				num2 = num7;
				num3 = 1;
				if (WyiFNuFIj5KXwXWE7lWR != null)
				{
					continue;
				}
				goto case 3;
			default:
			{
				num5 = l;
				num6 = ((l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl));
				if (!(num6 > 0.0))
				{
					break;
				}
				num7 = l + l - num6;
				double num8 = (num6 - num7) / num6;
				h *= 6.0;
				num9 = (int)h;
				double num10 = h - (double)num9;
				num11 = num6 * num8 * num10;
				num3 = 1;
				if (!scamCWFIDijswWrp55MP())
				{
					continue;
				}
				goto case 1;
			}
			case 3:
				num5 = num13;
				break;
			case 4:
				goto IL_0147;
			case 2:
				break;
				IL_0147:
				num = num7;
				num2 = num6;
				num5 = num12;
				break;
				end_IL_00ea:
				break;
			}
			break;
		}
		return new System.Windows.Media.Color
		{
			A = byte.MaxValue,
			R = Convert.ToByte(num * 255.0),
			G = Convert.ToByte(num2 * 255.0),
			B = Convert.ToByte(num5 * 255.0)
		};
	}

	public static System.Drawing.Color ColorFromHSV(double hue, double saturation, double value)
	{
		int num = Convert.ToInt32(Math.Floor(hue / 60.0)) % 6;
		double num2 = hue / 60.0 - Math.Floor(hue / 60.0);
		value *= 255.0;
		int num3 = Convert.ToInt32(value);
		int num4 = Convert.ToInt32(value * (1.0 - saturation));
		int num5 = Convert.ToInt32(value * (1.0 - num2 * saturation));
		int num6 = Convert.ToInt32(value * (1.0 - (1.0 - num2) * saturation));
		switch (num)
		{
		case 0:
			return System.Drawing.Color.FromArgb(255, num3, num6, num4);
		case 1:
		{
			int num7 = 0;
			if (WyiFNuFIj5KXwXWE7lWR != null)
			{
				int num8 = default(int);
				num7 = num8;
			}
			return num7 switch
			{
				_ => System.Drawing.Color.FromArgb(255, num5, num3, num4), 
			};
		}
		case 2:
			return System.Drawing.Color.FromArgb(255, num4, num3, num6);
		case 3:
			return System.Drawing.Color.FromArgb(255, num4, num5, num3);
		case 4:
			return System.Drawing.Color.FromArgb(255, num6, num4, num3);
		default:
			return System.Drawing.Color.FromArgb(255, num3, num4, num5);
		}
	}

	public static void ColorToHSV(System.Drawing.Color color, out double hue, out double saturation, out double value)
	{
		int num = Math.Max(color.R, Math.Max(color.G, color.B));
		int num2 = Math.Min(color.R, Math.Min(color.G, color.B));
		hue = color.GetHue();
		saturation = ((num == 0) ? 0.0 : (1.0 - 1.0 * (double)num2 / (double)num));
		value = (double)num / 255.0;
	}

	public static (double hue, double saturation, double value) GetHSV(this System.Drawing.Color color)
	{
		ColorToHSV(color, out var hue, out var saturation, out var value);
		return (hue: hue, saturation: saturation, value: value);
	}

	public static System.Drawing.Color ConvertCmykToRgb(float c, float m, float y, float k)
	{
		int red = Convert.ToInt32(255f * (1f - c) * (1f - k));
		int green = Convert.ToInt32(255f * (1f - m) * (1f - k));
		int blue = Convert.ToInt32(255f * (1f - y) * (1f - k));
		return System.Drawing.Color.FromArgb(red, green, blue);
	}

	public static (float c, float m, float y, float k) ConvertRgbToCmyk(int r, int g, int b)
	{
		float num = (float)r / 255f;
		float num2 = (float)g / 255f;
		float num3 = (float)b / 255f;
		float num4 = B1xLibge9VX(1f - Math.Max(Math.Max(num, num2), num3));
		float item = B1xLibge9VX((1f - num - num4) / (1f - num4));
		float item2 = B1xLibge9VX((1f - num2 - num4) / (1f - num4));
		float item3 = B1xLibge9VX((1f - num3 - num4) / (1f - num4));
		return (c: item, m: item2, y: item3, k: num4);
	}

	private static float B1xLibge9VX(float float_0)
	{
		if (float_0 < 0f || float.IsNaN(float_0))
		{
			float_0 = 0f;
		}
		return float_0;
	}

	public static System.Windows.Media.Brush BrushFromColorString(string colorStr, System.Windows.Media.Brush defaultBrush)
	{
		System.Windows.Media.Color? color = null;
		if (!string.IsNullOrEmpty(colorStr))
		{
			try
			{
				color = (System.Windows.Media.Color?)System.Windows.Media.ColorConverter.ConvertFromString(colorStr);
			}
			catch (Exception)
			{
				color = Colors.Black;
			}
		}
		if (!color.HasValue)
		{
			return defaultBrush;
		}
		return color.Value.GetBrush();
	}

	public static double GetLightness(this System.Windows.Media.Color color)
	{
		return (0.299 * (double)(int)color.R + 0.587 * (double)(int)color.G + 0.114 * (double)(int)color.B) / 255.0;
	}

	public static bool IsLightColor(this System.Windows.Media.Color color)
	{
		return color.GetLightness() > 0.5;
	}

	public static System.Windows.Media.Color ChangeColorBrightness(System.Windows.Media.Color color, double correctionFactor)
	{
		(double, double, double) hSL = color.ToSystemDrawingColor().GetHSL();
		hSL.Item3 *= 1.0 + correctionFactor;
		if (hSL.Item3 < 0.0)
		{
			hSL.Item3 = 0.0;
		}
		if (hSL.Item3 > 1.0)
		{
			hSL.Item3 = 1.0;
		}
		System.Windows.Media.Color result = HSL2RGB(hSL.Item1 / 360.0, hSL.Item2, hSL.Item3);
		result.A = color.A;
		return result;
	}

	public static System.Windows.Media.Color AddOverlay(System.Windows.Media.Color baseColor, System.Windows.Media.Color overlayColor, double alpha)
	{
		if (alpha < 0.0 || alpha > 1.0)
		{
			throw new ArgumentOutOfRangeException("alpha", "Alpha must be between 0 and 1");
		}
		double num = 1.0 - alpha;
		byte r = (byte)((double)(int)baseColor.R * num + (double)(int)overlayColor.R * alpha);
		byte g = (byte)((double)(int)baseColor.G * num + (double)(int)overlayColor.G * alpha);
		byte b = (byte)((double)(int)baseColor.B * num + (double)(int)overlayColor.B * alpha);
		return System.Windows.Media.Color.FromArgb(baseColor.A, r, g, b);
	}

	internal static bool scamCWFIDijswWrp55MP()
	{
		return WyiFNuFIj5KXwXWE7lWR == null;
	}
}
