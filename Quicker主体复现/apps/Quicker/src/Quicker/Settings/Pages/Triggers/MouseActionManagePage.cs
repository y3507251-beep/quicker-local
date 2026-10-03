using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using GongSolutions.Wpf.DragDrop;
using HandyControl.Controls;
using HandyControl.Data;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View.Hotkeys;
using Quicker.View.Mouse;
using Quicker.View.X;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Triggers;

public class MouseActionManagePage : SettingPage, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public Quicker.Domain.PowerMouse.MouseAction bb8v9imRjl9;

		internal static _003C_003Ec__DisplayClass18_0 vIqGSmcf3ms9YodUcwwR;

		internal bool zREv9lc1nsa(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return string.Equals(x.Description, bb8v9imRjl9.Description, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool W6BZJwcfEoltcZVvd749()
		{
			return vIqGSmcf3ms9YodUcwwR == null;
		}
	}

	private readonly DataService Hpoo2tRiKC;

	private readonly ITinyMessengerHub QeBouZA3QY;

	internal Button BtnNewMouseAction;

	internal TextBlock LblWarning;

	internal SearchBar TxtFilter;

	internal Button BtnCopyData;

	internal Button BtnPasteData;

	internal ListView LvActions;

	internal MenuItem MenuCopy;

	internal MenuItem MenuDelete;

	internal StackPanel PnlVersionTip;

	private bool mHhoNGhnU8;

	internal static MouseActionManagePage qjkwnACEePvP8UTdlhp;

	public MouseActionManagePage()
	{
		Hpoo2tRiKC = AppState.DataService;
		QeBouZA3QY = AppState.Y2RtaqSv0AQ();
		InitializeComponent();
		base.Loaded += NBJddpL6vg;
		LvActions.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
		PnlVersionTip.Visibility = (Visibility.Collapsed);
	}

	private void NBJddpL6vg(object sender, RoutedEventArgs e)
	{
		EabdoxgSuZ();
	}

	public override bool OnUnloading()
	{
		LvActions.ItemsSource = null;
		return base.OnUnloading();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	private void EabdoxgSuZ()
	{
		ICollectionView defaultView = CollectionViewSource.GetDefaultView(Hpoo2tRiKC.FnrtmLxNViE());
		defaultView.Filter = RdLovIW7Om;
		LvActions.ItemsSource = defaultView;
	}

	private void YFCdT4RFhs(object sender, RoutedEventArgs e)
	{
		MouseActionEditWindow mouseActionEditWindow = new MouseActionEditWindow(Hpoo2tRiKC, null)
		{
			Owner = base.ParentWindow
		};
		int num = 0;
		if (!jDL9i6CGA0uov141sLm())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (mouseActionEditWindow.ShowDialog() == true)
		{
			Hpoo2tRiKC.FnrtmLxNViE().Add(mouseActionEditWindow.Result);
			Save(true);
		}
	}

	private void IWZdMXuErC(object sender, RoutedEventArgs e)
	{
		Quicker.Domain.PowerMouse.MouseAction mouseAction_ = (sender as Button).Tag as Quicker.Domain.PowerMouse.MouseAction;
		dE8dADAh5l(mouseAction_);
	}

	private void dE8dADAh5l(Quicker.Domain.PowerMouse.MouseAction mouseAction_0)
	{
		MouseActionEditWindow mouseActionEditWindow = new MouseActionEditWindow(Hpoo2tRiKC, mouseAction_0)
		{
			Owner = base.ParentWindow
		};
		if (mouseActionEditWindow.ShowDialog() == true)
		{
			int num = Hpoo2tRiKC.FnrtmLxNViE().IndexOf(mouseAction_0);
			Hpoo2tRiKC.FnrtmLxNViE().Remove(mouseAction_0);
			if (num < 0)
			{
				Hpoo2tRiKC.FnrtmLxNViE().Add(mouseActionEditWindow.Result);
			}
			else
			{
				Hpoo2tRiKC.FnrtmLxNViE().Insert(num, mouseActionEditWindow.Result);
			}
			Save(true);
			int num2 = 0;
			if (!jDL9i6CGA0uov141sLm())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
	}

	private void Save(bool refesh = true)
	{
		if (refesh)
		{
			CollectionViewSource.GetDefaultView(Hpoo2tRiKC.FnrtmLxNViE()).Refresh();
		}
		Hpoo2tRiKC.mxCtX8S7NGg();
		QeBouZA3QY.NotifyCommonDataUpdated(this, "user_mouseActions");
	}

	private void EngdOiCtvG(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要删除这个鼠标操作么？"))
		{
			Quicker.Domain.PowerMouse.MouseAction item = (sender as Button).Tag as Quicker.Domain.PowerMouse.MouseAction;
			Hpoo2tRiKC.FnrtmLxNViE().Remove(item);
			Save(true);
		}
	}

	private void qLWdFTSQWE(object sender, MouseButtonEventArgs e)
	{
		if (((ListViewItem)sender).Content is Quicker.Domain.PowerMouse.MouseAction mouseAction_)
		{
			dE8dADAh5l(mouseAction_);
		}
	}

	private void McudUf0tcZ(object sender, RoutedEventArgs e)
	{
		Hpoo2tRiKC.FnrtmLxNViE().Add(new Quicker.Domain.PowerMouse.MouseAction
		{
			Description = "切换桌面←",
			MouseButton = null,
			MouseActionType = MouseActionType.WheelUp,
			Operation = MouseOperationType.QuickAction,
			ActionType = QuickActionType.Keystroke,
			Data = new Hotkey(VirtualKeyCode.LEFT, ModifierKeys.Control | ModifierKeys.Windows).ToData(),
			Location = MouseActionLocation.TaskBar
		});
		Hpoo2tRiKC.FnrtmLxNViE().Add(new Quicker.Domain.PowerMouse.MouseAction
		{
			Description = "切换桌面→",
			MouseButton = null,
			MouseActionType = MouseActionType.WheelDown,
			Operation = MouseOperationType.QuickAction,
			ActionType = QuickActionType.Keystroke,
			Data = new Hotkey(VirtualKeyCode.RIGHT, ModifierKeys.Control | ModifierKeys.Windows).ToData(),
			Location = MouseActionLocation.TaskBar
		});
		Save(true);
	}

	private void Ji5dl7Fq2k(object sender, RoutedEventArgs e)
	{
	}

	private void tngdirKUfx(object sender, RoutedEventArgs e)
	{
		afRd3G8RDf();
	}

	private void afRd3G8RDf()
	{
		if (LvActions.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要复制的条目。");
			return;
		}
		string text = JsonConvert.SerializeObject(LvActions.SelectedItems.Cast<Quicker.Domain.PowerMouse.MouseAction>());
		try
		{
			ClipboardHelper.SetText(text);
			AppHelper.ShowInformation("已复制。");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("复制出错，请重试。" + exception.GetMessageWithInner());
		}
	}

	private void xmvdfOnYWq(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			int num = 0;
			if (!jDL9i6CGA0uov141sLm())
			{
				goto IL_0067;
			}
			goto IL_006b;
			IL_0067:
			int num2 = default(int);
			num = num2;
			goto IL_006b;
			IL_006b:
			do
			{
				IL_006b_2:
				IList<Quicker.Domain.PowerMouse.MouseAction> list;
				switch (num)
				{
				default:
					if (!string.IsNullOrWhiteSpace(text))
					{
						text = text.Trim();
						if (text.StartsWith("["))
						{
							if (text.EndsWith("]"))
							{
								break;
							}
							num = 2;
							if (!jDL9i6CGA0uov141sLm())
							{
								goto IL_006b_2;
							}
						}
						goto case 2;
					}
					AppHelper.ShowWarning("剪贴板里没有文本数据。");
					return;
				case 1:
				{
					try
					{
						list = JsonConvert.DeserializeObject<IList<Quicker.Domain.PowerMouse.MouseAction>>(text);
					}
					catch (Exception exception)
					{
						AppHelper.ShowWarning("解析数据出错：" + exception.GetMessageWithInner());
						return;
					}
					if (list.Count == 0)
					{
						AppHelper.ShowWarning("数据长度为空！");
						return;
					}
					IList<string> list2 = new List<string>();
					using (IEnumerator<Quicker.Domain.PowerMouse.MouseAction> enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
							_003C_003Ec__DisplayClass18_.bb8v9imRjl9 = enumerator.Current;
							if (Hpoo2tRiKC.FnrtmLxNViE().Any(_003C_003Ec__DisplayClass18_.zREv9lc1nsa))
							{
								list2.Add(_003C_003Ec__DisplayClass18_.bb8v9imRjl9.Description);
							}
						}
					}
					if (list2.Count <= 0 || AppHelper.Confirm("这些条目（名称）在本地已存在，您确定要粘贴么？\r\n" + string.Join("\r\n", list2)))
					{
						Hpoo2tRiKC.FnrtmLxNViE().AddRange(list);
						Save(true);
						AppHelper.ShowSuccess($"已成功粘贴 {list.Count} 项。");
					}
					return;
				}
				case 2:
					AppHelper.ShowWarning("剪贴板内容格式不正确。");
					return;
				}
				list = null;
				num = 1;
			}
			while (jDL9i6CGA0uov141sLm());
			goto IL_0067;
		}
		catch (Exception exception2)
		{
			AppHelper.ShowWarning("粘贴出错：" + exception2.GetMessageWithInner());
		}
	}

	private void MYVdz3FeeV(object sender, RoutedEventArgs e)
	{
		AppHelper.ShowInformation("如果使用了右键长按方式弹出面板，请在弹出面板前滚动鼠标滚轮。");
		Save(true);
	}

	private void jP0owtUVEJ(object sender, RoutedEventArgs e)
	{
		Save(false);
	}

	private void hxDotqPVpu(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count > 0 && AppHelper.Confirm($"您确认要删除 {LvActions.SelectedItems.Count} 条规则么？\r\n删除后将无法恢复。"))
		{
			LvActions.SelectedItems.Cast<Quicker.Domain.PowerMouse.MouseAction>().ToList().ForEach(k5AoSxQyoW);
			Save(true);
		}
	}

	private void L82ogEpBYX(object sender, RoutedEventArgs e)
	{
		afRd3G8RDf();
	}

	private void Qb6oLPiPi0(object sender, FunctionEventArgs<string> e)
	{
		LvActions.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.IsDragSourceProperty, TxtFilter.Text.IsNullOrEmpty());
		CollectionViewSource.GetDefaultView(Hpoo2tRiKC.FnrtmLxNViE()).Refresh();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!mHhoNGhnU8)
		{
			mHhoNGhnU8 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/mouseactionmanagepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 1:
			BtnNewMouseAction = (Button)target;
			BtnNewMouseAction.Click += YFCdT4RFhs;
			break;
		case 2:
			LblWarning = (TextBlock)target;
			num = 0;
			if (!jDL9i6CGA0uov141sLm())
			{
				break;
			}
			goto IL_0133;
		case 3:
			TxtFilter = (SearchBar)target;
			TxtFilter.SearchStarted += Qb6oLPiPi0;
			break;
		case 4:
			BtnCopyData = (Button)target;
			BtnCopyData.Click += tngdirKUfx;
			break;
		case 5:
			BtnPasteData = (Button)target;
			BtnPasteData.Click += xmvdfOnYWq;
			break;
		case 6:
			LvActions = (ListView)target;
			break;
		case 7:
			MenuCopy = (MenuItem)target;
			MenuCopy.Click += L82ogEpBYX;
			num = 1;
			if (qjkwnACEePvP8UTdlhp != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0133;
		case 8:
			MenuDelete = (MenuItem)target;
			MenuDelete.Click += hxDotqPVpu;
			break;
		default:
			mHhoNGhnU8 = true;
			break;
		case 13:
			{
				PnlVersionTip = (StackPanel)target;
				break;
			}
			IL_0133:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 9:
			((CheckBox)target).Click += jP0owtUVEJ;
			break;
		case 10:
			((Button)target).Click += IWZdMXuErC;
			break;
		case 11:
			((Button)target).Click += EngdOiCtvG;
			break;
		case 12:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(qLWdFTSQWE);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	[CompilerGenerated]
	private bool RdLovIW7Om(object object_0)
	{
		if (string.IsNullOrWhiteSpace(TxtFilter.Text))
		{
			return true;
		}
		Quicker.Domain.PowerMouse.MouseAction obj = object_0 as Quicker.Domain.PowerMouse.MouseAction;
		if (obj == null)
		{
			return false;
		}
		return obj.Description?.IndexOf(TxtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0;
	}

	[CompilerGenerated]
	private void k5AoSxQyoW(Quicker.Domain.PowerMouse.MouseAction mouseAction_0)
	{
		if (Hpoo2tRiKC.FnrtmLxNViE().Contains(mouseAction_0))
		{
			Hpoo2tRiKC.FnrtmLxNViE().Remove(mouseAction_0);
		}
	}

	internal static bool jDL9i6CGA0uov141sLm()
	{
		return qjkwnACEePvP8UTdlhp == null;
	}
}
