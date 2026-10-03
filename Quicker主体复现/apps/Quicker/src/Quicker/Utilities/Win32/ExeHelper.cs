using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using log4net;

namespace Quicker.Utilities.Win32;

public static class ExeHelper
{
	private static readonly ILog lPwLFw4aK53;

	private static object AHwlvDFMQht07FC81dkV;

	public static string GetFileDescription(string filePathName)
	{
		try
		{
			if (!File.Exists(filePathName))
			{
				return Path.GetFileNameWithoutExtension(filePathName);
			}
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filePathName);
			if (!string.IsNullOrEmpty(versionInfo.FileDescription))
			{
				return versionInfo.FileDescription;
			}
			return Path.GetFileNameWithoutExtension(filePathName);
		}
		catch (Exception ex)
		{
			lPwLFw4aK53.Warn("无法获取文件的说明。" + ex.Message, ex);
			return Path.GetFileNameWithoutExtension(filePathName);
		}
	}

	static ExeHelper()
	{
		lPwLFw4aK53 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool RgOaeAFMF4jY6uZywFFm()
	{
		return AHwlvDFMQht07FC81dkV == null;
	}
}
