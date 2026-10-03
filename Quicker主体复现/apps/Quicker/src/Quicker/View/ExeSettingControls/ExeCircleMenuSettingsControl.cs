using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using CommunityToolkit.Mvvm.Messaging;
using JTIh7V5l65QV75A93Ly;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;
using Quicker.View.CircleMenu;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.View.ExeSettingControls;

public class ExeCircleMenuSettingsControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec q9CSpzLxfVC;

		public static Func<KeyValuePair<string, string>, bool> WqTSBw2m7br;

		internal static _003C_003Ec dg1cLTWUhSQxYLC6q5xC;

		static _003C_003Ec()
		{
			q9CSpzLxfVC = new _003C_003Ec();
		}

		internal bool Ut0SpfG2hY0(KeyValuePair<string, string> x)
		{
			return string.IsNullOrEmpty(x.Value);
		}

		internal static bool tMLWTAWUHTSIFfq0Y7VD()
		{
			return dg1cLTWUhSQxYLC6q5xC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_0
	{
		public ExeCircleMenuSettingsControl ovCSBL8XPiq;

		public CircleMenuEventArgs GyuSBv3eCXC;

		internal static _003C_003Ec__DisplayClass25_0 rRMPvTWxVrJLJDhOLnJE;

		internal void VRmSBtASl7Y(object sender, RoutedEventArgs e)
		{
			ovCSBL8XPiq.CircleActionMenu.ContextMenu = null;
		}

		internal void evlSBgMBtNv(object sender, RoutedEventArgs e)
		{
			ovCSBL8XPiq.LwdLvnlBGku(GyuSBv3eCXC.Position);
		}

		internal static bool KEWRjgWxQoE25DLvFROO()
		{
			return rRMPvTWxVrJLJDhOLnJE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_1
	{
		public ActionItem QgtSB2N89OD;

		public _003C_003Ec__DisplayClass25_0 iR6SBupwNyj;

		private static _003C_003Ec__DisplayClass25_1 o8Gci3Wxclob7T4LbZrR;

		internal void krwSBSBjq7x(object sender, RoutedEventArgs e)
		{
			iR6SBupwNyj.ovCSBL8XPiq.QtNLvBMjj3X(iR6SBupwNyj.GyuSBv3eCXC.Position, QgtSB2N89OD);
			iR6SBupwNyj.ovCSBL8XPiq.Save();
		}

		static _003C_003Ec__DisplayClass25_1()
		{
		}

		internal static bool kcmqRiWxWxjx8Y9qEAoc()
		{
			return o8Gci3Wxclob7T4LbZrR == null;
		}

		internal static void C9HiR8WxpYLbRbYCBRsA()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_2
	{
		public ActionItem nkOSBJW6ISL;

		public _003C_003Ec__DisplayClass25_0 xAJSB0gXkQi;

		internal static _003C_003Ec__DisplayClass25_2 piw4FjWxXTW6vckvhnVM;

		internal void pBnSBNn4NYT(object sender, RoutedEventArgs e)
		{
			xAJSB0gXkQi.ovCSBL8XPiq.QtNLvBMjj3X(xAJSB0gXkQi.GyuSBv3eCXC.Position, nkOSBJW6ISL);
			xAJSB0gXkQi.ovCSBL8XPiq.Save();
		}

		internal static bool Q8PKvOWx2U2e1jCnwUfk()
		{
			return piw4FjWxXTW6vckvhnVM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public ExeCircleMenuSettingsControl nPQSBagK4b6;

		public CircleMenuEventArgs UZ5SB7DXLK4;

		internal static _003C_003Ec__DisplayClass26_0 InpxTWWxnQXvmL0q0Sc7;

		internal void pO3SBC4NM21(object sender, RoutedEventArgs e)
		{
			nPQSBagK4b6.CircleActionMenu.ContextMenu = null;
		}

		internal void ccXSBPqNw7T(object sender, RoutedEventArgs e)
		{
			nPQSBagK4b6.EditAction(UZ5SB7DXLK4);
		}

		internal void s1oSBEjUq56(object sender, RoutedEventArgs e)
		{
			if (ClipboardHelper.IsClipboardHasIconUrl())
			{
				string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				if (UZ5SB7DXLK4.Action is CircleMenuTempAction circleMenuTempAction)
				{
					circleMenuTempAction.CircleMenuAction.Icon = text;
					string text2 = "json:" + JsonConvert.SerializeObject(circleMenuTempAction.CircleMenuAction);
					nPQSBagK4b6.CurrentExeSettings.CircleMenuActions[UZ5SB7DXLK4.Position.ToString()] = text2;
					nPQSBagK4b6.CircleActionMenu.SetPosition(UZ5SB7DXLK4.Position, TempActionCreator.CreateTempAction(text2));
					nPQSBagK4b6.Save();
					return;
				}
				AppHelper.ShowWarning("数据为空。无法在此动作上粘贴图标。");
				int num = 0;
				if (InpxTWWxnQXvmL0q0Sc7 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				AppHelper.ShowWarning("剪贴板中未发现图标。");
			}
		}

		internal void iEpSByAJYbx(object sender, RoutedEventArgs e)
		{
			try
			{
				ClipboardHelper.SetData("quicker-circle-menu-action", UZ5SB7DXLK4.Action);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("复制出错：" + ex.Message);
			}
		}

		internal void VHYSB8yZg4E(object sender, RoutedEventArgs e)
		{
			nPQSBagK4b6.RemoveAction(UZ5SB7DXLK4);
		}

		internal static bool qSfTNpWxekcUJM7im4Hm()
		{
			return InpxTWWxnQXvmL0q0Sc7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_1
	{
		public ActionItem YVpSBqIAKJx;

		internal static _003C_003Ec__DisplayClass26_1 CYBlirWxEJ1BpuBbFkfv;

		internal void R6ASBRh3pyH(object sender, RoutedEventArgs e)
		{
			AppState.lWutartRfUY().EditActionById(YVpSBqIAKJx.Id);
		}

		internal static bool TdiMALWxGUxmb9wf0pfv()
		{
			return CYBlirWxEJ1BpuBbFkfv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_2
	{
		public ActionItem IM1SBVGgSAW;

		internal static _003C_003Ec__DisplayClass26_2 XFu3MtWx1t0TS9gePYEe;

		internal void jqaSBc2xtT9(object sender, RoutedEventArgs e)
		{
			AppState.lWutartRfUY().EditActionById(IM1SBVGgSAW.Id);
		}

		internal static bool C2emgaWxKCyphT1bDLjI()
		{
			return XFu3MtWx1t0TS9gePYEe == null;
		}
	}

	[CompilerGenerated]
	private EventHandler m_DataChanged;

	private DataService CekLvlcdrNW;

	[CompilerGenerated]
	private ExeSettings v70LviXXdSO;

	[CompilerGenerated]
	private ExeSettings xGPLv3qsWWq;

	internal Grid DesignerPanel;

	internal CheckBox ChkDisable;

	internal TextBlock LblWarning;

	internal Label LblSetDefaultAction;

	internal CircleActionMenu CircleActionMenu;

	internal TextBlock LblVersionTip;

	internal Button BtnAddDefaultExtActions;

	internal Button BtnCopyAll;

	internal Button BtnPasteAll;

	internal Button BtnClearAll;

	internal Button BtnGotoSettings;

	private bool YO7LvfJY1Ts;

	private static ExeCircleMenuSettingsControl Ta9x2KFnvtk3IiAJ8fZx;

	public ExeSettings CurrentExeSettings
	{
		[CompilerGenerated]
		get
		{
			return v70LviXXdSO;
		}
		[CompilerGenerated]
		private set
		{
			v70LviXXdSO = value;
		}
	}

	public ExeSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return xGPLv3qsWWq;
		}
		[CompilerGenerated]
		private set
		{
			xGPLv3qsWWq = value;
		}
	}

	public event EventHandler DataChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExeCircleMenuSettingsControl()
	{
		InitializeComponent();
		base.Loaded += I1kLvmmGK0U;
		base.Unloaded += KObLvXAmpTU;
		O44LvKFgPbl();
	}

	private void KObLvXAmpTU(object sender, RoutedEventArgs e)
	{
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
	}

	private void I1kLvmmGK0U(object sender, RoutedEventArgs e)
	{
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, D2HLvOi2IEC);
	}

	private void O44LvKFgPbl()
	{
		if (string.IsNullOrEmpty(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().CircleMenu?.DefaultIconColor))
		{
			return;
		}
		DependencyProperty defaultIconColorProperty = ActionButton.DefaultIconColorProperty;
		Color? color = TryFindResource("SecondaryTextColor") as Color?;
		object obj;
		if (!color.HasValue)
		{
			obj = null;
		}
		else
		{
			obj = color.GetValueOrDefault().ToString();
			if (obj != null)
			{
				goto IL_0068;
			}
		}
		obj = "#A9A9A9";
		goto IL_0068;
		IL_0068:
		SetValue(defaultIconColorProperty, obj);
		SetValue(ActionButton.LabelColorProperty, TryFindResource("PrimaryTextBrush") as Brush);
		SetValue(RadialMenuItem.SpaceColorProperty, (TryFindResource("BorderBrush") as Brush) ?? Brushes.DarkGray);
	}

	public void Init(DataService dataService)
	{
		CekLvlcdrNW = dataService;
		LblVersionTip.Visibility = (dataService.Hb9tmk3OsJ7() ? Visibility.Collapsed : Visibility.Visible);
	}

	public void SetExe(ExeSettings exeSettings, ExeSettings defaultSettings)
	{
		CurrentExeSettings = exeSettings;
		DefaultSettings = defaultSettings;
		vcJLvxUSWSA();
	}

	private void vcJLvxUSWSA()
	{
		O44LvKFgPbl();
		SolidColorBrush color = Brushes.White;
		SolidColorBrush color2 = Brushes.GhostWhite;
		SolidColorBrush brush = "#A0FFFAF0".GetBrush();
		SolidColorBrush color3 = Brushes.White;
		SolidColorBrush solidColorBrush = default(SolidColorBrush);
		int num2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			IL_0150:
			SolidColorBrush color4 = Brushes.FloralWhite;
			int num;
			if (App.Current.n991yfUy4r())
			{
				solidColorBrush = new SolidColorBrush(Color.FromRgb(26, 26, 26));
				CircleActionMenu.BgFill = solidColorBrush;
				CircleActionMenu.BgOverlayFill = new SolidColorBrush(Color.FromRgb(97, 97, 97));
				color = solidColorBrush;
				color2 = new SolidColorBrush(Color.FromRgb(32, 33, 49));
				num = 0;
				if (!GCoe2EFndxjAo0P3bNCj())
				{
					goto IL_0069;
				}
				goto IL_006d;
			}
			goto IL_00de;
			IL_046a:
			CircleActionMenu.SetPositionColor(num2, color);
			goto IL_0462;
			IL_00de:
			if (CurrentExeSettings == null)
			{
				DesignerPanel.IsEnabled = false;
				num2 = 0;
				num = 1;
				if (Ta9x2KFnvtk3IiAJ8fZx == null)
				{
					goto IL_047b;
				}
			}
			else
			{
				if (!string.Equals(CurrentExeSettings.Exe, "_global", StringComparison.OrdinalIgnoreCase))
				{
					ChkDisable.Content = "在此软件下禁用轮盘菜单";
					LblSetDefaultAction.Visibility = Visibility.Collapsed;
					goto IL_018c;
				}
				num = 5;
				if (!GCoe2EFndxjAo0P3bNCj())
				{
					goto IL_0069;
				}
			}
			goto IL_006d;
			IL_019a:
			LblSetDefaultAction.Visibility = Visibility.Visible;
			BtnAddDefaultExtActions.Visibility = Visibility.Visible;
			goto IL_01b2;
			IL_01b2:
			DesignerPanel.IsEnabled = true;
			ChkDisable.IsChecked = CurrentExeSettings.DisableCircleMenu;
			CircleActionMenu.Clear();
			if (string.Equals(CurrentExeSettings.Exe, "_global", StringComparison.OrdinalIgnoreCase))
			{
				CircleActionMenu.SetExternItemsVisibility(true);
				for (int i = 0; i < CircleActionMenu.Circle1ActionCount; i++)
				{
					CircleActionMenu.SetPositionColor(i, color);
				}
				for (int j = 100; j < 100 + CircleActionMenu.Circle2ActionCount; j++)
				{
					CircleActionMenu.SetPositionColor(j, color);
				}
				for (int k = 200; k < 200 + CircleActionMenu.Circle3ActionCount; k++)
				{
					CircleActionMenu.SetPositionColor(k, color2);
				}
			}
			else
			{
				for (int l = 0; l < CircleActionMenu.Circle1ActionCount; l++)
				{
					CircleActionMenu.SetPositionColor(l, color3);
				}
				for (int m = 100; m < 100 + CircleActionMenu.Circle2ActionCount; m++)
				{
					CircleActionMenu.SetPositionColor(m, color3);
				}
				if (DefaultSettings != null && DefaultSettings.CircleMenuActions.HasData())
				{
					foreach (KeyValuePair<string, string> circleMenuAction in DefaultSettings.CircleMenuActions)
					{
						if (!string.IsNullOrEmpty(circleMenuAction.Value))
						{
							if (Convert.ToInt32(circleMenuAction.Key) < 200)
							{
								CircleActionMenu.SetPositionColor(Convert.ToInt32(circleMenuAction.Key), brush);
							}
							else
							{
								CircleActionMenu.SetPositionColor(Convert.ToInt32(circleMenuAction.Key), color4);
							}
						}
					}
				}
			}
			if (CurrentExeSettings.CircleMenuActions != null)
			{
				foreach (KeyValuePair<string, string> circleMenuAction2 in CurrentExeSettings.CircleMenuActions)
				{
					int position = Convert.ToInt32(circleMenuAction2.Key);
					string value = circleMenuAction2.Value;
					int num3 = 0;
					if (!GCoe2EFndxjAo0P3bNCj())
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					if (!string.IsNullOrEmpty(value))
					{
						ActionItem actionItem = TempActionCreator.CreateTempAction(value);
						if (actionItem != null)
						{
							CircleActionMenu.SetPosition(position, actionItem);
						}
					}
				}
			}
			try
			{
				BtnPasteAll.Visibility = ClipboardHelper.ContainsData("quicker-circle-menu-config").ToVisibility();
				return;
			}
			catch
			{
				BtnPasteAll.Visibility = Visibility.Collapsed;
				return;
			}
			IL_0069:
			num = num5;
			goto IL_006d;
			IL_018c:
			BtnAddDefaultExtActions.Visibility = Visibility.Collapsed;
			goto IL_01b2;
			IL_006d:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					brush = "#FF2A2520".GetBrush();
					color3 = solidColorBrush;
					color4 = "#FF302A20".GetBrush();
					goto end_IL_006d;
				case 2:
					goto end_IL_006d;
				case 7:
					goto IL_0150;
				case 4:
					goto IL_018c;
				case 6:
					goto IL_019a;
				case 8:
					goto IL_0462;
				case 1:
					goto IL_046a;
				case 3:
					goto IL_047b;
				}
				ChkDisable.Content = "默认禁用轮盘（除非在特定的软件下开启）";
				num = 6;
				if (Ta9x2KFnvtk3IiAJ8fZx == null)
				{
					continue;
				}
				goto IL_0069;
				continue;
				end_IL_006d:
				break;
			}
			goto IL_00de;
			IL_0462:
			num2++;
			goto IL_047b;
			IL_047b:
			if (num2 >= CircleActionMenu.Circle1ActionCount)
			{
				break;
			}
			goto IL_046a;
		}
		for (int n = 100; n < 100 + CircleActionMenu.Circle2ActionCount; n++)
		{
			CircleActionMenu.SetPositionColor(n, color);
		}
		for (int num6 = 200; num6 < 200 + CircleActionMenu.Circle3ActionCount; num6++)
		{
			CircleActionMenu.SetPositionColor(num6, color2);
		}
	}

	private CircleMenuAction iB1LvrRrLRJ(ActionItem actionItem_0)
	{
		if (actionItem_0 == null)
		{
			return null;
		}
		if (actionItem_0.ActionType.IsEither(ActionType.TempAction))
		{
			throw new InvalidDataException("错误的动作类型。");
		}
		if (actionItem_0 is CircleMenuTempAction circleMenuTempAction)
		{
			return circleMenuTempAction.CircleMenuAction;
		}
		return new CircleMenuAction
		{
			Title = actionItem_0.Title,
			Description = actionItem_0.Description,
			Icon = "",
			ActionType = QuickActionType.QuickerAction,
			Data = actionItem_0.Id
		};
	}

	private string YpGLvpHk77m(CircleMenuAction circleMenuAction_0)
	{
		if (circleMenuAction_0 != null)
		{
			return "json:" + JsonConvert.SerializeObject(circleMenuAction_0);
		}
		return null;
	}

	private void CircleActionMenu_OnDropOnItem(object sender, CircleMenuItemDropEventArgs e)
	{
		if (CurrentExeSettings == null)
		{
			AppHelper.ShowWarning("请选择要设置的软件！");
			return;
		}
		int num;
		if (e.OriginEventArgs.Data.GetDataPresent("quicker-action-drag-item"))
		{
			ActionItemDragObject actionItemDragObject = (ActionItemDragObject)e.OriginEventArgs.Data.GetData("quicker-action-drag-item");
			if (actionItemDragObject == null)
			{
				AppHelper.ShowWarning("获得的拖动对象为空。");
				return;
			}
			ActionItem action = actionItemDragObject.Action;
			if (CurrentExeSettings.CircleMenuActions == null)
			{
				CurrentExeSettings.CircleMenuActions = new Dictionary<string, string>();
			}
			QtNLvBMjj3X(e.Position, action);
			Save();
			num = 1;
			if (!GCoe2EFndxjAo0P3bNCj())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			if (!e.OriginEventArgs.Data.GetDataPresent("circle_menu_drag_item"))
			{
				AppHelper.ShowWarning("不支持的拖放对象！请拖放动作。");
				return;
			}
			RadialMenuItem obj = (RadialMenuItem)e.OriginEventArgs.Data.GetData("circle_menu_drag_item");
			int num3 = (int)obj.Tag;
			ActionItem actionItem = ((ActionButton)obj.Content).ActionItem;
			ActionItem actionItem2 = ((ActionButton)(sender as RadialMenuItem).Content).ActionItem;
			if (num3 == e.Position)
			{
				return;
			}
			QtNLvBMjj3X(e.Position, actionItem);
			QtNLvBMjj3X(num3, actionItem2);
			num = 0;
			if (Ta9x2KFnvtk3IiAJ8fZx != null)
			{
				goto IL_0152;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0152;
		IL_0152:
		Save();
	}

	private void QtNLvBMjj3X(int int_0, ActionItem actionItem_0)
	{
		if (actionItem_0 != null)
		{
			if (actionItem_0.ActionType == ActionType.TempAction)
			{
				CircleMenuTempAction circleMenuTempAction = actionItem_0 as CircleMenuTempAction;
				if (!GCoe2EFndxjAo0P3bNCj())
				{
					switch (0)
					{
					}
				}
				if (circleMenuTempAction != null)
				{
					CurrentExeSettings.CircleMenuActions[int_0.ToString()] = "json:" + JsonConvert.SerializeObject(circleMenuTempAction.CircleMenuAction);
					CircleActionMenu.SetPosition(int_0, actionItem_0);
				}
				else
				{
					AppHelper.ShowWarning("无法转换为轮盘动作");
				}
			}
			else
			{
				CircleMenuAction circleMenuAction = iB1LvrRrLRJ(actionItem_0);
				CurrentExeSettings.CircleMenuActions[int_0.ToString()] = YpGLvpHk77m(circleMenuAction);
				CircleMenuTempAction action = TempActionCreator.CreateTempAction(circleMenuAction, actionItem_0);
				CircleActionMenu.SetPosition(int_0, action);
			}
		}
		else
		{
			CurrentExeSettings.CircleMenuActions[int_0.ToString()] = null;
			CircleActionMenu.SetPosition(int_0, null);
		}
	}

	private void KYgLvQ3AOrK(object sender, RoutedEventArgs e)
	{
		CurrentExeSettings.DisableCircleMenu = ChkDisable.IsChecked == true;
		Save();
	}

	private void Save()
	{
		this.m_DataChanged?.Invoke(this, EventArgs.Empty);
	}

	private void CircleActionMenu_OnItemRightClick(object sender, CircleMenuEventArgs e)
	{
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
		_003C_003Ec__DisplayClass25_.ovCSBL8XPiq = this;
		_003C_003Ec__DisplayClass25_.GyuSBv3eCXC = e;
		if (CurrentExeSettings == null)
		{
			int num = 0;
			if (!GCoe2EFndxjAo0P3bNCj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		if (_003C_003Ec__DisplayClass25_.GyuSBv3eCXC.Action != null)
		{
			dsmLvjndh0Y(_003C_003Ec__DisplayClass25_.GyuSBv3eCXC);
			return;
		}
		ContextMenu contextMenu = new ContextMenu();
		contextMenu.Closed += _003C_003Ec__DisplayClass25_.VRmSBtASl7Y;
		try
		{
			if (ClipboardHelper.ContainsData("quicker-circle-menu-action"))
			{
				_003C_003Ec__DisplayClass25_1 _003C_003Ec__DisplayClass25_2 = new _003C_003Ec__DisplayClass25_1();
				_003C_003Ec__DisplayClass25_2.iR6SBupwNyj = _003C_003Ec__DisplayClass25_;
				_003C_003Ec__DisplayClass25_2.QgtSB2N89OD = ClipboardHelper.GetData("quicker-circle-menu-action") as ActionItem;
				if (Ta9x2KFnvtk3IiAJ8fZx != null)
				{
					switch (0)
					{
					}
				}
				if (_003C_003Ec__DisplayClass25_2.QgtSB2N89OD != null)
				{
					AppHelper.AddMenuItem(contextMenu.Items, "粘贴轮盘动作：" + _003C_003Ec__DisplayClass25_2.QgtSB2N89OD.Title, null, "fa:Light_Paste", _003C_003Ec__DisplayClass25_2.krwSBSBjq7x);
				}
			}
			if (ClipboardHelper.ContainsData("quicker-action-item"))
			{
				_003C_003Ec__DisplayClass25_2 _003C_003Ec__DisplayClass25_3 = new _003C_003Ec__DisplayClass25_2();
				_003C_003Ec__DisplayClass25_3.xAJSB0gXkQi = _003C_003Ec__DisplayClass25_;
				_003C_003Ec__DisplayClass25_3.nkOSBJW6ISL = ClipboardHelper.GetData("quicker-action-item") as ActionItem;
				if (_003C_003Ec__DisplayClass25_3.nkOSBJW6ISL != null && AppState.lWutartRfUY().CanPasteActionCopy(_003C_003Ec__DisplayClass25_3.nkOSBJW6ISL))
				{
					AppHelper.AddMenuItem(contextMenu.Items, "粘贴动作：" + _003C_003Ec__DisplayClass25_3.nkOSBJW6ISL.Title, null, "fa:Light_Paste", _003C_003Ec__DisplayClass25_3.pBnSBNn4NYT);
				}
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("读取剪贴板出错：" + ex.Message);
		}
		AppHelper.AddMenuItem(contextMenu.Items, "添加", "添加新的操作", "fa:Light_Plus:#0aad28", _003C_003Ec__DisplayClass25_.evlSBgMBtNv);
		CircleActionMenu.ContextMenu = contextMenu;
	}

	private ContextMenu dsmLvjndh0Y(CircleMenuEventArgs circleMenuEventArgs_0)
	{
		int num = 2;
		ContextMenu contextMenu = default(ContextMenu);
		_003C_003Ec__DisplayClass26_2 _003C_003Ec__DisplayClass26_2 = default(_003C_003Ec__DisplayClass26_2);
		while (true)
		{
			_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
			int num2 = 1;
			if (Ta9x2KFnvtk3IiAJ8fZx != null)
			{
				goto IL_0089;
			}
			goto IL_008d;
			IL_008d:
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass26_.nPQSBagK4b6 = this;
					_003C_003Ec__DisplayClass26_.UZ5SB7DXLK4 = circleMenuEventArgs_0;
					contextMenu = new ContextMenu();
					contextMenu.Closed += _003C_003Ec__DisplayClass26_.pO3SBC4NM21;
					if (_003C_003Ec__DisplayClass26_.UZ5SB7DXLK4.Action.ActionType != ActionType.TempAction)
					{
						_003C_003Ec__DisplayClass26_2 = new _003C_003Ec__DisplayClass26_2();
						_003C_003Ec__DisplayClass26_2.IM1SBVGgSAW = _003C_003Ec__DisplayClass26_.UZ5SB7DXLK4.Action;
						if (_003C_003Ec__DisplayClass26_2.IM1SBVGgSAW != null)
						{
							goto IL_007c;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass26_1 _003C_003Ec__DisplayClass26_3 = new _003C_003Ec__DisplayClass26_1();
						AppHelper.AddMenuItem(contextMenu.Items, "编辑", "编辑操作", "fa:Light_Edit", _003C_003Ec__DisplayClass26_.ccXSBPqNw7T);
						CircleMenuAction circleMenuAction = (_003C_003Ec__DisplayClass26_.UZ5SB7DXLK4.Action as CircleMenuTempAction).CircleMenuAction;
						_003C_003Ec__DisplayClass26_3.YVpSBqIAKJx = circleMenuAction.GetAction();
						if (_003C_003Ec__DisplayClass26_3.YVpSBqIAKJx != null)
						{
							AppHelper.AddMenuItem(contextMenu.Items, "编辑动作：" + _003C_003Ec__DisplayClass26_3.YVpSBqIAKJx.Title, "", "fa:Light_Edit", _003C_003Ec__DisplayClass26_3.R6ASBRh3pyH);
						}
						if (ClipboardHelper.IsClipboardHasIconUrl())
						{
							AppHelper.AddMenuItem(contextMenu.Items, "粘贴图标", "粘贴图标", "fa:Light_Paste", _003C_003Ec__DisplayClass26_.s1oSBEjUq56);
						}
					}
					goto IL_0216;
				case 2:
					break;
				default:
					{
						AppHelper.AddMenuItem(contextMenu.Items, "编辑动作：" + _003C_003Ec__DisplayClass26_2.IM1SBVGgSAW.Title, "", "fa:Light_Edit", _003C_003Ec__DisplayClass26_2.jqaSBc2xtT9);
						goto IL_0216;
					}
					IL_0216:
					AppHelper.AddMenuItem(contextMenu.Items, "复制", "复制此位置的操作", "fa:Light_Copy", _003C_003Ec__DisplayClass26_.iEpSByAJYbx);
					AppHelper.AddMenuItem(contextMenu.Items, "清除", "清除此位置的动作（不会从面板删除）", "fa:Light_Times:#FF0000", _003C_003Ec__DisplayClass26_.VHYSB8yZg4E);
					CircleActionMenu.ContextMenu = contextMenu;
					return contextMenu;
				}
				break;
				IL_007c:
				num2 = 0;
				if (GCoe2EFndxjAo0P3bNCj())
				{
					continue;
				}
				goto IL_0089;
			}
			continue;
			IL_0089:
			num2 = num;
			goto IL_008d;
		}
	}

	private void EditAction(CircleMenuEventArgs e)
	{
		if (!(e.Action is CircleMenuTempAction circleMenuTempAction))
		{
			dsmLvjndh0Y(e).IsOpen = true;
			return;
		}
		CircleMenuActionEditWindow circleMenuActionEditWindow = new CircleMenuActionEditWindow(CekLvlcdrNW, circleMenuTempAction.CircleMenuAction);
		int num = 0;
		if (!GCoe2EFndxjAo0P3bNCj())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		circleMenuActionEditWindow.Owner = Window.GetWindow(this);
		if (circleMenuActionEditWindow.ShowDialog() == true)
		{
			string text = "json:" + JsonConvert.SerializeObject(circleMenuActionEditWindow.Result);
			CurrentExeSettings.CircleMenuActions[e.Position.ToString()] = text;
			CircleActionMenu.SetPosition(e.Position, TempActionCreator.CreateTempAction(text));
			Save();
		}
	}

	private void LwdLvnlBGku(int int_0)
	{
		CircleMenuActionEditWindow circleMenuActionEditWindow = new CircleMenuActionEditWindow(CekLvlcdrNW, null);
		circleMenuActionEditWindow.Owner = Window.GetWindow(this);
		if (circleMenuActionEditWindow.ShowDialog() == true)
		{
			string text = "json:" + JsonConvert.SerializeObject(circleMenuActionEditWindow.Result);
			CurrentExeSettings.CircleMenuActions[int_0.ToString()] = text;
			CircleActionMenu.SetPosition(int_0, TempActionCreator.CreateTempAction(text));
			Save();
		}
	}

	private void RemoveAction(CircleMenuEventArgs circleMenuEventArgs)
	{
		if (CurrentExeSettings != null)
		{
			CurrentExeSettings.CircleMenuActions.Remove(circleMenuEventArgs.Position.ToString());
			CircleActionMenu.SetPosition(circleMenuEventArgs.Position, null);
			Save();
		}
	}

	private void CircleActionMenu_OnItemLeftClick(object sender, CircleMenuEventArgs e)
	{
		if (e.Action == null)
		{
			LwdLvnlBGku(e.Position);
		}
		else
		{
			EditAction(e);
		}
	}

	private void rbXLv4sO1tX(object sender, RoutedEventArgs e)
	{
		if (!AppHelper.Confirm("您确认要还原扩展圈的默认操作么？"))
		{
			return;
		}
		bool flag = false;
		int num = 200;
		int num3 = default(int);
		while (true)
		{
			if (num < 208)
			{
				if (CircleActionMenu.GetItemAction(num) == null)
				{
					goto IL_0138;
				}
				flag = true;
			}
			if (!flag || AppHelper.Confirm("确认要为扩展圈设置默认操作么？将会覆盖现有设置。"))
			{
				va7LvDhHNZy(200, "切换窗口", "Ctrl+Alt+Tab", new Hotkey(VirtualKeyCode.TAB, ModifierKeys.Alt | ModifierKeys.Control));
				QVuLv5JEr4E(201, "显示面板", "显示面板窗口", "quicker_show_main_win");
				va7LvDhHNZy(202, "前进", "", new Hotkey(VirtualKeyCode.BROWSER_FORWARD, ModifierKeys.None));
				va7LvDhHNZy(203, "关闭文档", "", new Hotkey(VirtualKeyCode.VK_W, ModifierKeys.Control));
				va7LvDhHNZy(204, "末尾", "", new Hotkey(VirtualKeyCode.END, ModifierKeys.Control));
				va7LvDhHNZy(205, "回车", "", new Hotkey(VirtualKeyCode.RETURN, ModifierKeys.None));
				va7LvDhHNZy(206, "后退", "", new Hotkey(VirtualKeyCode.BROWSER_BACK, ModifierKeys.None));
				int num2 = 1;
				if (!GCoe2EFndxjAo0P3bNCj())
				{
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					va7LvDhHNZy(207, "关闭窗口", "", new Hotkey(VirtualKeyCode.F4, ModifierKeys.Alt));
					Save();
					return;
				}
				goto IL_0138;
			}
			break;
			IL_0138:
			num++;
		}
	}

	private void QVuLv5JEr4E(int int_0, string string_0, string string_1, string string_2)
	{
		CircleMenuAction value = new CircleMenuAction
		{
			Title = string_0,
			Description = string_1,
			ActionType = QuickActionType.QuickerOperation,
			Data = string_2
		};
		uWQLvd6nId9(int_0, "json:" + JsonConvert.SerializeObject(value));
	}

	private void va7LvDhHNZy(int int_0, string string_0, string string_1, Hotkey hotkey_0)
	{
		CircleMenuAction value = new CircleMenuAction
		{
			Title = string_0,
			Description = string_1,
			ActionType = QuickActionType.Keystroke,
			Data = hotkey_0.ToData()
		};
		string string_2 = "json:" + JsonConvert.SerializeObject(value);
		uWQLvd6nId9(int_0, string_2);
	}

	private void uWQLvd6nId9(int int_0, string string_0)
	{
		CurrentExeSettings.CircleMenuActions[int_0.ToString()] = string_0;
		CircleActionMenu.SetPosition(int_0, TempActionCreator.CreateTempAction(string_0));
	}

	private void uRrLvoZksBF(object sender, RoutedEventArgs e)
	{
		try
		{
			if (CurrentExeSettings.CircleMenuActions.All(_003C_003Ec.WqTSBw2m7br ?? (_003C_003Ec.WqTSBw2m7br = _003C_003Ec.q9CSpzLxfVC.Ut0SpfG2hY0)))
			{
				AppHelper.ShowWarning("所有位置都为空，没有可以复制的内容。");
				return;
			}
			string data = JsonConvert.SerializeObject(CurrentExeSettings.CircleMenuActions);
			ClipboardHelper.SetData("quicker-circle-menu-config", data);
			AppHelper.ShowSuccess("已复制。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("复制出错：" + ex.Message);
		}
	}

	private void ECeLvTjGWTe(object sender, RoutedEventArgs e)
	{
		try
		{
			string value = ClipboardHelper.GetData("quicker-circle-menu-config") as string;
			if (string.IsNullOrEmpty(value))
			{
				AppHelper.ShowWarning("读取到的内容为空。");
				return;
			}
			Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
			if (AppHelper.Confirm("您确认要使用剪贴板中的内容覆盖当前的轮盘设置么？\n此操作不可撤销。", MessageBoxImage.Exclamation))
			{
				CurrentExeSettings.CircleMenuActions.Clear();
				foreach (KeyValuePair<string, string> item in dictionary)
				{
					CurrentExeSettings.CircleMenuActions.Add(item);
				}
			}
			vcJLvxUSWSA();
			if (Ta9x2KFnvtk3IiAJ8fZx != null)
			{
				switch (0)
				{
				}
			}
			Save();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("出错了。" + ex.Message, true);
		}
	}

	private void L3eLvMEEeFu(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要清空当前的轮盘设置么？\n此操作不可撤销。", MessageBoxImage.Exclamation))
		{
			CurrentExeSettings.CircleMenuActions.Clear();
			vcJLvxUSWSA();
			Save();
		}
	}

	private void IKULvAGyWZH(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.CircleMenuSettingPage);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YO7LvfJY1Ts)
		{
			YO7LvfJY1Ts = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exesettingcontrols/execirclemenusettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			YO7LvfJY1Ts = true;
			break;
		case 1:
			DesignerPanel = (Grid)target;
			num = 0;
			if (Ta9x2KFnvtk3IiAJ8fZx != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_010f;
		case 2:
			ChkDisable = (CheckBox)target;
			ChkDisable.Click += KYgLvQ3AOrK;
			break;
		case 3:
			LblWarning = (TextBlock)target;
			break;
		case 4:
			LblSetDefaultAction = (Label)target;
			break;
		case 5:
			CircleActionMenu = (CircleActionMenu)target;
			break;
		case 6:
			LblVersionTip = (TextBlock)target;
			break;
		case 7:
			BtnAddDefaultExtActions = (Button)target;
			BtnAddDefaultExtActions.Click += rbXLv4sO1tX;
			break;
		case 8:
			BtnCopyAll = (Button)target;
			BtnCopyAll.Click += uRrLvoZksBF;
			num = 1;
			if (Ta9x2KFnvtk3IiAJ8fZx != null)
			{
				break;
			}
			goto IL_010f;
		case 9:
			BtnPasteAll = (Button)target;
			BtnPasteAll.Click += ECeLvTjGWTe;
			break;
		case 10:
			BtnClearAll = (Button)target;
			BtnClearAll.Click += L3eLvMEEeFu;
			break;
		case 11:
			{
				BtnGotoSettings = (Button)target;
				BtnGotoSettings.Click += IKULvAGyWZH;
				break;
			}
			IL_010f:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void D2HLvOi2IEC(object object_0, ThemeChangedMessage themeChangedMessage_0)
	{
		vcJLvxUSWSA();
	}

	internal static bool GCoe2EFndxjAo0P3bNCj()
	{
		return Ta9x2KFnvtk3IiAJ8fZx == null;
	}

	internal static void gSDF8IFnJNIERPxjP3XW()
	{
	}
}
