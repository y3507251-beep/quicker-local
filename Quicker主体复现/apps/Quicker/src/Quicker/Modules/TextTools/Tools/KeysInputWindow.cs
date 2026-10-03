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
using Quicker.Utilities.UI;
using Quicker.View.Hotkeys;

namespace Quicker.Modules.TextTools.Tools;

public class KeysInputWindow : Window, IComponentConnector
{
	private readonly KeysInputMode jOKtSFdIgNl;

	internal TextBlock TxtTip;

	internal HotkeyEditorControl KeyEditor;

	internal TextBlock LblWarning;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool wfXtSU9IWgf;

	internal static KeysInputWindow T7TjiWQXctwIBTIBwUdL;

	public Hotkey SelectedHotkey => KeyEditor.Hotkey;

	public KeysInputWindow(KeysInputMode mode)
	{
		jOKtSFdIgNl = mode;
		InitializeComponent();
		v7HtSDdvQ9E();
		base.Loaded += qeetSdd3Lx7;
	}

	private void v7HtSDdvQ9E()
	{
		if (jOKtSFdIgNl == KeysInputMode.SingleKey)
		{
			KeyEditor.SingleKeyMode = true;
			KeyEditor.ShowSingleKeySelector = true;
		}
		else
		{
			KeyEditor.SingleKeyMode = false;
			KeyEditor.ShowSingleKeySelector = false;
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

	private void qeetSdd3Lx7(object sender, RoutedEventArgs e)
	{
		AppHelper.RunOnUiThread(false, D9JtSOAU2ss);
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		RlftSobmOFC();
	}

	private void RlftSobmOFC()
	{
		BtnOk.IsEnabled = MgftSTxxdbR();
	}

	private bool MgftSTxxdbR()
	{
		Hotkey hotkey = KeyEditor.Hotkey;
		if (hotkey == null)
		{
			return false;
		}
		if (jOKtSFdIgNl == KeysInputMode.CombinedKey && hotkey.Modifiers.HasFlag(ModifierKeys.Windows))
		{
			LblWarning.Text = "不支持Win键";
			return false;
		}
		return true;
	}

	private void KoPtSMmtGnV(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void qJOtSAZC5yi(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!wfXtSU9IWgf)
		{
			wfXtSU9IWgf = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/texttools/tools/keyboard/keysinputwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			wfXtSU9IWgf = true;
			break;
		case 1:
			TxtTip = (TextBlock)target;
			break;
		case 2:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 3:
			LblWarning = (TextBlock)target;
			break;
		case 4:
			BtnOk = (Button)target;
			BtnOk.Click += qJOtSAZC5yi;
			break;
		case 5:
			BtnCancel = (Button)target;
			BtnCancel.Click += KoPtSMmtGnV;
			break;
		}
	}

	[CompilerGenerated]
	private void D9JtSOAU2ss()
	{
		Activate();
		KeyEditor.BeginInput();
		RlftSobmOFC();
	}

	internal static bool DqkrA9QXWRe2GitwqKm3()
	{
		return T7TjiWQXctwIBTIBwUdL == null;
	}
}
