using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HandyControl.Tools.Extension;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities.Images;

public static class ImageHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ake28NhiuY9;

		public static EventHandler<ExceptionEventArgs> IV128J8f1iW;

		public static EventHandler<ExceptionEventArgs> coG280rPYvO;

		public static EventHandler<ExceptionEventArgs> t3V28CsJgED;

		public static EventHandler<ExceptionEventArgs> q9H28Py1jtV;

		private static _003C_003Ec ASfFUgyaFPPEY0bOCNOr;

		static _003C_003Ec()
		{
			ake28NhiuY9 = new _003C_003Ec();
		}

		internal void yPv28vstlbO(object sender, ExceptionEventArgs e)
		{
		}

		internal void XOe28SRyPwl(object sender, ExceptionEventArgs e)
		{
		}

		internal void gmj282a6CH0(object sender, ExceptionEventArgs e)
		{
		}

		internal void tmA28uXaV7p(object sender, ExceptionEventArgs e)
		{
		}

		internal static bool awesJ4yacdBIkZ85dylH()
		{
			return ASfFUgyaFPPEY0bOCNOr == null;
		}
	}

	internal static object IfnGa2cV6yCIniqCB1du;

	public static string SaveToTempFile(Image image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		string text = new ImageFormatConverter().ConvertToString(image.RawFormat);
		string text2 = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + "." + text);
		image.Save(text2);
		return text2;
	}

	public static Image ReadImageFromFileWithoutLock(string path)
	{
		return Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
	}

	public static byte[] ImageToByteArray(this Image imageIn)
	{
		return (byte[])new System.Drawing.ImageConverter().ConvertTo(imageIn, typeof(byte[]));
	}

	public static BitmapImage LoadBitmapImageFromFile(string path, int decodePixelWidth = 0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = File.ReadAllBytes(path);
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		bitmapImage.BeginInit();
		bitmapImage.StreamSource = memoryStream;
		int num = 0;
		if (IfnGa2cV6yCIniqCB1du != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (decodePixelWidth > 0)
			{
				bitmapImage.DecodePixelWidth = decodePixelWidth;
			}
			bitmapImage.EndInit();
			bitmapImage.TryFreeze();
			return bitmapImage;
		}
	}

	public static string FilePathToFileUrl(string filePath)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = default(int);
		foreach (char c in filePath)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z'))
			{
				if (c >= '0')
				{
					goto IL_00ba;
				}
				goto IL_00c0;
			}
			goto IL_00fb;
			IL_00fb:
			stringBuilder.Append(c);
			continue;
			IL_00ba:
			if (c > '9')
			{
				goto IL_00c0;
			}
			goto IL_00fb;
			IL_00cb:
			if (c != Path.AltDirectorySeparatorChar)
			{
				stringBuilder.Append($"%{(int)c:X2}");
				continue;
			}
			goto IL_00d4;
			IL_00d4:
			stringBuilder.Append('/');
			continue;
			IL_00c0:
			if (c != '+' && c != '/')
			{
				int num = 0;
				if (!JtCr5tcVtoFEvFbA2sl5())
				{
					num = num2;
				}
				while (true)
				{
					IL_00a7:
					switch (num)
					{
					case 2:
						goto end_IL_00a7;
					case 1:
						goto IL_00cb;
					}
					while (c != ':' && c != '.' && c != '-' && c != '_' && c != '~' && c <= 'ÿ')
					{
						if (c != Path.DirectorySeparatorChar)
						{
							num = 1;
							if (!JtCr5tcVtoFEvFbA2sl5())
							{
								continue;
							}
							goto IL_00a7;
						}
						goto IL_00d4;
					}
					goto IL_00fb;
					continue;
					end_IL_00a7:
					break;
				}
				goto IL_00ba;
			}
			goto IL_00fb;
		}
		if (stringBuilder.Length >= 2 && stringBuilder[0] == '/' && stringBuilder[1] == '/')
		{
			stringBuilder.Insert(0, "file:");
		}
		else
		{
			stringBuilder.Insert(0, "file:///");
		}
		return stringBuilder.ToString();
	}

	public static ImageFormat GetImageFormatByFileExt(string path)
	{
		int num = 4;
		string text = default(string);
		int length = default(int);
		while (!string.IsNullOrEmpty(path))
		{
			int num2 = 3;
			if (IfnGa2cV6yCIniqCB1du != null)
			{
				goto IL_004c;
			}
			goto IL_0050;
			IL_004c:
			num2 = num;
			goto IL_0050;
			IL_0050:
			while (true)
			{
				switch (num2)
				{
				case 3:
					text = Path.GetExtension(path).ToLower();
					if (text != null)
					{
						length = text.Length;
						if (length != 4)
						{
							goto IL_003f;
						}
						goto default;
					}
					goto IL_0182;
				case 4:
					break;
				case 1:
					if (length == 5)
					{
						char c = text[1];
						if (c != 'j')
						{
							if (c == 't' && text == ".tiff")
							{
								return ImageFormat.Tiff;
							}
						}
						else if (text == ".jpeg")
						{
							goto IL_0132;
						}
					}
					goto IL_0182;
				default:
					switch (text[1])
					{
					case 'g':
						if (text == ".gif")
						{
							return ImageFormat.Gif;
						}
						goto IL_0182;
					case 'i':
						if (text == ".ico")
						{
							return ImageFormat.Icon;
						}
						goto IL_0182;
					case 'j':
						break;
					case 'b':
						if (text == ".bmp")
						{
							return ImageFormat.Bmp;
						}
						goto IL_0182;
					case 'w':
						if (text == ".wmf")
						{
							return ImageFormat.Wmf;
						}
						goto IL_0182;
					case 'p':
						if (text == ".png")
						{
							return ImageFormat.Png;
						}
						goto IL_0182;
					default:
						goto IL_0182;
					}
					goto case 2;
				case 2:
					{
						if (text == ".jpg")
						{
							goto IL_0132;
						}
						goto IL_0182;
					}
					IL_0182:
					return ImageFormat.Png;
					IL_0132:
					return ImageFormat.Jpeg;
				}
				break;
				IL_003f:
				num2 = 1;
				if (JtCr5tcVtoFEvFbA2sl5())
				{
					continue;
				}
				goto IL_004c;
			}
		}
		return ImageFormat.Png;
	}

	public static BitmapSource BitmapToBitmapSource(Bitmap bitmap)
	{
		if (bitmap == null)
		{
			return null;
		}
		BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
		try
		{
			BitmapSource bitmapSource = BitmapSource.Create(bitmapData.Width, bitmapData.Height, 96.0, 96.0, KDavNWTEt3d(bitmap.PixelFormat), null, bitmapData.Scan0, bitmapData.Stride * bitmapData.Height, bitmapData.Stride);
			if (bitmapSource.CanFreeze)
			{
				bitmapSource.Freeze();
			}
			return bitmapSource;
		}
		catch (Exception)
		{
			BitmapImage bitmapImage = new BitmapImage();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap.Save(memoryStream, ImageFormat.Png);
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = memoryStream;
				bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage.EndInit();
				bitmapImage.Freeze();
			}
			return bitmapImage;
		}
		finally
		{
			bitmap.UnlockBits(bitmapData);
		}
	}

	private static System.Windows.Media.PixelFormat KDavNWTEt3d(System.Drawing.Imaging.PixelFormat pixelFormat_0)
	{
		return pixelFormat_0 switch
		{
			System.Drawing.Imaging.PixelFormat.Format32bppArgb => PixelFormats.Bgra32, 
			System.Drawing.Imaging.PixelFormat.Format32bppRgb => PixelFormats.Bgr32, 
			System.Drawing.Imaging.PixelFormat.Format24bppRgb => PixelFormats.Bgr24, 
			_ => default(System.Windows.Media.PixelFormat), 
		};
	}

	internal static BitmapSource IOnvNk2qgcn(string string_0, double double_0)
	{
		int num = 32;
		num = ((double_0.IsNaN() || double.IsInfinity(double_0) || !(double_0 > 0.0)) ? 32 : ((int)double_0));
		BitmapImage bitmapImage;
		int num2;
		if (File.Exists(string_0))
		{
			bitmapImage = new BitmapImage();
			bitmapImage.DownloadFailed += _003C_003Ec.IV128J8f1iW ?? (_003C_003Ec.IV128J8f1iW = _003C_003Ec.ake28NhiuY9.yPv28vstlbO);
			bitmapImage.DecodeFailed += _003C_003Ec.coG280rPYvO ?? (_003C_003Ec.coG280rPYvO = _003C_003Ec.ake28NhiuY9.XOe28SRyPwl);
			bitmapImage.BeginInit();
			bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
			num2 = 1;
			if (IfnGa2cV6yCIniqCB1du != null)
			{
				goto IL_00bb;
			}
			goto IL_00bf;
		}
		return null;
		IL_00bb:
		int num3 = default(int);
		num2 = num3;
		goto IL_00bf;
		IL_00bf:
		do
		{
			switch (num2)
			{
			case 1:
				break;
			default:
				bitmapImage.UriSource = new Uri(string_0);
				bitmapImage.DecodePixelWidth = num;
				bitmapImage.EndInit();
				if (bitmapImage.CanFreeze)
				{
					bitmapImage.Freeze();
				}
				return bitmapImage;
			}
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			num2 = 0;
		}
		while (JtCr5tcVtoFEvFbA2sl5());
		goto IL_00bb;
	}

	internal static BitmapSource ow1vNGsa99M(string string_0, int? nullable_0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.DownloadFailed += _003C_003Ec.t3V28CsJgED ?? (_003C_003Ec.t3V28CsJgED = _003C_003Ec.ake28NhiuY9.gmj282a6CH0);
		bitmapImage.DecodeFailed += _003C_003Ec.q9H28Py1jtV ?? (_003C_003Ec.q9H28Py1jtV = _003C_003Ec.ake28NhiuY9.tmA28uXaV7p);
		bitmapImage.BeginInit();
		bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
		bitmapImage.UriSource = new Uri(string_0, UriKind.Absolute);
		if (nullable_0.HasValue)
		{
			bitmapImage.DecodePixelWidth = nullable_0.Value;
		}
		bitmapImage.EndInit();
		bitmapImage.TryFreeze();
		return bitmapImage;
	}

	public static bool ConvertToIcon(Bitmap inputBitmap, Stream output, IList<int> sizes)
	{
		if (inputBitmap == null)
		{
			return false;
		}
		List<MemoryStream> list = new List<MemoryStream>();
		foreach (int size in sizes)
		{
			using Bitmap bitmap = rMHvNsInv5M(inputBitmap, size);
			if (bitmap == null)
			{
				return false;
			}
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Png);
			list.Add(memoryStream);
		}
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		if (output != null && binaryWriter != null)
		{
			int num = 0;
			binaryWriter.Write((byte)0);
			binaryWriter.Write((byte)0);
			binaryWriter.Write((short)1);
			binaryWriter.Write((short)sizes.Count);
			num = 0 + (6 + 16 * sizes.Count);
			for (int i = 0; i < sizes.Count; i++)
			{
				binaryWriter.Write((byte)sizes[i]);
				binaryWriter.Write((byte)sizes[i]);
				binaryWriter.Write((byte)0);
				binaryWriter.Write((byte)0);
				binaryWriter.Write((short)0);
				binaryWriter.Write((short)32);
				binaryWriter.Write((int)list[i].Length);
				binaryWriter.Write(num);
				num += (int)list[i].Length;
			}
			for (int j = 0; j < sizes.Count; j++)
			{
				binaryWriter.Write(list[j].ToArray());
				list[j].Close();
			}
			binaryWriter.Flush();
			foreach (MemoryStream item in list)
			{
				item.Close();
			}
			return true;
		}
		return false;
	}

	public static Bitmap ResizeImage(Image image, int width, int height)
	{
		Rectangle destRect = new Rectangle(0, 0, width, height);
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

	private static Bitmap rMHvNsInv5M(Image image_0, int int_0)
	{
		int width = int_0;
		int height = int_0;
		Rectangle destRect;
		if (image_0.Width != image_0.Height)
		{
			if (image_0.Width > image_0.Height)
			{
				height = (int)((float)image_0.Height / (float)image_0.Width * (float)int_0);
				destRect = new Rectangle(0, (int_0 - height) / 2, width, height);
			}
			else
			{
				width = (int)((float)image_0.Width / (float)image_0.Height * (float)int_0);
				destRect = new Rectangle((int_0 - width) / 2, 0, width, height);
			}
		}
		else
		{
			destRect = new Rectangle(0, 0, width, height);
		}
		Bitmap bitmap = new Bitmap(int_0, int_0);
		bitmap.SetResolution(image_0.HorizontalResolution, image_0.VerticalResolution);
		int num = 0;
		if (IfnGa2cV6yCIniqCB1du != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			using Graphics graphics = Graphics.FromImage(bitmap);
			graphics.CompositingMode = CompositingMode.SourceCopy;
			graphics.CompositingQuality = CompositingQuality.HighQuality;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			using ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
			graphics.DrawImage(image_0, destRect, 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttributes);
			return bitmap;
		}
		}
	}

	public static bool ConvertToIcon(Stream input, Stream output, IList<int> sizes)
	{
		using Bitmap inputBitmap = (Bitmap)Image.FromStream(input);
		return ConvertToIcon(inputBitmap, output, sizes);
	}

	public static bool ConvertToIcon(string inputPath, string outputPath, IList<int> sizes)
	{
		using FileStream input = new FileStream(inputPath, FileMode.Open);
		using FileStream output = new FileStream(outputPath, FileMode.OpenOrCreate);
		return ConvertToIcon(input, output, sizes);
	}

	public static bool ConvertToIcon(Image inputImage, string outputPath, IList<int> sizes)
	{
		using FileStream output = new FileStream(outputPath, FileMode.OpenOrCreate);
		return ConvertToIcon(new Bitmap(inputImage), output, sizes);
	}

	static ImageHelper()
	{
	}

	internal static bool JtCr5tcVtoFEvFbA2sl5()
	{
		return IfnGa2cV6yCIniqCB1du == null;
	}

	internal static void OwG9V4cV7jXROmd8949S()
	{
	}
}
