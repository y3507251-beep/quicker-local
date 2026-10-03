using System;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace Quicker.Utilities.UI;

public class DebounceDispatcher
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public DebounceDispatcher OFr2EhW3RDY;

		public Action<object> gPm2EeXLLIP;

		public object OgN2EYBuqCZ;

		internal static _003C_003Ec__DisplayClass5_0 rXTojMykVr6Bp5XY47DM;

		internal void BTH2E90iAVj(object sender, EventArgs e)
		{
			if (OFr2EhW3RDY.sANv2WKJWgf != null)
			{
				OFr2EhW3RDY.sANv2WKJWgf?.Stop();
				OFr2EhW3RDY.sANv2WKJWgf = null;
				gPm2EeXLLIP(OgN2EYBuqCZ);
			}
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}

		internal static bool rZEIA7ykQ0WplY4gXtjn()
		{
			return rXTojMykVr6Bp5XY47DM == null;
		}

		internal static void iQtxE1ykcOuXh3sFHMXB()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public DebounceDispatcher S1H2EWoT5uH;

		public Action<object> I4R2Ekc1jp6;

		public object lKL2EGrywKb;

		private static _003C_003Ec__DisplayClass6_0 doVddvykWC9evKV9CMH3;

		internal void lkN2EIlK94w(object sender, EventArgs e)
		{
			if (S1H2EWoT5uH.sANv2WKJWgf != null)
			{
				S1H2EWoT5uH.sANv2WKJWgf?.Stop();
				S1H2EWoT5uH.sANv2WKJWgf = null;
				I4R2Ekc1jp6(lKL2EGrywKb);
			}
		}

		internal static bool spUmdlykyehypArEo7cp()
		{
			return doVddvykWC9evKV9CMH3 == null;
		}
	}

	private DispatcherTimer sANv2WKJWgf;

	[CompilerGenerated]
	private DateTime pJ6v2kVvkmY = DateTime.UtcNow.AddYears(-1);

	internal static DebounceDispatcher Ian0GkFHZDJiMFaPkCmk;

	[SpecialName]
	[CompilerGenerated]
	private DateTime Ew8v2eL0yZn()
	{
		return pJ6v2kVvkmY;
	}

	[SpecialName]
	[CompilerGenerated]
	private void mrfv2YE2GMm(DateTime value)
	{
		pJ6v2kVvkmY = value;
	}

	public void Debounce(int interval, Action<object> action, object param = null, DispatcherPriority priority = DispatcherPriority.ApplicationIdle, Dispatcher disp = null)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.OFr2EhW3RDY = this;
		_003C_003Ec__DisplayClass5_.gPm2EeXLLIP = action;
		_003C_003Ec__DisplayClass5_.OgN2EYBuqCZ = param;
		sANv2WKJWgf?.Stop();
		sANv2WKJWgf = null;
		if (disp == null)
		{
			disp = Dispatcher.CurrentDispatcher;
		}
		sANv2WKJWgf = new DispatcherTimer(TimeSpan.FromMilliseconds(interval), priority, _003C_003Ec__DisplayClass5_.BTH2E90iAVj, disp);
		sANv2WKJWgf.Start();
	}

	public void Throttle(int interval, Action<object> action, object param = null, DispatcherPriority priority = DispatcherPriority.ApplicationIdle, Dispatcher disp = null)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.S1H2EWoT5uH = this;
		_003C_003Ec__DisplayClass6_.I4R2Ekc1jp6 = action;
		_003C_003Ec__DisplayClass6_.lKL2EGrywKb = param;
		sANv2WKJWgf?.Stop();
		sANv2WKJWgf = null;
		if (disp == null)
		{
			disp = Dispatcher.CurrentDispatcher;
		}
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow.Subtract(Ew8v2eL0yZn()).TotalMilliseconds < (double)interval)
		{
			interval -= (int)utcNow.Subtract(Ew8v2eL0yZn()).TotalMilliseconds;
		}
		sANv2WKJWgf = new DispatcherTimer(TimeSpan.FromMilliseconds(interval), priority, _003C_003Ec__DisplayClass6_.lkN2EIlK94w, disp);
		sANv2WKJWgf.Start();
		mrfv2YE2GMm(utcNow);
	}

	public void Cancel()
	{
		sANv2WKJWgf?.Stop();
		sANv2WKJWgf = null;
	}

	internal static bool ujlm0iFH5DVhZRXHscsN()
	{
		return Ian0GkFHZDJiMFaPkCmk == null;
	}
}
