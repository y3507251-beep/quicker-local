using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using O5blBdM6bCRI1gbI3U2;
using Quicker.Domain.Exe;

namespace Quicker.Utilities.UI;

public class ExeIconConverter : IValueConverter
{
	private static ExeIconConverter rflwTdFzJh0ucSSTspre;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null && !string.IsNullOrEmpty(value.ToString()))
		{
			string text = value.ToString();
			if (text.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
			{
				string text2 = iah68iMf4KvhT7ULCsJ.DpvLoo2xNQd(text.Substring("StoreApp:".Length));
				if (File.Exists(text2))
				{
					return IconHelper.FileToImageSource(text2);
				}
				return null;
			}
			return ExeFileIconHelper.GetExeFileIcon(Path.GetFileName(text), text);
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool rMJAkWFzkbO4tGR3yIRA()
	{
		return rflwTdFzJh0ucSSTspre == null;
	}
}
