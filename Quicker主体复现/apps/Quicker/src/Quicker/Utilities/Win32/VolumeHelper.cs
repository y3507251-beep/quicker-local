using System;
using System.Runtime.InteropServices;

namespace Quicker.Utilities.Win32;

public static class VolumeHelper
{
	private static object plTF2BFMbKkESGmI1NKa;

	[DllImport("user32.dll", EntryPoint = "SendMessageW")]
	private static extern IntPtr r50LF937UH7(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	public static void Mute()
	{
		IntPtr shellWindow = NativeMethods.GetShellWindow();
		r50LF937UH7(shellWindow, 793, shellWindow, (IntPtr)524288);
	}

	public static void VolDown()
	{
		IntPtr shellWindow = NativeMethods.GetShellWindow();
		r50LF937UH7(shellWindow, 793, shellWindow, (IntPtr)589824);
	}

	public static void VolUp()
	{
		IntPtr shellWindow = NativeMethods.GetShellWindow();
		r50LF937UH7(shellWindow, 793, shellWindow, (IntPtr)655360);
	}

	internal static bool DRmJnGFMquTGhZnLqNlO()
	{
		return plTF2BFMbKkESGmI1NKa == null;
	}
}
