using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Quicker.Common.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using sBtxL6X8ZmkfRQWgUC5;
using WindowsInput.Native;

namespace Quicker.View.LeftButton;

public class LeftButtonPlusListControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public VirtualKeyCode HOkSd9JCxsu;

		public LeftButtonPlusListControl zY9Sdhdk9sm;

		private static _003C_003Ec__DisplayClass13_0 EfkwQ6Ws2uXFLriFYNa5;

		internal bool sCXSdZqhyVN(PowerKeyActionItem x)
		{
			return x.SecondaryKey == (int?)HOkSd9JCxsu;
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}

		internal static bool PIeGDEWsAGwSdceGTklB()
		{
			return EfkwQ6Ws2uXFLriFYNa5 == null;
		}

		internal static void WGXcyoWseAdLy0fvZU5V()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_1
	{
		public PowerKeyActionItem v4sSdYQZmyI;

		public _003C_003Ec__DisplayClass13_0 h8iSdIu31lX;

		private static _003C_003Ec__DisplayClass13_1 phY11aWsjdDmJvPdA6uW;

		internal void FHdSde0CvLL()
		{
			h8iSdIu31lX.zY9Sdhdk9sm.LvActions.SelectedItem = v4sSdYQZmyI;
		}

		internal static bool OI7FKgWsDFak8uZUipNo()
		{
			return phY11aWsjdDmJvPdA6uW == null;
		}
	}

	private readonly SmartCollection<PowerKeyActionItem> sGjLRxcx5K1 = new SmartCollection<PowerKeyActionItem>();

	private ListCollectionView gAVLRrKJ3o8;

	private PowerKeyActionItem qjuLRpvu2Mb;

	[CompilerGenerated]
	private EventHandler m_DataChanged;

	internal Grid MainGrid;

	internal ListView LvActions;

	internal Button BtnDelete;

	internal HotkeyEditorControl KeyEditor;

	internal Button BtnAddKey;

	internal StackPanel PnlNoItemSelected;

	internal ScrollViewer PanelKeySettings;

	internal TextBlock LblKey;

	internal CheckBox ChkEnable;

	internal QuickActionEditor QuickActionEditor;

	internal QuickActionEditor QuickActionEditorForLongPress;

	internal TextBox TxtLongPressNotification;

	internal Button BtnSaveCurrentAction;

	internal Button BtnRestoreItemDefault;

	private bool wahLRBwJVNZ;

	private static LeftButtonPlusListControl DLamEpF1WQIEqCEu4ydJ;

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

	public LeftButtonPlusListControl()
	{
		InitializeComponent();
		gAVLRrKJ3o8 = new ListCollectionView(sGjLRxcx5K1);
		gAVLRrKJ3o8.SortDescriptions.Add(new SortDescription("SecondaryKey", ListSortDirection.Ascending));
		LvActions.ItemsSource = gAVLRrKJ3o8;
	}

	public void SetData(IList<PowerKeyActionItem> list)
	{
		if (list.HasData())
		{
			sGjLRxcx5K1.Reset(list);
		}
		else
		{
			sGjLRxcx5K1.Clear();
		}
		LvActions.SelectedItem = null;
		JkoLRGHP418();
	}

	public IList<PowerKeyActionItem> GetData()
	{
		return sGjLRxcx5K1.ToList();
	}

	private void RpPLRk3v0f7(object sender, SelectionChangedEventArgs e)
	{
		qflLRsewP0q();
		PowerKeyActionItem powerKeyActionItem = LvActions.SelectedItem as PowerKeyActionItem;
		qjuLRpvu2Mb = powerKeyActionItem;
		JkoLRGHP418();
	}

	private void JkoLRGHP418()
	{
		if (qjuLRpvu2Mb != null)
		{
			PanelKeySettings.Visibility = Visibility.Visible;
			LblKey.Text = KeyboardHelper.GetKeyName((VirtualKeyCode)qjuLRpvu2Mb.SecondaryKey.Value);
			ChkEnable.IsChecked = !qjuLRpvu2Mb.IsDisabled;
			QuickActionEditor.SetData(qjuLRpvu2Mb);
			QuickActionEditorForLongPress.SetData(qjuLRpvu2Mb.CreateLongPressTempItem());
			TxtLongPressNotification.Text = qjuLRpvu2Mb.LongPressNotification;
			PnlNoItemSelected.Visibility = Visibility.Collapsed;
			if (string.IsNullOrEmpty(qjuLRpvu2Mb.BindingProcessName) && GrZJHjXh9DrUnn7CH6P.eCntKe8gqVY().Any(xSnLRm7I9jH))
			{
				BtnRestoreItemDefault.Visibility = Visibility.Visible;
				if (DLamEpF1WQIEqCEu4ydJ != null)
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				BtnRestoreItemDefault.Visibility = Visibility.Collapsed;
			}
		}
		else
		{
			PanelKeySettings.Visibility = Visibility.Hidden;
			PnlNoItemSelected.Visibility = Visibility.Visible;
		}
	}

	private void qflLRsewP0q()
	{
		int num = 1;
		while (qjuLRpvu2Mb != null)
		{
			int num2 = 0;
			if (!uxkO0DF1yghEgOllYwnD())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			QuickActionEditor.SaveData(qjuLRpvu2Mb);
			TempQuickActionItem tempQuickActionItem = new TempQuickActionItem();
			QuickActionEditorForLongPress.SaveData(tempQuickActionItem);
			qjuLRpvu2Mb.LongPressActionType = tempQuickActionItem.ActionType;
			qjuLRpvu2Mb.LongPressData = tempQuickActionItem.Data;
			qjuLRpvu2Mb.LongPressNotification = TxtLongPressNotification.Text;
			qjuLRpvu2Mb.IsDisabled = ChkEnable.IsChecked == false;
			gAVLRrKJ3o8.Refresh();
			cRTLR6RgHjS();
			return;
		}
	}

	private void U3qLRHMxn6x(object sender, RoutedEventArgs e)
	{
		qflLRsewP0q();
		LvActions.SelectedItem = null;
	}

	private void utKLR1UhiYp(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.zY9Sdhdk9sm = this;
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("请输入要添加的键。");
			return;
		}
		_003C_003Ec__DisplayClass13_.HOkSd9JCxsu = KeyEditor.Hotkey.Key;
		if (_003C_003Ec__DisplayClass13_.HOkSd9JCxsu == VirtualKeyCode.LBUTTON)
		{
			KeyEditor.Hotkey = null;
			AppHelper.ShowWarning("不支持此键。");
		}
		else if (sGjLRxcx5K1.Any(_003C_003Ec__DisplayClass13_.sCXSdZqhyVN))
		{
			KeyEditor.Hotkey = null;
			int num = 0;
			if (DLamEpF1WQIEqCEu4ydJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.ShowWarning("已经添加了此键，不能再次添加。", true);
		}
		else
		{
			_003C_003Ec__DisplayClass13_1 _003C_003Ec__DisplayClass13_2 = new _003C_003Ec__DisplayClass13_1();
			_003C_003Ec__DisplayClass13_2.h8iSdIu31lX = _003C_003Ec__DisplayClass13_;
			_003C_003Ec__DisplayClass13_2.v4sSdYQZmyI = new PowerKeyActionItem
			{
				SecondaryKey = (int)_003C_003Ec__DisplayClass13_2.h8iSdIu31lX.HOkSd9JCxsu
			};
			sGjLRxcx5K1.Add(_003C_003Ec__DisplayClass13_2.v4sSdYQZmyI);
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass13_2.FHdSde0CvLL);
			cRTLR6RgHjS();
		}
	}

	private void s3WLRbTyKXW(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItem != null && AppHelper.Confirm("您确认要删除此项么？"))
		{
			sGjLRxcx5K1.Remove(LvActions.SelectedItem as PowerKeyActionItem);
			LvActions.SelectedItem = null;
			cRTLR6RgHjS();
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除按键。");
		}
	}

	private void cRTLR6RgHjS()
	{
		this.m_DataChanged?.Invoke(this, EventArgs.Empty);
	}

	private void mrlLRXAODab(object sender, RoutedEventArgs e)
	{
		if (qjuLRpvu2Mb != null)
		{
			PowerKeyActionItem powerKeyActionItem = GrZJHjXh9DrUnn7CH6P.eCntKe8gqVY().FirstOrDefault(l5xLRKyst2b);
			if (powerKeyActionItem != null)
			{
				qjuLRpvu2Mb.ActionType = powerKeyActionItem.ActionType;
				qjuLRpvu2Mb.Title = powerKeyActionItem.Title;
				qjuLRpvu2Mb.Data = powerKeyActionItem.Data;
				JkoLRGHP418();
				cRTLR6RgHjS();
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!wahLRBwJVNZ)
		{
			wahLRBwJVNZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/leftbutton/leftbuttonpluslistcontrol.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			wahLRBwJVNZ = true;
			return;
		case 1:
			MainGrid = (Grid)target;
			return;
		case 2:
			LvActions = (ListView)target;
			LvActions.SelectionChanged += RpPLRk3v0f7;
			return;
		case 3:
			BtnDelete = (Button)target;
			BtnDelete.Click += s3WLRbTyKXW;
			return;
		case 4:
			KeyEditor = (HotkeyEditorControl)target;
			return;
		case 5:
			BtnAddKey = (Button)target;
			BtnAddKey.Click += utKLR1UhiYp;
			return;
		case 6:
			PnlNoItemSelected = (StackPanel)target;
			num = 0;
			if (uxkO0DF1yghEgOllYwnD())
			{
				return;
			}
			break;
		case 7:
			PanelKeySettings = (ScrollViewer)target;
			return;
		case 8:
			LblKey = (TextBlock)target;
			return;
		case 9:
			ChkEnable = (CheckBox)target;
			return;
		case 10:
			QuickActionEditor = (QuickActionEditor)target;
			return;
		case 11:
			QuickActionEditorForLongPress = (QuickActionEditor)target;
			return;
		case 12:
			TxtLongPressNotification = (TextBox)target;
			return;
		case 13:
			BtnSaveCurrentAction = (Button)target;
			BtnSaveCurrentAction.Click += U3qLRHMxn6x;
			return;
		case 14:
			BtnRestoreItemDefault = (Button)target;
			BtnRestoreItemDefault.Click += mrlLRXAODab;
			num = 0;
			if (uxkO0DF1yghEgOllYwnD())
			{
				return;
			}
			break;
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	[CompilerGenerated]
	private bool xSnLRm7I9jH(PowerKeyActionItem powerKeyActionItem_1)
	{
		return powerKeyActionItem_1.SecondaryKey == qjuLRpvu2Mb.SecondaryKey;
	}

	[CompilerGenerated]
	private bool l5xLRKyst2b(PowerKeyActionItem powerKeyActionItem_1)
	{
		return powerKeyActionItem_1.SecondaryKey == qjuLRpvu2Mb.SecondaryKey;
	}

	internal static bool uxkO0DF1yghEgOllYwnD()
	{
		return DLamEpF1WQIEqCEu4ydJ == null;
	}
}
