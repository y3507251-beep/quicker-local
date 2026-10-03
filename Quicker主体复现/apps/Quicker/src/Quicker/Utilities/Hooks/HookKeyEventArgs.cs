using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Quicker.Utilities.Hooks;

public class HookKeyEventArgs : KeyEventArgs
{
	[CompilerGenerated]
	private bool JB4LAZ7D1MI;

	[CompilerGenerated]
	private bool XnELA9KewbA;

	[CompilerGenerated]
	private bool CraLAhG5Prn;

	[CompilerGenerated]
	private bool RdDLAeyi8YG;

	[CompilerGenerated]
	private bool ucULAYQPeNv;

	private static HookKeyEventArgs iIE5P0Fgb8ayPUxkRULP;

	public bool IsInjected
	{
		[CompilerGenerated]
		get
		{
			return JB4LAZ7D1MI;
		}
		[CompilerGenerated]
		set
		{
			JB4LAZ7D1MI = value;
		}
	}

	public bool IsExtended
	{
		[CompilerGenerated]
		get
		{
			return XnELA9KewbA;
		}
		[CompilerGenerated]
		set
		{
			XnELA9KewbA = value;
		}
	}

	public bool IsFromQuicker
	{
		[CompilerGenerated]
		get
		{
			return CraLAhG5Prn;
		}
		[CompilerGenerated]
		set
		{
			CraLAhG5Prn = value;
		}
	}

	public bool IsRepeating
	{
		[CompilerGenerated]
		get
		{
			return RdDLAeyi8YG;
		}
		[CompilerGenerated]
		set
		{
			RdDLAeyi8YG = value;
		}
	}

	public bool IsRestore
	{
		[CompilerGenerated]
		get
		{
			return ucULAYQPeNv;
		}
		[CompilerGenerated]
		set
		{
			ucULAYQPeNv = value;
		}
	}

	public HookKeyEventArgs(Keys keyData)
		: base(keyData)
	{
	}

	static HookKeyEventArgs()
	{
	}

	internal static bool GBEEkPFgqg2HCDA0VN4h()
	{
		return iIE5P0Fgb8ayPUxkRULP == null;
	}

	internal static void CYpPoiFglrkC69WXjKyB()
	{
	}
}
