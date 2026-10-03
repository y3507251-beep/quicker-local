using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using log4net;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public class HostedProcessHelper
{
	private static readonly ILog g3ALMmnehRK;

	private Process SCfLMKrOmut;

	internal static HostedProcessHelper RZdKIWFR5deOrkJCgENc;

	[DllImport("user32.dll", EntryPoint = "IsImmersiveProcess")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool z8ULMbAmm3x(IntPtr intptr_0);

	public static bool IsHostProcess(Process process)
	{
		return process.ProcessName == "ApplicationFrameHost";
	}

	public static bool IsHostProcess(string processName)
	{
		return string.Equals(processName, "ApplicationFrameHost", StringComparison.OrdinalIgnoreCase);
	}

	public static bool IsHostProcessExe(string fileName)
	{
		return string.Equals(fileName, "ApplicationFrameHost.exe", StringComparison.OrdinalIgnoreCase);
	}

	public static Process GetRealProcess(Process hostProcess)
	{
		return new HostedProcessHelper().n7RLM6FSx1A(hostProcess);
	}

	private Process n7RLM6FSx1A(Process process_1)
	{
		NativeMethods.EnumChildWindows(process_1.MainWindowHandle, avpLMX4e5MR, IntPtr.Zero);
		return SCfLMKrOmut;
	}

	private bool avpLMX4e5MR(IntPtr intptr_0, IntPtr intptr_1)
	{
		try
		{
			Process processById = Process.GetProcessById(NativeMethods.GetWindowProcessId(intptr_0));
			if (processById.ProcessName != "ApplicationFrameHost")
			{
				SCfLMKrOmut = processById;
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			g3ALMmnehRK.Warn("获取UWP实际进程出错：" + ex.Message, ex);
			return false;
		}
	}

	static HostedProcessHelper()
	{
		g3ALMmnehRK = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool m00C0ZFRYRA0vcmfr5qE()
	{
		return RZdKIWFR5deOrkJCgENc == null;
	}

	internal static void Js3ONkFRPmn6O3NMVKNm()
	{
	}
}
