using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using FontAwesome5.WPF;
using HMdjedXPwaug8yh9mEq;
using Quicker.Domain;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Hooks;
using Quicker.View.KeyInput;
using t8SGKhhgLWTgeqjGcrq;
using WindowsInput.Native;

namespace Quicker.View.Hotkeys;

public class HotkeyEditorControl : System.Windows.Controls.UserControl, IComponentConnector
{
	public static readonly DependencyProperty HotkeyProperty;

	[CompilerGenerated]
	private EventHandler<HotkeyDataEventArgs> m_HotkeyChanged;

	public static readonly DependencyProperty SingleKeyModeProperty;

	public static readonly DependencyProperty FilterControlKeysInSingleModeProperty;

	private readonly KeyboardHook Am4LvVcpWit = new KeyboardHook();

	private Hotkey XweLvZ9bI9P;

	internal HotkeyEditorControl UserControl;

	internal System.Windows.Controls.TextBox HotkeyTextBox;

	internal System.Windows.Controls.Button BtnClear;

	internal System.Windows.Controls.Button BtnSelect;

	internal KeySelectorControl SingleKeySelector;

	internal SvgAwesome AlertIcon;

	private bool dWDLv9MbOcL;

	internal static HotkeyEditorControl rsTeF9FnW6Ur90xXc4Ed;

	public bool SingleKeyMode
	{
		get
		{
			return (bool)GetValue(SingleKeyModeProperty);
		}
		set
		{
			SetValue(SingleKeyModeProperty, value);
			if (value)
			{
				ShowSingleKeySelector = true;
				SelectorVisibility = Visibility.Collapsed;
			}
		}
	}

	public bool EnableScrollEvent
	{
		get
		{
			return SingleKeySelector.EnableScrollEvents;
		}
		set
		{
			SingleKeySelector.EnableScrollEvents = value;
		}
	}

	public bool EnableAppAnyKey
	{
		get
		{
			return SingleKeySelector.EnableAppAnyKey;
		}
		set
		{
			SingleKeySelector.EnableAppAnyKey = value;
		}
	}

	public bool FilterControlKeysInSingleMode
	{
		get
		{
			return (bool)GetValue(FilterControlKeysInSingleModeProperty);
		}
		set
		{
			SetValue(FilterControlKeysInSingleModeProperty, value);
		}
	}

