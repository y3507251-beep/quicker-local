using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Interactivity;
using Quicker.Domain;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.View.UI;

public class GoToLineWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	private bool? f7FLCv4c6S0;

	internal TextBox TxtLineNumber;

	internal Button BtnEnter;

	internal Button BtnCancel;

	private bool D1SLCSfbP1T;

	private static GoToLineWindow SrZiuvF37qmB2CF2l7Jl;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return f7FLCv4c6S0;
		}
		[CompilerGenerated]
		set
		{
			f7FLCv4c6S0 = value;
		}
	}

	public int GoToLineNumber => (base.DataContext as GoToLineVm)?.GoToLineNumber ?? 0;

	public GoToLineWindow(int maxLineNumber, int currLine)
	{
		InitializeComponent();
		base.CommandBindings.Add(new CommandBinding(ControlCommands.Close, uIoL0ziwwvj));
		base.CommandBindings.Add(new CommandBinding(ControlCommands.Confirm, AjqLCwhkR4r));
		base.DataContext = new GoToLineVm
		{
			MaxLineNumber = maxLineNumber,
			GoToLineNumber = currLine
		};
		base.Loaded += s0xLCtelyV4;
		base.Deactivated += uGmL03cXsSJ;
		base.Closing += dN3LCLgjNs8;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void uGmL03cXsSJ(object sender, EventArgs e)
	{
		if (base.IsLoaded && PresentationSource.FromVisual(this) != null)
		{
			try
			{
				Close();
			}
			catch (Exception)
			{
			}
		}
	}

	private void Confirm()
	{
		this.ThNvuM5Q9GQ(true);
	}

	private void Y5YL0fffhlD(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			BtnEnter.Command?.Execute(null);
			e.Handled = true;
		}
		else if (e.Key == Key.Escape)
		{
			BtnCancel.Command?.Execute(null);
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!D1SLCSfbP1T)
		{
			D1SLCSfbP1T = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/gotolinewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			D1SLCSfbP1T = true;
			break;
		case 1:
			TxtLineNumber = (TextBox)target;
			TxtLineNumber.PreviewKeyDown += Y5YL0fffhlD;
			break;
		case 2:
			BtnEnter = (Button)target;
			break;
		case 3:
			BtnCancel = (Button)target;
			break;
		}
	}

	[CompilerGenerated]
	private void uIoL0ziwwvj(object sender, ExecutedRoutedEventArgs e)
	{
		Close();
	}

	[CompilerGenerated]
	private void AjqLCwhkR4r(object sender, ExecutedRoutedEventArgs e)
	{
		Confirm();
	}

	[CompilerGenerated]
	private void s0xLCtelyV4(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(yMLLCgjxFBX);
	}

	[CompilerGenerated]
	private void yMLLCgjxFBX()
	{
		TxtLineNumber.Focus();
		TxtLineNumber.SelectAll();
	}

	[CompilerGenerated]
	private void dN3LCLgjNs8(object sender, CancelEventArgs e)
	{
		base.Deactivated -= uGmL03cXsSJ;
	}

	internal static void phofxfF3H5v4HTFUKc9L()
	{
	}

	internal static bool IuUS3LF340W3mYwAqaSg()
	{
		return SrZiuvF37qmB2CF2l7Jl == null;
	}
}
