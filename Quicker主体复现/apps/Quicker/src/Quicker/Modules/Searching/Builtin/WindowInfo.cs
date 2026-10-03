using System;
using System.Runtime.CompilerServices;
using Quicker.Utilities.Win32;

namespace Quicker.Modules.Searching.Builtin;

public class WindowInfo
{
	[CompilerGenerated]
	private string JF4tPR0inwP;

	[CompilerGenerated]
	private string tZFtPqQwoi7;

	[CompilerGenerated]
	private string qfWtPcQmJuf;

	[CompilerGenerated]
	private IntPtr mhPtPVghdXg;

	[CompilerGenerated]
	private NativeMethods.RECT ThatPZpkwcR;

	private static WindowInfo ia7eahQjphcEyAaMQhpK;

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return JF4tPR0inwP;
		}
		[CompilerGenerated]
		set
		{
			JF4tPR0inwP = value;
		}
	}

	public string ProcessPath
	{
		[CompilerGenerated]
		get
		{
			return tZFtPqQwoi7;
		}
		[CompilerGenerated]
		set
		{
			tZFtPqQwoi7 = value;
		}
	}

	public string ProcessName
	{
		[CompilerGenerated]
		get
		{
			return qfWtPcQmJuf;
		}
		[CompilerGenerated]
		set
		{
			qfWtPcQmJuf = value;
		}
	}

	public IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return mhPtPVghdXg;
		}
		[CompilerGenerated]
		set
		{
			mhPtPVghdXg = value;
		}
	}

	public NativeMethods.RECT Rect
	{
		[CompilerGenerated]
		get
		{
			return ThatPZpkwcR;
		}
		[CompilerGenerated]
		set
		{
			ThatPZpkwcR = value;
		}
	}

	internal static bool JrNK1XQjXQVOqRy4dIAp()
	{
		return ia7eahQjphcEyAaMQhpK == null;
	}
}
