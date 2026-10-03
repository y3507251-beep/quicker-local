using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CW.Win32;

public static class Kernel32
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(SafeFileHandle file, out ByHandleFileInformation fileInformation);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern SafeFileHandle CreateFileW([In][MarshalAs(UnmanagedType.LPWStr)] string fileName, FileAccess desiredAccess, FileShare shareMode, IntPtr securityAttributes, FileMode createDisposition, FileOptions flagsAndAttributes, IntPtr templateFile);

	[DllImport("kernel32")]
	public static extern int GlobalAddAtom(string str);

	[DllImport("kernel32")]
	public static extern int GlobalDeleteAtom(int atom);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string lpFileName);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll")]
	public static extern bool FreeLibrary(IntPtr hLibModule);
}
