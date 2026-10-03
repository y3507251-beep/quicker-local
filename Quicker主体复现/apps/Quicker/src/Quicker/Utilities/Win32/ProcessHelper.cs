using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using PInvoke;
using Quicker.Utilities._3rd;

namespace Quicker.Utilities.Win32;

public static class ProcessHelper
{
	public struct ProcessBasicInfo
	{
		internal IntPtr Un02SjPF35D;

		internal IntPtr bhR2SnWJd0a;

		internal IntPtr MvZ2S4yOGGn;

		internal IntPtr yqe2S5EHEYn;

		internal IntPtr Va22SDQ3Efp;

		internal IntPtr Ssc2SdUpXvs;
	}

	private static object eN5PNCFMka5Gt48Atu5c;

	public static bool IsDesktopSoftware(string process)
	{
		if (!string.Equals(process, "DesktopMgr64", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "DesktopMgr", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "360DESKTOP", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "360DESKTOPlite", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "360DESKTOPlite64", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "coodesker", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "coodesker-x64", StringComparison.OrdinalIgnoreCase) && !string.Equals(process, "XZDesktop64", StringComparison.OrdinalIgnoreCase))
		{
			if (!BQULg9FMaZehHF2QbCLU())
			{
				switch (0)
				{
				}
			}
			return string.Equals(process, "XZDesktop", StringComparison.OrdinalIgnoreCase);
		}
		return true;
	}

	public static bool IsDesktopSoftwareByExe(string exe)
	{
		return IsDesktopSoftware(Path.GetFileNameWithoutExtension(exe));
	}

	public static bool IsProcessInBinding(this string processName, string bindingProcesses, bool emptyAsTrue)
	{
		if (string.IsNullOrEmpty(bindingProcesses))
		{
			return emptyAsTrue;
		}
		if (string.IsNullOrEmpty(processName))
		{
			return false;
		}
		int num = bindingProcesses.IndexOf(processName, StringComparison.OrdinalIgnoreCase);
		if (num < 0)
		{
			return false;
		}
		if (num == 0)
		{
			if (bindingProcesses.Length != processName.Length)
			{
				return bindingProcesses[processName.Length].IsEither(',', ';');
			}
			return true;
		}
		if (num > 0)
		{
			if (!bindingProcesses[num - 1].IsEither(',', ';'))
			{
				int num2 = 0;
				if (!BQULg9FMaZehHF2QbCLU())
				{
					int num3 = default(int);
					num2 = num3;
				}
				return num2 switch
				{
					_ => false, 
				};
			}
			if (bindingProcesses.Length > num + processName.Length)
			{
				return bindingProcesses[num + processName.Length].IsEither(',', ';');
			}
			return true;
		}
		return false;
	}

	public static bool IsBindingSameProcess(string bindingProcesses1, string bindingProcesses2)
	{
		if (string.IsNullOrEmpty(bindingProcesses1) != string.IsNullOrEmpty(bindingProcesses2))
		{
			return false;
		}
		if (string.IsNullOrEmpty(bindingProcesses1) && string.IsNullOrEmpty(bindingProcesses2))
		{
			return true;
		}
		string[] array = bindingProcesses1.Split(new char[2] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		if (eN5PNCFMka5Gt48Atu5c != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			int num3 = 0;
			while (true)
			{
				if (num3 < array.Length)
				{
					if (array[num3].IsProcessInBinding(bindingProcesses2, false))
					{
						break;
					}
					num3++;
					continue;
				}
				return false;
			}
			return true;
		}
		}
	}

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess")]
	private static extern int O7GLFVjefXl(IntPtr intptr_0, int int_0, ref ProcessBasicInfo processBasicInfo_0, int int_1, out int int_2);

	public static int GetParentPidIfExists(int pid)
	{
		IntPtr intPtr = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.QueryInformation, false, (uint)pid);
		if (intPtr == IntPtr.Zero)
		{
			return 0;
		}
		try
		{
			ProcessBasicInfo processBasicInfo_ = default(ProcessBasicInfo);
			int int_;
			int num = O7GLFVjefXl(intPtr, 0, ref processBasicInfo_, Marshal.SizeOf(processBasicInfo_), out int_);
			if (num != 0)
			{
				throw new System.ComponentModel.Win32Exception(num);
			}
			int num2 = processBasicInfo_.Ssc2SdUpXvs.ToInt32();
			if (num2 == 0)
			{
				return pid;
			}
			return num2;
		}
		finally
		{
			NativeMethods.CloseHandle(intPtr);
			intPtr = IntPtr.Zero;
		}
	}

	public static int GetBrowserMainProcess(int pid, string procName)
	{
		int parentPidIfExists = GetParentPidIfExists(pid);
		if (parentPidIfExists == 0)
		{
			return pid;
		}
		if (!string.Equals(NativeMethods.GetProcessName(parentPidIfExists), procName, StringComparison.OrdinalIgnoreCase))
		{
			return pid;
		}
		return parentPidIfExists;
	}

	public static IList<string> GetProcList()
	{
		Kernel32.SafeObjectHandle safeObjectHandle = Kernel32.CreateToolhelp32Snapshot(Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPPROCESS, 0);
		List<string> list = new List<string>();
		Kernel32.PROCESSENTRY32 lppe = Kernel32.PROCESSENTRY32.Create();
		try
		{
			while (Kernel32.Process32Next(safeObjectHandle, ref lppe))
			{
				list.Add($"{lppe.th32ProcessID} {lppe.ExeFile}");
			}
			return list;
		}
		finally
		{
			safeObjectHandle.Close();
		}
	}

	internal static bool BQULg9FMaZehHF2QbCLU()
	{
		return eN5PNCFMka5Gt48Atu5c == null;
	}
}
