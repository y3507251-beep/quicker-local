using System;
using System.Diagnostics;
using System.Reflection;
using log4net;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public class UwpProcessHelper
{
	private static readonly ILog a7fLoUenY7m;

	private Process LuMLoljQboi;

	internal static UwpProcessHelper Le4QPSFYa5lN9VCIPrt2;

	public Process GetRealProcess(IntPtr mainWindow)
	{
		NativeMethods.EnumChildWindows(mainWindow, BEnLoFhh1nV, IntPtr.Zero);
		return LuMLoljQboi;
	}

	private bool BEnLoFhh1nV(IntPtr intptr_0, IntPtr intptr_1)
	{
		try
		{
			if (NativeMethods.GetWindowClass(intptr_0) == "Windows.UI.Core.CoreWindow")
			{
				int windowProcessId = NativeMethods.GetWindowProcessId(intptr_0);
				LuMLoljQboi = Process.GetProcessById(windowProcessId);
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			a7fLoUenY7m.Warn("获取UWP实际进程出错：" + ex.Message, ex);
			return true;
		}
	}

	static UwpProcessHelper()
	{
		a7fLoUenY7m = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool NKk6TxFYrgqOFFNF68Hj()
	{
		return Le4QPSFYa5lN9VCIPrt2 == null;
	}

	internal static void T0de8xFY9fke7iJqqA5v()
	{
	}
}
