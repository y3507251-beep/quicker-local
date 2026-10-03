using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Input;
using System.Windows.Interop;
using fneISX1M6nM0ygtYee;

namespace SnipInsight.ImageCapture;

public class ImageCaptureCursor : IDisposable
{
	private Cursor tCBgGwFOeu;

	private nEWMYSebvd9uAgm7Qm gvegsxuj38;

	internal static ImageCaptureCursor JA7X99ybBijRsrvxfNf;

	public Cursor GetCursor()
	{
		if (tCBgGwFOeu == null)
		{
			tCBgGwFOeu = xxTgkjv2Di(32, 32);
		}
		return tCBgGwFOeu;
	}

	private Cursor xxTgkjv2Di(int int_0, int int_1)
	{
		Pen pen = new Pen(Color.Red, 3f);
		Bitmap bitmap = new Bitmap(int_0, int_1);
		Graphics graphics = Graphics.FromImage(bitmap);
		GraphicsPath graphicsPath = new GraphicsPath();
		GraphicsPath graphicsPath2 = new GraphicsPath();
		GraphicsPath graphicsPath3 = new GraphicsPath();
		GraphicsPath graphicsPath4 = new GraphicsPath();
		GraphicsPath graphicsPath5 = new GraphicsPath();
		GraphicsPath graphicsPath6 = new GraphicsPath();
		graphicsPath6.AddLine(new Point(int_0 / 2, 0), new Point(int_0 / 2, int_1));
		graphicsPath4.AddLine(new Point(int_0 / 2, int_1 / 2 - 32), new Point(int_0 / 2, int_1 / 2 - 16));
		graphicsPath5.AddLine(new Point(int_0 / 2, int_1 / 2 + 32), new Point(int_0 / 2, int_1 / 2 + 16));
		graphicsPath3.AddLine(new Point(0, int_1 / 2), new Point(int_0, int_1 / 2));
		graphicsPath.AddLine(new Point(int_0 / 2 - 32, int_1 / 2), new Point(int_0 / 2 - 16, int_1 / 2));
		graphicsPath2.AddLine(new Point(int_0 / 2 + 16, int_1 / 2), new Point(int_0 / 2 + 32, int_1 / 2));
		graphics.DrawPath(pen, graphicsPath3);
		graphics.DrawPath(pen, graphicsPath6);
		Icon icon = Icon.FromHandle(bitmap.GetHicon());
		gvegsxuj38?.Dispose();
		gvegsxuj38 = new nEWMYSebvd9uAgm7Qm(icon.Handle);
		nEWMYSebvd9uAgm7Qm cursorHandle = gvegsxuj38;
		return CursorInteropHelper.Create(cursorHandle);
	}

	~ImageCaptureCursor()
	{
		Dispose(false);
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (tCBgGwFOeu != null)
			{
				tCBgGwFOeu.Dispose();
				tCBgGwFOeu = null;
			}
			if (gvegsxuj38 != null)
			{
				gvegsxuj38.Dispose();
				gvegsxuj38 = null;
			}
		}
	}

	internal static bool KxxSBhyqIlUl6TLt6vn()
	{
		return JA7X99ybBijRsrvxfNf == null;
	}
}
