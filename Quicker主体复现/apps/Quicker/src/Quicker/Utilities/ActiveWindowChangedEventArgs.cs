using System;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities;

public class ActiveWindowChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private WindowInfo i5aLoEF4SFN;

	[CompilerGenerated]
	private WindowInfo Ox9LoyEmjoI;

	internal static ActiveWindowChangedEventArgs zSnv3PF5EUeWO38wd9OL;

	public WindowInfo ActivatedWindow
	{
		[CompilerGenerated]
		get
		{
			return i5aLoEF4SFN;
		}
		[CompilerGenerated]
		set
		{
			i5aLoEF4SFN = value;
		}
	}

	public WindowInfo DeactivatedWindow
	{
		[CompilerGenerated]
		get
		{
			return Ox9LoyEmjoI;
		}
		[CompilerGenerated]
		set
		{
			Ox9LoyEmjoI = value;
		}
	}

	internal static bool MmJxl8F5G2KMTdauEWjC()
	{
		return zSnv3PF5EUeWO38wd9OL == null;
	}
}
