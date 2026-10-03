using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Common.QuickActions;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using sBtxL6X8ZmkfRQWgUC5;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Triggers.Editors;

public class LeftButtonPlusEditWindow : Window, IComponentConnector, IMockModalWindow
{
	public readonly PowerKeyActionItem ResultItem;

	[CompilerGenerated]
	private bool? GO5o3hun8K;

	internal ScrollViewer PanelKeySettings;

	internal TextBlock LblKey;

	internal CheckBox ChkEnable;

	internal TextBlock LblDownTrigger;

	internal QuickActionEditor QuickActionEditor;

	internal TextBlock LongPressCtrl1;

	internal QuickActionEditor QuickActionEditorForLongPress;

	internal Button BtnSaveCurrentAction;

	internal Button BtnRestoreItemDefault;

	internal Button BtnClose;

	private bool wbKofSv6Jo;

	internal static LeftButtonPlusEditWindow NeHiSv7cfNV9T4tyy74;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return GO5o3hun8K;
		}
		[CompilerGenerated]
		set
		{
			GO5o3hun8K = value;
		}
	}

	public LeftButtonPlusEditWindow(PowerKeyActionItem currentSelectedItem)
	{
		ResultItem = AppHelper.Clone(currentSelectedItem);
		InitializeComponent();
		base.Loaded += SoBoT5SbnV;
	}

	private void SoBoT5SbnV(object sender, RoutedEventArgs e)
	{
		LZyoM02mAg();
		if (!ResultItem.SecondaryKey.HasValue)
		{
			return;
		}
		int? secondaryKey = ResultItem.SecondaryKey;
		int num = 0;
		if (NeHiSv7cfNV9T4tyy74 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (secondaryKey.Value == 1)
		{
			LongPressCtrl1.Visibility = Visibility.Collapsed;
			QuickActionEditorForLongPress.Visibility = Visibility.Collapsed;
			QuickActionEditor.UpdateOperationList(new QuickActionType[3]
			{
				QuickActionType.None,
				QuickActionType.QuickerOperation,
				QuickActionType.QuickerAction
			});
			QuickActionEditor.UpdateQuickOperationItems("operation_copy", "operation_paste", "operation_copy_or_paste", "operation_copy_or_paste_no_hint", "operation_copy_and_show_contextmenu", "quicker_show_main_win");
			LblDownTrigger.Text = "长按左键触发的操作";
		}
	}

	private void LZyoM02mAg()
	{
		if (ResultItem != null)
		{
			PanelKeySettings.Visibility = Visibility.Visible;
			LblKey.Text = KeyboardHelper.GetKeyName((VirtualKeyCode)ResultItem.SecondaryKey.Value);
			ChkEnable.IsChecked = !ResultItem.IsDisabled;
			QuickActionEditor.SetData(ResultItem);
			QuickActionEditorForLongPress.SetData(ResultItem.CreateLongPressTempItem());
			if (string.IsNullOrEmpty(ResultItem.BindingProcessName) && GrZJHjXh9DrUnn7CH6P.eCntKe8gqVY().Any(uxvolyZhpn))
			{
				BtnRestoreItemDefault.Visibility = Visibility.Visible;
				if (NeHiSv7cfNV9T4tyy74 != null)
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
		}
	}

	private void GcroAnEF7x(object sender, RoutedEventArgs e)
	{
		if (ResultItem == null)
		{
			return;
		}
		PowerKeyActionItem powerKeyActionItem = GrZJHjXh9DrUnn7CH6P.eCntKe8gqVY().FirstOrDefault(mnKoi2nAfq);
		if (powerKeyActionItem == null)
		{
			return;
		}
		ResultItem.ActionType = powerKeyActionItem.ActionType;
		if (!XiCJ217WPkduI8q2oii())
		{
			switch (0)
			{
			}
		}
		ResultItem.Title = powerKeyActionItem.Title;
		ResultItem.Data = powerKeyActionItem.Data;
		ResultItem.LongPressActionType = powerKeyActionItem.LongPressActionType;
		ResultItem.LongPressData = powerKeyActionItem.LongPressData;
		ResultItem.LongPressNotification = powerKeyActionItem.LongPressNotification;
		LZyoM02mAg();
	}

	private void EmroO3eQDu()
	{
		if (ResultItem != null)
		{
			QuickActionEditor.SaveData(ResultItem);
			TempQuickActionItem tempQuickActionItem = new TempQuickActionItem();
			QuickActionEditorForLongPress.SaveData(tempQuickActionItem);
			ResultItem.LongPressActionType = tempQuickActionItem.ActionType;
			ResultItem.LongPressData = tempQuickActionItem.Data;
			ResultItem.LongPressNotification = tempQuickActionItem.Message;
			ResultItem.IsDisabled = ChkEnable.IsChecked == false;
		}
	}

	private void RJxoFr85DA(object sender, RoutedEventArgs e)
	{
		EmroO3eQDu();
		this.ThNvuM5Q9GQ(true);
	}

	private void E1WoUkL53B(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!wbKofSv6Jo)
		{
			wbKofSv6Jo = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/leftbuttonplus/leftbuttonpluseditwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			wbKofSv6Jo = true;
			break;
		case 1:
			PanelKeySettings = (ScrollViewer)target;
			break;
		case 2:
			LblKey = (TextBlock)target;
			break;
		case 3:
			ChkEnable = (CheckBox)target;
			break;
		case 4:
			LblDownTrigger = (TextBlock)target;
			break;
		case 5:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 6:
			LongPressCtrl1 = (TextBlock)target;
			break;
		case 7:
		{
			QuickActionEditorForLongPress = (QuickActionEditor)target;
			int num = 0;
			if (!XiCJ217WPkduI8q2oii())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 8:
			BtnSaveCurrentAction = (Button)target;
			BtnSaveCurrentAction.Click += RJxoFr85DA;
			break;
		case 9:
			BtnRestoreItemDefault = (Button)target;
			BtnRestoreItemDefault.Click += GcroAnEF7x;
			break;
		case 10:
			BtnClose = (Button)target;
			BtnClose.Click += E1WoUkL53B;
			break;
		}
	}

	[CompilerGenerated]
	private bool uxvolyZhpn(PowerKeyActionItem powerKeyActionItem_0)
	{
		return powerKeyActionItem_0.SecondaryKey == ResultItem.SecondaryKey;
	}

	[CompilerGenerated]
	private bool mnKoi2nAfq(PowerKeyActionItem powerKeyActionItem_0)
	{
		return powerKeyActionItem_0.SecondaryKey == ResultItem.SecondaryKey;
	}

	internal static bool XiCJ217WPkduI8q2oii()
	{
		return NeHiSv7cfNV9T4tyy74 == null;
	}
}
