using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;

namespace Quicker.View.Progress;

public class ProgressReportWindow : Window, IComponentConnector, IStyleConnector
{
	internal Button BtnClear;

	internal ItemsControl ProgressItemsList;

	private bool IdILuNlvXkx;

	private static ProgressReportWindow mU1gCuFjDNXH9NTf47uc;

	public ProgressReportWindow(SmartCollection<ProgressReportItem> progressItems)
	{
		InitializeComponent();
		base.SizeChanged += TP5LuveYqvu;
		base.SourceInitialized += eKmLuuCuMO4;
		base.Closing += KqdLuLRPPaj;
		ProgressItemsList.ItemsSource = progressItems;
	}

	private void KqdLuLRPPaj(object sender, CancelEventArgs e)
	{
		Hide();
		e.Cancel = true;
	}

	private void TP5LuveYqvu(object sender, SizeChangedEventArgs e)
	{
		Rect workArea = SystemParameters.WorkArea;
		base.Left = workArea.Right - base.ActualWidth;
		base.Top = workArea.Bottom - base.ActualHeight;
	}

	private void xOwLuSeZCSJ(object sender, RoutedEventArgs e)
	{
		ProgressReportMgr.Clear();
	}

	private void JhOLu20K1O1(object sender, RoutedEventArgs e)
	{
		if ((sender as Button).Tag is ProgressReportItem progressReportItem)
		{
			progressReportItem.Cts?.Cancel();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!IdILuNlvXkx)
		{
			IdILuNlvXkx = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/progress/progressreportwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			IdILuNlvXkx = true;
			break;
		case 2:
			ProgressItemsList = (ItemsControl)target;
			break;
		case 1:
			BtnClear = (Button)target;
			BtnClear.Click += xOwLuSeZCSJ;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 3)
		{
			((Button)target).Click += JhOLu20K1O1;
		}
	}

	[CompilerGenerated]
	private void eKmLuuCuMO4(object sender, EventArgs e)
	{
		NativeMethods.SetWindowNoActivate(this);
	}

	internal static bool Mmc8MxFj3jraAwdVG8Sx()
	{
		return mU1gCuFjDNXH9NTf47uc == null;
	}
}
