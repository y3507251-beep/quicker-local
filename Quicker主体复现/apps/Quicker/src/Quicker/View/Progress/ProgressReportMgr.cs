using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.View.Progress;

public static class ProgressReportMgr
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec EVBSjSVP6SZ;

		public static EventHandler h8mSj25NR7A;

		public static Action cnTSjuFsaxk;

		public static Action C2RSjNeapaj;

		public static Action gIISjJhXQdX;

		private static _003C_003Ec XJVZAMWIg3TGXOTD1goK;

		static _003C_003Ec()
		{
			EVBSjSVP6SZ = new _003C_003Ec();
		}

		internal void CGHSjtbZcIG()
		{
			QXHLutFCJiQ = new ProgressReportWindow(MNfLuw0gVd8);
			QXHLutFCJiQ.Closed += h8mSj25NR7A ?? (h8mSj25NR7A = EVBSjSVP6SZ.kihSjgb7gpx);
			QXHLutFCJiQ.Show();
		}

		internal void kihSjgb7gpx(object sender, EventArgs e)
		{
			lock (FB3Lugf3cWV)
			{
				QXHLutFCJiQ = null;
			}
		}

		internal void OqiSjLhK674()
		{
			QXHLutFCJiQ?.Show();
		}

		internal void oGOSjv4FS85()
		{
			foreach (ProgressReportItem item in MNfLuw0gVd8)
			{
				if (item.Cts != null)
				{
					item.Cts?.Cancel();
				}
			}
			MNfLuw0gVd8.Clear();
			QXHLutFCJiQ?.Hide();
		}

		internal static bool blwiu4WIPy0XGj9TPAZZ()
		{
			return XJVZAMWIg3TGXOTD1goK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public int bG4SjPTaxAu;

		public string x2mSjE58mpx;

		public string wEOSjyEoTnX;

		public double l0mSj8JR0gf;

		public string RNmSjaABMrA;

		public int PxZSj7QuGp1;

		public CancellationTokenSource hwnSjRsK2M5;

		public Func<ProgressReportItem, bool> VhcSjqaUv0i;

		private static _003C_003Ec__DisplayClass3_0 ASoE2dWIUjMtU0mche7i;

		internal void t2CSj0VVeli()
		{
			ProgressReportItem progressReportItem = MNfLuw0gVd8.FirstOrDefault(VhcSjqaUv0i ?? (VhcSjqaUv0i = DepSjCR3Rgx));
			if (progressReportItem == null)
			{
				progressReportItem = new ProgressReportItem
				{
					Id = bG4SjPTaxAu,
					Icon = x2mSjE58mpx,
					Title = wEOSjyEoTnX,
					Percent = l0mSj8JR0gf,
					Text = RNmSjaABMrA,
					ActionExecuteContextId = PxZSj7QuGp1,
					Cts = hwnSjRsK2M5
				};
				MNfLuw0gVd8.Insert(0, progressReportItem);
			}
			else
			{
				progressReportItem.Title = wEOSjyEoTnX;
				progressReportItem.Percent = l0mSj8JR0gf;
				progressReportItem.Text = RNmSjaABMrA;
				progressReportItem.Icon = x2mSjE58mpx;
			}
		}

		internal bool DepSjCR3Rgx(ProgressReportItem x)
		{
			return x.Id == bG4SjPTaxAu;
		}

		internal static bool G7r8pBWIxVdTqyXQU4MT()
		{
			return ASoE2dWIUjMtU0mche7i == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public int dpHSjZ4pHjn;

		public ProgressReportItem yPwSj9xQdcL;

		internal static _003C_003Ec__DisplayClass7_0 WbloAJWItjCPZ92yZjXf;

		internal bool ANPSjcwCb5p(ProgressReportItem x)
		{
			return x.Id == dpHSjZ4pHjn;
		}

		internal void GHnSjVRo4OL()
		{
			MNfLuw0gVd8.Remove(yPwSj9xQdcL);
			if (MNfLuw0gVd8.Count == 0)
			{
				QXHLutFCJiQ?.Hide();
			}
		}

		internal static bool ToCIHXWIS24dOxL803ac()
		{
			return WbloAJWItjCPZ92yZjXf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public int ACkSjYJFr2a;

		public List<ProgressReportItem> pHESjIBnsOE;

		private static _003C_003Ec__DisplayClass8_0 LResa5WITgTELfYgyvGN;

		internal bool NB9SjhCyfPS(ProgressReportItem x)
		{
			return x.ActionExecuteContextId == ACkSjYJFr2a;
		}

		internal void UktSjeLrYbk()
		{
			foreach (ProgressReportItem item in pHESjIBnsOE)
			{
				MNfLuw0gVd8.Remove(item);
				item.Cts?.Cancel();
			}
			if (MNfLuw0gVd8.Count == 0)
			{
				QXHLutFCJiQ?.Hide();
			}
		}

		internal static bool p87bCsWImEKi8oXtc8UF()
		{
			return LResa5WITgTELfYgyvGN == null;
		}
	}

	private static int FEJL2z8SPpf;

	private static SmartCollection<ProgressReportItem> MNfLuw0gVd8;

	private static ProgressReportWindow QXHLutFCJiQ;

	private static object FB3Lugf3cWV;

	private static object UPsGSWFjAYaH7XGLVWXa;

	public static int RequestProgressId()
	{
		return FEJL2z8SPpf++;
	}

	public static void UpdateProgress(int id, string icon, string title, double percentage, string text, int actionExecuteContextId, CancellationTokenSource cts = null)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.bG4SjPTaxAu = id;
		_003C_003Ec__DisplayClass3_.x2mSjE58mpx = icon;
		_003C_003Ec__DisplayClass3_.wEOSjyEoTnX = title;
		_003C_003Ec__DisplayClass3_.l0mSj8JR0gf = percentage;
		_003C_003Ec__DisplayClass3_.RNmSjaABMrA = text;
		_003C_003Ec__DisplayClass3_.PxZSj7QuGp1 = actionExecuteContextId;
		_003C_003Ec__DisplayClass3_.hwnSjRsK2M5 = cts;
		if (_003C_003Ec__DisplayClass3_.bG4SjPTaxAu >= 1)
		{
			GjOL2fvFiQQ();
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass3_.t2CSj0VVeli);
			int num = 0;
			if (!XKp0flFjnIPSgWNitxs6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private static void GjOL2fvFiQQ()
	{
		lock (FB3Lugf3cWV)
		{
			if (QXHLutFCJiQ != null)
			{
				if (!QXHLutFCJiQ.IsVisible)
				{
					AppHelper.RunOnUiThread(false, _003C_003Ec.C2RSjNeapaj ?? (_003C_003Ec.C2RSjNeapaj = _003C_003Ec.EVBSjSVP6SZ.OqiSjLhK674));
				}
			}
			else
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec.cnTSjuFsaxk ?? (_003C_003Ec.cnTSjuFsaxk = _003C_003Ec.EVBSjSVP6SZ.CGHSjtbZcIG));
			}
		}
	}

	public static void RemoveProgress(int id)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.dpHSjZ4pHjn = id;
		_003C_003Ec__DisplayClass7_.yPwSj9xQdcL = MNfLuw0gVd8.FirstOrDefault(_003C_003Ec__DisplayClass7_.ANPSjcwCb5p);
		if (_003C_003Ec__DisplayClass7_.yPwSj9xQdcL != null)
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass7_.GHnSjVRo4OL);
		}
	}

	public static void ClearContextProgress(int actionExecuteContextId)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.ACkSjYJFr2a = actionExecuteContextId;
		_003C_003Ec__DisplayClass8_.pHESjIBnsOE = MNfLuw0gVd8.Where(_003C_003Ec__DisplayClass8_.NB9SjhCyfPS).ToList();
		if (_003C_003Ec__DisplayClass8_.pHESjIBnsOE.HasData())
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass8_.UktSjeLrYbk);
		}
	}

	public static void Clear()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.gIISjJhXQdX ?? (_003C_003Ec.gIISjJhXQdX = _003C_003Ec.EVBSjSVP6SZ.oGOSjv4FS85));
	}

	static ProgressReportMgr()
	{
		FEJL2z8SPpf = 1;
		MNfLuw0gVd8 = new SmartCollection<ProgressReportItem>();
		QXHLutFCJiQ = null;
		FB3Lugf3cWV = new object();
	}

	internal static bool XKp0flFjnIPSgWNitxs6()
	{
		return UPsGSWFjAYaH7XGLVWXa == null;
	}
}
