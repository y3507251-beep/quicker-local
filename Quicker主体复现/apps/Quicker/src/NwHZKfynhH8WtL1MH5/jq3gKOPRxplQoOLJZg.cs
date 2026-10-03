using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using jeaU1l2eVVj4W2gaVc;
using log4net;
using Quicker.Utilities.Ext;
using SnipInsight.Util;

namespace NwHZKfynhH8WtL1MH5;

internal static class jq3gKOPRxplQoOLJZg
{
	private static readonly ILog EM6LcRJPnp;

	internal static object XJQLtFyT96wwm10ZT0g;

	public static Bitmap RYOLEZI1rj(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3)
	{
		Bitmap bitmap = null;
		DpiScale systemScale = DpiUtilities.GetSystemScale();
		if (int_2 > 0 && int_3 > 0)
		{
			IntPtr intptr_1 = OO77uFW4jgnwuPwqBc.OF6tByAHkP(intptr_0);
			bitmap = new Bitmap(int_2, int_3, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
			bitmap.MakeTransparent();
			Graphics graphics = Graphics.FromImage(bitmap);
			OO77uFW4jgnwuPwqBc.smjgwPNFom(graphics.GetHdc(), 0, 0, int_2, int_3, intptr_1, int_0, int_1, (OO77uFW4jgnwuPwqBc.NoBp5Em3ZvASVH36FW9)1087111200u);
			if (!vsVIB0ymM4DKnno7gLu())
			{
				switch (0)
				{
				}
			}
			bitmap.SetResolution((float)(96.0 * systemScale.X), (float)(96.0 * systemScale.Y));
			graphics.ReleaseHdc();
			OO77uFW4jgnwuPwqBc.TZXt5jYrmP(IntPtr.Zero, intptr_1);
			graphics.Dispose();
		}
		return bitmap;
	}

	public static Bitmap I3uLye4LQU()
	{
		int left = SystemInformation.VirtualScreen.Left;
		int top = SystemInformation.VirtualScreen.Top;
		int width = SystemInformation.VirtualScreen.Width;
		int height = SystemInformation.VirtualScreen.Height;
		Bitmap bitmap = new Bitmap(width, height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CopyFromScreen(left, top, 0, 0, bitmap.Size);
		return bitmap;
	}

	public static BitmapSource jirL86k2TM(Bitmap bitmap_0)
	{
		if (bitmap_0 == null)
		{
			return null;
		}
		BitmapSource bitmapSource = null;
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadOnly, bitmap_0.PixelFormat);
		try
		{
			bitmapSource = BitmapSource.Create(bitmap_0.Width, bitmap_0.Height, bitmap_0.HorizontalResolution, bitmap_0.VerticalResolution, PixelFormats.Bgra32, null, bitmapData.Scan0, bitmapData.Stride * bitmap_0.Height, bitmapData.Stride);
		}
		finally
		{
			bitmap_0.UnlockBits(bitmapData);
		}
		bitmapSource.TryFreeze();
		return bitmapSource;
	}

	public static BitmapSource fguLa5Krp9(Bitmap bitmap_0, Rectangle rectangle_0, DpiScale dpiScale_0 = null)
	{
		Bitmap bitmap = iiFLRiREYS(bitmap_0, rectangle_0);
		if (dpiScale_0 != null && dpiScale_0.X > 0.0 && dpiScale_0.Y > 0.0)
		{
			bitmap.SetResolution((float)(96.0 * dpiScale_0.X), (float)(96.0 * dpiScale_0.Y));
		}
		return jirL86k2TM(bitmap);
	}

	public static Bitmap z3DL70qh82(Bitmap bitmap_0, Rectangle rectangle_0, DpiScale dpiScale_0 = null)
	{
		Bitmap bitmap = iiFLRiREYS(bitmap_0, rectangle_0);
		if (dpiScale_0 != null && dpiScale_0.X > 0.0 && dpiScale_0.Y > 0.0)
		{
			bitmap.SetResolution((float)(96.0 * dpiScale_0.X), (float)(96.0 * dpiScale_0.Y));
		}
		return bitmap;
	}

	public static Bitmap iiFLRiREYS(Bitmap bitmap_0, Rectangle rectangle_0)
	{
		try
		{
			Bitmap bitmap = new Bitmap(rectangle_0.Width, rectangle_0.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(bitmap_0, -rectangle_0.X, -rectangle_0.Y);
			}
			return bitmap;
		}
		catch (Exception exception)
		{
			EM6LcRJPnp.Warn($"截图创建位图出错。{rectangle_0.Width}*{rectangle_0.Height} {exception.GetMessageWithInner()}", exception);
			throw;
		}
	}

	public static Bitmap gocLqSud0o(Bitmap bitmap_0, int int_0, int int_1)
	{
		Bitmap bitmap = new Bitmap(int_0, int_1);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.DrawImage(bitmap_0, new Rectangle(0, 0, int_0, int_1));
		return bitmap;
	}

	static jq3gKOPRxplQoOLJZg()
	{
		EM6LcRJPnp = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool vsVIB0ymM4DKnno7gLu()
	{
		return XJQLtFyT96wwm10ZT0g == null;
	}
}
