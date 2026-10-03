using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using d4tWy4Mv65mxaXtw8eI;
using log4net;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace eHGj15MUIx8QneCHitQ;

internal static class tZZhZGM4HaKvySF2OqY
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GkA2SccdCQl;

		private static _003C_003Ec RhuHcWyEjilRTEq0raHv;

		static _003C_003Ec()
		{
			GkA2SccdCQl = new _003C_003Ec();
		}

		internal string ynw2SqhdI1p(uint pid)
		{
			return NativeMethods.GetProcessFilePath(pid);
		}

		internal static bool c14FRCyEDIAiZWicqvgf()
		{
			return RhuHcWyEjilRTEq0raHv == null;
		}

		internal static void PyarxayEEyfiClJgKrVf()
		{
		}
	}

	private static readonly ILog U6TLOrxWXsp;

	private static readonly gGjMwBMgfVwrmpjVjDh<uint, string> WlfLOpccHOV;

	private static object F73iDXFP5mZnl9or7wXm;

	public static string ulvLOm7PgsE(uint uint_0)
	{
		return WlfLOpccHOV.fH3LOB69sE2(uint_0);
	}

	public static (string fileName, string path) S25LOK4WqVA(uint uint_0)
	{
		try
		{
			string text = ulvLOm7PgsE(uint_0);
			if (!string.IsNullOrEmpty(text))
			{
				return (fileName: string.Intern(Path.GetFileName(text)), path: text);
			}
			return (fileName: string.Empty, path: string.Empty);
		}
		catch (Exception exception)
		{
			U6TLOrxWXsp.Warn("获取进程路径失败：" + exception.GetMessageWithInner());
			return (fileName: "unknown-proc.exe", path: "");
		}
	}

	public static string u1MLOxTPiyo(uint uint_0)
	{
		try
		{
			string text = ulvLOm7PgsE(uint_0);
			if (!string.IsNullOrEmpty(text))
			{
				return Path.GetFileName(text);
			}
			return string.Empty;
		}
		catch (Exception exception)
		{
			U6TLOrxWXsp.Warn("获取进程路径失败：" + exception.GetMessageWithInner());
			return "unknown-proc.exe";
		}
	}

	static tZZhZGM4HaKvySF2OqY()
	{
		U6TLOrxWXsp = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		WlfLOpccHOV = new gGjMwBMgfVwrmpjVjDh<uint, string>(300000, _003C_003Ec.GkA2SccdCQl.ynw2SqhdI1p);
	}

	internal static bool w4QacfFPY6ZMH9C3p9Q0()
	{
		return F73iDXFP5mZnl9or7wXm == null;
	}
}
