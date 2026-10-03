using System;
using PInvoke;

namespace Quicker.Utilities.Ext;

public static class IntPtrExt
{
	private static object XrTbuGFxiT3DtqoGQOY5;

	public static string GetWindowTitle(this IntPtr hWnd)
	{
		if (hWnd == IntPtr.Zero)
		{
			return "";
		}
		return User32.GetWindowText(hWnd);
	}

	internal static bool e8u1A4FxlKc7S9BsuedE()
	{
		return XrTbuGFxiT3DtqoGQOY5 == null;
	}
}
