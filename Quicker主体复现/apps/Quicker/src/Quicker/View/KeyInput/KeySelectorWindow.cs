using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class KeySelectorWindow : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private readonly IList<VirtualKeyCode> l0nLL8EVXAY;

	[CompilerGenerated]
	private readonly IList<VirtualKeyCode> WADLLae6y7V;

	[CompilerGenerated]
	private readonly ObservableCollection<KeyItem> vKiLL7nBeML = new ObservableCollection<KeyItem>();

	internal CheckBox ChkKeyCtrl;

	internal CheckBox ChkKeyShift;

	internal CheckBox ChkKeyAlt;

	internal CheckBox ChkKeyWin;

	internal ListBox LbNormalKeys;

	internal KeySelectorControl BtnNewNormalKey;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool Yo7LLRr0VVy;

	private static KeySelectorWindow MQ104hFADhcU2xTusgwF;

	public IList<VirtualKeyCode> Modifiers
	{
		[CompilerGenerated]
		get
		{
			return l0nLL8EVXAY;
		}
	}

	public IList<VirtualKeyCode> Keys
	{
		[CompilerGenerated]
		get
		{
			return WADLLae6y7V;
		}
	}

	public ObservableCollection<KeyItem> NormalKeyList
	{
		[CompilerGenerated]
		get
		{
			return vKiLL7nBeML;
		}
	}

	public KeySelectorWindow(IList<VirtualKeyCode> modifiers, IList<VirtualKeyCode> keys)
	{
		object obj;
		if (modifiers == null)
		{
			obj = null;
		}
		else
		{
			obj = modifiers.ToList();
			if (obj != null)
			{
				goto IL_0027;
			}
		}
		obj = new List<VirtualKeyCode>();
		goto IL_0027;
		IL_0042:
		object obj2;
		WADLLae6y7V = (IList<VirtualKeyCode>)obj2;
		InitializeComponent();
		LbNormalKeys.ItemsSource = NormalKeyList;
		base.Loaded += nSDLLCaP3hy;
		return;
		IL_0027:
		l0nLL8EVXAY = (IList<VirtualKeyCode>)obj;
		if (keys == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = keys.ToList();
			if (obj2 != null)
			{
				goto IL_0042;
			}
		}
		obj2 = new List<VirtualKeyCode>();
		goto IL_0042;
	}

	private void nSDLLCaP3hy(object sender, RoutedEventArgs e)
	{
		KDfLLP6F9FK();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void KDfLLP6F9FK()
	{
		ChkKeyCtrl.IsChecked = Modifiers.ContainsAny(VirtualKeyCode.CONTROL, VirtualKeyCode.LCONTROL, VirtualKeyCode.RCONTROL);
		ChkKeyShift.IsChecked = Modifiers.ContainsAny(VirtualKeyCode.SHIFT, VirtualKeyCode.LSHIFT, VirtualKeyCode.RSHIFT);
		ChkKeyAlt.IsChecked = Modifiers.ContainsAny(VirtualKeyCode.MENU, VirtualKeyCode.LMENU, VirtualKeyCode.RMENU);
		ChkKeyWin.IsChecked = Modifiers.ContainsAny(VirtualKeyCode.LWIN, VirtualKeyCode.RWIN);
		NormalKeyList.Clear();
		foreach (VirtualKeyCode key in Keys)
		{
			NormalKeyList.Add(new KeyItem
			{
				KeyCode = key
			});
		}
	}

	private void BtnNewNormalKey_OnSelectionChanged(object sender, EventArgs e)
	{
		if (BtnNewNormalKey.SelectedKeyCode.HasValue)
		{
			NormalKeyList.Add(new KeyItem
			{
				KeyCode = BtnNewNormalKey.SelectedKeyCode.Value
			});
			LbNormalKeys.Items.Refresh();
			BtnNewNormalKey.SelectedKeyCode = null;
		}
	}

	private void n2ZLLEBMFYs(object sender, RoutedEventArgs e)
	{
		KeyItem item = (sender as Button).Tag as KeyItem;
		NormalKeyList.Remove(item);
	}

	private void NormalKeyItem_OnSelectionChanged(object sender, EventArgs e)
	{
		((sender as KeySelectorControl).Tag as KeyItem).KeyCode = (sender as KeySelectorControl).SelectedKeyCode.Value;
	}

	private void VNlLLykeZcP(object sender, RoutedEventArgs e)
	{
		Modifiers.Clear();
		if (ChkKeyCtrl.IsChecked == true)
		{
			Modifiers.Add(VirtualKeyCode.CONTROL);
		}
		if (ChkKeyAlt.IsChecked == true)
		{
			Modifiers.Add(VirtualKeyCode.MENU);
		}
		int num;
		if (ChkKeyShift.IsChecked == true)
		{
			num = 0;
			if (MQ104hFADhcU2xTusgwF != null)
			{
				goto IL_0090;
			}
			goto IL_0094;
		}
		goto IL_00ae;
		IL_0090:
		int num2 = default(int);
		num = num2;
		goto IL_0094;
		IL_00ae:
		if (ChkKeyWin.IsChecked == true)
		{
			Modifiers.Add(VirtualKeyCode.LWIN);
			num = 1;
			if (!SvGtTQFA303crFoe78Sh())
			{
				goto IL_0090;
			}
			goto IL_0094;
		}
		goto IL_00c4;
		IL_00c4:
		Keys.Clear();
		foreach (KeyItem normalKey in NormalKeyList)
		{
			Keys.Add(normalKey.KeyCode);
		}
		base.DialogResult = true;
		return;
		IL_0094:
		switch (num)
		{
		case 1:
			goto IL_00c4;
		}
		Modifiers.Add(VirtualKeyCode.SHIFT);
		goto IL_00ae;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Yo7LLRr0VVy)
		{
			Yo7LLRr0VVy = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/keyinput/keyselectorwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			default:
				if (!SvGtTQFA303crFoe78Sh())
				{
					switch (0)
					{
					case 1:
						goto end_IL_0021;
					}
				}
				goto case 6;
			case 1:
				ChkKeyCtrl = (CheckBox)target;
				return;
			case 2:
				ChkKeyShift = (CheckBox)target;
				return;
			case 3:
				ChkKeyAlt = (CheckBox)target;
				return;
			case 4:
				ChkKeyWin = (CheckBox)target;
				return;
			case 5:
				LbNormalKeys = (ListBox)target;
				return;
			case 6:
				Yo7LLRr0VVy = true;
				return;
			case 7:
				BtnNewNormalKey = (KeySelectorControl)target;
				return;
			case 8:
				BtnSave = (Button)target;
				BtnSave.Click += VNlLLykeZcP;
				return;
			case 9:
				{
					BtnCancel = (Button)target;
					return;
				}
				end_IL_0021:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 6)
		{
			((Button)target).Click += n2ZLLEBMFYs;
		}
	}

	internal static bool SvGtTQFA303crFoe78Sh()
	{
		return MQ104hFADhcU2xTusgwF == null;
	}
}
