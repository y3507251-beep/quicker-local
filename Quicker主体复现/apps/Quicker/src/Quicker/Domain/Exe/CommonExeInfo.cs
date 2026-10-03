using System;
using System.Globalization;
using Quicker.Properties;
using Quicker.View;

namespace Quicker.Domain.Exe;

public static class CommonExeInfo
{
	private static object dYUEjeQ1NXej4DeAwbxV;

	public static ExeInfo Global => new ExeInfo
	{
		Name = CommonStrings.CommonExeInfo_Global_Name,
		Exe = "_global",
		Path = "_global",
		Description = CommonStrings.CommonExeInfo_Global_Desc,
		IconStr = ExeFileIconHelper.GetGlobalProfileImageStr()
	};

	public static ExeInfo Common => new ExeInfo
	{
		Name = CommonStrings.CommonExeInfo_Common_Name,
		Exe = "common",
		Path = "common",
		Description = CommonStrings.CommonExeInfo_Common_Desc,
		IconStr = ExeFileIconHelper.GetCommonProfileImageStr()
	};

	public static ExeInfo Taskbar => new ExeInfo
	{
		Name = CommonStrings.CommonExeInfo_Taskbar_Name,
		Exe = "taskbar",
		Path = "taskbar",
		Description = CommonStrings.CommonExeInfo_Taskbar_Desc,
		IconStr = ExeFileIconHelper.GetTaskbarImageStr()
	};

	public static ExeInfo Desktop => new ExeInfo
	{
		Name = CommonStrings.CommonExeInfo_Desktop_Name,
		Exe = "desktop",
		Path = "desktop",
		Description = CommonStrings.CommonExeInfo_Desktop_Desc,
		IconStr = ExeFileIconHelper.GetDesktopImageStr()
	};

	public static ExeInfo GetCommonExeInfo(string exeName)
	{
		if (exeName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidOperationException("不是一个通用Exe");
		}
		return exeName.ToLower(CultureInfo.InvariantCulture) switch
		{
			"desktop" => Desktop, 
			"taskbar" => Taskbar, 
			"common" => Common, 
			"_global" => Global, 
			_ => null, 
		};
	}

	public static bool IsCommonExe(string exeName)
	{
		switch (exeName.ToLowerInvariant())
		{
		default:
			return false;
		case "_global":
		case "common":
		case "desktop":
		case "taskbar":
			return true;
		}
	}

	public static string GetCommonExeName(string exeName)
	{
		ExeInfo commonExeInfo = GetCommonExeInfo(exeName);
		object obj;
		if (commonExeInfo == null)
		{
			obj = null;
		}
		else
		{
			obj = commonExeInfo.Name;
			if (obj != null)
			{
				goto IL_0017;
			}
		}
		obj = exeName;
		goto IL_0017;
		IL_0017:
		return (string)obj;
	}

	static CommonExeInfo()
	{
	}

	internal static bool J0xsOLQ191mcUUr7jl4t()
	{
		return dYUEjeQ1NXej4DeAwbxV == null;
	}

	internal static void t5T4jVQ1qJGnO3BqKyRE()
	{
	}
}
