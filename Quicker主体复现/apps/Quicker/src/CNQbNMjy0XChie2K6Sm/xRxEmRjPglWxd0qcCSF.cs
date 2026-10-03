using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using fmaGYuo4Ku330Ewtfhr;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace CNQbNMjy0XChie2K6Sm;

internal class xRxEmRjPglWxd0qcCSF
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec vJUvBVsmug9;

		public static Func<ql8exboyDpJ7Y0f68sS, bool> Kn5vBZNYV7I;

		private static _003C_003Ec NoAAJscTzJuFMA1N7ZdK;

		static _003C_003Ec()
		{
			vJUvBVsmug9 = new _003C_003Ec();
		}

		internal bool QJ7vBcc5a3r(ql8exboyDpJ7Y0f68sS x)
		{
			return x.BindingProcess.HasData();
		}

		internal static bool ET6mvjcmVcU7xMK6nojT()
		{
			return NoAAJscTzJuFMA1N7ZdK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public xRxEmRjPglWxd0qcCSF qmmvBeQVyie;

		public string W6JvBYAaRel;

		public Func<string, bool> OZBvBIVW91h;

		private static _003C_003Ec__DisplayClass3_0 DK8HKucmF71XhaT24L6h;

		internal void MOYvB92CjUq()
		{
			foreach (ql8exboyDpJ7Y0f68sS item in qmmvBeQVyie.WaEtIzBPinv)
			{
				if (item.BindingProcess != null && item.BindingProcess.Count != 0)
				{
					if (item.BindingProcess.Any(OZBvBIVW91h ?? (OZBvBIVW91h = ThnvBhup2ZM)))
					{
						((Window)item).Visibility = Visibility.Visible;
					}
					else
					{
						((Window)item).Visibility = Visibility.Collapsed;
					}
				}
			}
		}

		internal bool ThnvBhup2ZM(string x)
		{
			return string.Equals(x, W6JvBYAaRel, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool O0yZDwcmc5nEbKT9ObcD()
		{
			return DK8HKucmF71XhaT24L6h == null;
		}
	}

	private static xRxEmRjPglWxd0qcCSF SeHtI3BPFrB;

	private static readonly object blstIfXiwHx;

	private IList<ql8exboyDpJ7Y0f68sS> WaEtIzBPinv = new List<ql8exboyDpJ7Y0f68sS>();

	private static xRxEmRjPglWxd0qcCSF NUe3oiQJesMowUmpUMKI;

	private xRxEmRjPglWxd0qcCSF()
	{
		AppState.Y2RtaqSv0AQ().Subscribe<ActiveProcessChangedMessage>(Hs5tIAvbc6I);
	}

	private void Hs5tIAvbc6I(ActiveProcessChangedMessage activeProcessChangedMessage_0)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.qmmvBeQVyie = this;
		if (WaEtIzBPinv.HasData() && WaEtIzBPinv.Any(_003C_003Ec.Kn5vBZNYV7I ?? (_003C_003Ec.Kn5vBZNYV7I = _003C_003Ec.vJUvBVsmug9.QJ7vBcc5a3r)))
		{
			_003C_003Ec__DisplayClass3_.W6JvBYAaRel = AppState.CurrentProcessName;
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass3_.MOYvB92CjUq);
		}
	}

	[SpecialName]
	public static xRxEmRjPglWxd0qcCSF MbstIlqq9p0()
	{
		if (SeHtI3BPFrB == null)
		{
			lock (blstIfXiwHx)
			{
				if (SeHtI3BPFrB == null)
				{
					SeHtI3BPFrB = new xRxEmRjPglWxd0qcCSF();
				}
			}
		}
		return SeHtI3BPFrB;
	}

	public void VcstIOSJLEc(ql8exboyDpJ7Y0f68sS ql8exboyDpJ7Y0f68sS_0)
	{
		WaEtIzBPinv.Add(ql8exboyDpJ7Y0f68sS_0);
		((Window)ql8exboyDpJ7Y0f68sS_0).Closed += JamtIU7lEWp;
	}

	public void GSOtIFqkrdf(ql8exboyDpJ7Y0f68sS ql8exboyDpJ7Y0f68sS_0)
	{
		if (WaEtIzBPinv.Contains(ql8exboyDpJ7Y0f68sS_0))
		{
			WaEtIzBPinv.Remove(ql8exboyDpJ7Y0f68sS_0);
			((Window)ql8exboyDpJ7Y0f68sS_0).Closed -= JamtIU7lEWp;
		}
	}

	private void JamtIU7lEWp(object sender, EventArgs e)
	{
		ql8exboyDpJ7Y0f68sS ql8exboyDpJ7Y0f68sS_ = (ql8exboyDpJ7Y0f68sS)sender;
		GSOtIFqkrdf(ql8exboyDpJ7Y0f68sS_);
	}

	static xRxEmRjPglWxd0qcCSF()
	{
		blstIfXiwHx = new object();
	}

	internal static bool CIg1j4QJj7ldfHN1KOiB()
	{
		return NUe3oiQJesMowUmpUMKI == null;
	}
}
