using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Quicker.Native.ShellMenu;

public class SafeHBitmapHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private static SafeHBitmapHandle V02Jw6txQdO6NxLAKIy;

	public IntPtr Handle => handle;

	[SecurityCritical]
	public SafeHBitmapHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	protected override bool ReleaseHandle()
	{
		return DeleteObject(handle);
	}

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr hObject);

	internal static bool BItGW1tIaMVtg6LIoHY()
	{
		return V02Jw6txQdO6NxLAKIy == null;
	}
}
