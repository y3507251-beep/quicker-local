using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using log4net;
using Quicker.Utilities;

namespace Quicker.Domain.Exe;

public static class ExeFileIconHelper
{
	private static readonly ILog yU7tV2OCn6Z;

	internal static object gI0ZDTQ1ixNjDuyKeD5t;

	public static ImageSource GetTaskbarImage()
	{
		return AppHelper.GetResourceImage("taskbar2.png");
	}

	public static ImageSource GetDesktopImage()
	{
		return AppHelper.GetResourceImage("desktop.png");
	}

	public static ImageSource GetCommonProfileImage()
	{
		return AppHelper.GetResourceImage("common.png");
	}

	public static ImageSource GetGlobalProfileImage()
	{
		return AppHelper.GetResourceImage("buttons_pad.png");
	}

	public static ImageSource GetCommonExeProfileImage()
	{
		return AppHelper.GetResourceImage("window_gray.png");
	}

	public static string GetTaskbarImageStr()
	{
		return "taskbar2.png";
	}

	public static string GetDesktopImageStr()
	{
		return "desktop.png";
	}

	public static string GetCommonProfileImageStr()
	{
		return "common.png";
	}

	public static string GetGlobalProfileImageStr()
	{
		return "buttons_pad.png";
	}

	public static string GetCommonExeProfileImageStr()
	{
		return "window_gray.png";
	}

	public static ImageSource GetExeFileIcon(string exeFileName, string exeFullPath)
	{
		if (string.Equals(exeFileName, CommonExeInfo.Global.Exe, StringComparison.OrdinalIgnoreCase))
		{
			return GetGlobalProfileImage();
		}
		if (string.Equals(exeFileName, CommonExeInfo.Common.Exe, StringComparison.OrdinalIgnoreCase))
		{
			return GetCommonProfileImage();
		}
		if (string.Equals(exeFileName, "taskbar", StringComparison.OrdinalIgnoreCase))
		{
			return GetTaskbarImage();
		}
		if (string.Equals(exeFileName, "desktop", StringComparison.OrdinalIgnoreCase))
		{
			return GetDesktopImage();
		}
		if (string.Equals(exeFileName, "explorer.exe", StringComparison.OrdinalIgnoreCase) && File.Exists("c:\\Windows\\explorer.exe"))
		{
			int num = 0;
			if (gI0ZDTQ1ixNjDuyKeD5t != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				using Icon icon = Icon.ExtractAssociatedIcon("c:\\Windows\\explorer.exe");
				return IconHelper.IconToImageSource(icon);
			}
			}
		}
		if (File.Exists(exeFullPath))
		{
			try
			{
				using Icon icon2 = Icon.ExtractAssociatedIcon(exeFullPath);
				return IconHelper.IconToImageSource(icon2);
			}
			catch (Exception exception)
			{
				yU7tV2OCn6Z.Warn("获取图标失败.", exception);
				return GetCommonExeProfileImage();
			}
		}
		return IconHelper.UrlToBitmapSource(AppHelper.fpULTDMjTQ3(exeFileName));
	}

	public static string GetExeFileIconStr(string exeFileName, string exeFullPath)
	{
		if (string.Equals(exeFileName, CommonExeInfo.Global.Exe, StringComparison.OrdinalIgnoreCase))
		{
			return "buttons_pad.png";
		}
		if (string.Equals(exeFileName, CommonExeInfo.Common.Exe, StringComparison.OrdinalIgnoreCase))
		{
			return "common.png";
		}
		if (string.Equals(exeFileName, "taskbar", StringComparison.OrdinalIgnoreCase))
		{
			return "taskbar2.png";
		}
		if (string.Equals(exeFileName, "desktop", StringComparison.OrdinalIgnoreCase))
		{
			return "desktop.png";
		}
		if (string.Equals(exeFileName, "explorer.exe", StringComparison.OrdinalIgnoreCase) && File.Exists("c:\\Windows\\explorer.exe"))
		{
			return "icon:c:\\Windows\\explorer.exe";
		}
		if (File.Exists(exeFullPath))
		{
			return "icon:" + exeFullPath;
		}
		return "url:" + AppHelper.fpULTDMjTQ3(exeFileName);
	}

	static ExeFileIconHelper()
	{
		yU7tV2OCn6Z = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool mD8MXhQ1lcPW17egMPy6()
	{
		return gI0ZDTQ1ixNjDuyKeD5t == null;
	}
}
