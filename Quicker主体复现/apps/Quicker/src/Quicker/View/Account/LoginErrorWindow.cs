using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities;

namespace Quicker.View.Account;

public class LoginErrorWindow : Window, IComponentConnector
{
	private readonly string DOCLh2LyV9v;

	internal TextBlock LblMessage;

	internal Button BtnHelp;

	internal Button BtnClose;

	private bool WqhLhubPmmu;

	private static LoginErrorWindow relZTGFdSs2lbOySDRtO;

	public LoginErrorWindow(string message, string link)
	{
		DOCLh2LyV9v = link;
		InitializeComponent();
		LblMessage.Text = message;
	}

	private void JHlLhSWfb9u(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(DOCLh2LyV9v);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!WqhLhubPmmu)
		{
			WqhLhubPmmu = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/loginerrorwindow.xaml", UriKind.Relative);
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
			WqhLhubPmmu = true;
			break;
		case 1:
			LblMessage = (TextBlock)target;
			break;
		case 2:
			BtnHelp = (Button)target;
			BtnHelp.Click += JHlLhSWfb9u;
			break;
		case 3:
			BtnClose = (Button)target;
			break;
		}
	}

	internal static bool gvaF9GFdwWUhgVkp72BX()
	{
		return relZTGFdSs2lbOySDRtO == null;
	}
}
