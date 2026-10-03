using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using CW;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain;
using Quicker.Modules.Searching.Builtin;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.Modules.Searching.Plugins.Builtin.Network;

public class EditSearchEngineWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	private WebSearchEngine tAetExCjDyL;

	[CompilerGenerated]
	private bool? pActErbdrdy;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool zeptEpd5Jtj;

	private static EditSearchEngineWindow M6NLO0QD9vDyjulJSPQ2;

	public WebSearchEngine Engine
	{
		[CompilerGenerated]
		get
		{
			return tAetExCjDyL;
		}
		[CompilerGenerated]
		set
		{
			tAetExCjDyL = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return pActErbdrdy;
		}
		[CompilerGenerated]
		set
		{
			pActErbdrdy = value;
		}
	}

	public EditSearchEngineWindow(WebSearchEngine engine)
	{
		InitializeComponent();
		Engine = ((engine == null) ? new WebSearchEngine() : AppHelper.Clone(engine));
		base.DataContext = Engine;
		base.Loaded += FlMtEXAbcIk;
	}

	private void FlMtEXAbcIk(object sender, RoutedEventArgs e)
	{
		this.aJDvuAkk8hZ();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void AhjtEmWgEV5(object sender, RoutedEventArgs e)
	{
		if (!Engine.Name.IsNullOrEmpty() && !Engine.QueryUrl.IsNullOrEmpty() && !Engine.TriggerWords.IsNullOrEmpty())
		{
			this.ThNvuM5Q9GQ(true);
		}
		else
		{
			AppHelper.ShowWarning("请检查表单。");
		}
	}

	private void vlhtEKLRGp9(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zeptEpd5Jtj)
		{
			zeptEpd5Jtj = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/network/editsearchenginewindow.xaml", UriKind.Relative);
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
			zeptEpd5Jtj = true;
			break;
		case 2:
			BtnCancel = (Button)target;
			BtnCancel.Click += vlhtEKLRGp9;
			break;
		case 1:
			BtnOk = (Button)target;
			BtnOk.Click += AhjtEmWgEV5;
			break;
		}
	}

	internal static bool mb4dIuQDLANitQ87CGG3()
	{
		return M6NLO0QD9vDyjulJSPQ2 == null;
	}
}
