using System;

namespace CW.Win32.Shell;

public struct InvokeCommandInfo
{
	public int Size;

	public int Mask;

	public IntPtr Hwnd;

	public IntPtr Verb;

	public IntPtr Parameters;

	public IntPtr Directory;

	public ShowWindowCommand Show;

	public int HotKey;

	public IntPtr Icon;
}
