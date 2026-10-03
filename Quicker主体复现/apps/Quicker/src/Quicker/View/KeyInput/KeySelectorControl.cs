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
using System.Windows.Markup;
using Quicker.Utilities;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class KeySelectorControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private EventHandler m_SelectionChanged;

	public static readonly DependencyProperty SelectedKeyCodeProperty;

	public static readonly DependencyProperty FilteredKeysProperty;

	public static readonly DependencyProperty LabelProperty;

	[CompilerGenerated]
	private bool LQLLglHTNqj;

	[CompilerGenerated]
	private bool LO3Lgipnrml;

	internal Button KeyButton;

	internal TextBlock LblKeyName;

	private bool W63Lg3OF2r7;

	private static KeySelectorControl KKtVJfFAV6yhhDjQ8WbH;

	public bool HideLabel
	{
		get
		{
			return LblKeyName.Visibility == Visibility.Collapsed;
		}
		set
		{
			LblKeyName.Visibility = (value ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public IEnumerable<VirtualKeyCode> FilteredKeys
	{
		get
		{
			return (IEnumerable<VirtualKeyCode>)GetValue(FilteredKeysProperty);
		}
		set
		{
			SetValue(FilteredKeysProperty, value);
		}
	}

	public string Label
	{
		get
		{
			return (string)GetValue(LabelProperty);
		}
		set
		{
			SetValue(LabelProperty, value);
		}
	}

	public VirtualKeyCode? SelectedKeyCode
	{
		get
		{
			return (VirtualKeyCode?)GetValue(SelectedKeyCodeProperty);
		}
		set
		{
			SetValue(SelectedKeyCodeProperty, value);
		}
	}

	public bool EnableScrollEvents
	{
		[CompilerGenerated]
		get
		{
			return LQLLglHTNqj;
		}
		[CompilerGenerated]
		set
		{
			LQLLglHTNqj = value;
		}
	}

	public bool EnableAppAnyKey
	{
		[CompilerGenerated]
		get
		{
			return LO3Lgipnrml;
		}
		[CompilerGenerated]
		set
		{
			LO3Lgipnrml = value;
		}
	}

	public event EventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private static void JiILgMaP9eM(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is KeySelectorControl)
		{
			(dependencyObject_0 as KeySelectorControl).UpdateKeyName();
		}
	}

	public void UpdateKeyName()
	{
		VirtualKeyCode? selectedKeyCode = SelectedKeyCode;
		if (!selectedKeyCode.HasValue)
		{
			LblKeyName.Text = Label;
		}
		else
		{
			LblKeyName.Text = KeyboardHelper.GetKeyName(selectedKeyCode.Value);
		}
	}

	public KeySelectorControl()
	{
		InitializeComponent();
		UpdateKeyName();
	}

	private ContextMenu RxuLgAgGg9t()
	{
		ContextMenu contextMenu = new ContextMenu();
		RtrLgOIM9Vq(contextMenu, "数字", VirtualKeyCode.VK_0, VirtualKeyCode.VK_1, VirtualKeyCode.VK_2, VirtualKeyCode.VK_3, VirtualKeyCode.VK_4, VirtualKeyCode.VK_5, VirtualKeyCode.VK_6, VirtualKeyCode.VK_7, VirtualKeyCode.VK_8, VirtualKeyCode.VK_9);
		if (KKtVJfFAV6yhhDjQ8WbH != null)
		{
			switch (0)
			{
			}
		}
		RtrLgOIM9Vq(contextMenu, "字符", VirtualKeyCode.VK_A, VirtualKeyCode.VK_B, VirtualKeyCode.VK_C, VirtualKeyCode.VK_D, VirtualKeyCode.VK_E, VirtualKeyCode.VK_F, VirtualKeyCode.VK_G, VirtualKeyCode.VK_H, VirtualKeyCode.VK_I, VirtualKeyCode.VK_J, VirtualKeyCode.VK_K, VirtualKeyCode.VK_L, VirtualKeyCode.VK_M, VirtualKeyCode.VK_N, VirtualKeyCode.VK_O, VirtualKeyCode.VK_P, VirtualKeyCode.VK_Q, VirtualKeyCode.VK_R, VirtualKeyCode.VK_S, VirtualKeyCode.VK_T, VirtualKeyCode.VK_U, VirtualKeyCode.VK_V, VirtualKeyCode.VK_W, VirtualKeyCode.VK_X, VirtualKeyCode.VK_Y, VirtualKeyCode.VK_Z, VirtualKeyCode.OEM_1, VirtualKeyCode.OEM_PLUS, VirtualKeyCode.OEM_COMMA, VirtualKeyCode.OEM_MINUS, VirtualKeyCode.OEM_PERIOD, VirtualKeyCode.OEM_2, VirtualKeyCode.OEM_3, VirtualKeyCode.OEM_4, VirtualKeyCode.OEM_5, VirtualKeyCode.OEM_6, VirtualKeyCode.OEM_7, VirtualKeyCode.SPACE, VirtualKeyCode.TAB);
		RtrLgOIM9Vq(contextMenu, "方向", VirtualKeyCode.LEFT, VirtualKeyCode.RIGHT, VirtualKeyCode.UP, VirtualKeyCode.DOWN);
		RtrLgOIM9Vq(contextMenu, "功能键", VirtualKeyCode.CONTROL, VirtualKeyCode.LCONTROL, VirtualKeyCode.RCONTROL, VirtualKeyCode.SHIFT, VirtualKeyCode.LSHIFT, VirtualKeyCode.RSHIFT, VirtualKeyCode.MENU, VirtualKeyCode.LMENU, VirtualKeyCode.RMENU, VirtualKeyCode.LWIN, VirtualKeyCode.RWIN, VirtualKeyCode.RETURN, VirtualKeyCode.APPS, VirtualKeyCode.ESCAPE, VirtualKeyCode.BACK, VirtualKeyCode.INSERT, VirtualKeyCode.DELETE, VirtualKeyCode.HOME, VirtualKeyCode.END, VirtualKeyCode.PRIOR, VirtualKeyCode.NEXT, VirtualKeyCode.CAPITAL, VirtualKeyCode.NUMLOCK, VirtualKeyCode.SCROLL, VirtualKeyCode.PAUSE, VirtualKeyCode.SNAPSHOT);
		RtrLgOIM9Vq(contextMenu, "F键", VirtualKeyCode.F1, VirtualKeyCode.F2, VirtualKeyCode.F3, VirtualKeyCode.F4, VirtualKeyCode.F5, VirtualKeyCode.F6, VirtualKeyCode.F7, VirtualKeyCode.F8, VirtualKeyCode.F9, VirtualKeyCode.F10, VirtualKeyCode.F11, VirtualKeyCode.F12, VirtualKeyCode.F13, VirtualKeyCode.F14, VirtualKeyCode.F15, VirtualKeyCode.F16, VirtualKeyCode.F17, VirtualKeyCode.F18, VirtualKeyCode.F19, VirtualKeyCode.F20, VirtualKeyCode.F21, VirtualKeyCode.F22, VirtualKeyCode.F23, VirtualKeyCode.F24);
		RtrLgOIM9Vq(contextMenu, "数字键盘", VirtualKeyCode.NUMPAD0, VirtualKeyCode.NUMPAD1, VirtualKeyCode.NUMPAD2, VirtualKeyCode.NUMPAD3, VirtualKeyCode.NUMPAD4, VirtualKeyCode.NUMPAD5, VirtualKeyCode.NUMPAD6, VirtualKeyCode.NUMPAD7, VirtualKeyCode.NUMPAD8, VirtualKeyCode.NUMPAD9, VirtualKeyCode.ADD, VirtualKeyCode.SUBTRACT, VirtualKeyCode.MULTIPLY, VirtualKeyCode.DIVIDE, VirtualKeyCode.DECIMAL, VirtualKeyCode.SEPARATOR, VirtualKeyCode.NumpadEnter);
		RtrLgOIM9Vq(contextMenu, "媒体按键", VirtualKeyCode.VOLUME_MUTE, VirtualKeyCode.VOLUME_DOWN, VirtualKeyCode.VOLUME_UP, VirtualKeyCode.MEDIA_NEXT_TRACK, VirtualKeyCode.MEDIA_PREV_TRACK, VirtualKeyCode.MEDIA_STOP, VirtualKeyCode.MEDIA_PLAY_PAUSE);
		RtrLgOIM9Vq(contextMenu, "特殊按键", VirtualKeyCode.ACCEPT, VirtualKeyCode.ATTN, VirtualKeyCode.BROWSER_BACK, VirtualKeyCode.BROWSER_FAVORITES, VirtualKeyCode.BROWSER_FORWARD, VirtualKeyCode.BROWSER_HOME, VirtualKeyCode.BROWSER_REFRESH, VirtualKeyCode.BROWSER_SEARCH, VirtualKeyCode.BROWSER_STOP, VirtualKeyCode.CANCEL, VirtualKeyCode.CONVERT, VirtualKeyCode.CRSEL, VirtualKeyCode.EREOF, VirtualKeyCode.EXECUTE, VirtualKeyCode.EXSEL, VirtualKeyCode.HELP, VirtualKeyCode.LAUNCH_APP1, VirtualKeyCode.LAUNCH_APP2, VirtualKeyCode.LAUNCH_MAIL, VirtualKeyCode.LAUNCH_MEDIA_SELECT, VirtualKeyCode.NONAME, VirtualKeyCode.OEM_102, VirtualKeyCode.OEM_8, VirtualKeyCode.OEM_CLEAR, VirtualKeyCode.PA1, VirtualKeyCode.PACKET, VirtualKeyCode.PLAY, VirtualKeyCode.PRINT, VirtualKeyCode.PROCESSKEY, VirtualKeyCode.SELECT, VirtualKeyCode.SLEEP, VirtualKeyCode.ZOOM);
		RtrLgOIM9Vq(contextMenu, "鼠标键", VirtualKeyCode.LBUTTON, VirtualKeyCode.MBUTTON, VirtualKeyCode.RBUTTON, VirtualKeyCode.XBUTTON1, VirtualKeyCode.XBUTTON2);
		if (EnableScrollEvents)
		{
			RtrLgOIM9Vq(contextMenu, "滚轮事件", VirtualKeyCode.APP_SCROLL_UP, VirtualKeyCode.APP_SCROLL_DOWN, VirtualKeyCode.APP_SCROLL_LEFT, VirtualKeyCode.APP_SCROLL_RIGHT);
		}
		if (EnableAppAnyKey)
		{
			RtrLgOIM9Vq(contextMenu, "其它", VirtualKeyCode.APP_ANYKEY);
		}
		return contextMenu;
	}

	private void RtrLgOIM9Vq(ContextMenu contextMenu_0, string string_0, params VirtualKeyCode[] Keys)
	{
		MenuItem menuItem = new MenuItem();
		menuItem.Header = string_0;
		int num3 = default(int);
		foreach (VirtualKeyCode virtualKeyCode in Keys)
		{
			int num2 = 0;
			if (KKtVJfFAV6yhhDjQ8WbH != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (FilteredKeys == null || !FilteredKeys.Contains(virtualKeyCode))
			{
				MenuItem menuItem2 = new MenuItem();
				menuItem2.Header = KeyboardHelper.GetKeyName(virtualKeyCode);
				menuItem2.Tag = virtualKeyCode;
				menuItem2.Click += flTLgFK9HdS;
				menuItem.Items.Add(menuItem2);
			}
		}
		contextMenu_0.Items.Add(menuItem);
	}

	private void flTLgFK9HdS(object sender, RoutedEventArgs e)
	{
		MenuItem menuItem = sender as MenuItem;
		SelectedKeyCode = menuItem.Tag as VirtualKeyCode?;
		this.m_SelectionChanged?.Invoke(this, EventArgs.Empty);
	}

	private void qtRLgUAdpcK(object sender, RoutedEventArgs e)
	{
		if (KeyButton.ContextMenu == null)
		{
			KeyButton.ContextMenu = RxuLgAgGg9t();
		}
		KeyButton.ContextMenu.IsOpen = !KeyButton.ContextMenu.IsOpen;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!W63Lg3OF2r7)
		{
			W63Lg3OF2r7 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/keyinput/keyselectorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			W63Lg3OF2r7 = true;
			break;
		case 2:
			LblKeyName = (TextBlock)target;
			break;
		case 1:
			KeyButton = (Button)target;
			KeyButton.Click += qtRLgUAdpcK;
			break;
		}
	}

	static KeySelectorControl()
	{
		SelectedKeyCodeProperty = DependencyProperty.Register("SelectedKeyCode", typeof(VirtualKeyCode?), typeof(KeySelectorControl), new PropertyMetadata(null, JiILgMaP9eM));
		FilteredKeysProperty = DependencyProperty.Register("FilteredKeys", typeof(IEnumerable<VirtualKeyCode>), typeof(KeySelectorControl), new PropertyMetadata((object)null));
		LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(KeySelectorControl), new PropertyMetadata("选择..."));
	}

	internal static bool ewffscFAQIAsiysJIkdi()
	{
		return KKtVJfFAV6yhhDjQ8WbH == null;
	}
}
