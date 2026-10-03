using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FontAwesome5;
using FontAwesome5.Extensions;
using log4net;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.Utilities;

public static class FaIconHelper
{
	private static readonly ILog XCHLo5NrPFh;

	internal static object SsE731FYAFwSYtQuEPrl;

	public static (EFontAwesomeIcon icon, Brush forgroundBrush) DecodeFaIconString(string faIconString, string defaultColor)
	{
		string[] array = faIconString.Split(':');
		if (!Enum.TryParse<EFontAwesomeIcon>(array[1], out var result))
		{
			return (icon: EFontAwesomeIcon.Light_ExclamationCircle, forgroundBrush: Brushes.OrangeRed);
		}
		string text = defaultColor;
		if (array.Length > 2)
		{
			text = array[2];
		}
		Brush item = null;
		if (!string.IsNullOrEmpty(text))
		{
			item = GetBrushFromColorString(text);
		}
		return (icon: result, forgroundBrush: item);
	}

	public static Brush GetBrushFromColorString(string colorStr)
	{
		if (string.IsNullOrEmpty(colorStr))
		{
			return Brushes.DarkGray;
		}
		Color? color = null;
		try
		{
			string text = colorStr.ToLower();
			Color value;
			Color value2;
			int num;
			switch (text)
			{
			case "link":
				color = (Quicker.App.Current.TryFindResource("TextLinkColor") as Color?) ?? Color.FromRgb(70, 143, 252);
				goto end_IL_0016;
			case "info":
			{
				Color? color2 = Quicker.App.Current.TryFindResource("TextInfoColor") as Color?;
				if (!color2.HasValue)
				{
					goto IL_0352;
				}
				value = color2.GetValueOrDefault();
				goto IL_0363;
			}
			case "warning":
			{
				Color? color2 = Quicker.App.Current.TryFindResource("TextWarningColor") as Color?;
				if (!color2.HasValue)
				{
					goto IL_0244;
				}
				value2 = color2.GetValueOrDefault();
				goto IL_0255;
			}
			case "primary":
				color = (Quicker.App.Current.TryFindResource("PrimaryColor") as Color?) ?? Colors.Black;
				goto end_IL_0016;
			case "secondary":
				color = (Quicker.App.Current.TryFindResource("SecondaryTextColor") as Color?) ?? Colors.Gray;
				num = 1;
				if (SsE731FYAFwSYtQuEPrl == null)
				{
					goto IL_026d;
				}
				goto end_IL_0016;
			case "danger":
				color = (Quicker.App.Current.TryFindResource("TextDangerColor") as Color?) ?? Color.FromRgb(221, 85, 85);
				goto end_IL_0016;
			case "success":
				goto IL_036c;
				IL_036c:
				color = (Quicker.App.Current.TryFindResource("TextSuccessColor") as Color?) ?? Colors.ForestGreen;
				goto end_IL_0016;
				IL_026d:
				switch (num)
				{
				case 4:
					break;
				default:
					goto end_IL_0016;
				case 3:
					goto IL_0297;
				case 5:
				{
					char c = default(char);
					if (c != 't')
					{
						goto end_IL_0020;
					}
					goto case 2;
				}
				case 2:
					if (!(text == "text"))
					{
						goto end_IL_0020;
					}
					color = (Quicker.App.Current.TryFindResource("PrimaryTextColor") as Color?) ?? Color.FromRgb(13, 202, 240);
					goto end_IL_0016;
				case 6:
					goto IL_0352;
				case 7:
					goto IL_036c;
				case 0:
				case 1:
					goto end_IL_0016;
				}
				goto IL_0244;
				IL_0363:
				color = value;
				goto end_IL_0016;
				IL_0297:
				if (!(text == "danger"))
				{
					break;
				}
				goto case "danger";
				IL_0244:
				value2 = Color.FromRgb(byte.MaxValue, 201, 37);
				goto IL_0255;
				IL_0255:
				color = value2;
				num = 0;
				if (SsE731FYAFwSYtQuEPrl != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_026d;
				IL_0352:
				value = Color.FromRgb(13, 202, 240);
				goto IL_0363;
				end_IL_0020:
				break;
			}
			color = (Color?)ColorConverter.ConvertFromString(colorStr);
			end_IL_0016:;
		}
		catch (Exception exception)
		{
			XCHLo5NrPFh.Warn("转换颜色出错,文本=" + colorStr + "。" + exception.GetMessageWithInner(), exception);
			color = Colors.Black;
		}
		return (color ?? Color.FromArgb(0, 0, 0, 0)).GetBrush();
	}

	public static Path CreatePath(EFontAwesomeIcon icon, Brush foregroundBrush, double emSize = 100.0)
	{
		Path path = null;
		FontAwesomeSvgInformationAttribute svg = icon.GetSvg();
		if (svg != null)
		{
			path = new Path();
			path.Data = Geometry.Parse(svg.Path);
			path.Width = svg.Width;
			path.Height = svg.Height;
			path.Fill = foregroundBrush;
		}
		return path;
	}

	public static ImageSource GetImageSourceFromFaIcon(EFontAwesomeIcon icon, Brush foregroundBrush, double emSize = 100.0, double dpiScaling = 1.0)
	{
		Path path = CreatePath(icon, foregroundBrush, emSize);
		int num = (int)(emSize / dpiScaling);
		double num2 = Math.Min((double)num * 1.0 / path.Width, (double)num * 1.0 / path.Height);
		path.RenderTransform = new ScaleTransform(num2, num2);
		Canvas canvas = new Canvas();
		canvas.Width = num;
		canvas.Height = num;
		canvas.Background = Brushes.Transparent;
		canvas.Children.Add(path);
		path.SetValue(Canvas.LeftProperty, ((double)num - path.Width * num2) / 2.0);
		path.SetValue(Canvas.TopProperty, ((double)num - path.Height * num2) / 2.0);
		canvas.Measure(new Size(canvas.Width, canvas.Height));
		canvas.Arrange(new Rect(new Size(canvas.Width, canvas.Height)));
		RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(num, num, 96.0, 96.0, PixelFormats.Pbgra32);
		renderTargetBitmap.Render(canvas);
		int num3 = 0;
		if (SsE731FYAFwSYtQuEPrl != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
			if (renderTargetBitmap.CanFreeze)
			{
				renderTargetBitmap.Freeze();
			}
			return renderTargetBitmap;
		}
	}

	public static ImageSource GetImageSourceFromFaIcon(string faIconString, string defaultColor, double size, double dpiScaling)
	{
		var (icon, foregroundBrush) = DecodeFaIconString(faIconString, defaultColor);
		return GetImageSourceFromFaIcon(icon, foregroundBrush, size, dpiScaling);
	}

	static FaIconHelper()
	{
		XCHLo5NrPFh = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool cE2ipRFYnUom9VXRHctd()
	{
		return SsE731FYAFwSYtQuEPrl == null;
	}
}
