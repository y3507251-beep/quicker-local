using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using log4net;
using Quicker.Utilities;
using Quicker.View.Controls;
using upLrfmibGdtSX9dWuOT;

namespace Quicker.View.Account;

public class ExternalLoginWindow : Window, IComponentConnector
{
	[ComImport]
	[Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IOleServiceProvider
	{
		[PreserveSig]
		int QueryService([In] ref Guid guidService, [In] ref Guid riid, [MarshalAs(UnmanagedType.IDispatch)] out object ppvObject);
	}

	[ComVisible(true)]
	public class ScriptingHelper
	{
		private readonly ExternalLoginWindow a8JSTVFueGF;

		internal static ScriptingHelper wVId5qW71Y2eAGmX3Tqc;

		public ScriptingHelper(ExternalLoginWindow window)
		{
			a8JSTVFueGF = window;
		}

		public void DoLogin(string token)
		{
			a8JSTVFueGF.Token = token;
			a8JSTVFueGF.DialogResult = true;
		}

		internal static bool IFC6f9W7KAAsL3MiJwR2()
		{
			return wVId5qW71Y2eAGmX3Tqc == null;
		}
	}

	private static readonly ILog k3JLhyMev5r;

	[CompilerGenerated]
	private string nDALh8qd6KC;

	private WebView2Wrapper FDNLhaNRrQx;

	internal Grid Wrapper;

	internal WebBrowser browser;

	private bool WCPLh7oBFyv;

	internal static ExternalLoginWindow bXWE4FFd7CDX0xP6seSv;

	public string Token
	{
		[CompilerGenerated]
		get
		{
			return nDALh8qd6KC;
		}
		[CompilerGenerated]
		set
		{
			nDALh8qd6KC = value;
		}
	}

	public ExternalLoginWindow()
	{
		InitializeComponent();
		Wrapper.Children.Clear();
		Wrapper.Children.Add(new System.Windows.Controls.TextBlock { Text = "本地版无需账号，请关闭此窗口直接使用。", Margin = new Thickness(20) });
	}

	private void rB0LhCMPmXg(object sender, CancelEventArgs e)
	{
		if (FDNLhaNRrQx != null)
		{
			try
			{
				FDNLhaNRrQx.WebView2.CoreWebView2.CookieManager.DeleteAllCookies();
			}
			catch (Exception ex)
			{
				k3JLhyMev5r.Warn("登录窗口删除cookie出错：" + ex.Message, ex);
			}
		}
	}

	private void LfFLhPBRbGN(object sender, NavigationEventArgs e)
	{
		SetSilent(browser, true);
	}

	public static void SetSilent(WebBrowser browser, bool silent)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (browser.Document is IOleServiceProvider oleServiceProvider)
		{
			Guid guidService = new Guid("0002DF05-0000-0000-C000-000000000046");
			Guid riid = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");
			oleServiceProvider.QueryService(ref guidService, ref riid, out var ppvObject);
			ppvObject?.GetType().InvokeMember("Silent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null, ppvObject, new object[1] { silent });
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!WCPLh7oBFyv)
		{
			WCPLh7oBFyv = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/externalloginwindow.xaml", UriKind.Relative);
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
			WCPLh7oBFyv = true;
			break;
		case 2:
			browser = (WebBrowser)target;
			break;
		case 1:
			Wrapper = (Grid)target;
			break;
		}
	}

	static ExternalLoginWindow()
	{
		k3JLhyMev5r = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void FFoLhEJiER8(object sender, EventArgs e)
	{
		try
		{
			browser.Dispose();
		}
		catch (Exception exception)
		{
			k3JLhyMev5r.Warn("释放browser出错。", exception);
		}
	}

	internal static bool VosISIFd4gGWcBa8Z1k9()
	{
		return bXWE4FFd7CDX0xP6seSv == null;
	}
}
