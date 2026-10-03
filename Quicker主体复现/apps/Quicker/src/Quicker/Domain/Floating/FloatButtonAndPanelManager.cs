using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using log4net;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;

namespace Quicker.Domain.Floating;

public class FloatButtonAndPanelManager
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bpKvBmYAJrK;

		public static Action<FloatButtonWindow> W5avBKej75V;

		public static Func<FloatItemState, bool> X3PvBx8jFqJ;

		public static Func<FloatItemState, bool> KTuvBr088Xb;

		private static _003C_003Ec aMRuI3cmEwICmUn8PgLH;

		static _003C_003Ec()
		{
			bpKvBmYAJrK = new _003C_003Ec();
		}

		internal void jDxvBb5IBcx(FloatButtonWindow x)
		{
			x.Refresh();
		}

		internal bool v7UvB6LF46O(FloatItemState x)
		{
			return x.ItemType == FloatItemType.ActionButton;
		}

		internal bool wu8vBXPTUM1(FloatItemState x)
		{
			return x.ItemType == FloatItemType.ActionPage;
		}

		internal static bool nv2lZgcmGsE8YmeYOe57()
		{
			return aMRuI3cmEwICmUn8PgLH == null;
		}

		internal static void tZpLe6cm1m3wEduOEVLX()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public FloatButtonAndPanelManager LxAvBBtm2H7;

		public string D0dvBQ0ds1Z;

		internal static _003C_003Ec__DisplayClass10_0 KmRiR5cmKhpZ76JcDUvW;

		internal void u53vBpeG6KR()
		{
			foreach (FloatButtonWindow item in LxAvBBtm2H7.CDktWWsHEw8)
			{
				bool flag;
				switch (LxAvBBtm2H7.FloatViewMode)
				{
				case ViewMode.ByProcess:
				{
					int num;
					if (item.EnableProcessBinding)
					{
						if (KmRiR5cmKhpZ76JcDUvW == null)
						{
							switch (0)
							{
							case 1:
								goto IL_0083;
							}
						}
						num = (string.Equals(item.BindingProcessName, D0dvBQ0ds1Z, StringComparison.OrdinalIgnoreCase) ? 1 : 0);
					}
					else
					{
						num = 1;
					}
					flag = (byte)num != 0;
					goto IL_0085;
				}
				case ViewMode.ShowAll:
					flag = true;
					goto IL_0085;
				case ViewMode.HideAll:
					goto IL_0083;
				default:
					{
						throw new ArgumentOutOfRangeException();
					}
					IL_0083:
					flag = false;
					goto IL_0085;
					IL_0085:
					if (flag)
					{
						if (!item.IsVisible)
						{
							item.Show();
						}
					}
					else if (item.IsVisible)
					{
						item.Hide();
					}
					break;
				}
			}
			int num3 = default(int);
			foreach (FloatPanelWindow item2 in LxAvBBtm2H7.QI8tWGZSHNJ)
			{
				int num2 = 0;
				if (KmRiR5cmKhpZ76JcDUvW != null)
				{
					goto IL_015a;
				}
				goto IL_015b;
				IL_015a:
				num2 = num3;
				goto IL_015b;
				IL_015b:
				while (true)
				{
					switch (num2)
					{
					default:
						if (LxAvBBtm2H7.FloatViewMode switch
						{
							ViewMode.ByProcess => (!item2.EnableProcessBinding || string.Equals(item2.BindingProcessName, D0dvBQ0ds1Z, StringComparison.OrdinalIgnoreCase)) ? 1 : 0, 
							ViewMode.ShowAll => 1, 
							ViewMode.HideAll => 0, 
							_ => throw new ArgumentOutOfRangeException(), 
						} == 0)
						{
							if (!item2.IsVisible)
							{
								break;
							}
							goto IL_014d;
						}
						if (!item2.IsVisible)
						{
							item2.Show();
						}
						break;
					case 1:
						item2.Hide();
						break;
					}
					break;
					IL_014d:
					num2 = 1;
					if (NvQh8jcmBakwXC1Ebsx5())
					{
						continue;
					}
					goto IL_015a;
				}
			}
		}

		internal static bool NvQh8jcmBakwXC1Ebsx5()
		{
			return KmRiR5cmKhpZ76JcDUvW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public ActionDeletedMessage blCvBnDclQF;

		internal static _003C_003Ec__DisplayClass11_0 Y7MiQHcmdldUujFcSntH;

		internal bool aIpvBjYojPL(FloatButtonWindow x)
		{
			return x.Action.Id == blCvBnDclQF.ActionId;
		}

		internal static bool P2vt0jcmOglJhGdDgwqC()
		{
			return Y7MiQHcmdldUujFcSntH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_1
	{
		public FloatButtonWindow BDnvB5pWxcQ;

		private static _003C_003Ec__DisplayClass11_1 snEw4Icmk1m7BGaDjP0P;

		internal void lFyvB4AjYE8()
		{
			BDnvB5pWxcQ.Close();
		}

		internal static void iKcNoUcmNlJcbLtcTnnA()
		{
		}

		internal static bool i9Ga4wcma26Wxe68hQY3()
		{
			return snEw4Icmk1m7BGaDjP0P == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public FloatButtonAndPanelManager OcuvBTgSPX2;

		public ActionUpdatedMessage YEivBMrwWbi;

		public Func<FloatButtonWindow, bool> kpxvBA4R5Id;

		public Action<FloatPanelWindow> gjbvBOg06tb;

		private static _003C_003Ec__DisplayClass12_0 t9rKXgcm9VpfyBZ6pIAd;

		internal void PSSvBDEFX9I()
		{
			ExtLib.ForEach(OcuvBTgSPX2.CDktWWsHEw8.Where(kpxvBA4R5Id ?? (kpxvBA4R5Id = ryQvBdTmXIS)).ToList(), _003C_003Ec.W5avBKej75V ?? (_003C_003Ec.W5avBKej75V = _003C_003Ec.bpKvBmYAJrK.jDxvBb5IBcx));
			OcuvBTgSPX2.QI8tWGZSHNJ.ForEach(gjbvBOg06tb ?? (gjbvBOg06tb = lFvvBoeiHYL));
		}

		internal bool ryQvBdTmXIS(FloatButtonWindow x)
		{
			return x.Action.Id == YEivBMrwWbi.ActionId;
		}

		internal void lFvvBoeiHYL(FloatPanelWindow x)
		{
			x.RefreshAction(YEivBMrwWbi.ActionId);
		}

		internal static bool JG4YhLcmLbD05OQNjMRm()
		{
			return t9rKXgcm9VpfyBZ6pIAd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public FloatButtonWindow nsVvBU6NCNT;

		public Func<BtnSnapLink, bool> Vk7vBlfuMm6;

		private static _003C_003Ec__DisplayClass23_0 lwl1CNcmf2bxm9L4PA08;

		internal bool QwDvBF2Clrn(BtnSnapLink x)
		{
			return x.Primary == nsVvBU6NCNT;
		}

		internal static bool TjPoOPcmbAC2HGWHXoyG()
		{
			return lwl1CNcmf2bxm9L4PA08 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public FloatButtonAndPanelManager ehUvB3W7Cwg;

		public List<FloatItemState> as1vBf0whdS;

		private static _003C_003Ec__DisplayClass33_0 G0X4wRcmiSw0UVorCpnH;

		internal void jIcvBibHcmK()
		{
			foreach (FloatButtonWindow item in ehUvB3W7Cwg.CDktWWsHEw8)
			{
				as1vBf0whdS.Add(item.GetState());
			}
			foreach (FloatPanelWindow item2 in ehUvB3W7Cwg.QI8tWGZSHNJ)
			{
				as1vBf0whdS.Add(item2.GetState());
			}
		}

		internal static bool fdVKMQcmlJH5wsRTa2Kv()
		{
			return G0X4wRcmiSw0UVorCpnH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public FloatState cjyvQw1uFFv;

		public FloatButtonAndPanelManager z7RvQtI4KPs;

		internal static _003C_003Ec__DisplayClass34_0 b6LmRycmYfgYplyMqvCh;

		internal void EFDvBzTMtS5()
		{
			using (IEnumerator<FloatItemState> enumerator = cjyvQw1uFFv.Items.GetEnumerator())
			{
				int num2 = default(int);
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_1
					{
						MK6vQLLUwR8 = enumerator.Current
					};
					switch (_003C_003Ec__DisplayClass34_.MK6vQLLUwR8.ItemType)
					{
					case FloatItemType.ActionPage:
					{
						AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass34_.e1ivQg7IBqZ);
						int num = 0;
						if (!vPPMqfcm8aHOSwSAYgaa())
						{
							num = num2;
						}
						switch (num)
						{
						}
						break;
					}
					case FloatItemType.ActionButton:
					{
						FloatButtonWindow floatButtonWindow = AppState.lWutartRfUY().RestoreFloatAction(_003C_003Ec__DisplayClass34_.MK6vQLLUwR8);
						if (floatButtonWindow != null)
						{
							QjLtWYTF4Nt.Info($"恢复悬浮动作：{_003C_003Ec__DisplayClass34_.MK6vQLLUwR8.Location}, {_003C_003Ec__DisplayClass34_.MK6vQLLUwR8.ItemId}");
							z7RvQtI4KPs.F43tWRoIRg3(floatButtonWindow);
						}
						break;
					}
					}
				}
			}
			z7RvQtI4KPs.UpdateButtonResizeMode();
		}

		internal static bool vPPMqfcm8aHOSwSAYgaa()
		{
			return b6LmRycmYfgYplyMqvCh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_1
	{
		public FloatItemState MK6vQLLUwR8;

		internal static _003C_003Ec__DisplayClass34_1 KwdptNcmgpSWeegafRBy;

		internal void e1ivQg7IBqZ()
		{
			AppState.lWutartRfUY().RestoreFloatPanelWindow(MK6vQLLUwR8);
		}

		internal static bool eGw030cmPGmdtGss1JrX()
		{
			return KwdptNcmgpSWeegafRBy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public FloatButtonWindow b14vQS76fjO;

		public Func<BtnSnapLink, bool> rmRvQ2huB2d;

		private static _003C_003Ec__DisplayClass44_0 NeqUrdcmUv22HlOsLxNt;

		internal bool sJlvQvnaA1x(BtnSnapLink x)
		{
			return x.Primary == b14vQS76fjO;
		}

		internal static bool Uy5D6YcmxYydyuDaFyLI()
		{
			return NeqUrdcmUv22HlOsLxNt == null;
		}
	}

	private readonly BtnSnapLinkMgr LxAtWeEDjb1 = new BtnSnapLinkMgr();

	private static readonly ILog QjLtWYTF4Nt;

	[CompilerGenerated]
	private ViewMode nNHtWIvlOTW;

	private readonly IList<FloatButtonWindow> CDktWWsHEw8 = new List<FloatButtonWindow>();

	private readonly ITinyMessengerHub DaEtWkB9kXA;

	private readonly IList<FloatPanelWindow> QI8tWGZSHNJ = new List<FloatPanelWindow>();

	private FloatButtonWindow uP9tWs82kwF;

	private readonly DebounceDispatcher AlStWHSsZvV = new DebounceDispatcher();

	private DebounceTimer HJOtW1gfQKN = new DebounceTimer();

	[CompilerGenerated]
	private ResizeMode UhMtWbw6T3W = ResizeMode.CanResize;

	internal static FloatButtonAndPanelManager Nvs832QJaENyifVG5geL;

	public ViewMode FloatViewMode
	{
		[CompilerGenerated]
		get
		{
			return nNHtWIvlOTW;
		}
		[CompilerGenerated]
		set
		{
			nNHtWIvlOTW = value;
		}
	}

	public ResizeMode FloatButtonResizeMode
	{
		[CompilerGenerated]
		get
		{
			return UhMtWbw6T3W;
		}
		[CompilerGenerated]
		set
		{
			UhMtWbw6T3W = value;
		}
	}

	public FloatButtonAndPanelManager(ITinyMessengerHub hub)
	{
		DaEtWkB9kXA = hub;
		DaEtWkB9kXA.Subscribe<ActionDeletedMessage>(CAntWuFhEyS);
		DaEtWkB9kXA.Subscribe<ActiveProcessChangedMessage>(P8OtWSjoIJ0);
		DaEtWkB9kXA.Subscribe<ActionUpdatedMessage>(aS1tWN4EMrE);
		AppState.L19ta3UhRbZ(this);
	}

	public void SetButtonViewMode(ViewMode mode)
	{
		FloatViewMode = mode;
		htmtW2juMXj();
	}

	private void P8OtWSjoIJ0(ActiveProcessChangedMessage activeProcessChangedMessage_0)
	{
		htmtW2juMXj();
	}

	private void htmtW2juMXj()
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.LxAvBBtm2H7 = this;
		_003C_003Ec__DisplayClass10_.D0dvBQ0ds1Z = AppState.CurrentProcessName;
		if (Application.Current != null)
		{
			Application.Current.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass10_.u53vBpeG6KR);
		}
	}

	private void CAntWuFhEyS(ActionDeletedMessage actionDeletedMessage_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.blCvBnDclQF = actionDeletedMessage_0;
		using IEnumerator<FloatButtonWindow> enumerator = ((IEnumerable<FloatButtonWindow>)CDktWWsHEw8.Where(_003C_003Ec__DisplayClass11_.aIpvBjYojPL).ToList()).GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_2 = new _003C_003Ec__DisplayClass11_1();
			_003C_003Ec__DisplayClass11_2.BDnvB5pWxcQ = enumerator.Current;
			Application.Current.Dispatcher.Invoke(_003C_003Ec__DisplayClass11_2.lFyvB4AjYE8);
		}
	}

	private void aS1tWN4EMrE(ActionUpdatedMessage actionUpdatedMessage_0)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.OcuvBTgSPX2 = this;
		_003C_003Ec__DisplayClass12_.YEivBMrwWbi = actionUpdatedMessage_0;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass12_.PSSvBDEFX9I);
	}

	internal void sKqtWJA2GDn(FloatButtonWindow floatButtonWindow_1)
	{
		CDktWWsHEw8.Add(floatButtonWindow_1);
		floatButtonWindow_1.LocationChanged += yjwtWPuwtSu;
		iQ6tWqLf3ht();
	}

	internal void B5ttW0SUr1w(FloatPanelWindow floatPanelWindow_0)
	{
		QI8tWGZSHNJ.Add(floatPanelWindow_0);
		floatPanelWindow_0.LocationChanged += DkVtW8hS0y8;
		iQ6tWqLf3ht();
	}

	internal (bool hasButton, double width, double height) AortWCpXK25()
	{
		if (CDktWWsHEw8.Count > 0)
		{
			FloatButtonWindow floatButtonWindow = CDktWWsHEw8.Last();
			return (hasButton: true, width: floatButtonWindow.Width, height: floatButtonWindow.Height);
		}
		return (hasButton: false, width: 0.0, height: 0.0);
	}

	private void yjwtWPuwtSu(object sender, EventArgs e)
	{
		if (!(sender is FloatButtonWindow floatButtonWindow))
		{
			AppHelper.ShowWarning("不是悬浮按钮！");
		}
		else if (floatButtonWindow == uP9tWs82kwF)
		{
			NF6tWyH7CSQ(floatButtonWindow);
		}
	}

	private double ekQtWE7ch8t(Point point_0, Point point_1)
	{
		return Math.Abs(point_0.X - point_1.X) + Math.Abs(point_0.Y - point_1.Y);
	}

	private void NF6tWyH7CSQ(FloatButtonWindow floatButtonWindow_1)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.nsVvBU6NCNT = floatButtonWindow_1;
		using IEnumerator<BtnSnapLink> enumerator = LxAtWeEDjb1.Links.Where(_003C_003Ec__DisplayClass23_.Vk7vBlfuMm6 ?? (_003C_003Ec__DisplayClass23_.Vk7vBlfuMm6 = _003C_003Ec__DisplayClass23_.QwDvBF2Clrn)).GetEnumerator();
		while (enumerator.MoveNext())
		{
			BtnSnapLink current = enumerator.Current;
			if (current.LinkType == SnapLinkType.LeftRight)
			{
				current.Secondary.Top = _003C_003Ec__DisplayClass23_.nsVvBU6NCNT.Top;
				current.Secondary.Left = _003C_003Ec__DisplayClass23_.nsVvBU6NCNT.Right + 1.0;
				NF6tWyH7CSQ(current.Secondary);
			}
			else if (current.LinkType == SnapLinkType.UpDown)
			{
				current.Secondary.Top = _003C_003Ec__DisplayClass23_.nsVvBU6NCNT.Bottom + 1.0;
				current.Secondary.Left = _003C_003Ec__DisplayClass23_.nsVvBU6NCNT.Left;
				NF6tWyH7CSQ(current.Secondary);
			}
		}
		int num = 0;
		if (Nvs832QJaENyifVG5geL != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public void UnRegister(FloatButtonWindow floatButton)
	{
		if (CDktWWsHEw8.Contains(floatButton))
		{
			floatButton.LocationChanged -= yjwtWPuwtSu;
			CDktWWsHEw8.Remove(floatButton);
			LxAtWeEDjb1.RemoveButton(floatButton);
		}
		iQ6tWqLf3ht();
	}

	public void UnRegister(FloatPanelWindow floatPanelWindow)
	{
		if (QI8tWGZSHNJ.Contains(floatPanelWindow))
		{
			floatPanelWindow.LocationChanged -= DkVtW8hS0y8;
			QI8tWGZSHNJ.Remove(floatPanelWindow);
		}
		iQ6tWqLf3ht();
	}

	private void DkVtW8hS0y8(object sender, EventArgs e)
	{
		iQ6tWqLf3ht();
	}

	internal void geptWaoGhSi(FloatButtonWindow floatButtonWindow_1)
	{
		uP9tWs82kwF = floatButtonWindow_1;
		LxAtWeEDjb1.RemoveButtonPrimaryLinks(floatButtonWindow_1);
	}

	internal void TrQtW7ijKse(FloatButtonWindow floatButtonWindow_1)
	{
		NF6tWyH7CSQ(floatButtonWindow_1);
		F43tWRoIRg3(floatButtonWindow_1);
		uP9tWs82kwF = null;
		iQ6tWqLf3ht();
	}

	private void F43tWRoIRg3(FloatButtonWindow floatButtonWindow_1)
	{
		Point? point = null;
		BtnSnapLink snapLink = null;
		foreach (FloatButtonWindow item in CDktWWsHEw8)
		{
			if (Nvs832QJaENyifVG5geL != null)
			{
				switch (0)
				{
				}
			}
			if (item != floatButtonWindow_1 && !LxAtWeEDjb1.IsFollowing(item, floatButtonWindow_1))
			{
				double num = ekQtWE7ch8t(item.TopRight, floatButtonWindow_1.TopLeft);
				if (num < 40.0 && (!point.HasValue || num < ekQtWE7ch8t(point.Value, floatButtonWindow_1.TopLeft)))
				{
					point = item.TopRight;
					snapLink = new BtnSnapLink(SnapLinkType.LeftRight, item, floatButtonWindow_1);
				}
				num = ekQtWE7ch8t(item.BottomLeft, floatButtonWindow_1.TopLeft);
				if (num < 40.0 && (!point.HasValue || num < ekQtWE7ch8t(point.Value, floatButtonWindow_1.TopLeft)))
				{
					point = item.BottomLeft;
					snapLink = new BtnSnapLink(SnapLinkType.UpDown, item, floatButtonWindow_1);
				}
			}
		}
		if (point.HasValue)
		{
			int num2 = 0;
			if (Nvs832QJaENyifVG5geL != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			floatButtonWindow_1.Left = point.Value.X;
			floatButtonWindow_1.Top = point.Value.Y;
			LxAtWeEDjb1.AddLink(snapLink);
		}
		else
		{
			LxAtWeEDjb1.RemoveButtonPrimaryLinks(floatButtonWindow_1);
		}
	}

	private void iQ6tWqLf3ht()
	{
		HJOtW1gfQKN.Debounce(1000, lrmtWVhQDOn);
	}

	internal void dZMtWcP6ceZ(FloatButtonWindow floatButtonWindow_1)
	{
		iQ6tWqLf3ht();
	}

	private void lrmtWVhQDOn(object object_0)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.ehUvB3W7Cwg = this;
		_003C_003Ec__DisplayClass33_.as1vBf0whdS = new List<FloatItemState>();
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass33_.jIcvBibHcmK);
		FloatState floatState_ = new FloatState
		{
			Items = _003C_003Ec__DisplayClass33_.as1vBf0whdS
		};
		AppState.DataService.EAjtXEg2I49(floatState_);
	}

	internal void xBetWZRU6Fr()
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.z7RvQtI4KPs = this;
		if (gLQpb4QJrKXKHoudqliK())
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass34_.cjyvQw1uFFv = AppState.DataService.YDvtXy81syS();
		if (_003C_003Ec__DisplayClass34_.cjyvQw1uFFv != null && _003C_003Ec__DisplayClass34_.cjyvQw1uFFv.Items.HasData())
		{
			QjLtWYTF4Nt.Info($"恢复{_003C_003Ec__DisplayClass34_.cjyvQw1uFFv.Items.Count(_003C_003Ec.X3PvBx8jFqJ ?? (_003C_003Ec.X3PvBx8jFqJ = _003C_003Ec.bpKvBmYAJrK.v7UvB6LF46O))}个悬浮动作，{_003C_003Ec__DisplayClass34_.cjyvQw1uFFv.Items.Count(_003C_003Ec.KTuvBr088Xb ?? (_003C_003Ec.KTuvBr088Xb = _003C_003Ec.bpKvBmYAJrK.wu8vBXPTUM1))}个悬浮动作页");
			if (_003C_003Ec__DisplayClass34_.cjyvQw1uFFv.Items.HasData())
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass34_.EFDvBzTMtS5);
			}
			htmtW2juMXj();
		}
	}

	public void Exit()
	{
	}

	[SpecialName]
	internal int T8FtW9pjdDA()
	{
		return CDktWWsHEw8.Count + QI8tWGZSHNJ.Count;
	}

	public void UpdateUiSkin()
	{
		foreach (FloatButtonWindow item in CDktWWsHEw8)
		{
			item.UpdateUiSkin();
		}
		foreach (FloatPanelWindow item2 in QI8tWGZSHNJ)
		{
			item2.UpdateUiSkin();
		}
	}

	public void UpdateButtonResizeMode()
	{
		ResizeMode resizeMode = ((AppState.HHxtaMaoqJr().FixFloatButtonSize != -1) ? ResizeMode.CanResize : ResizeMode.NoResize);
		if (FloatButtonResizeMode == resizeMode)
		{
			return;
		}
		FloatButtonResizeMode = resizeMode;
		foreach (FloatButtonWindow item in CDktWWsHEw8)
		{
			item.ResizeMode = FloatButtonResizeMode;
			if (FloatButtonResizeMode == ResizeMode.NoResize && NativeMethods.IsOnWindows10OrLater() && !NativeMethods.IsOnWindows11())
			{
				item.UpdateNoResizeShadow();
			}
		}
	}

	public void OnItemSizeChanged(FloatButtonWindow currBtn)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.b14vQS76fjO = currBtn;
		foreach (BtnSnapLink item in LxAtWeEDjb1.Links.Where(_003C_003Ec__DisplayClass44_.rmRvQ2huB2d ?? (_003C_003Ec__DisplayClass44_.rmRvQ2huB2d = _003C_003Ec__DisplayClass44_.sJlvQvnaA1x)))
		{
			item.Secondary.Width = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Width;
			item.Secondary.Height = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Height;
			if (item.LinkType == SnapLinkType.LeftRight)
			{
				item.Secondary.Top = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Top;
				item.Secondary.Left = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Right + 1.0;
				NF6tWyH7CSQ(item.Secondary);
			}
			else if (item.LinkType == SnapLinkType.UpDown)
			{
				item.Secondary.Top = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Bottom + 1.0;
				item.Secondary.Left = _003C_003Ec__DisplayClass44_.b14vQS76fjO.Left;
				NF6tWyH7CSQ(item.Secondary);
			}
		}
	}

	static FloatButtonAndPanelManager()
	{
		QjLtWYTF4Nt = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool gLQpb4QJrKXKHoudqliK()
	{
		return Nvs832QJaENyifVG5geL == null;
	}
}