	public bool ShowWarning
	{
		get
		{
			return AlertIcon.Visibility == Visibility.Visible;
		}
		set
		{
			AlertIcon.Visibility = ((!value) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public double EditorWidth
	{
		get
		{
			return HotkeyTextBox.Width;
		}
		set
		{
			HotkeyTextBox.Width = value;
		}
	}

	public Hotkey Hotkey
	{
		get
		{
			return (Hotkey)GetValue(HotkeyProperty);
		}
		set
		{
			SetValue(HotkeyProperty, value);
			this.m_HotkeyChanged?.Invoke(this, new HotkeyDataEventArgs
			{
				Hotkey = value
			});
		}
	}

	public Visibility SelectorVisibility
	{
		get
		{
			return BtnSelect.Visibility;
		}
		set
		{
			BtnSelect.Visibility = value;
		}
	}

	public bool ShowSingleKeySelector
	{
		get
		{
			return SingleKeySelector.Visibility == Visibility.Visible;
		}
		set
		{
			SingleKeySelector.Visibility = ((!value) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public event EventHandler<HotkeyDataEventArgs> HotkeyChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<HotkeyDataEventArgs> eventHandler = this.m_HotkeyChanged;
			EventHandler<HotkeyDataEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<HotkeyDataEventArgs> value2 = (EventHandler<HotkeyDataEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_HotkeyChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<HotkeyDataEventArgs> eventHandler = this.m_HotkeyChanged;
			EventHandler<HotkeyDataEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<HotkeyDataEventArgs> value2 = (EventHandler<HotkeyDataEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_HotkeyChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public void SetSingleKey(int keyCode)
	{
		if (keyCode == 0)
		{
			Hotkey = null;
		}
		else
		{
			Hotkey = new Hotkey((VirtualKeyCode)keyCode, ModifierKeys.None);
		}
	}

	public int GetSingleKey()
	{
		if (Hotkey == null)
		{
			return 0;
		}
		return (int)(Hotkey?.Key).Value;
	}

	public void SetData(string data, bool updateState = false)
	{
		if (!string.IsNullOrEmpty(data))
		{
			Hotkey = new Hotkey(data);
		}
		else
		{
			Hotkey = null;
		}
		if (updateState)
		{
			UpdateValidState();
		}
	}

	public HotkeyEditorControl()
	{
		InitializeComponent();
		InputMethod.SetIsInputMethodEnabled(HotkeyTextBox, false);
		Am4LvVcpWit.KeyDown += zImLvai4yYA;
		Am4LvVcpWit.KeyUp += mGZLv8u6rtr;
	}

	private void mGZLv8u6rtr(object sender, System.Windows.Forms.KeyEventArgs e)
	{
		if (Hotkey == null)
		{
			Hotkey = new Hotkey((VirtualKeyCode)e.KeyCode, ModifierKeys.None);
		}
	}

	private void zImLvai4yYA(object sender, System.Windows.Forms.KeyEventArgs e)
	{
		int num = 2;
		VirtualKeyCode keyValue = default(VirtualKeyCode);
		ModifierKeys modifierKeys = default(ModifierKeys);
		while (true)
		{
			HookKeyEventArgs e2 = e as HookKeyEventArgs;
			int num2 = 1;
			if (rsTeF9FnW6Ur90xXc4Ed != null)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!Am4LvVcpWit.IsKeyDown((VirtualKeyCode)e2.KeyCode) && Hotkey != null)
					{
						XweLvZ9bI9P = Hotkey;
						Hotkey = null;
					}
					if (!Enum.IsDefined(typeof(VirtualKeyCode), e.KeyValue))
					{
						return;
					}
					keyValue = (VirtualKeyCode)e.KeyValue;
					if (!SingleKeyMode)
					{
						if (keyValue.IsEither(VirtualKeyCode.LCONTROL, VirtualKeyCode.RCONTROL, VirtualKeyCode.LMENU, VirtualKeyCode.RMENU, VirtualKeyCode.LSHIFT, VirtualKeyCode.RSHIFT, VirtualKeyCode.LWIN, VirtualKeyCode.RWIN, VirtualKeyCode.APPS, VirtualKeyCode.CLEAR, VirtualKeyCode.OEM_CLEAR))
						{
							return;
						}
						modifierKeys = Keyboard.Modifiers;
						if (!Keyboard.IsKeyDown(Key.LWin))
						{
							if (!Keyboard.IsKeyDown(Key.RWin))
							{
								goto IL_011a;
							}
							num2 = 0;
							if (rsTeF9FnW6Ur90xXc4Ed == null)
							{
								continue;
							}
						}
						goto default;
					}
					if (FilterControlKeysInSingleMode && keyValue.IsEither(VirtualKeyCode.LCONTROL, VirtualKeyCode.RCONTROL, VirtualKeyCode.LMENU, VirtualKeyCode.RMENU, VirtualKeyCode.LSHIFT, VirtualKeyCode.RSHIFT, VirtualKeyCode.LWIN, VirtualKeyCode.RWIN, VirtualKeyCode.APPS, VirtualKeyCode.CLEAR, VirtualKeyCode.OEM_CLEAR))
					{
						return;
					}
					Hotkey = new Hotkey(keyValue, ModifierKeys.None);
					goto IL_0129;
				case 2:
					break;
				default:
					{
						modifierKeys |= ModifierKeys.Windows;
						goto IL_011a;
					}
					IL_0129:
					e.Handled = true;
					return;
					IL_011a:
					Hotkey = new Hotkey(keyValue, modifierKeys);
					goto IL_0129;
				}
				break;
			}
		}
	}

	public string GetKeyData()
	{
		if (Hotkey != null)
		{
			return Hotkey.ToData();
		}
		return "";
	}

	private void MJ1Lv7J0QQb(object sender, RoutedEventArgs e)
	{
		Am4LvVcpWit.Start();
	}

	private void LmOLvRUdsu5(object sender, RoutedEventArgs e)
	{
		Am4LvVcpWit.Stop();
	}

	public void BeginInput()
	{
		HotkeyTextBox.Focus();
	}

	public void SetFocus()
	{
		HotkeyTextBox.Focus();
	}

	private void QyPLvqPXCsA(object sender, RoutedEventArgs e)
	{
		HotkeySelectWinodw obj = new HotkeySelectWinodw(SingleKeyMode)
		{
			Owner = Window.GetWindow(this)
		};
		Hotkey hotkey = Hotkey;
		obj.Ctrl = hotkey != null && hotkey.Modifiers.HasFlag(ModifierKeys.Control);
		Hotkey hotkey2 = Hotkey;
		obj.Shift = hotkey2 != null && hotkey2.Modifiers.HasFlag(ModifierKeys.Shift);
		Hotkey hotkey3 = Hotkey;
		obj.Alt = hotkey3 != null && hotkey3.Modifiers.HasFlag(ModifierKeys.Alt);
		Hotkey hotkey4 = Hotkey;
		obj.Win = hotkey4 != null && hotkey4.Modifiers.HasFlag(ModifierKeys.Windows);
		obj.Key = Hotkey?.Key;
		HotkeySelectWinodw hotkeySelectWinodw = obj;
		if (hotkeySelectWinodw.ShowDialog() != true)
		{
			return;
		}
		ModifierKeys modifiers = (ModifierKeys)((hotkeySelectWinodw.Ctrl ? 2 : 0) | (hotkeySelectWinodw.Shift ? 4 : 0) | (hotkeySelectWinodw.Alt ? 1 : 0) | (hotkeySelectWinodw.Win ? 8 : 0));
		VirtualKeyCode? key = hotkeySelectWinodw.Key;
		if (yBS7iQFnyE8aObSC2jA1())
		{
			switch (0)
			{
			}
		}
		Hotkey hotkey5 = new Hotkey(key.Value, modifiers);
		Hotkey = hotkey5;
	}

	private void KeySelectorControl_OnSelectionChanged(object sender, EventArgs e)
	{
		if (SingleKeySelector.SelectedKeyCode.HasValue)
		{
			Hotkey = new Hotkey(SingleKeySelector.SelectedKeyCode.Value, ModifierKeys.None);
		}
		else
		{
			Hotkey = null;
		}
	}

	private void ulHLvcVlet0(object sender, RoutedEventArgs e)
	{
		Hotkey = null;
	}

	public void UpdateValidState()
	{
		string keyData = GetKeyData();
		if (string.IsNullOrEmpty(keyData))
		{
			ShowWarning = false;
			return;
		}
		brgW8EX9ZVfZExh7q9t brgW8EX9ZVfZExh7q9t = AppState.aXRtadMEfsj();
		if (brgW8EX9ZVfZExh7q9t != null)
		{
			bool? flag = brgW8EX9ZVfZExh7q9t.C2JtpKqOOT9()?.Contains(keyData);
			if (rsTeF9FnW6Ur90xXc4Ed == null)
			{
				switch (0)
				{
				}
			}
			if (flag == true)
			{
				ShowWarning = true;
				return;
			}
		}
		ShowWarning = false;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!dWDLv9MbOcL)
		{
			dWDLv9MbOcL = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/hotkeys/hotkeyeditorcontrol.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			dWDLv9MbOcL = true;
			break;
		case 1:
			UserControl = (HotkeyEditorControl)target;
			break;
		case 2:
			HotkeyTextBox = (System.Windows.Controls.TextBox)target;
			HotkeyTextBox.GotKeyboardFocus += MJ1Lv7J0QQb;
			HotkeyTextBox.LostKeyboardFocus += LmOLvRUdsu5;
			if (yBS7iQFnyE8aObSC2jA1())
			{
				switch (0)
				{
				}
			}
			break;
		case 3:
			BtnClear = (System.Windows.Controls.Button)target;
			BtnClear.Click += ulHLvcVlet0;
			break;
		case 4:
			BtnSelect = (System.Windows.Controls.Button)target;
			BtnSelect.Click += QyPLvqPXCsA;
			break;
		case 5:
			SingleKeySelector = (KeySelectorControl)target;
			break;
		case 6:
			AlertIcon = (SvgAwesome)target;
			break;
		}
	}

	static HotkeyEditorControl()
	{
		HotkeyProperty = DependencyProperty.Register("Hotkey", typeof(Hotkey), typeof(HotkeyEditorControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		SingleKeyModeProperty = DependencyProperty.Register("SingleKeyMode", typeof(bool), typeof(HotkeyEditorControl), new PropertyMetadata(false));
		FilterControlKeysInSingleModeProperty = DependencyProperty.Register("FilterControlKeysInSingleMode", typeof(bool), typeof(global::Quicker.View.Hotkeys.HotkeyEditorControl), new PropertyMetadata(false));
	}

	internal static bool yBS7iQFnyE8aObSC2jA1()
	{
		return rsTeF9FnW6Ur90xXc4Ed == null;
	}
}
