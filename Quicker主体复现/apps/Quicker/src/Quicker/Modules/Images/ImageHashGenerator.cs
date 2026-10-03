using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Quicker.Modules.Images;

public class ImageHashGenerator
{
	internal static ImageHashGenerator wEIFkrQ3p7oqGam0VHlR;

	public string GetHashFromImage(ImageSource image)
	{
		if (!(image is BitmapSource source))
		{
			return null;
		}
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
			BitmapFrame bitmapFrame = BitmapFrame.Create(source);
			bitmapFrame.Freeze();
			jpegBitmapEncoder.Frames.Add(bitmapFrame);
			jpegBitmapEncoder.Save(memoryStream);
			byte[] buffer = memoryStream.GetBuffer();
			using SHA1 sHA = SHA1.Create();
			return Convert.ToBase64String(sHA.ComputeHash(buffer));
		}
		catch (Exception)
		{
			return null;
		}
	}

	internal static bool Wg8RVIQ3XXLgYrkJVBRv()
	{
		return wEIFkrQ3p7oqGam0VHlR == null;
	}
}
