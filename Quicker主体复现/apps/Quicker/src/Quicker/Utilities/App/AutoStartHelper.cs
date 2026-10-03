using System;
using System.Reflection;
using log4net;
using Microsoft.Win32;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities.App;

public static class AutoStartHelper
{
	private static readonly ILog KFwLOYfsYvM;

	internal static object gG5S4LFPKQFAmq7C7igI;

	public static bool IsAutoStart()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
			if (registryKey != null && registryKey.GetValue("Quicker") != null)
			{
				return true;
			}
			return false;
		}
		catch (Exception exception)
		{
			KFwLOYfsYvM.Warn("获取自动启动状态出错:" + exception.GetMessageWithInner(), exception);
			return false;
		}
	}

	public static bool SetAutoStart(bool autoStart)
	{
		try
		{
			if (autoStart)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (registryKey == null)
				{
					if (e7VPJRFPBdh6HUnuGDyO())
					{
						switch (0)
						{
						}
					}
					registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
				registryKey.SetValue("Quicker", "\"" + AppHelper.GetAppExePath() + "\" -autorun");
				registryKey?.Close();
			}
			else
			{
				using RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				registryKey2?.DeleteValue("Quicker", false);
			}
			return true;
		}
		catch (Exception ex)
		{
			KFwLOYfsYvM.Error("自动启动写入注册表失败：" + ex.Message, ex);
			AppHelper.ShowWarning("自动启动选项注册表写入失败，请将Quicker加入安全软件的信任列表。" + ex.Message, true);
			return false;
		}
	}

	static AutoStartHelper()
	{
		KFwLOYfsYvM = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool e7VPJRFPBdh6HUnuGDyO()
	{
		return gG5S4LFPKQFAmq7C7igI == null;
	}
}
