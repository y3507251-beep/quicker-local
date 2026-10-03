using System;
using System.Diagnostics;
using System.IO;
using Quicker.Utilities;

namespace wRnoADYMWoP6pH6Uoa0;

internal class dGYI6iYYvlg2idKQBAd
{
	internal static dGYI6iYYvlg2idKQBAd bGtkxKFnmU6KjhwaEbtN;

	public static void QONLSJOMusv()
	{
		string contents = "Windows Registry Editor Version 5.00\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\BraveSoftware\\Brave]\r\n\"ExtensionManifestV2Availability\"=dword:00000002\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Chromium]\r\n\"ExtensionManifestV2Availability\"=dword:00000002\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome]\r\n\"ExtensionManifestV2Availability\"=dword:00000002\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge]\r\n\"ExtensionManifestV2Availability\"=dword:00000002\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Vivaldi]\r\n\"ExtensionManifestV2Availability\"=dword:00000002\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\YandexBrowser]\r\n\"ExtensionManifestV2Availability\"=dword:00000002";
		string text = Path.Combine(Path.GetTempPath(), "EnableExtensionManifestV2.reg");
		File.WriteAllText(text, contents);
		iBELS0Bybw4(text);
	}

	public static void iBELS0Bybw4(string string_0)
	{
		try
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "regedit.exe",
				Arguments = "/s \"" + string_0 + "\"",
				Verb = "runas",
				UseShellExecute = true
			});
			process.WaitForExit();
			if (process.ExitCode == 0)
			{
				AppHelper.ShowSuccess("注册表文件已成功导入.");
			}
			else
			{
				AppHelper.ShowWarning("导入注册表文件时发生错误.");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法导入注册表文件: " + ex.Message);
		}
	}

	static dGYI6iYYvlg2idKQBAd()
	{
	}

	internal static bool n5LVS5FnsrNG37GP64b5()
	{
		return bGtkxKFnmU6KjhwaEbtN == null;
	}

	internal static void Tg65phFnhLcUyeVJ2BLb()
	{
	}
}
