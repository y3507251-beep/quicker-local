using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using log4net;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace yyXIB9Yxgd6ACb7T4ig;

internal class j53dHOYtcRyb9edAMaZ
{
	private static readonly ILog p3XL5OtFmM3;

	public static string wjDL5FVXCxu;

	private static j53dHOYtcRyb9edAMaZ hLqN8VFlahfr728FXB6u;

	static j53dHOYtcRyb9edAMaZ()
	{
		p3XL5OtFmM3 = LogManager.GetLogger(typeof(ImageCache));
		wjDL5FVXCxu = AppHelper.GetUserDataDir("ImageCache");
	}

	internal static string ercL5MLtTEv(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (SHA1Managed sHA1Managed = new SHA1Managed())
		{
			byte[] array = sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(string_1));
			stringBuilder.Append(BitConverter.ToString(array).Replace("-", "").ToUpperInvariant());
			string extension = Path.GetExtension(Path.GetFileName(new Uri(string_1).LocalPath));
			if (extension.EqualsAny(true, ".png", ".jpg", ".jpeg", ".svg", ".tiff", ".apng", ".gif", ".bmp", ".webp"))
			{
				stringBuilder.Append(extension);
			}
			else
			{
				stringBuilder.Append(".png");
			}
		}
		string path = stringBuilder.ToString();
		return Path.Combine(wjDL5FVXCxu, path);
	}

	public static bool tpOL5AcxHf9(string string_1)
	{
		return File.Exists(string_1);
	}

	internal static bool WcgWL3FlrxYTDnQW8p6m()
	{
		return hLqN8VFlahfr728FXB6u == null;
	}
}
