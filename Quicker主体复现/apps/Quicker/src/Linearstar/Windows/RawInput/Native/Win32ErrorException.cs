using System;
using System.Runtime.InteropServices;
using uDL5IgqaOLgOa1ojKgW;

namespace Linearstar.Windows.RawInput.Native;

public class Win32ErrorException : Exception
{
	internal static Win32ErrorException tcaSDHZDarkEB13UeAF;

	public Win32ErrorException()
		: this(Marshal.GetLastWin32Error())
	{
	}

	public Win32ErrorException(int win32ErrorCode)
		: base(EnuqjjqpaxFuoWX08Ny.YGxsc88AFI(win32ErrorCode))
	{
	}

	internal static bool rtvck3Z341gXMRqj6UE()
	{
		return tcaSDHZDarkEB13UeAF == null;
	}
}
