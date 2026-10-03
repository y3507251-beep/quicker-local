using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

public struct ShellExecuteInfo
{
	public int Size;

	public ShellExecuteExMask Mask;

	public IntPtr Handle;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string Verb;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string File;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string Parameters;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string Directory;

	public ShowWindowCommand Show;

	public IntPtr InstApp;

	public IntPtr IDList;

	[MarshalAs(UnmanagedType.LPTStr)]
	public string Class;

	public IntPtr KeyClass;

	public uint HotKey;

	public IntPtr Icon;

	public IntPtr Process;
}
