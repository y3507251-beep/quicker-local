using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.View.PowerKeys;

public class PowerKeyActionEditWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public PowerKeyActionItem mtuS4vynTpH;

		public PowerKeyActionEditWindow bkKS4SJkB8Q;

		private static _003C_003Ec__DisplayClass14_0 nEv4cqWthwEoRjvvS7Be;

		internal bool qXhS4LuFEIP(PowerKeyActionItem x)
		{
			if (x.SecondaryKey == mtuS4vynTpH.SecondaryKey && x.AdornKey == mtuS4vynTpH.AdornKey && ProcessHelper.IsBindingSameProcess(x.BindingProcessName, mtuS4vynTpH.BindingProcessName))
			{
				return x != bkKS4SJkB8Q.JTYLJA78R1w;
			}
			return false;
		}

		internal static bool GWtLQ9WtH5qbe2DRsx3C()
		{
			return nEv4cqWthwEoRjvvS7Be == null;
		}
	}

	private readonly PowerKeyActionItem JTYLJA78R1w;

	private readonly PowerKey XbXLJOYM4ry;

	private readonly DataService qfILJFdnOoq;

	private readonly string tv0LJUeU203;

	[CompilerGenerated]
	private PowerKeyActionItem W7nLJlxigwb;

	internal HotkeyEditorControl KeyEditor;

	internal CheckBox ChkIsEnabled;

	internal HotkeyEditorControl AdornKeyEditor;

	internal TextBox TxtTitle;

	internal TextBox TxtGroup;

	internal TextBox TxtBindingProcessName;

	internal QuickActionEditor QuickActionEditor;

	internal Button BtnSave;

	private bool cHPLJietqba;

	internal static PowerKeyActionEditWindow cxnKicFDHtBFb3cZZ2aL;

	public PowerKeyActionItem Result
	{
		[CompilerGenerated]
		get
		{
			return W7nLJlxigwb;
		}
		[CompilerGenerated]
		private set
		{
			W7nLJlxigwb = value;
		}
	}

	public PowerKeyActionEditWindow(PowerKeyActionItem editingItem, PowerKey powerKey, DataService dataService, string group)
	{
		JTYLJA78R1w = editingItem;
		XbXLJOYM4ry = powerKey;
		qfILJFdnOoq = dataService;
		tv0LJUeU203 = group;
		InitializeComponent();
		base.Loaded += ukILJocNE70;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	public void DisableAdornKey()
	{
		AdornKeyEditor.IsEnabled = false;
	}

	private void ukILJocNE70(object sender, RoutedEventArgs e)
	{
		ChkIsEnabled.IsChecked = true;
		if (JTYLJA78R1w != null)
		{
			QuickActionEditor.SetData(JTYLJA78R1w);
			KeyEditor.Hotkey = ((!JTYLJA78R1w.SecondaryKey.HasValue) ? null : new Hotkey((VirtualKeyCode)JTYLJA78R1w.SecondaryKey.Value, ModifierKeys.None));
			AdornKeyEditor.Hotkey = ((!JTYLJA78R1w.AdornKey.HasValue) ? null : new Hotkey((VirtualKeyCode)JTYLJA78R1w.AdornKey.Value, ModifierKeys.None));
			TxtTitle.Text = JTYLJA78R1w.Title;
			TxtBindingProcessName.Text = JTYLJA78R1w.BindingProcessName;
			if (cxnKicFDHtBFb3cZZ2aL == null)
			{
				switch (0)
				{
				}
			}
			ChkIsEnabled.IsChecked = !JTYLJA78R1w.IsDisabled;
			TxtGroup.Text = JTYLJA78R1w.Group;
		}
		else
		{
			TxtGroup.Text = tv0LJUeU203;
		}
		if (XbXLJOYM4ry.Key <= 6)
		{
			DisableAdornKey();
		}
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		if (KeyEditor.Hotkey != null)
		{
			if (KeyEditor.Hotkey.Modifiers != ModifierKeys.None)
			{
				AppHelper.ShowWarning("此处只能输入单个按键.", true);
				KeyEditor.Hotkey = null;
			}
			else if (KeyEditor.Hotkey.Key.IsAny(VirtualKeyCode.LBUTTON, VirtualKeyCode.MBUTTON, VirtualKeyCode.RBUTTON, VirtualKeyCode.XBUTTON1, VirtualKeyCode.XBUTTON2))
			{
				AppHelper.ShowWarning("不支持鼠标键.", true);
				KeyEditor.Hotkey = null;
			}
		}
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		if (!string.IsNullOrEmpty(TxtBindingProcessName.Text))
		{
			TxtBindingProcessName.Text = TxtBindingProcessName.Text.TrimEnd() + ";" + e.ProcessName.ToLower();
		}
		else
		{
			TxtBindingProcessName.Text = e.ProcessName;
		}
	}

	private void gZMLJThcQC9(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.bkKS4SJkB8Q = this;
		if (KeyEditor.Hotkey != null && KeyEditor.Hotkey.Key == (VirtualKeyCode)XbXLJOYM4ry.Key)
		{
			int num = 0;
			if (cxnKicFDHtBFb3cZZ2aL != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.ShowWarning("不能使用和引导键相同的按键，将无法触发。");
			return;
		}
		_003C_003Ec__DisplayClass14_.mtuS4vynTpH = new PowerKeyActionItem
		{
			SecondaryKey = ((KeyEditor.Hotkey == null) ? ((int?)null) : new int?((int)KeyEditor.Hotkey.Key)),
			AdornKey = ((AdornKeyEditor.Hotkey != null) ? new int?((int)AdornKeyEditor.Hotkey.Key) : ((int?)null)),
			BindingProcessName = TxtBindingProcessName.Text?.Trim(),
			Title = TxtTitle.Text,
			IsDisabled = (ChkIsEnabled.IsChecked == false),
			Group = TxtGroup.Text
		};
		if (!XbXLJOYM4ry.KeyActions.Any(_003C_003Ec__DisplayClass14_.qXhS4LuFEIP) || MessageBoxHelper.Show(Window.GetWindow(this), "已存在相同键值和绑定进程的设置，是否继续保存？", "冲突提示", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation, MessageBoxResult.Cancel) != MessageBoxResult.Cancel)
		{
			(bool, string) tuple = QuickActionEditor.IsDataValid();
			if (!tuple.Item1)
			{
				AppHelper.ShowWarning(tuple.Item2);
				return;
			}
			QuickActionEditor.SaveData(_003C_003Ec__DisplayClass14_.mtuS4vynTpH);
			Result = _003C_003Ec__DisplayClass14_.mtuS4vynTpH;
			base.DialogResult = true;
		}
	}

	public PowerKeyActionItem GetResult()
	{
		return new PowerKeyActionItem
		{
			SecondaryKey = (int?)KeyEditor.Hotkey?.Key,
			BindingProcessName = TxtBindingProcessName.Text.Trim()
		};
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!cHPLJietqba)
		{
			cHPLJietqba = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/powerkeys/powerkeyactioneditwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			cHPLJietqba = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			ChkIsEnabled = (CheckBox)target;
			break;
		case 3:
			AdornKeyEditor = (HotkeyEditorControl)target;
			break;
		case 4:
			TxtTitle = (TextBox)target;
			break;
		case 5:
			TxtGroup = (TextBox)target;
			if (cxnKicFDHtBFb3cZZ2aL == null)
			{
				switch (0)
				{
				}
			}
			break;
		case 6:
			TxtBindingProcessName = (TextBox)target;
			break;
		case 7:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 8:
			BtnSave = (Button)target;
			BtnSave.Click += gZMLJThcQC9;
			break;
		}
	}

	internal static bool xP50KEFDzRPfBNcMI1qM()
	{
		return cxnKicFDHtBFb3cZZ2aL == null;
	}
}
