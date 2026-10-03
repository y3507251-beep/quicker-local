using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Utilities.UI;

namespace Quicker.View.KeyInput;

public class KeyboardInputEditorWindow : System.Windows.Window, IComponentConnector
{
	[CompilerGenerated]
	private bool zeTLL2DG5Ay;

	[CompilerGenerated]
	private KeyInputItem jBSLLuygTCr;

	[CompilerGenerated]
	private KeyInputItem cDjLLNu3YTC;

	[CompilerGenerated]
	private IList<KeyInputItemType> IyALLJlNQql = new List<KeyInputItemType>
	{
		KeyInputItemType.MultiKey,
		KeyInputItemType.SingleKey,
		KeyInputItemType.Text,
		KeyInputItemType.Sleep
	};

	internal System.Windows.Controls.TabControl TheTab;

	internal KeyInputOrSelectControl KeyInputOrSelectControl;

	internal KeySelectorControl SingleKeySelector;

	internal System.Windows.Controls.TextBox TxtText;

	internal NumericUpDown TxtSleepMs;

	internal Button BtnSave;

	private bool boELL0iHUh9;

	private static KeyboardInputEditorWindow xSTtoeFAAy75qBVpOvRb;

	public bool OnlyKeys
	{
		[CompilerGenerated]
		get
		{
			return zeTLL2DG5Ay;
		}
		[CompilerGenerated]
		set
		{
			zeTLL2DG5Ay = value;
		}
	}

	public KeyInputItem EditingItem
	{
		[CompilerGenerated]
		get
		{
			return jBSLLuygTCr;
		}
		[CompilerGenerated]
		set
		{
			jBSLLuygTCr = value;
		}
	}

	public KeyInputItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return cDjLLNu3YTC;
		}
		[CompilerGenerated]
		set
		{
			cDjLLNu3YTC = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IList<KeyInputItemType> BZTLLLXgEIw()
	{
		return IyALLJlNQql;
	}

	[SpecialName]
	[CompilerGenerated]
	private void lo3LLvu4cGi(IList<KeyInputItemType> value)
	{
		IyALLJlNQql = value;
	}

	public KeyboardInputEditorWindow()
	{
		InitializeComponent();
		base.Loaded += evjLgze3Fpl;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void evjLgze3Fpl(object sender, RoutedEventArgs e)
	{
		if (EditingItem == null)
		{
			ResultItem = new KeyInputItem
			{
				ItemType = KeyInputItemType.MultiKey
			};
		}
		else
		{
			ResultItem = KeyInputItem.ParseText(EditingItem.ToText());
			KeyInputOrSelectControl.SetData(ResultItem.CtrlKeys, ResultItem.NormalKeys);
		}
		TheTab.SelectedIndex = BZTLLLXgEIw().IndexOf(ResultItem.ItemType);
		B1qLLtLP00n();
	}

	private void sbeLLwyOOfM(object sender, SelectionChangedEventArgs e)
	{
		if (ResultItem != null)
		{
			ResultItem.ItemType = BZTLLLXgEIw()[TheTab.SelectedIndex];
		}
	}

	private void B1qLLtLP00n()
	{
		SingleKeySelector.SelectedKeyCode = ResultItem.SingleKey;
		TxtText.Text = ResultItem.Text;
		TxtSleepMs.Value = ResultItem.SleepMs ?? 100;
	}

	private void eI4LLgSgaxo(object sender, RoutedEventArgs e)
	{
		ResultItem.ItemType = BZTLLLXgEIw()[TheTab.SelectedIndex];
		ResultItem.CtrlKeys = KeyInputOrSelectControl.CtrlKeys;
		ResultItem.NormalKeys = KeyInputOrSelectControl.NormalKeys;
		ResultItem.SingleKey = SingleKeySelector.SelectedKeyCode;
		ResultItem.Text = TxtText.Text;
		if (ResultItem.ItemType == KeyInputItemType.Sleep)
		{
			int value = (int)TxtSleepMs.Value;
			int num = 0;
			if (xSTtoeFAAy75qBVpOvRb != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			ResultItem.SleepMs = value;
		}
		else
		{
			ResultItem.SleepMs = 0;
		}
		base.DialogResult = true;
	}

	private void SingleKeySelector_OnSelectionChanged(object sender, EventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!boELL0iHUh9)
		{
			boELL0iHUh9 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/keyinput/keyboardinputeditorwindow.xaml", UriKind.Relative);
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
			boELL0iHUh9 = true;
			break;
		case 1:
			TheTab = (System.Windows.Controls.TabControl)target;
			TheTab.SelectionChanged += sbeLLwyOOfM;
			break;
		case 2:
			KeyInputOrSelectControl = (KeyInputOrSelectControl)target;
			break;
		case 3:
			SingleKeySelector = (KeySelectorControl)target;
			break;
		case 4:
			TxtText = (System.Windows.Controls.TextBox)target;
			break;
		case 5:
			TxtSleepMs = (NumericUpDown)target;
			break;
		case 6:
			BtnSave = (Button)target;
			BtnSave.Click += eI4LLgSgaxo;
			if (xSTtoeFAAy75qBVpOvRb == null)
			{
				switch (0)
				{
				}
			}
			break;
		}
	}

	internal static bool QWsL04FAn8qR9W5WKIpO()
	{
		return xSTtoeFAAy75qBVpOvRb == null;
	}
}
