using System;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public class HotKeyEventArgs : EventArgs
{
	[CompilerGenerated]
	private HotKey ih5CjZnyG1;

	private static HotKeyEventArgs nWu9Ot07fPPsDtZmX0y;

	public HotKey HotKey
	{
		[CompilerGenerated]
		get
		{
			return ih5CjZnyG1;
		}
		[CompilerGenerated]
		private set
		{
			ih5CjZnyG1 = value;
		}
	}

	public HotKeyEventArgs(HotKey hotkey)
	{
		hotkey.ThrowIfNull("hotkey");
		HotKey = hotkey;
	}

	internal static bool PHr9xU04ciYCwwnEI2Y()
	{
		return nWu9Ot07fPPsDtZmX0y == null;
	}
}
