using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using Quicker.Utilities;
using Quicker.View.Account;

namespace Quicker.View;

public class LocalBrowserWindow : Window, IComponentConnector
{
	private readonly string sBcLt5euuOb;

	private readonly string ASRLtDEsey6;

	internal WebBrowser Browser;

	private bool N9GLtdlZbii;

	private static LocalBrowserWindow LlAWHmF21uk8tU2UwBCi;

	public LocalBrowserWindow(string url, string html = "")
	{
		sBcLt5euuOb = url;
		ASRLtDEsey6 = html;
		InitializeComponent();
		base.Loaded += xdMLt489VP0;
		base.Closed += jLoLtni5S2g;
		Browser.MessageHook += d7aLtjOTZZ3;
		Browser.Navigated += U6dLtQBiJIs;
	}

	private void U6dLtQBiJIs(object sender, NavigationEventArgs e)
	{
		ExternalLoginWindow.SetSilent(Browser, true);
	}

	private IntPtr d7aLtjOTZZ3(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_1)
	{
		if (int_0 == 16)
		{
			bool_1 = true;
			Close();
		}
		return IntPtr.Zero;
	}

	private void jLoLtni5S2g(object sender, EventArgs e)
	{
		try
		{
			Browser.Dispose();
		}
		catch
		{
		}
	}

	private void xdMLt489VP0(object sender, RoutedEventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(sBcLt5euuOb))
			{
				Browser.Navigate(sBcLt5euuOb);
			}
			else if (!string.IsNullOrEmpty(ASRLtDEsey6))
			{
				Browser.NavigateToString(ASRLtDEsey6);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("打开网址 " + sBcLt5euuOb + " 出错。" + ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!N9GLtdlZbii)
		{
			N9GLtdlZbii = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/localbrowserwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			Browser = (WebBrowser)target;
		}
		else
		{
			N9GLtdlZbii = true;
		}
	}

	internal static bool IhY2WEF2KBufHGAlYiBv()
	{
		return LlAWHmF21uk8tU2UwBCi == null;
	}
}
