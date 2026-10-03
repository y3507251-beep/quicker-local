using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Hotkeys;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.Hotkeys;

public class ActionHotkeyEditorWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private ActionHotKeyItem t5eLvsPvJyJ;

	[CompilerGenerated]
	private ActionHotKeyItem xGxLvHm3nmC;

	private readonly DataService MNNLv1iYihb;

	private ActionItem FhkLvbRd9np;

	internal HotkeyEditorControl HotkeyEditor;

	internal TextBox TxtBindingProcessName;

	internal TextBox TxtBlackList;

	internal TextBlock LblParam;

	internal StackPanel PnlParam;

	internal TextBox TxtActionId;

	internal Button BtnSelectAction;

	internal IconControl ImgIcon;

	internal TextBlock TextActionTitle;

	internal TextBlock LblActionParam;

	internal StackPanel PnlActionParam;

	internal TextBox TxtActionParam;

	internal CheckBox ChkWaitKeyUp;

	internal Button BtnSave;

	private bool zUGLv6SRZ55;

	internal static ActionHotkeyEditorWindow EU1j2pFnEUx9vlVBuCR4;

	public ActionHotKeyItem EditingItem
	{
		[CompilerGenerated]
		get
		{
			return t5eLvsPvJyJ;
		}
		[CompilerGenerated]
		set
		{
			t5eLvsPvJyJ = value;
		}
	}

	public ActionHotKeyItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return xGxLvHm3nmC;
		}
		[CompilerGenerated]
		set
		{
			xGxLvHm3nmC = value;
		}
	}

	public ActionHotkeyEditorWindow()
	{
		InitializeComponent();
		base.Loaded += aaJLveH9910;
		MNNLv1iYihb = AppState.dAntabrFWrV().Get<DataService>(Array.Empty<IParameter>());
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void aaJLveH9910(object sender, RoutedEventArgs e)
	{
		if (EditingItem != null)
		{
			TxtActionId.Text = EditingItem.ActionId;
			HotkeyEditor.SetData(EditingItem.Keys);
			TxtBindingProcessName.Text = EditingItem.BindingProcessName;
			TxtBlackList.Text = EditingItem.BlackList;
			ChkWaitKeyUp.IsChecked = EditingItem.WaitKeyUp;
			TxtActionParam.Text = EditingItem.ActionParam;
			kuDLvIYy2p4();
		}
	}

	private void PtiLvYVYV2D()
	{
	}

	private void kuDLvIYy2p4()
	{
		FhkLvbRd9np = null;
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtActionId.Text);
		if (tuple.Item1 != null)
		{
			if (EU1j2pFnEUx9vlVBuCR4 != null)
			{
				switch (0)
				{
				}
			}
			ImgIcon.Icon = tuple.Item1.Icon;
			TextActionTitle.Text = tuple.Item1.Title;
			TextActionTitle.Foreground = TryFindResource("SecondaryTextBrush") as Brush;
			(FhkLvbRd9np, _) = tuple;
		}
		else
		{
			ImgIcon.Icon = null;
			TextActionTitle.Text = tuple.Item2;
			TextActionTitle.Foreground = Brushes.Red;
		}
	}

	private void xwlLvWZMO4G(object sender, RoutedEventArgs e)
	{
		string keyData = HotkeyEditor.GetKeyData();
		if (TxtActionId.EnsureNotEmpty("动作ID"))
		{
			if (FhkLvbRd9np == null)
			{
				AppHelper.ShowWarning("找不到动作！", true);
				return;
			}
			ResultItem = new ActionHotKeyItem
			{
				ActionId = TxtActionId.Text,
				Keys = keyData,
				Title = FhkLvbRd9np.Title,
				Icon = FhkLvbRd9np.Icon,
				BindingProcessName = TxtBindingProcessName.Text,
				BlackList = TxtBlackList.Text,
				WaitKeyUp = (ChkWaitKeyUp.IsChecked == true),
				ActionParam = TxtActionParam.Text
			};
			base.DialogResult = true;
		}
	}

	private void XQrLvkvr1ts(object sender, TextChangedEventArgs e)
	{
		kuDLvIYy2p4();
	}

	public void SetEditingAction(ActionItem action)
	{
		TxtActionId.Text = action.Id;
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtBindingProcessName, e.ProcessName, e.HWnd);
	}

	private void nJbLvGAQgTo(object sender, RoutedEventArgs e)
	{
		SearchActionWindow searchActionWindow = new SearchActionWindow(AppState.DataService);
		searchActionWindow.Owner = Window.GetWindow(this);
		if (searchActionWindow.ShowDialog() != true)
		{
			return;
		}
		ActionItem result = searchActionWindow.Result;
		TextBox txtActionId = TxtActionId;
		object obj;
		if (result == null)
		{
			obj = null;
		}
		else
		{
			obj = result.Id;
			if (obj != null)
			{
				goto IL_0051;
			}
		}
		obj = "";
		goto IL_0051;
		IL_0051:
		txtActionId.Text = (string)obj;
	}

	private void BlackListWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtBlackList, e.ProcessName, e.HWnd);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!zUGLv6SRZ55)
		{
			zUGLv6SRZ55 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/hotkeys/actionhotkeyeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			zUGLv6SRZ55 = true;
			break;
		case 1:
			HotkeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			TxtBindingProcessName = (TextBox)target;
			break;
		case 3:
			TxtBlackList = (TextBox)target;
			num = 0;
			if (!evgfCfFnGcG0fAFIeatO())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00da;
		case 4:
			LblParam = (TextBlock)target;
			break;
		case 5:
			PnlParam = (StackPanel)target;
			break;
		case 6:
			TxtActionId = (TextBox)target;
			TxtActionId.TextChanged += XQrLvkvr1ts;
			break;
		case 7:
			BtnSelectAction = (Button)target;
			num = 1;
			if (EU1j2pFnEUx9vlVBuCR4 != null)
			{
				goto IL_00da;
			}
			goto IL_00e8;
		case 8:
			ImgIcon = (IconControl)target;
			break;
		case 9:
			TextActionTitle = (TextBlock)target;
			break;
		case 10:
			LblActionParam = (TextBlock)target;
			break;
		case 11:
			PnlActionParam = (StackPanel)target;
			break;
		case 12:
			TxtActionParam = (TextBox)target;
			break;
		case 13:
			ChkWaitKeyUp = (CheckBox)target;
			break;
		case 14:
			{
				BtnSave = (Button)target;
				BtnSave.Click += xwlLvWZMO4G;
				break;
			}
			IL_00da:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto IL_00e8;
			IL_00e8:
			BtnSelectAction.Click += nJbLvGAQgTo;
			break;
		}
	}

	internal static bool evgfCfFnGcG0fAFIeatO()
	{
		return EU1j2pFnEUx9vlVBuCR4 == null;
	}
}
