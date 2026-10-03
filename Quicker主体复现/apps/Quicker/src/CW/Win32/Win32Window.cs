using System;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public class Win32Window : DisposableObject
{
	[CompilerGenerated]
	private IntPtr FgTCfOHlWl;

	private bool ueeCzkAtfT;

	internal static Win32Window gtQhRq1I9RpSk1pfL2V;

	public IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return FgTCfOHlWl;
		}
		[CompilerGenerated]
		private set
		{
			FgTCfOHlWl = value;
		}
	}

	public Win32Window(IntPtr handle)
		: this(handle, false)
	{
	}

	public Win32Window(IntPtr handle, bool owner)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("handle");
		}
		Handle = handle;
		ueeCzkAtfT = owner;
	}

	public void Show(ShowWindowCommand cmd)
	{
		User32.ShowWindow(Handle, cmd);
	}

	public void SetForeground()
	{
		User32.SetForegroundWindow(Handle);
	}

	public void Activate()
	{
		User32.SetActiveWindow(Handle);
	}

	internal static bool kLLonx16ZtKGQJCRflJ()
	{
		return gtQhRq1I9RpSk1pfL2V == null;
	}
}
