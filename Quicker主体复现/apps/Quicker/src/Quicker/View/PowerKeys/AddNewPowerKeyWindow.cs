using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.View.PowerKeys;

public class AddNewPowerKeyWindow : Window, IComponentConnector
{
	internal HotkeyEditorControl KeyEditor;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool Jr3LJdxmlgT;

	private static AddNewPowerKeyWindow TZLMeYFDTM2Dgf8vBrLs;

	public Hotkey Hotkey
	{
		get
		{
			return KeyEditor.Hotkey;
		}
		set
		{
			KeyEditor.Hotkey = value;
		}
	}

	public AddNewPowerKeyWindow()
	{
		InitializeComponent();
		base.Loaded += rcBLJDojOYb;
	}

	private void FlALJ4wL3Tb(object sender, RoutedEventArgs e)
	{
		if (KeyEditor.Hotkey != null && KeyEditor.Hotkey.Modifiers == ModifierKeys.None)
		{
			if (KeyEditor.Hotkey.Key.IsEither(VirtualKeyCode.LBUTTON))
			{
				AppHelper.ShowWarning("不支持此键作为引导键。");
				int num = 0;
				if (TZLMeYFDTM2Dgf8vBrLs != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				return;
			}
			if (KeyEditor.Hotkey.Key == VirtualKeyCode.LCONTROL || KeyEditor.Hotkey.Key == VirtualKeyCode.LSHIFT || KeyEditor.Hotkey.Key == VirtualKeyCode.LMENU || KeyEditor.Hotkey.Key == VirtualKeyCode.LWIN)
			{
				if (!AppState.HHxtaMaoqJr().PowerKeys_AllowLeftSysKeys)
				{
					AppHelper.ShowWarning("使用控制键将使其失去原来的功能，请更换为其他按键。");
					KeyEditor.Hotkey = null;
					return;
				}
				if (!AppHelper.Confirm("使用控制键将使其失去原来的功能，您确认要使用它么？"))
				{
					KeyEditor.Hotkey = null;
					return;
				}
			}
			base.DialogResult = true;
		}
		else
		{
			AppHelper.ShowWarning("请输入单个按键。");
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void FuFLJ5SMRQx(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Jr3LJdxmlgT)
		{
			Jr3LJdxmlgT = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/powerkeys/addnewpowerkeywindow.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Jr3LJdxmlgT = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			BtnSave = (Button)target;
			BtnSave.Click += FlALJ4wL3Tb;
			break;
		case 3:
			BtnCancel = (Button)target;
			BtnCancel.Click += FuFLJ5SMRQx;
			break;
		}
	}

	[CompilerGenerated]
	private void rcBLJDojOYb(object sender, RoutedEventArgs e)
	{
		KeyEditor.BeginInput();
	}

	internal static bool dCExDHFDmncXJ8CV40uP()
	{
		return TZLMeYFDTM2Dgf8vBrLs == null;
	}
}
