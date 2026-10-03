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
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;

namespace Quicker.View.X.Controls;

public class BrowserContextMenuBindingWindow : System.Windows.Window, IComponentConnector, IMockModalWindow
{
	private static IList<string> gGtLbVt1PCN;

	[CompilerGenerated]
	private BrowserContextMenuBinding nduLbZwT0qT;

	[CompilerGenerated]
	private bool? MZ0Lb9wxDNU;

	internal CheckComboBox CbContexts;

	internal TextBoxWithToolsControl TxtDocumentUrlPatterns;

	internal TextBoxWithToolsControl TxtTargetUrlPatterns;

	internal System.Windows.Controls.TextBox TxtActionParam;

	internal Button BtnOk;

	internal Button BtnCancel;

	internal Button BtnClear;

	private bool LIHLbhXhFgT;

	internal static BrowserContextMenuBindingWindow ushQNdFNPYhiVGqAe10b;

	public BrowserContextMenuBinding ResultBinding
	{
		[CompilerGenerated]
		get
		{
			return nduLbZwT0qT;
		}
		[CompilerGenerated]
		private set
		{
			nduLbZwT0qT = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return MZ0Lb9wxDNU;
		}
		[CompilerGenerated]
		set
		{
			MZ0Lb9wxDNU = value;
		}
	}

	public BrowserContextMenuBindingWindow(BrowserContextMenuBinding binding)
	{
		InitializeComponent();
		ObservableCollection<string> itemsSource = new ObservableCollection<string>(gGtLbVt1PCN);
		CbContexts.ItemsSource = itemsSource;
		if (binding != null)
		{
			string[] array = binding.Contexts.SplitToList();
			foreach (string value in array)
			{
				CbContexts.SelectedItems.Add(value);
			}
			TxtActionParam.Text = binding.ActionParam;
			TxtDocumentUrlPatterns.Text = binding.DocumentUrlPatterns;
			TxtTargetUrlPatterns.Text = binding.TargetUrlPatterns;
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

	private void d2XLb7kDQuC(object sender, RoutedEventArgs e)
	{
		ResultBinding = new BrowserContextMenuBinding();
		ResultBinding.Contexts = string.Join("\r\n", CbContexts.SelectedItems.Cast<string>());
		if (ResultBinding.Contexts.IsNullOrEmpty())
		{
			AppHelper.ShowWarning("请选择关联上下文。");
			return;
		}
		ResultBinding.ActionParam = TxtActionParam.Text;
		ResultBinding.DocumentUrlPatterns = TxtDocumentUrlPatterns.Text;
		ResultBinding.TargetUrlPatterns = TxtTargetUrlPatterns.Text;
		this.ThNvuM5Q9GQ(true);
	}

	private void rT4LbRLkS5N(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	private void RaRLbqE2DKZ(object sender, RoutedEventArgs e)
	{
		ResultBinding = null;
		this.ThNvuM5Q9GQ(true);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!LIHLbhXhFgT)
		{
			LIHLbhXhFgT = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/browsercontextmenubindingwindow.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			LIHLbhXhFgT = true;
			break;
		case 1:
			CbContexts = (CheckComboBox)target;
			break;
		case 2:
			TxtDocumentUrlPatterns = (TextBoxWithToolsControl)target;
			break;
		case 3:
			TxtTargetUrlPatterns = (TextBoxWithToolsControl)target;
			break;
		case 4:
			TxtActionParam = (System.Windows.Controls.TextBox)target;
			break;
		case 5:
			BtnOk = (Button)target;
			BtnOk.Click += d2XLb7kDQuC;
			break;
		case 6:
			BtnCancel = (Button)target;
			BtnCancel.Click += rT4LbRLkS5N;
			break;
		case 7:
			BtnClear = (Button)target;
			BtnClear.Click += RaRLbqE2DKZ;
			break;
		}
	}

	static BrowserContextMenuBindingWindow()
	{
		gGtLbVt1PCN = new string[13]
		{
			"all", "page", "frame", "selection", "link", "editable", "image", "video", "audio", "launcher",
			"browser_action", "page_action", "action"
		};
	}

	internal static bool bTxGMmFNMIVyUISt4wHf()
	{
		return ushQNdFNPYhiVGqAe10b == null;
	}
}
