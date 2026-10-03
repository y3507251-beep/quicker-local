using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Common.QuickActions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using Quicker.View.UI;

namespace Quicker.Modules.Gestures.Manage;

public class EditHotkeyWatcherItemWindow : System.Windows.Window, IComponentConnector, IMockModalWindow
{
	private readonly HotkeyWatcherItem cUttgODRsKq;

	[CompilerGenerated]
	private HotkeyWatcherItem MRDtgFoIjX1;

	[CompilerGenerated]
	private bool? A7CtgURr0OI;

	internal HotkeyEditorControl KeyEditor;

	internal HotkeyEditorControl KeyEditor2;

	internal System.Windows.Controls.TextBox TxtDescription;

	internal TextBlock LblWhiteList;

	internal StackPanel PnlWhiteList;

	internal System.Windows.Controls.TextBox TxtWhiteList;

	internal WindowSelector WhiteListWindowSelector;

	internal TextBlock LblBlackList;

	internal StackPanel PnlBlackList;

	internal System.Windows.Controls.TextBox TxtBlackList;

	internal WindowSelector BlackListWindowSelector;

	internal ValidMachinesEditorControl ValidMachineEditor;

	internal NumericUpDown TxtDelayMs;

	internal QuickActionEditor QuickActionEditor;

	internal CheckBox ChkIsEnabled;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool j6NtglKMkxH;

	private static EditHotkeyWatcherItemWindow oaCt6bQWfhfEK5pZDPSw;

	public HotkeyWatcherItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return MRDtgFoIjX1;
		}
		[CompilerGenerated]
		set
		{
			MRDtgFoIjX1 = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return A7CtgURr0OI;
		}
		[CompilerGenerated]
		set
		{
			A7CtgURr0OI = value;
		}
	}

	public EditHotkeyWatcherItemWindow(HotkeyWatcherItem editingSubActionItem)
	{
		cUttgODRsKq = editingSubActionItem;
		InitializeComponent();
		base.Loaded += Ob7tgTyAuim;
	}

	private void Ob7tgTyAuim(object sender, RoutedEventArgs e)
	{
		if (cUttgODRsKq != null)
		{
			KeyEditor.Hotkey = cUttgODRsKq.Hotkey1;
			KeyEditor2.Hotkey = cUttgODRsKq.Hotkey2;
			TxtDescription.Text = cUttgODRsKq.Description;
			TxtWhiteList.Text = cUttgODRsKq.BindingProcessName;
			TxtBlackList.Text = cUttgODRsKq.BlackList;
			QuickActionEditor.SetData(cUttgODRsKq);
			ChkIsEnabled.IsChecked = cUttgODRsKq.IsEnabled;
			if (oaCt6bQWfhfEK5pZDPSw != null)
			{
				switch (0)
				{
				}
			}
			TxtDelayMs.Value = cUttgODRsKq.DelayMs;
			ValidMachineEditor.Text = cUttgODRsKq.ValidForMachines;
		}
		else
		{
			KeyEditor.BeginInput();
			ChkIsEnabled.IsChecked = true;
		}
	}

	private void ML0tgM9Cvw3(object sender, RoutedEventArgs e)
	{
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("请输入按键。");
			KeyEditor.BeginInput();
			return;
		}
		int key = (int)KeyEditor.Hotkey.Key;
		if (key < 256 && !key.IsEither(1, 2, 4, 5, 6, 17, 18, 16))
		{
			(bool, string) tuple = QuickActionEditor.IsDataValid();
			if (!tuple.Item1)
			{
				AppHelper.ShowWarning(tuple.Item2, true);
				return;
			}
			ResultItem = new HotkeyWatcherItem
			{
				Hotkey1Data = KeyEditor.Hotkey?.ToData(),
				Hotkey2Data = KeyEditor2.Hotkey?.ToData(),
				Description = TxtDescription.Text,
				BindingProcessName = TxtWhiteList.Text,
				BlackList = TxtBlackList.Text,
				IsEnabled = (ChkIsEnabled.IsChecked == true),
				DelayMs = (int)TxtDelayMs.Value,
				ValidForMachines = ValidMachineEditor.Text
			};
			QuickActionEditor.SaveData(ResultItem);
			int num = 0;
			if (!Jm8essQWb2BlSEEinKFJ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			this.ThNvuM5Q9GQ(true);
		}
		else
		{
			AppHelper.ShowWarning("不支持此按键值。");
		}
	}

	private void WwCtgAA1gIr(object sender, RoutedEventArgs e)
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!j6NtglKMkxH)
		{
			j6NtglKMkxH = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/hotkeywatchers/edithotkeywatcheritemwindow.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			j6NtglKMkxH = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			KeyEditor2 = (HotkeyEditorControl)target;
			break;
		case 3:
			TxtDescription = (System.Windows.Controls.TextBox)target;
			break;
		case 4:
			LblWhiteList = (TextBlock)target;
			num = 1;
			if (Jm8essQWb2BlSEEinKFJ())
			{
				break;
			}
			goto IL_00da;
		case 5:
			PnlWhiteList = (StackPanel)target;
			break;
		case 6:
			TxtWhiteList = (System.Windows.Controls.TextBox)target;
			break;
		case 7:
			WhiteListWindowSelector = (WindowSelector)target;
			break;
		case 8:
			LblBlackList = (TextBlock)target;
			num = 0;
			if (oaCt6bQWfhfEK5pZDPSw != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00da;
		case 9:
			PnlBlackList = (StackPanel)target;
			break;
		case 10:
			TxtBlackList = (System.Windows.Controls.TextBox)target;
			break;
		case 11:
			BlackListWindowSelector = (WindowSelector)target;
			break;
		case 12:
			ValidMachineEditor = (ValidMachinesEditorControl)target;
			break;
		case 13:
			TxtDelayMs = (NumericUpDown)target;
			break;
		case 14:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 15:
			ChkIsEnabled = (CheckBox)target;
			break;
		case 16:
			BtnSave = (Button)target;
			BtnSave.Click += ML0tgM9Cvw3;
			break;
		case 17:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += WwCtgAA1gIr;
				break;
			}
			IL_00da:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool Jm8essQWb2BlSEEinKFJ()
	{
		return oaCt6bQWfhfEK5pZDPSw == null;
	}
}
