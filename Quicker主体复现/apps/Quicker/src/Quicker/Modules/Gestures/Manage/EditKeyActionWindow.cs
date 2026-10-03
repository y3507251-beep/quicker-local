using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Modules.Gestures.Manage;

public class EditKeyActionWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public EditKeyActionWindow X3QvWQrl1IP;

		public int IUkvWjfP6eD;

		private static _003C_003Ec__DisplayClass9_0 yVdSiZc5fGxLcEW8V9pM;

		internal bool g8IvWB0Vnvl(KeyActionItem x)
		{
			if (x != X3QvWQrl1IP.lBAtLck1NV4 && x.Key == IUkvWjfP6eD)
			{
				return ProcessHelper.IsBindingSameProcess(x.BindingProcessName, X3QvWQrl1IP.TxtWhiteList.Text);
			}
			return false;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}

		internal static void lNGNPxc5i0rCFToSy5g5()
		{
		}

		internal static bool ox93qQc5befZ4MeD0E11()
		{
			return yVdSiZc5fGxLcEW8V9pM == null;
		}

		internal static void rb0XWqc5l6RXW0nd4wjP()
		{
		}
	}

	private readonly IList<KeyActionItem> bfftLq0hItq;

	private readonly KeyActionItem lBAtLck1NV4;

	[CompilerGenerated]
	private KeyActionItem rHJtLV2tqBc;

	[CompilerGenerated]
	private bool? i8mtLZILVph;

	internal HotkeyEditorControl KeyEditor;

	internal TextBox TxtDescription;

	internal TextBlock LblWhiteList;

	internal StackPanel PnlWhiteList;

	internal TextBox TxtWhiteList;

	internal WindowSelector WhiteListWindowSelector;

	internal TextBlock LblBlackList;

	internal StackPanel PnlBlackList;

	internal TextBox TxtBlackList;

	internal WindowSelector BlackListWindowSelector;

	internal QuickActionEditor QuickActionEditor;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool D5otL9JxKgX;

	internal static EditKeyActionWindow V1BB5hQWSTHbQEhlDTb2;

	public KeyActionItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return rHJtLV2tqBc;
		}
		[CompilerGenerated]
		set
		{
			rHJtLV2tqBc = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return i8mtLZILVph;
		}
		[CompilerGenerated]
		set
		{
			i8mtLZILVph = value;
		}
	}

	public EditKeyActionWindow(IList<KeyActionItem> currentSubActions, KeyActionItem editingSubActionItem)
	{
		bfftLq0hItq = currentSubActions;
		lBAtLck1NV4 = editingSubActionItem;
		InitializeComponent();
		base.Loaded += Qn4tL83akgQ;
	}

	private void Qn4tL83akgQ(object sender, RoutedEventArgs e)
	{
		if (lBAtLck1NV4 != null)
		{
			KeyEditor.SetSingleKey(lBAtLck1NV4.Key);
			TxtDescription.Text = lBAtLck1NV4.Description;
			TxtWhiteList.Text = lBAtLck1NV4.BindingProcessName;
			TxtBlackList.Text = lBAtLck1NV4.BlackList;
			QuickActionEditor.SetData(lBAtLck1NV4.DoubleClickAction);
		}
		else
		{
			KeyEditor.BeginInput();
		}
	}

	private void if3tLajR5CM(object sender, RoutedEventArgs e)
	{
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("请输入按键。");
			KeyEditor.BeginInput();
			return;
		}
		int key = (int)KeyEditor.Hotkey.Key;
		if (key >= 256 || key.IsEither(1, 2, 4, 5, 6, 17, 18, 16))
		{
			AppHelper.ShowWarning("不支持此按键值。");
			return;
		}
		if (!BSxtL7TdqKQ())
		{
			KeyEditor.Focus();
			AppHelper.ShowWarning("当前键 " + KeyboardHelper.GetKeyName((VirtualKeyCode)key) + " 已对相同进程设置过类似规则，请检查。");
			return;
		}
		(bool, string) tuple = QuickActionEditor.IsDataValid();
		if (!tuple.Item1)
		{
			AppHelper.ShowWarning(tuple.Item2, true);
			return;
		}
		ResultItem = new KeyActionItem
		{
			Key = key,
			Description = TxtDescription.Text,
			BindingProcessName = TxtWhiteList.Text?.Trim(),
			BlackList = TxtBlackList.Text?.Trim(),
			DoubleClickAction = new TempQuickActionItem()
		};
		QuickActionEditor.SaveData(ResultItem.DoubleClickAction);
		this.ThNvuM5Q9GQ(true);
		int num = 0;
		if (V1BB5hQWSTHbQEhlDTb2 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private bool BSxtL7TdqKQ()
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.X3QvWQrl1IP = this;
		_003C_003Ec__DisplayClass9_.IUkvWjfP6eD = (int)KeyEditor.Hotkey.Key;
		return !bfftLq0hItq.Any(_003C_003Ec__DisplayClass9_.g8IvWB0Vnvl);
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		if (KeyEditor.Hotkey != null)
		{
			VirtualKeyCode key = KeyEditor.Hotkey.Key;
			if (!BSxtL7TdqKQ())
			{
				AppHelper.ShowWarning("当前按键已有类似规则，请注意避免重复。");
			}
		}
	}

	private void skstLRk2JqL(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void WhiteListWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtWhiteList, e.ProcessName, e.HWnd);
	}

	private void BlackListWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtBlackList, e.ProcessName, e.HWnd);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!D5otL9JxKgX)
		{
			D5otL9JxKgX = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/keyaction/editkeyactionwindow.xaml", UriKind.Relative);
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
			D5otL9JxKgX = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			num = 0;
			if (!rWCcK9QWwJZEfWFdO3vl())
			{
				break;
			}
			goto IL_0094;
		case 2:
			TxtDescription = (TextBox)target;
			break;
		case 3:
			LblWhiteList = (TextBlock)target;
			break;
		case 4:
			PnlWhiteList = (StackPanel)target;
			num = 1;
			if (rWCcK9QWwJZEfWFdO3vl())
			{
				break;
			}
			goto IL_0094;
		case 5:
			TxtWhiteList = (TextBox)target;
			break;
		case 6:
			WhiteListWindowSelector = (WindowSelector)target;
			break;
		case 7:
			LblBlackList = (TextBlock)target;
			break;
		case 8:
			PnlBlackList = (StackPanel)target;
			break;
		case 9:
			TxtBlackList = (TextBox)target;
			break;
		case 10:
			BlackListWindowSelector = (WindowSelector)target;
			break;
		case 11:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 12:
			BtnSave = (Button)target;
			BtnSave.Click += if3tLajR5CM;
			break;
		case 13:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += skstLRk2JqL;
				break;
			}
			IL_0094:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool rWCcK9QWwJZEfWFdO3vl()
	{
		return V1BB5hQWSTHbQEhlDTb2 == null;
	}
}
