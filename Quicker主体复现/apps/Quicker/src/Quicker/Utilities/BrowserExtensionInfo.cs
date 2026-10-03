using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Win32;

namespace Quicker.Utilities;

public class BrowserExtensionInfo
{
	[CompilerGenerated]
	private string Qi5LocurWXW;

	[CompilerGenerated]
	private string AiALoVH4Lf3;

	[CompilerGenerated]
	private string L8LLoZEBXHU;

	[CompilerGenerated]
	private string YQdLo9jeZsY;

	[CompilerGenerated]
	private string ITgLoheGK9y;

	[CompilerGenerated]
	private string qvdLoe5MiDF;

	[CompilerGenerated]
	private string rXnLoYw5JAk;

	private static BrowserExtensionInfo oHRDpvF5OUBT5REnVei2;

	public string Browser
	{
		[CompilerGenerated]
		get
		{
			return Qi5LocurWXW;
		}
		[CompilerGenerated]
		set
		{
			Qi5LocurWXW = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return AiALoVH4Lf3;
		}
		[CompilerGenerated]
		set
		{
			AiALoVH4Lf3 = value;
		}
	}

	public string ExtId
	{
		[CompilerGenerated]
		get
		{
			return L8LLoZEBXHU;
		}
		[CompilerGenerated]
		set
		{
			L8LLoZEBXHU = value;
		}
	}

	public string RegKey32
	{
		[CompilerGenerated]
		get
		{
			return YQdLo9jeZsY;
		}
		[CompilerGenerated]
		set
		{
			YQdLo9jeZsY = value;
		}
	}

	public string RegKey64
	{
		[CompilerGenerated]
		get
		{
			return ITgLoheGK9y;
		}
		[CompilerGenerated]
		set
		{
			ITgLoheGK9y = value;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return qvdLoe5MiDF;
		}
		[CompilerGenerated]
		set
		{
			qvdLoe5MiDF = value;
		}
	}

	public string UpdateUrl
	{
		[CompilerGenerated]
		get
		{
			return rXnLoYw5JAk;
		}
		[CompilerGenerated]
		set
		{
			rXnLoYw5JAk = value;
		}
	}

	public bool IsInstalled()
	{
		try
		{
			return Directory.Exists(System.IO.Path.Combine(Environment.ExpandEnvironmentVariables(Path), ExtId));
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("获取插件路径信息出错：" + ex.Message);
			return false;
		}
	}

	public void InstallExt()
	{
		string text = MijLoqGn7ym();
		string contents = "Windows Registry Editor Version 5.00\r\n\r\n[HKEY_LOCAL_MACHINE\\" + text + "\\" + ExtId + "]\r\n\"update_url\"=\"" + UpdateUrl + "\"\r\n";
		string text2 = AppHelper.mXLLT4tZBNH(".reg");
		File.WriteAllText(text2, contents, Encoding.Unicode);
		Process.Start(new ProcessStartInfo
		{
			Verb = "runas",
			UseShellExecute = true,
			FileName = "regedit.exe",
			Arguments = "/s \"" + text2 + "\""
		}).WaitForExit();
	}

	private string MijLoqGn7ym()
	{
		if (!Environment.Is64BitOperatingSystem)
		{
			return RegKey32;
		}
		return RegKey64;
	}

	public void RemoveExt()
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(MijLoqGn7ym(), true);
		registryKey.DeleteSubKey(ExtId);
	}

	internal static bool mHWKYUF5Jwe6Vjb6ADjB()
	{
		return oHRDpvF5OUBT5REnVei2 == null;
	}
}
