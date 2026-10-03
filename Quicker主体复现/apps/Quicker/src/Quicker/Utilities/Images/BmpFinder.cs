using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Quicker.Utilities.Images;

public static class BmpFinder
{
	internal static object VIfH1hcQW1Zo6fhGPIPK;

	public static Bitmap CopyScreen(Rectangle rect)
	{
		if (rect.Size.IsEmpty)
		{
			throw new Exception($"截图区域大小不能为0（{rect.Left},{rect.Top},{rect.Right},{rect.Bottom}）");
		}
		try
		{
			Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
			}
			return bitmap;
		}
		catch (Exception ex)
		{
			throw new Exception("截图失败：" + ex.Message + $" 范围：{rect.Left},{rect.Top},{rect.Right},{rect.Bottom}", ex);
		}
	}

	internal static bool I6UoWAcQykOOIslI374M()
	{
		return VIfH1hcQW1Zo6fhGPIPK == null;
	}
}
