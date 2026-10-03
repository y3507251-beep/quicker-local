using System;
using System.Runtime.CompilerServices;
using System.Timers;

namespace Quicker.Utilities.UI;

public class DebounceTimer : IDisposable
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public DebounceTimer v5k2EP0rdpV;

		public Action<object> VuD2EE1L0tN;

		public object V6Z2Ey1jaNb;

		internal static _003C_003Ec__DisplayClass7_0 fR5RcIyJ8SE00RqbRBSQ;

		internal void r5U2ECVpaYJ(object sender, ElapsedEventArgs e)
		{
			v5k2EP0rdpV.btpv221M3VJ();
			VuD2EE1L0tN(V6Z2Ey1jaNb);
		}

		internal static bool rn5ER1yJRMFOpiNtKqeq()
		{
			return fR5RcIyJ8SE00RqbRBSQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public DebounceTimer fnW2EaPFn9T;

		public Action<object> nfH2E7VuNYr;

		public object vOu2ERGHQrH;

		private static _003C_003Ec__DisplayClass8_0 PAnjygyJPujmjD4OKkuf;

		internal void Sr12E8WL806(object sender, ElapsedEventArgs e)
		{
			fnW2EaPFn9T.btpv221M3VJ();
			nfH2E7VuNYr(vOu2ERGHQrH);
		}

		internal static bool aC78GfyJMmEhwShy3AjR()
		{
			return PAnjygyJPujmjD4OKkuf == null;
		}
	}

	private Timer EYAv20Z0DxS;

	[CompilerGenerated]
	private DateTime bSEv2CNN3Dr = DateTime.UtcNow.AddYears(-1);

	private object YX1v2PZsmAj = new object();

	internal static DebounceTimer cEiYPXFh7Usb2x6815rF;

	[SpecialName]
	[CompilerGenerated]
	private DateTime uy9v2uggHQC()
	{
		return bSEv2CNN3Dr;
	}

	[SpecialName]
	[CompilerGenerated]
	private void GPMv2Nc6LJd(DateTime value)
	{
		bSEv2CNN3Dr = value;
	}

	private void btpv221M3VJ()
	{
		if (EYAv20Z0DxS == null)
		{
			return;
		}
		lock (YX1v2PZsmAj)
		{
			if (EYAv20Z0DxS != null)
			{
				EYAv20Z0DxS.Stop();
				EYAv20Z0DxS.Dispose();
				EYAv20Z0DxS = null;
			}
		}
	}

	public void Debounce(int interval, Action<object> action, object param = null)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.v5k2EP0rdpV = this;
		_003C_003Ec__DisplayClass7_.VuD2EE1L0tN = action;
		_003C_003Ec__DisplayClass7_.V6Z2Ey1jaNb = param;
		lock (YX1v2PZsmAj)
		{
			btpv221M3VJ();
			EYAv20Z0DxS = new Timer(interval);
			EYAv20Z0DxS.Elapsed += _003C_003Ec__DisplayClass7_.r5U2ECVpaYJ;
			EYAv20Z0DxS.Start();
		}
	}

	public void Throttle(int interval, Action<object> action, object param = null)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.fnW2EaPFn9T = this;
		_003C_003Ec__DisplayClass8_.nfH2E7VuNYr = action;
		_003C_003Ec__DisplayClass8_.vOu2ERGHQrH = param;
		if (EYAv20Z0DxS == null)
		{
			EYAv20Z0DxS = new Timer(interval);
			EYAv20Z0DxS.Elapsed += _003C_003Ec__DisplayClass8_.Sr12E8WL806;
			EYAv20Z0DxS.Start();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			EYAv20Z0DxS?.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public void Clear()
	{
		btpv221M3VJ();
	}

	internal static bool L7pRNJFh4rJmEDXoZSjb()
	{
		return cEiYPXFh7Usb2x6815rF == null;
	}
}
