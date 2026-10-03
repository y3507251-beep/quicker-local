using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CW.Win32;

public class ComTaskMemory : DisposableObject
{
	[CompilerGenerated]
	private IntPtr s8H0zjcShO;

	internal static ComTaskMemory qBap0VGOU8fBpmMxwAv;

	public IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return s8H0zjcShO;
		}
		[CompilerGenerated]
		private set
		{
			s8H0zjcShO = value;
		}
	}

	public ComTaskMemory(IntPtr handle)
	{
		Handle = handle;
	}

	protected override void Dispose(bool disposing)
	{
		if (Handle != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(Handle);
			Handle = IntPtr.Zero;
		}
	}

	internal static bool hFdDsxGJZNOElxXFFj6()
	{
		return qBap0VGOU8fBpmMxwAv == null;
	}
}
