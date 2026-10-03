using System;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Push;

public class ConnectionStatusChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private PushConnectionState BnXth1TZ2HV;

	internal static ConnectionStatusChangedEventArgs V6tYSmQBgp0fwjc0wp6L;

	public PushConnectionState State
	{
		[CompilerGenerated]
		get
		{
			return BnXth1TZ2HV;
		}
		[CompilerGenerated]
		set
		{
			BnXth1TZ2HV = value;
		}
	}

	public ConnectionStatusChangedEventArgs(PushConnectionState state)
	{
		State = state;
	}

	internal static bool QCUW6aQBPatlONjcBPbu()
	{
		return V6tYSmQBgp0fwjc0wp6L == null;
	}
}
