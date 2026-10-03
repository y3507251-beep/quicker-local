using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities.Hooks;

public abstract class GlobalHook
{
	[CompilerGenerated]
	private HookType BVwLAEwNb5c;

	[CompilerGenerated]
	private IntPtr f8ELAyEFnOY;

	[CompilerGenerated]
	private NativeMethods.HookProc P41LA8QKFyI;

	[CompilerGenerated]
	private bool gE4LAagr0Zj;

	internal static GlobalHook uAmVDlFgOdb09g8gCLwM;

	protected HookType HookType
	{
		[CompilerGenerated]
		get
		{
			return BVwLAEwNb5c;
		}
		[CompilerGenerated]
		set
		{
			BVwLAEwNb5c = value;
		}
	}

	protected IntPtr HandleToHook
	{
		[CompilerGenerated]
		get
		{
			return f8ELAyEFnOY;
		}
		[CompilerGenerated]
		set
		{
			f8ELAyEFnOY = value;
		}
	}

	protected NativeMethods.HookProc HookCallback
	{
		[CompilerGenerated]
		get
		{
			return P41LA8QKFyI;
		}
		[CompilerGenerated]
		set
		{
			P41LA8QKFyI = value;
		}
	}

	public bool IsStarted
	{
		[CompilerGenerated]
		get
		{
			return gE4LAagr0Zj;
		}
		[CompilerGenerated]
		set
		{
			gE4LAagr0Zj = value;
		}
	}

	public GlobalHook()
	{
	}

	private void jcQLAP5XBsL(object sender, ExitEventArgs e)
	{
		if (IsStarted)
		{
			Stop();
		}
	}

	public void Start()
	{
		if (!IsStarted && HookType != HookType.WH_JOURNALRECORD)
		{
			StartInternal();
			HookCallback = HookCallbackProcedure;
			HandleToHook = NativeMethods.SetWindowsHookEx(HookType, HookCallback, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0u);
			if (HandleToHook != IntPtr.Zero)
			{
				IsStarted = true;
			}
		}
	}

	public virtual void Stop()
	{
		if (IsStarted)
		{
			StopInternal();
			NativeMethods.UnhookWindowsHookEx(HandleToHook);
			IsStarted = false;
		}
	}

	protected virtual IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	public void Restart()
	{
		Stop();
		Start();
	}

	public virtual void StartInternal()
	{
	}

	public virtual void StopInternal()
	{
	}

	internal static bool YUAF5yFgJgGDIEVHJL3y()
	{
		return uAmVDlFgOdb09g8gCLwM == null;
	}

	internal static void t378o0Fga4Cen4RI8VqC()
	{
	}
}
