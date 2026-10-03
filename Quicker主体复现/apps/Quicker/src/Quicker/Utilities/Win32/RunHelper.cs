using System;
using System.Runtime.InteropServices;

namespace Quicker.Utilities.Win32;

public static class RunHelper
{
	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public uint dwProcessId;

		public uint dwThreadId;
	}

	public struct STARTUPINFO
	{
		public uint cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public uint dwX;

		public uint dwY;

		public uint dwXSize;

		public uint dwYSize;

		public uint dwXCountChars;

		public uint dwYCountChars;

		public uint dwFillAttribute;

		public uint dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public IntPtr lpReserved2;

		public IntPtr hStdInput;

		public IntPtr hStdOutput;

		public IntPtr hStdError;
	}

	private static object X7S0kIFMNWAVM4ogQ82X;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateProcess", SetLastError = true)]
	private static extern bool YZCLFZaGfr0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref STARTUPINFO startupinfo_0, out PROCESS_INFORMATION process_INFORMATION_0);

	public static bool Run(string commandLine, out PROCESS_INFORMATION pi)
	{
		STARTUPINFO startupinfo_ = default(STARTUPINFO);
		pi = default(PROCESS_INFORMATION);
		return YZCLFZaGfr0(null, commandLine, IntPtr.Zero, IntPtr.Zero, false, 0u, IntPtr.Zero, null, ref startupinfo_, out pi);
	}

	internal static bool lknHTeFM9DUO2vEkek93()
	{
		return X7S0kIFMNWAVM4ogQ82X == null;
	}
}
