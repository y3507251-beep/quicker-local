using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Quicker.Utilities.Hooks;

public class AppMouseEventArgs : MouseEventArgs
{
	[CompilerGenerated]
	private bool AOxLAIGvC0U;

	[CompilerGenerated]
	private bool Lr6LAWCQU80;

	[CompilerGenerated]
	private bool fWpLAkyX4Ox;

	[CompilerGenerated]
	private bool bGQLAGYsNA7;

	[CompilerGenerated]
	private bool PNxLAsohOEE;

	[CompilerGenerated]
	private bool CDMLAHTtfgL;

	[CompilerGenerated]
	private bool isdLA1k9kje;

	private static AppMouseEventArgs DB06SGFgZTjqck5BflWg;

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return AOxLAIGvC0U;
		}
		[CompilerGenerated]
		set
		{
			AOxLAIGvC0U = value;
		}
	}

	public bool IsInjected
	{
		[CompilerGenerated]
		get
		{
			return Lr6LAWCQU80;
		}
		[CompilerGenerated]
		set
		{
			Lr6LAWCQU80 = value;
		}
	}

	public bool IsFromQuicker
	{
		[CompilerGenerated]
		get
		{
			return fWpLAkyX4Ox;
		}
		[CompilerGenerated]
		set
		{
			fWpLAkyX4Ox = value;
		}
	}

	public bool IsPenOrTouch
	{
		[CompilerGenerated]
		get
		{
			return bGQLAGYsNA7;
		}
		[CompilerGenerated]
		set
		{
			bGQLAGYsNA7 = value;
		}
	}

	public bool IsButtonDown
	{
		[CompilerGenerated]
		get
		{
			return PNxLAsohOEE;
		}
		[CompilerGenerated]
		set
		{
			PNxLAsohOEE = value;
		}
	}

	public bool IsDbClickUp
	{
		[CompilerGenerated]
		get
		{
			return CDMLAHTtfgL;
		}
		[CompilerGenerated]
		set
		{
			CDMLAHTtfgL = value;
		}
	}

	public bool IsFromGestureSoftware
	{
		[CompilerGenerated]
		get
		{
			return isdLA1k9kje;
		}
		[CompilerGenerated]
		set
		{
			isdLA1k9kje = value;
		}
	}

	public AppMouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta)
		: base(button, clicks, x, y, delta)
	{
	}

	internal static bool hXRmDtFg5V2nlDXYbNd2()
	{
		return DB06SGFgZTjqck5BflWg == null;
	}
}
