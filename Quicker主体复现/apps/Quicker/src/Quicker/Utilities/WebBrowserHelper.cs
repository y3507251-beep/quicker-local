using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace Quicker.Utilities;

public static class WebBrowserHelper
{
	internal static object htCOKwFYLbnv5AL5qhZT;

	public static int GetEmbVersion()
	{
		int browserVersion = GetBrowserVersion();
		if (browserVersion > 9)
		{
			return browserVersion * 1000 + 1;
		}
		if (browserVersion > 7)
		{
			return browserVersion * 1111;
		}
		return 7000;
	}

	public static void FixBrowserVersion()
	{
		FixBrowserVersion(Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location));
	}

	public static void FixBrowserVersion(string appName)
	{
		FixBrowserVersion(appName, GetEmbVersion());
	}

	public static void FixBrowserVersion(string appName, int ieVer)
	{
		dO5LoiIGC48("HKEY_LOCAL_MACHINE", appName + ".exe", ieVer);
		dO5LoiIGC48("HKEY_CURRENT_USER", appName + ".exe", ieVer);
		dO5LoiIGC48("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", ieVer);
		dO5LoiIGC48("HKEY_CURRENT_USER", appName + ".vshost.exe", ieVer);
	}

	private static void dO5LoiIGC48(string string_0, string string_1, int int_0)
	{
		try
		{
			if (Environment.Is64BitOperatingSystem)
			{
				Registry.SetValue(string_0 + "\\Software\\Wow6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", string_1, int_0);
			}
			else
			{
				Registry.SetValue(string_0 + "\\Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", string_1, int_0);
			}
		}
		catch (Exception)
		{
		}
	}

	public static int GetBrowserVersion()
	{
		string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Internet Explorer";
		string[] array = new string[4] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			string text = Convert.ToString(Registry.GetValue(keyName, array[i], "0"), CultureInfo.InvariantCulture);
			if (text == null)
			{
				continue;
			}
			int num2 = text.IndexOf('.');
			if (num2 > 0)
			{
				text = text.Substring(0, num2);
			}
			int result = 0;
			if (!int.TryParse(text, out result))
			{
				continue;
			}
			num = Math.Max(num, result);
			if (P11Y84FYuYxMOScvDlIQ())
			{
				switch (0)
				{
				}
			}
		}
		return num;
	}

	internal static bool P11Y84FYuYxMOScvDlIQ()
	{
		return htCOKwFYLbnv5AL5qhZT == null;
	}
}
