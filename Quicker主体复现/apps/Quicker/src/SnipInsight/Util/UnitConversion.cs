using System.Windows;
using Quicker.Domain;

namespace SnipInsight.Util;

public static class UnitConversion
{
	private static object u2q69qyQiuif2pAEFeI;

	public static Size ConvertToEMU(Size input)
	{
		double? num = PresentationSource.FromVisual(AppState.HS2taepcAbc())?.CompositionTarget.TransformToDevice.M11;
		double width = input.Width * 12700.0;
		double height = input.Height * 12700.0;
		return new Size(width, height);
	}

	public static Rect ConvertToEMU(Rect input)
	{
		double? num = PresentationSource.FromVisual(AppState.HS2taepcAbc())?.CompositionTarget.TransformToDevice.M11;
		double x = input.X * 12700.0;
		double y = input.Y * 12700.0;
		double width = input.Width * 12700.0;
		double height = input.Height * 12700.0;
		return new Rect(x, y, width, height);
	}

	public static Size ConvertToPixels(Size input)
	{
		double? num = PresentationSource.FromVisual(AppState.HS2taepcAbc())?.CompositionTarget.TransformToDevice.M11;
		double width = input.Width / 12700.0;
		double height = input.Height / 12700.0;
		return new Size(width, height);
	}

	public static Rect ConvertToPixels(Rect input)
	{
		double? num = PresentationSource.FromVisual(AppState.HS2taepcAbc())?.CompositionTarget.TransformToDevice.M11;
		double x = input.X / 12700.0;
		double y = input.Y / 12700.0;
		double width = input.Width / 12700.0;
		double height = input.Height / 12700.0;
		return new Rect(x, y, width, height);
	}

	internal static bool SO19OLyFjkGwYIiMSa7()
	{
		return u2q69qyQiuif2pAEFeI == null;
	}
}
