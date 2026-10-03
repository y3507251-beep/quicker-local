using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CW.Win32;
using log4net;
using O5blBdM6bCRI1gbI3U2;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Icons;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public static class IconHelper
{
	private static readonly ILog eRuLMrYUWhi;

	private static object M8wtBrFRU00J7MwYERbU;

	public static Icon GetExeOrLnkFileIcon(string fileName)
	{
		if (fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			return Icon.ExtractAssociatedIcon(fileName);
		}
		try
		{
			Icon fileLnkIcon = FileSystemIconHelper.GetFileLnkIcon(fileName);
			if (fileLnkIcon != null)
			{
				return fileLnkIcon;
			}
			return Icon.ExtractAssociatedIcon(fileName);
		}
		catch (Exception)
		{
			return Icon.ExtractAssociatedIcon(fileName);
		}
	}

	private static Icon L8SLMxCqknR(string string_0)
	{
		NativeMethods.SHFILEINFO psfi = default(NativeMethods.SHFILEINFO);
		NativeMethods.SHGetFileInfo(string_0, 0u, out psfi, (uint)Marshal.SizeOf(psfi), 256u);
		using Icon icon = Icon.FromHandle(psfi.hIcon);
		Icon result = (Icon)icon.Clone();
		User32.DestroyIcon(psfi.hIcon);
		return result;
	}

	public static Icon GetFolderIcon()
	{
		string fullName = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())).FullName;
		Icon result = L8SLMxCqknR(fullName);
		Directory.Delete(fullName);
		return result;
	}

	public static Bitmap ResizeImage(Image image, int width, int height)
	{
		System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(0, 0, width, height);
		Bitmap bitmap = new Bitmap(width, height);
		bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CompositingMode = CompositingMode.SourceCopy;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		using ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
		graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
		return bitmap;
	}

	public static ImageSource IconToImageSource(Icon icon)
	{
		using Bitmap bitmap = icon.ToBitmap();
		IntPtr hbitmap = bitmap.GetHbitmap();
		ImageSource imageSource = Imaging.CreateBitmapSourceFromHBitmap(hbitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		if (!NativeMethods.DeleteObject(hbitmap))
		{
			throw new Win32Exception();
		}
		imageSource.TryFreeze();
		return imageSource;
	}

	public static ImageSource GetExeIconImageSource(string exeFile)
	{
		if (string.IsNullOrEmpty(exeFile))
		{
			return null;
		}
		if (exeFile.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
		{
			string text = iah68iMf4KvhT7ULCsJ.DpvLoo2xNQd(exeFile.Substring("StoreApp:".Length));
			if (File.Exists(text))
			{
				return ImageCache.GetImageSource(text);
			}
			return null;
		}
		if (File.Exists(exeFile))
		{
			try
			{
				using Icon icon = Icon.ExtractAssociatedIcon(exeFile);
				return IconToImageSource(icon);
			}
			catch (Exception ex)
			{
				eRuLMrYUWhi.Warn("获取exe图标出错：" + ex.Message, ex);
				return null;
			}
		}
		return null;
	}

	public static string GetExeIconImageStr(string exeFile)
	{
		if (string.IsNullOrEmpty(exeFile))
		{
			return null;
		}
		if (exeFile.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
		{
			string text = iah68iMf4KvhT7ULCsJ.DpvLoo2xNQd(exeFile.Substring("StoreApp:".Length));
			if (File.Exists(text))
			{
				return "url:" + text;
			}
			return null;
		}
		if (File.Exists(exeFile))
		{
			return "icon:" + exeFile;
		}
		return null;
	}

	public static BitmapImage BitmapToImageSource(Bitmap bitmap)
	{
		using MemoryStream memoryStream = new MemoryStream();
		bitmap.Save(memoryStream, ImageFormat.Bmp);
		memoryStream.Position = 0L;
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.StreamSource = memoryStream;
		int num = 0;
		if (M8wtBrFRU00J7MwYERbU != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.EndInit();
			if (bitmapImage.CanFreeze)
			{
				bitmapImage.Freeze();
			}
			return bitmapImage;
		}
	}

	public static BitmapImage ImageToImageSource(Image img)
	{
		BitmapImage bitmapImage = new BitmapImage();
		using MemoryStream memoryStream = new MemoryStream();
		img.Save(memoryStream, ImageFormat.Bmp);
		memoryStream.Position = 0L;
		bitmapImage.BeginInit();
		bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
		int num = 0;
		if (!MYMe9kFRxMM6NqTgxMXt())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			bitmapImage.UriSource = null;
			bitmapImage.StreamSource = memoryStream;
			bitmapImage.EndInit();
			if (bitmapImage.CanFreeze)
			{
				bitmapImage.Freeze();
			}
			return bitmapImage;
		}
	}

	[DllImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteObject([In] IntPtr hObject);

	public static ImageSource ImageSourceFromBitmap(Bitmap bmp)
	{
		IntPtr hbitmap = bmp.GetHbitmap();
		try
		{
			return Imaging.CreateBitmapSourceFromHBitmap(hbitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}
		finally
		{
			DeleteObject(hbitmap);
		}
	}

	public static BitmapImage UrlToBitmapSource(string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			return null;
		}
		try
		{
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.UriSource = new Uri(url, UriKind.Absolute);
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.EndInit();
			if (bitmapImage.CanFreeze)
			{
				bitmapImage.Freeze();
			}
			return bitmapImage;
		}
		catch (Exception ex)
		{
			eRuLMrYUWhi.Warn("加载图片出错！" + url + " 错误：" + ex.Message, ex);
			return null;
		}
	}

	public static BitmapImage FileToImageSource(string fileName)
	{
		try
		{
			return new BitmapImage(new Uri(fileName));
		}
		catch
		{
			return null;
		}
	}

	public static string WriteClipboardImageToTempFile()
	{
		Bitmap obj = ImageClipboardHelper.GetImageFromClipboard() ?? throw new InvalidDataException("剪贴板中没有图片。");
		string text = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + ".png");
		obj.Save(text, ImageFormat.Png);
		return text;
	}

	static IconHelper()
	{
		eRuLMrYUWhi = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool MYMe9kFRxMM6NqTgxMXt()
	{
		return M8wtBrFRU00J7MwYERbU == null;
	}
}
