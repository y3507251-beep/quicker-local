using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class KeyInputOrSelectControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private bool fIMLgDIg3RM;

	[CompilerGenerated]
	private IList<VirtualKeyCode> yNFLgd5wWZM = new List<VirtualKeyCode>();

	[CompilerGenerated]
	private IList<VirtualKeyCode> M4XLgo3q70c = new List<VirtualKeyCode>();

	internal StackPanel WrapperPanel;

	internal Label LblKeyName;

	internal HotkeyInputControl HotkeyInputControl;

	internal Button BtnSelect;

	private bool S40LgTiuyAq;

	private static KeyInputOrSelectControl fj3HWXF27YfUZicx03d6;

	public bool HorizontalLayout
	{
		[CompilerGenerated]
		get
		{
			return fIMLgDIg3RM;
		}
		[CompilerGenerated]
		set
		{
			fIMLgDIg3RM = value;
		}
	}

	public IList<VirtualKeyCode> CtrlKeys
	{
		[CompilerGenerated]
		get
		{
			return yNFLgd5wWZM;
		}
		[CompilerGenerated]
		set
		{
			yNFLgd5wWZM = value;
		}
	}

	public IList<VirtualKeyCode> NormalKeys
	{
		[CompilerGenerated]
		get
		{
			return M4XLgo3q70c;
		}
		[CompilerGenerated]
		private set
		{
			M4XLgo3q70c = value;
		}
	}

	public void SetData(IList<VirtualKeyCode> ctrlKeys, IList<VirtualKeyCode> normalKeys)
	{
		CtrlKeys = ctrlKeys;
		NormalKeys = normalKeys;
		NOyLgnCgI80();
	}

	public KeyInputOrSelectControl()
	{
		InitializeComponent();
		base.Loaded += M7dLgjrjJTn;
	}

	private void M7dLgjrjJTn(object sender, RoutedEventArgs e)
	{
		if (HorizontalLayout)
		{
			WrapperPanel.Orientation = Orientation.Horizontal;
			LblKeyName.Width = 200.0;
		}
	}

	private void HotkeyInputControl_OnKeySelected(object sender, EventArgs e)
	{
		CtrlKeys = (e as HotkeyInputControl.eui5DfuGF9WWP7Css2k).Modifiers;
		NormalKeys = (e as HotkeyInputControl.eui5DfuGF9WWP7Css2k).Keys;
		NOyLgnCgI80();
	}

	private void NOyLgnCgI80()
	{
		LblKeyName.Content = KeyboardHelper.GetKeysName(CtrlKeys, NormalKeys);
	}

	private void rjjLg4EwvfK(object sender, RoutedEventArgs e)
	{
		KeySelectorWindow keySelectorWindow = new KeySelectorWindow(CtrlKeys, NormalKeys);
		keySelectorWindow.Owner = Window.GetWindow(this);
		if (keySelectorWindow.ShowDialog() == true)
		{
			CtrlKeys = keySelectorWindow.Modifiers;
			NormalKeys = keySelectorWindow.Keys;
			NOyLgnCgI80();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!S40LgTiuyAq)
		{
			S40LgTiuyAq = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/keyinput/keyinputorselectcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			S40LgTiuyAq = true;
			break;
		case 1:
			WrapperPanel = (StackPanel)target;
			break;
		case 2:
			LblKeyName = (Label)target;
			break;
		case 3:
			HotkeyInputControl = (HotkeyInputControl)target;
			break;
		case 4:
			BtnSelect = (Button)target;
			BtnSelect.Click += rjjLg4EwvfK;
			break;
		}
	}

	internal static bool t8EVXlF24YVUjUf6XgOc()
	{
		return fj3HWXF27YfUZicx03d6 == null;
	}

	internal static void EYqyiuF2H6fcXOHoqQDH()
	{
	}
}
