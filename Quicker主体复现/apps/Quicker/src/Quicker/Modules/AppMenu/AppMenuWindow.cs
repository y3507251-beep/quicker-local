using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Modules.AppMenu;

public class AppMenuWindow : Window, IComponentConnector
{
	internal Menu Menu;

	private bool bCUAlarV23;

	internal static AppMenuWindow tZNHtnH5qH9pv6QLfLT;

	public AppMenuWindow()
	{
		InitializeComponent();
		base.Topmost = true;
		base.ShowInTaskbar = false;
		base.SourceInitialized += uaVAO5PkV7;
		base.Closed += lmjAAMwQwR;
	}

	private void lmjAAMwQwR(object sender, EventArgs e)
	{
		AppState.r4itaWBnyVQ().ForegroundWindowChanged -= TNXAFeuk5i;
	}

	private void uaVAO5PkV7(object sender, EventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.GWHvvUGmjWL(this);
		AppState.r4itaWBnyVQ().ForegroundWindowChanged += TNXAFeuk5i;
	}

	private void TNXAFeuk5i(object sender, EventArgs e)
	{
	}

	private void QXSAUkHbHo(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bCUAlarV23)
		{
			bCUAlarV23 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/appmenu/appmenuwindow.xaml", UriKind.Relative);
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
			bCUAlarV23 = true;
			break;
		case 2:
			((Button)target).Click += QXSAUkHbHo;
			break;
		case 1:
			Menu = (Menu)target;
			break;
		}
	}

	internal static void AwclGeHRCR2ojnaQ6LR()
	{
	}

	internal static bool CMgYWdHYl13LJ1g1J4n()
	{
		return tZNHtnH5qH9pv6QLfLT == null;
	}
}
