using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace oXbLLb78vvxM0SkZwm;

internal static class MQBHPX6oKQF3tv4OI5
{
	internal static object aKA5xVynqyOmZ0OcpTg;

	public static BitmapSource PA0gNiVNWP(UIElement uielement_0, UIElement uielement_1, double double_0 = 1.0)
	{
		Size size = new Size(uielement_0.RenderSize.Width * double_0, uielement_0.RenderSize.Height * double_0);
		RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96.0, 96.0, PixelFormats.Pbgra32);
		VisualBrush brush = new VisualBrush(uielement_0);
		VisualBrush brush2 = new VisualBrush(uielement_1);
		DrawingVisual drawingVisual = new DrawingVisual();
		using (DrawingContext drawingContext = drawingVisual.RenderOpen())
		{
			drawingContext.PushTransform(new ScaleTransform(double_0, double_0));
			drawingContext.DrawRectangle(brush, null, new Rect(new Point(0.0, 0.0), new Point(uielement_0.RenderSize.Width, uielement_0.RenderSize.Height)));
			drawingContext.DrawRectangle(brush2, null, new Rect(new Point(0.0, 0.0), new Point(uielement_0.RenderSize.Width, uielement_0.RenderSize.Height)));
		}
		renderTargetBitmap.Render(drawingVisual);
		return renderTargetBitmap;
	}

	public static z95ZVLi9uLJ2a6sysl EBhgJHPKjL<z95ZVLi9uLJ2a6sysl>(BitmapSource bitmapSource_0, z95ZVLi9uLJ2a6sysl L7FxjamKuWxNGpNrA7) where z95ZVLi9uLJ2a6sysl : Stream
	{
		PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
		pngBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapSource_0));
		pngBitmapEncoder.Save(L7FxjamKuWxNGpNrA7);
		return L7FxjamKuWxNGpNrA7;
	}

	public static cIeOecdbgrWHqvkWeo jqbg0Pt6qq<cIeOecdbgrWHqvkWeo>(BitmapSource bitmapSource_0, cIeOecdbgrWHqvkWeo GOo0douYZU1P0wlbh5, int int_0 = 95) where cIeOecdbgrWHqvkWeo : Stream
	{
		JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
		jpegBitmapEncoder.QualityLevel = int_0;
		jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapSource_0));
		jpegBitmapEncoder.Save(GOo0douYZU1P0wlbh5);
		return GOo0douYZU1P0wlbh5;
	}

	public static uIgayNDasE9dcYx3gZ n3agC1aUMo<uIgayNDasE9dcYx3gZ>(BitmapSource bitmapSource_0, uIgayNDasE9dcYx3gZ VlvTIcHl6cFPl9l1OQ) where uIgayNDasE9dcYx3gZ : Stream
	{
		BmpBitmapEncoder bmpBitmapEncoder = new BmpBitmapEncoder();
		bmpBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapSource_0));
		bmpBitmapEncoder.Save(VlvTIcHl6cFPl9l1OQ);
		return VlvTIcHl6cFPl9l1OQ;
	}

	internal static bool gtRHnayeuZkupqeTI1L()
	{
		return aKA5xVynqyOmZ0OcpTg == null;
	}
}
