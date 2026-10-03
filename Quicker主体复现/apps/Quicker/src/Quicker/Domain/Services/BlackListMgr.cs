using System;
using System.Collections.Generic;
using System.Linq;
using CW;
using Quicker.Common.Entities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Services;

public static class BlackListMgr
{
	private static readonly IList<string> F6ktH75iStI;

	private static bool nPttHRIX4gN;

	private static object fLTsVxQa8YpeIICK7p0a;

	public static bool IsInBlackList(string exeFileName, string path)
	{
		if (!string.Equals(exeFileName, "LockApp.exe", StringComparison.OrdinalIgnoreCase) && !string.Equals(exeFileName, "LockAppHost.exe", StringComparison.OrdinalIgnoreCase))
		{
			if (AppState.DataService.CpItmVISR7P().SpecialExeList != null && AppState.DataService.CpItmVISR7P().SpecialExeList.Count != 0)
			{
				int num2 = default(int);
				foreach (SpecialExeItem specialExe in AppState.DataService.CpItmVISR7P().SpecialExeList)
				{
					if (specialExe.ExeName.IsNullOrEmpty())
					{
						continue;
					}
					int num = 0;
					if (fLTsVxQa8YpeIICK7p0a != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
					if (specialExe.ExeName.Length < 2 || specialExe.ExeName[1] != ':' || string.IsNullOrEmpty(path) || !path.StartsWith(specialExe.ExeName, StringComparison.OrdinalIgnoreCase))
					{
						if (string.Equals(specialExe.ExeName, exeFileName, StringComparison.OrdinalIgnoreCase))
						{
							return true;
						}
						continue;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public static bool IsCurrentAppInBlackListOrDisabledByFullScreen()
	{
		if (IsInBlackList(AppState.CurrentExeName, AppState.CurrentExePath))
		{
			return true;
		}
		return IsDisabledFullscreenWindow(NativeMethods.GetForegroundWindow(), AppState.CurrentExeName);
	}

	public static bool IsDisabledFullscreenWindow(IntPtr hWnd, string exeName)
	{
		if (!AppState.HHxtaMaoqJr().DisableOnFullscreenApp)
		{
			return false;
		}
		return IsForegroundFullScreen(hWnd, exeName);
	}

	public static bool IsForegroundFullScreen(IntPtr hWnd, string exeName)
	{
		if (!string.Equals(exeName, "desktop", StringComparison.OrdinalIgnoreCase) && !ProcessHelper.IsDesktopSoftwareByExe(exeName) && !string.Equals(exeName, "explorer.exe", StringComparison.OrdinalIgnoreCase) && !string.Equals(AppState.CurrentExeName, "desktop", StringComparison.OrdinalIgnoreCase))
		{
			if (NativeMethods.IsForegroundFullScreen(hWnd))
			{
				return !IsInFullScreenWhiteList(exeName);
			}
			return false;
		}
		return false;
	}

	public static void UpdateFullscreenWhiteList()
	{
		F6ktH75iStI.Clear();
		if (!string.IsNullOrEmpty(AppState.HHxtaMaoqJr().AllowedFullscreenProcesses))
		{
			foreach (string item in AppState.HHxtaMaoqJr().AllowedFullscreenProcesses.Split(new char[6] { ',', ';', '；', '，', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList())
			{
				F6ktH75iStI.Add(item.ToLower().Trim());
			}
		}
		nPttHRIX4gN = true;
	}

	public static bool IsInFullScreenWhiteList(string exeName)
	{
		if (!nPttHRIX4gN)
		{
			UpdateFullscreenWhiteList();
		}
		foreach (string item in F6ktH75iStI)
		{
			if (exeName.StartsWith(item, StringComparison.OrdinalIgnoreCase) && (string.Equals(exeName, item, StringComparison.OrdinalIgnoreCase) || string.Equals(exeName, item + ".exe", StringComparison.OrdinalIgnoreCase)))
			{
				return true;
			}
		}
		return false;
	}

	static BlackListMgr()
	{
		F6ktH75iStI = new List<string>();
		nPttHRIX4gN = false;
	}

	internal static bool eQctY3QaRe4eO3D2xJ0e()
	{
		return fLTsVxQa8YpeIICK7p0a == null;
	}
}
