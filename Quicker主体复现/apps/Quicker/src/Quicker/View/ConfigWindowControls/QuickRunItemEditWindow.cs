using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.ConfigWindowControls;

public class QuickRunItemEditWindow : Window, IComponentConnector
{
	private ActionItem KahLhLEDHAw;

	internal TextBox TxtCmdText;

	internal TextBox TxtActionId;

	internal Button BtnSelectAction;

	internal IconControl ImgIcon;

	internal TextBlock TextActionTitle;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool mowLhv2vOhX;

	private static QuickRunItemEditWindow XddGbjFdPc8HT5p4K5n4;

	public string CmdText
	{
		get
		{
			return TxtCmdText.Text;
		}
		set
		{
			TxtCmdText.Text = value;
		}
	}

	public string ActionIdOrName
	{
		get
		{
			return TxtActionId.Text;
		}
		set
		{
			TxtActionId.Text = value;
		}
	}

	public QuickRunItemEditWindow()
	{
		InitializeComponent();
		base.Loaded += TRiL935uceB;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void TRiL935uceB(object sender, RoutedEventArgs e)
	{
		TxtCmdText.Focus();
	}

	private void TJ9L9fBQZ68(object sender, TextChangedEventArgs e)
	{
		P1qLhty5bOt();
	}

	private void rOCL9znYNYi(object sender, RoutedEventArgs e)
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

	private void xtQLhwrUhhe(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void P1qLhty5bOt()
	{
		KahLhLEDHAw = null;
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtActionId.Text);
		if (tuple.Item1 != null)
		{
			ImgIcon.Icon = tuple.Item1.Icon;
			TextActionTitle.Text = tuple.Item1.Title;
			TextActionTitle.Foreground = Brushes.Black;
			(KahLhLEDHAw, _) = tuple;
			return;
		}
		ImgIcon.Icon = null;
		TextActionTitle.Text = tuple.Item2;
		int num = 0;
		if (XddGbjFdPc8HT5p4K5n4 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TextActionTitle.Foreground = Brushes.Red;
	}

	private void MO5LhgfhsYC(object sender, RoutedEventArgs e)
	{
		if (TxtCmdText.EnsureNotEmpty("命令字符") && TxtActionId.EnsureNotEmpty("动作"))
		{
			base.DialogResult = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!mowLhv2vOhX)
		{
			mowLhv2vOhX = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/configwindowcontrols/quickrunitemeditwindow.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			mowLhv2vOhX = true;
			break;
		case 1:
			TxtCmdText = (TextBox)target;
			break;
		case 2:
			TxtActionId = (TextBox)target;
			TxtActionId.TextChanged += TJ9L9fBQZ68;
			break;
		case 3:
		{
			BtnSelectAction = (Button)target;
			int num = 0;
			if (!SD8rMuFdMgrOILpGVYxl())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnSelectAction.Click += rOCL9znYNYi;
				break;
			}
			break;
		}
		case 4:
			ImgIcon = (IconControl)target;
			break;
		case 5:
			TextActionTitle = (TextBlock)target;
			break;
		case 6:
			BtnSave = (Button)target;
			BtnSave.Click += MO5LhgfhsYC;
			break;
		case 7:
			BtnCancel = (Button)target;
			BtnCancel.Click += xtQLhwrUhhe;
			break;
		}
	}

	internal static bool SD8rMuFdMgrOILpGVYxl()
	{
		return XddGbjFdPc8HT5p4K5n4 == null;
	}
}
