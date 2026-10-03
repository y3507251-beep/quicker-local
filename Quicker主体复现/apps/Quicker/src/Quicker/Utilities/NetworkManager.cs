using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using NETWORKLIST;

namespace Quicker.Utilities;

public class NetworkManager : IDisposable, INetworkListManagerEvents
{
	public delegate void OnConnectivityChangedDelegate(NetworkManager aNetworkManager, NLM_CONNECTIVITY aConnectivity);

	[CompilerGenerated]
	private OnConnectivityChangedDelegate RI4LTgYSMy3;

	private int YmBLTLsbILu;

	private IConnectionPoint DoiLTv0bPvp;

	private readonly INetworkListManager zFcLTSBuW2n;

	private static NetworkManager TeR4ORFY7JpFLbubpJdY;

	public INetworkListManager NetworkListManager => zFcLTSBuW2n;

	public event OnConnectivityChangedDelegate OnConnectivityChanged
	{
		[CompilerGenerated]
		add
		{
			OnConnectivityChangedDelegate onConnectivityChangedDelegate = RI4LTgYSMy3;
			OnConnectivityChangedDelegate onConnectivityChangedDelegate2;
			do
			{
				onConnectivityChangedDelegate2 = onConnectivityChangedDelegate;
				OnConnectivityChangedDelegate value2 = (OnConnectivityChangedDelegate)Delegate.Combine(onConnectivityChangedDelegate2, value);
				onConnectivityChangedDelegate = Interlocked.CompareExchange(ref RI4LTgYSMy3, value2, onConnectivityChangedDelegate2);
			}
			while ((object)onConnectivityChangedDelegate != onConnectivityChangedDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			OnConnectivityChangedDelegate onConnectivityChangedDelegate = RI4LTgYSMy3;
			OnConnectivityChangedDelegate onConnectivityChangedDelegate2;
			do
			{
				onConnectivityChangedDelegate2 = onConnectivityChangedDelegate;
				OnConnectivityChangedDelegate value2 = (OnConnectivityChangedDelegate)Delegate.Remove(onConnectivityChangedDelegate2, value);
				onConnectivityChangedDelegate = Interlocked.CompareExchange(ref RI4LTgYSMy3, value2, onConnectivityChangedDelegate2);
			}
			while ((object)onConnectivityChangedDelegate != onConnectivityChangedDelegate2);
		}
	}

	public NetworkManager()
	{
		zFcLTSBuW2n = (NetworkListManager)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("DCB00C01-570F-4A9B-8D69-199FDBA5723B")));
		ConnectToNetworkListManagerEvents();
	}

	protected virtual void Dispose(bool disposing)
	{
		DisconnectFromNetworkListManagerEvents();
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public void ConnectivityChanged(NLM_CONNECTIVITY newConnectivity)
	{
		if (RI4LTgYSMy3 != null)
		{
			RI4LTgYSMy3(this, newConnectivity);
		}
	}

	public void ConnectToNetworkListManagerEvents()
	{
		IConnectionPointContainer obj = (IConnectionPointContainer)zFcLTSBuW2n;
		Guid riid = typeof(INetworkListManagerEvents).GUID;
		obj.FindConnectionPoint(ref riid, out DoiLTv0bPvp);
		DoiLTv0bPvp.Advise(this, out YmBLTLsbILu);
	}

	public void DisconnectFromNetworkListManagerEvents()
	{
		DoiLTv0bPvp?.Unadvise(YmBLTLsbILu);
	}

	internal static bool SL6PLXFY4L2rByNZjiUW()
	{
		return TeR4ORFY7JpFLbubpJdY == null;
	}
}
