using System;
using System.Runtime.CompilerServices;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public class WindowInfo
{
	[CompilerGenerated]
	private IntPtr bknLo28LDNM;

	[CompilerGenerated]
	private int fPJLou3e3j6;

	[CompilerGenerated]
	private string FyNLoN25gCS;

	[CompilerGenerated]
	private string LFSLoJfunwv;

	[CompilerGenerated]
	private string S6WLo0ecxE7;

	private string eqpLoCh32Ig;

	private string X2RLoPfZNm2;

	private static WindowInfo i5GZemF5eYnw3qO0cIYq;

	public IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return bknLo28LDNM;
		}
		[CompilerGenerated]
		set
		{
			bknLo28LDNM = value;
		}
	}

	public int Pid
	{
		[CompilerGenerated]
		get
		{
			return fPJLou3e3j6;
		}
		[CompilerGenerated]
		set
		{
			fPJLou3e3j6 = value;
		}
	}

	public string ProcessName
	{
		[CompilerGenerated]
		get
		{
			return FyNLoN25gCS;
		}
		[CompilerGenerated]
		set
		{
			FyNLoN25gCS = value;
		}
	}

	public string ExeName
	{
		[CompilerGenerated]
		get
		{
			return LFSLoJfunwv;
		}
		[CompilerGenerated]
		set
		{
			LFSLoJfunwv = value;
		}
	}

	public string ExePath
	{
		[CompilerGenerated]
		get
		{
			return S6WLo0ecxE7;
		}
		[CompilerGenerated]
		set
		{
			S6WLo0ecxE7 = value;
		}
	}

	public string Title => eqpLoCh32Ig ?? (eqpLoCh32Ig = NativeMethods.GetWindowTitle(Handle));

	public string ClassName => X2RLoPfZNm2 ?? (X2RLoPfZNm2 = NativeMethods.GetWindowClass(Handle));

	static WindowInfo()
	{
	}

	internal static bool IeAhuPF5j3F2RfHJfPnx()
	{
		return i5GZemF5eYnw3qO0cIYq == null;
	}

	internal static void HnV4QqF53sWtqFi1I99Q()
	{
	}
}
