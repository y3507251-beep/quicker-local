using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Quicker.Common;
using Quicker.Domain.Profiles;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;

namespace Quicker.Domain.Services;

public class TextFloatPanelMgr
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public TextFloatPanelMgr sHBv43N4LTM;

		public ActionProfile b7Lv4f3TArY;

		internal static _003C_003Ec__DisplayClass15_0 u1SucQWQzPXdqrgNbIps;

		internal void TEav4i1sp0h()
		{
			sHBv43N4LTM.pRdtKzOr64A?.AddProfile(b7Lv4f3TArY);
		}

		internal static bool Fo4diLWFV8imauYCFY1V()
		{
			return u1SucQWQzPXdqrgNbIps == null;
		}
	}

	private readonly DataService JW5tKlTyvt7;

	private readonly ActiveWindowHook XfctKiLDHRC;

	private readonly ProfileSwitcher KCvtK3LhudT;

	private readonly ITinyMessengerHub HD3tKf4edXq;

	private TextFloatPanelWindow pRdtKzOr64A;

	private TextFloatPanelState nystxwHSgTR;

	[CompilerGenerated]
	private bool UgStxtGknKm;

	private System.Drawing.Point GcUtxgirWuG = new System.Drawing.Point(0, 0);

	private bool oSutxL0aocK;

	private bool z2otxvLpmJ0;

	private DateTime PPntxSkoE40 = DateTime.MinValue;

	private DateTime fTptx2np8QB = DateTime.MinValue;

	private System.Drawing.Point dSvtxuf5Px9 = System.Drawing.Point.Empty;

	private DebounceTimer QmYtxNt0tja = new DebounceTimer();

	internal static TextFloatPanelMgr qmsFxAQr7jPpyhr2TJub;

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return UgStxtGknKm;
		}
		[CompilerGenerated]
		private set
		{
			UgStxtGknKm = value;
		}
	}

	public TextFloatPanelWindow FloatWindow => pRdtKzOr64A;

	public TextFloatPanelMgr(DataService dataService, ActiveWindowHook activeWindowWatcher, ProfileSwitcher profileSwitcher, ITinyMessengerHub hub)
	{
		JW5tKlTyvt7 = dataService;
		XfctKiLDHRC = activeWindowWatcher;
		KCvtK3LhudT = profileSwitcher;
		HD3tKf4edXq = hub;
		AppState.TextFloatPanelMgr = this;
	}

	private void Show()
	{
		if (!IsEnabled || XfctKiLDHRC.ForegroundProcessId == AppState.QuickerProcessId)
		{
			return;
		}
		if (pRdtKzOr64A == null)
		{
			if (nystxwHSgTR == null)
			{
				nystxwHSgTR = JW5tKlTyvt7.Xc6tX2mAm0N();
			}
			System.Windows.Application.Current.Dispatcher.Invoke(JKYtKdUq4Aj);
			return;
		}
		try
		{
			if (!pRdtKzOr64A.IsVisible)
			{
				System.Windows.Application.Current.Dispatcher.InvokeAsync(h9JtKTgJaXI);
			}
			else
			{
				AppHelper.RunOnUiThread(false, MbMtKMK8i1f);
			}
		}
		catch (Exception)
		{
		}
	}

	public void Hide()
	{
		try
		{
			if (pRdtKzOr64A != null && pRdtKzOr64A.IsVisible)
			{
				System.Windows.Application.Current.Dispatcher.InvokeAsync(XUptKAn20GQ);
			}
		}
		catch (Exception)
		{
			pRdtKzOr64A = null;
		}
	}

	public void AddProfile(ActionProfile profile)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.sHBv43N4LTM = this;
		_003C_003Ec__DisplayClass15_.b7Lv4f3TArY = profile;
		Show();
		System.Windows.Application.Current.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass15_.TEav4i1sp0h);
	}

	public void OnLeftButtonDown(System.Windows.Forms.MouseEventArgs e)
	{
		if (IsEnabled)
		{
			dSvtxuf5Px9 = GcUtxgirWuG;
			GcUtxgirWuG.X = e.X;
			GcUtxgirWuG.Y = e.Y;
			int num = 0;
			if (qmsFxAQr7jPpyhr2TJub != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			z2otxvLpmJ0 = oSutxL0aocK;
			fTptx2np8QB = PPntxSkoE40;
			PPntxSkoE40 = DateTime.Now;
			oSutxL0aocK = false;
			oSutxL0aocK = NativeMethods.IsSelectingTextCursor();
		}
	}

	public void OnLeftButtonUp(System.Windows.Forms.MouseEventArgs e, PointTargetInfo targetInfo)
	{
		int num;
		if (IsEnabled && !BlackListMgr.IsCurrentAppInBlackListOrDisabledByFullScreen() && !AppState.HS2taepcAbc().IsVisible)
		{
			num = 2;
			if (qmsFxAQr7jPpyhr2TJub != null)
			{
				goto IL_0067;
			}
			goto IL_006b;
		}
		return;
		IL_006b:
		do
		{
			switch (num)
			{
			case 2:
				if (targetInfo == null)
				{
					targetInfo = AppHelper.GetPointTargetInfo(null);
				}
				if (targetInfo.IsInBlackList)
				{
					return;
				}
				if (targetInfo.IsOnQuicker)
				{
					break;
				}
				if (targetInfo.IsDisabledFullScreenWindow)
				{
					return;
				}
				if (nystxwHSgTR != null && nystxwHSgTR.FollowMode != MouseFollowMode.TextSelection)
				{
					if (nystxwHSgTR.FollowMode == MouseFollowMode.Text)
					{
						if (!oSutxL0aocK)
						{
							goto default;
						}
						goto IL_00ec;
					}
					if (nystxwHSgTR.FollowMode == MouseFollowMode.Always)
					{
						SKdtKDBA40N();
					}
					return;
				}
				if (((oSutxL0aocK || NativeMethods.IsSelectingTextCursor()) && (AppHelper.IsFarThan(GcUtxgirWuG, e.Location, 5) || (JrJWiKYIEBcPm8FFZOl.Modifiers & ModifierKeys.Shift) != ModifierKeys.None)) || (z2otxvLpmJ0 && (PPntxSkoE40 - fTptx2np8QB).TotalMilliseconds < 500.0 && !AppHelper.IsFarThan(GcUtxgirWuG, dSvtxuf5Px9, 5)))
				{
					SKdtKDBA40N();
				}
				return;
			default:
				if (!NativeMethods.IsSelectingTextCursor() && (!z2otxvLpmJ0 || (PPntxSkoE40 - fTptx2np8QB).TotalMilliseconds >= 500.0))
				{
					return;
				}
				goto IL_00ec;
			case 1:
				return;
				IL_00ec:
				SKdtKDBA40N();
				return;
			}
			num = 1;
		}
		while (c9ZsBoQr4F1Wk84YLxGp());
		goto IL_0067;
		IL_0067:
		int num2 = default(int);
		num = num2;
		goto IL_006b;
	}

	private void SKdtKDBA40N()
	{
		QmYtxNt0tja.Debounce(100, nkbtKOdEixQ);
	}

	public void Start()
	{
		IsEnabled = true;
		nystxwHSgTR = JW5tKlTyvt7.Xc6tX2mAm0N();
	}

	public void Stop()
	{
		IsEnabled = false;
		System.Windows.Application.Current.Dispatcher.InvokeAsync(V3DtKFh4b2W);
	}

	public void Toggle()
	{
		if (IsEnabled)
		{
			Stop();
			return;
		}
		Start();
		AppHelper.ShowInformation("文本悬浮窗功能已开启。");
	}

	public void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
	{
		if (!e.Shift)
		{
			Hide();
		}
	}

	public void SaveTextFloatPanelState(TextFloatPanelState state)
	{
		nystxwHSgTR = state;
		JW5tKlTyvt7.qqotXuGZfSq(state);
	}

	public void ResetState()
	{
		if (nystxwHSgTR != null)
		{
			nystxwHSgTR.OffsetX = -60;
			nystxwHSgTR.OffsetY = -60;
			JW5tKlTyvt7.qqotXuGZfSq(nystxwHSgTR);
			AppHelper.ShowInformation("已重置位置。");
		}
		else
		{
			AppHelper.ShowInformation("尚未显示文本悬浮窗。");
		}
	}

	[CompilerGenerated]
	private void JKYtKdUq4Aj()
	{
		if (pRdtKzOr64A != null)
		{
			pRdtKzOr64A.UpdatePosition();
			pRdtKzOr64A.Show();
			return;
		}
		pRdtKzOr64A = new TextFloatPanelWindow(this, nystxwHSgTR, KCvtK3LhudT.AllGlobalProfiles[0], HD3tKf4edXq, JW5tKlTyvt7);
		pRdtKzOr64A.Show();
		pRdtKzOr64A.UpdatePosition();
		pRdtKzOr64A.Closed += wHutKoCSStV;
	}

	[CompilerGenerated]
	private void wHutKoCSStV(object sender, EventArgs e)
	{
		pRdtKzOr64A = null;
		Stop();
		AppHelper.ShowInformation("文本悬浮窗功能已关闭。");
	}

	[CompilerGenerated]
	private void h9JtKTgJaXI()
	{
		pRdtKzOr64A.UpdatePosition();
		pRdtKzOr64A.Show();
	}

	[CompilerGenerated]
	private void MbMtKMK8i1f()
	{
		pRdtKzOr64A.UpdatePosition();
	}

	[CompilerGenerated]
	private void XUptKAn20GQ()
	{
		if (!pRdtKzOr64A.IsMouseOver)
		{
			pRdtKzOr64A?.DoHideWindow();
		}
	}

	[CompilerGenerated]
	private void nkbtKOdEixQ(object object_0)
	{
		Show();
	}

	[CompilerGenerated]
	private void V3DtKFh4b2W()
	{
		pRdtKzOr64A?.Close();
	}

	internal static bool c9ZsBoQr4F1Wk84YLxGp()
	{
		return qmsFxAQr7jPpyhr2TJub == null;
	}

	internal static void wParSNQrHhTut2ZADYMZ()
	{
	}
}
