using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.KeyInput;
using WindowsInput.Native;

namespace Quicker.View.Hotkeys;

public class HotkeySelectWinodw : Window, IComponentConnector
{
	private readonly bool JwrLvCkut5v;

	internal StackPanel PnlControlKeys;

	internal CheckBox ChkKeyCtrl;

	internal CheckBox ChkKeyShift;

	internal CheckBox ChkKeyAlt;

	internal CheckBox ChkKeyWin;

	internal KeySelectorControl KeySelector;

	internal Button BtnSave;

	private bool Oy3LvP6Xbth;

	internal static HotkeySelectWinodw TATk6oFA4uB20c5JGZFJ;

	public bool Ctrl
	{
		get
		{
			return ChkKeyCtrl.IsChecked == true;
		}
		set
		{
			ChkKeyCtrl.IsChecked = value;
		}
	}

	public bool Shift
	{
		get
		{
			return ChkKeyShift.IsChecked == true;
		}
		set
		{
			ChkKeyShift.IsChecked = value;
		}
	}

	public bool Alt
	{
		get
		{
			return ChkKeyAlt.IsChecked == true;
		}
		set
		{
			ChkKeyAlt.IsChecked = value;
		}
	}

	public bool Win
	{
		get
		{
			return ChkKeyWin.IsChecked == true;
		}
		set
		{
			ChkKeyWin.IsChecked = value;
		}
	}

	public VirtualKeyCode? Key
	{
		get
		{
			return KeySelector.SelectedKeyCode;
		}
		set
		{
			KeySelector.SelectedKeyCode = value;
		}
	}

	public HotkeySelectWinodw(bool hideControlKeys = false)
	{
		JwrLvCkut5v = hideControlKeys;
		InitializeComponent();
		base.Loaded += G2ELvJMTcJl;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void G2ELvJMTcJl(object sender, RoutedEventArgs e)
	{
		if (JwrLvCkut5v)
		{
			PnlControlKeys.Visibility = Visibility.Collapsed;
		}
	}

	private void VpJLv0w9OOd(object sender, RoutedEventArgs e)
	{
		if (!KeySelector.SelectedKeyCode.HasValue)
		{
			AppHelper.ShowWarning("请选择按键");
		}
		else
		{
			base.DialogResult = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Oy3LvP6Xbth)
		{
			Oy3LvP6Xbth = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/hotkeys/hotkeyselectwinodw.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Oy3LvP6Xbth = true;
			break;
		case 1:
		{
			PnlControlKeys = (StackPanel)target;
			int num = 0;
			if (!XpKTE8FAhpbcFq1fZP9B())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 2:
			ChkKeyCtrl = (CheckBox)target;
			break;
		case 3:
			ChkKeyShift = (CheckBox)target;
			break;
		case 4:
			ChkKeyAlt = (CheckBox)target;
			break;
		case 5:
			ChkKeyWin = (CheckBox)target;
			break;
		case 6:
			KeySelector = (KeySelectorControl)target;
			break;
		case 7:
			BtnSave = (Button)target;
			BtnSave.Click += VpJLv0w9OOd;
			break;
		}
	}

	internal static bool XpKTE8FAhpbcFq1fZP9B()
	{
		return TATk6oFA4uB20c5JGZFJ == null;
	}
}
