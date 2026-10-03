using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using log4net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using upLrfmibGdtSX9dWuOT;

namespace Quicker.View.Controls;

public class WebView2Wrapper : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public WebView2Wrapper uJ4SiIOhQGf;

		public CoreWebView2ProcessFailedEventArgs aNfSiWDwStL;

		internal static _003C_003Ec__DisplayClass28_0 VCZ3NUyy10YZXugJ23rg;

		internal void YIlSi9nTLAk(CoreWebView2ProcessFailedKind kind)
		{
			string caption;
			string messageBoxText;
			if (kind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
			{
				caption = "Browser process exited";
				messageBoxText = "WebView2 Runtime's browser process exited unexpectedly. Recreate WebView?";
			}
			else
			{
				caption = "Web page unresponsive";
				if (Q3B49AyyKhFFcRljQqIk())
				{
					switch (0)
					{
					}
				}
				messageBoxText = "WebView2 Runtime's render process stopped responding. Recreate WebView?";
			}
			if (MessageBoxHelper.Show(Window.GetWindow(uJ4SiIOhQGf), messageBoxText, caption, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				if (uJ4SiIOhQGf.aKKLpjLpssq)
				{
					uJ4SiIOhQGf.v7WLpqcFR5N(uJ4SiIOhQGf.webView);
				}
				try
				{
					uJ4SiIOhQGf.webView.Dispose();
				}
				catch (Exception exception)
				{
					bVRLpK3DDRV.Error("释放WebView2组件失败。", exception);
				}
				uJ4SiIOhQGf.webView = uJ4SiIOhQGf.Y96Lp728VFf(false);
				uJ4SiIOhQGf.EmmLpcjtuVd(uJ4SiIOhQGf.webView);
			}
		}

		internal void QnjSihZKrLn(CoreWebView2ProcessFailedKind kind)
		{
			string caption;
			string messageBoxText;
			if (kind == CoreWebView2ProcessFailedKind.RenderProcessExited)
			{
				caption = "Web page unresponsive";
				messageBoxText = "WebView2 Runtime's render process exited unexpectedly. Reload page?";
			}
			else
			{
				caption = "App content frame unresponsive";
				messageBoxText = "WebView2 Runtime's render process for app frame exited unexpectedly. Reload page?";
			}
			if (MessageBoxHelper.Show(Window.GetWindow(uJ4SiIOhQGf), messageBoxText, caption, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				uJ4SiIOhQGf.webView.Reload();
			}
		}

		internal void MOUSieMK5SJ(object _)
		{
			YIlSi9nTLAk(aNfSiWDwStL.ProcessFailedKind);
		}

		internal void syDSiYUBus5(object _)
		{
			QnjSihZKrLn(aNfSiWDwStL.ProcessFailedKind);
		}

		internal static bool Q3B49AyyKhFFcRljQqIk()
		{
			return VCZ3NUyy10YZXugJ23rg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_1
	{
		public StringBuilder siESiGha8fP;

		public _003C_003Ec__DisplayClass28_0 K9dSismFf1X;

		private static _003C_003Ec__DisplayClass28_1 u0yHivyyvBWLuCpcBdqL;

		internal void SmESiku5yXv(object _)
		{
			MessageBoxHelper.Show(Window.GetWindow(K9dSismFf1X.uJ4SiIOhQGf), siESiGha8fP.ToString(), "Child process failed");
		}

		internal static bool oEOGxByydafy82mWYm6W()
		{
			return u0yHivyyvBWLuCpcBdqL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToPageCmdExecuted_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExecutedRoutedEventArgs e;

		public WebView2Wrapper _003C_003E4__this;

		private static object zKgQOMyyJoxIZLh5LCqr;

		private void MoveNext()
		{
			WebView2Wrapper webView2Wrapper = _003C_003E4__this;
			try
			{
				try
				{
					string text = (string)e.Parameter;
					Uri uri = null;
					if (Uri.IsWellFormedUriString(text, UriKind.Absolute))
					{
						uri = new Uri(text);
					}
					else if (!text.Contains(" ") && text.Contains("."))
					{
						int num = 0;
						if (zKgQOMyyJoxIZLh5LCqr != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						}
						uri = new Uri("http://" + text);
					}
					else
					{
						uri = new Uri("https://bing.com/search?q=" + string.Join("+", Uri.EscapeDataString(text).Split(new string[1] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
					}
					webView2Wrapper.webView.CoreWebView2.Navigate(uri.ToString());
				}
				catch (Exception ex)
				{
					bVRLpK3DDRV.Warn("GoToPageCmdExecuted出错：" + ex.Message, ex);
					AppHelper.ShowWarning("无法打开网页：" + ex.Message);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool NO0ybEyykQfLSejtUqog()
		{
			return zKgQOMyyJoxIZLh5LCqr == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebView2Wrapper _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object g4cDt7yyNJZlEIUsu3YY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebView2Wrapper webView2Wrapper = _003C_003E4__this;
			try
			{
				try
				{
					if (num == 0)
					{
						goto IL_0086;
					}
					webView2Wrapper.webView.CreationProperties = V1kWZri8vrLTHgNDH0k.y0qvSaX2h6Z();
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = webView2Wrapper.webView.EnsureCoreWebView2Async(null, null).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						if (g4cDt7yyNJZlEIUsu3YY == null)
						{
							switch (0)
							{
							case 1:
								goto IL_0086;
							}
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a2;
					IL_00a2:
					awaiter.GetResult();
					webView2Wrapper.webView.NavigationCompleted += webView2Wrapper.pwELpZ8pLBm;
					if (webView2Wrapper.webView.CoreWebView2 != null)
					{
						if (webView2Wrapper.x84LppXCx9N != null)
						{
							IEnumerator<KeyValuePair<string, object>> enumerator = webView2Wrapper.x84LppXCx9N.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									KeyValuePair<string, object> current = enumerator.Current;
									webView2Wrapper.webView.CoreWebView2.AddHostObjectToScript(current.Key, current.Value);
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
						}
					}
					else
					{
						AppWindowManager.ShowWebViewInstaller();
					}
					goto end_IL_000f;
					IL_0086:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a2;
					end_IL_000f:;
				}
				catch (Exception exception)
				{
					bVRLpK3DDRV.Error("初始化WebView2组件失败。", exception);
					AppHelper.ShowWarning("无法初始化WebView2组件。\r\n" + exception.GetMessageWithInner(), true);
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool JVOY5kyy9NVLgGxYPk35()
		{
			return g4cDt7yyNJZlEIUsu3YY == null;
		}
	}

	private static readonly ILog bVRLpK3DDRV;

	private bool bK5LpxSFEOc;

	private CoreWebView2Environment UTwLprCkhw4;

	private readonly IDictionary<string, object> x84LppXCx9N = new ActivityTagsCollection();

	private bool NtbLpBgIhxM = true;

	private bool SdKLpQjKsgR;

	private bool aKKLpjLpssq = true;

	internal DockPanel ToolbarWrapper;

	internal TextBox url;

	internal Grid Layout;

	internal WebView2 webView;

	private bool IDWLpnDJSyl;

	private static WebView2Wrapper vWKTdkFoCrrvU3nAPSyd;

	public WebView2 WebView2 => webView;

	public Uri Source
	{
		get
		{
			return webView.Source;
		}
		set
		{
			webView.Source = value;
		}
	}

	public bool ShowToolbar
	{
		get
		{
			return ToolbarWrapper.Visibility == Visibility.Visible;
		}
		set
		{
			ToolbarWrapper.Visibility = value.ToVisibility();
		}
	}

	[SpecialName]
	private CoreWebView2Environment QZ7LpXa5OXE()
	{
		if (UTwLprCkhw4 == null && webView?.CoreWebView2 != null)
		{
			UTwLprCkhw4 = webView.CoreWebView2.Environment;
		}
		return UTwLprCkhw4;
	}

	public void AddHostObjects(string name, object rawObject)
	{
		x84LppXCx9N.Add(name, rawObject);
	}

	public WebView2Wrapper()
	{
		InitializeComponent();
		jL9Lp0fZ6em();
		base.Unloaded += dncLpNEPCbN;
	}

	private void dncLpNEPCbN(object sender, RoutedEventArgs e)
	{
		base.Unloaded -= dncLpNEPCbN;
		if (webView == null)
		{
			return;
		}
		try
		{
			webView.NavigationCompleted -= pwELpZ8pLBm;
			if (webView.CoreWebView2 != null)
			{
				webView.CoreWebView2.ProcessFailed -= iRYLpRmKYET;
				webView.CoreWebView2.DocumentTitleChanged -= tHZLpy9L2ln;
			}
			if (!AppState.sD1t7gME9aw())
			{
				webView.Dispose();
				webView = null;
			}
		}
		catch (Exception exception)
		{
			bVRLpK3DDRV.Error("释放WebView2组件失败。", exception);
		}
	}

	private void iscLpJgaveG(object sender, EventArgs e)
	{
		jL9Lp0fZ6em();
	}

	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__18))]
	private void jL9Lp0fZ6em()
	{
		_003CInitializeAsync_003Ed__18 stateMachine = default(_003CInitializeAsync_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void y5wLpCWj7GW(WebView2 webView2_0)
	{
		webView2_0.NavigationStarting += joELpPYOgxd;
		webView2_0.NavigationCompleted += JXZLpEl8AHO;
		webView2_0.CoreWebView2InitializationCompleted += GX5Lp8Lfv6E;
	}

	private void joELpPYOgxd(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		bK5LpxSFEOc = true;
		pn2LpVWSpu3();
	}

	private void JXZLpEl8AHO(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		bK5LpxSFEOc = false;
		pn2LpVWSpu3();
	}

	private void tHZLpy9L2ln(object object_0, object object_1)
	{
	}

	private void GX5Lp8Lfv6E(object sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			webView.CoreWebView2.ProcessFailed += iRYLpRmKYET;
			webView.CoreWebView2.DocumentTitleChanged += tHZLpy9L2ln;
			if (NtbLpBgIhxM)
			{
				try
				{
					QZ7LpXa5OXE().BrowserProcessExited += MtBLpaH5yiK;
				}
				catch (NotImplementedException)
				{
				}
				NtbLpBgIhxM = false;
			}
		}
		else
		{
			MessageBoxHelper.Show(Window.GetWindow(this), $"WebView2 creation failed with exception = {e.InitializationException}");
		}
	}

	private void MtBLpaH5yiK(object sender, CoreWebView2BrowserProcessExitedEventArgs e)
	{
		if (e.BrowserProcessExitKind != CoreWebView2BrowserProcessExitKind.Failed && SdKLpQjKsgR)
		{
			UTwLprCkhw4 = null;
			webView = Y96Lp728VFf(true);
			EmmLpcjtuVd(webView);
			SdKLpQjKsgR = false;
		}
	}

	private WebView2 Y96Lp728VFf(bool bool_5)
	{
		WebView2 webView = new WebView2();
		((ISupportInitialize)webView).BeginInit();
		int num = 0;
		if (vWKTdkFoCrrvU3nAPSyd != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			if (bool_5)
			{
				webView.CreationProperties = new CoreWebView2CreationProperties();
				webView.CreationProperties.BrowserExecutableFolder = this.webView.CreationProperties.BrowserExecutableFolder;
				webView.CreationProperties.Language = this.webView.CreationProperties.Language;
				webView.CreationProperties.UserDataFolder = this.webView.CreationProperties.UserDataFolder;
				NtbLpBgIhxM = true;
			}
			else
			{
				webView.CreationProperties = this.webView.CreationProperties;
			}
			Binding binding = new Binding
			{
				Source = webView,
				Path = new PropertyPath("Source"),
				Mode = BindingMode.OneWay
			};
			url.SetBinding(TextBox.TextProperty, binding);
			y5wLpCWj7GW(webView);
			webView.Source = this.webView.Source ?? new Uri("https://www.bing.com");
			((ISupportInitialize)webView).EndInit();
			return webView;
		}
		}
	}

	private void iRYLpRmKYET(object sender, CoreWebView2ProcessFailedEventArgs e)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.uJ4SiIOhQGf = this;
		_003C_003Ec__DisplayClass28_.aNfSiWDwStL = e;
		_003C_003Ec__DisplayClass28_1 _003C_003Ec__DisplayClass28_2 = new _003C_003Ec__DisplayClass28_1();
		_003C_003Ec__DisplayClass28_2.K9dSismFf1X = _003C_003Ec__DisplayClass28_;
		int num;
		switch (_003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.ProcessFailedKind)
		{
		default:
			_003C_003Ec__DisplayClass28_2.siESiGha8fP = new StringBuilder();
			_003C_003Ec__DisplayClass28_2.siESiGha8fP.AppendLine($"Process kind: {_003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.ProcessFailedKind}");
			_003C_003Ec__DisplayClass28_2.siESiGha8fP.AppendLine($"Reason: {_003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.Reason}");
			_003C_003Ec__DisplayClass28_2.siESiGha8fP.AppendLine($"Exit code: {_003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.ExitCode}");
			num = 1;
			if (A3h0wiFo7kvCKbQjkB8C())
			{
				goto IL_012d;
			}
			goto IL_013b;
		case CoreWebView2ProcessFailedKind.BrowserProcessExited:
			v7WLpqcFR5N(webView);
			goto case CoreWebView2ProcessFailedKind.RenderProcessUnresponsive;
		case CoreWebView2ProcessFailedKind.RenderProcessUnresponsive:
			SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass28_2.K9dSismFf1X.MOUSieMK5SJ, null);
			num = 0;
			if (vWKTdkFoCrrvU3nAPSyd != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_012d;
		case CoreWebView2ProcessFailedKind.FrameRenderProcessExited:
		{
			using (IEnumerator<CoreWebView2FrameInfo> enumerator = _003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.FrameInfosForFailedProcess.GetEnumerator())
			{
				do
				{
					if (!enumerator.MoveNext())
					{
						return;
					}
				}
				while (!U1WLp6u4RqG(new Uri(enumerator.Current.Source)));
			}
			break;
		}
		case CoreWebView2ProcessFailedKind.RenderProcessExited:
			break;
			IL_013b:
			_003C_003Ec__DisplayClass28_2.siESiGha8fP.AppendLine("Process description: " + _003C_003Ec__DisplayClass28_2.K9dSismFf1X.aNfSiWDwStL.ProcessDescription);
			SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass28_2.SmESiku5yXv, null);
			return;
			IL_012d:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto IL_013b;
		}
		SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass28_2.K9dSismFf1X.syDSiYUBus5, null);
	}

	private void v7WLpqcFR5N(WebView2 webView2_0)
	{
		Layout.Children.Remove(webView2_0);
		aKKLpjLpssq = false;
	}

	private void EmmLpcjtuVd(WebView2 webView2_0)
	{
		Layout.Children.Add(webView2_0);
		aKKLpjLpssq = true;
	}

	private void pn2LpVWSpu3()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	private void pwELpZ8pLBm(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
	}

	private void safLp9cF0X0(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			webView.CoreWebView2.Navigate(string_0);
		}
	}

	private void xYGLphxYrgS(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoBack;
	}

	private void QSaLpeyqmR9(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoBack();
	}

	private void eZELpYXcmho(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoForward;
	}

	private void cuuLpIoqLam(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoForward();
	}

	private void NTKLpWfUNSl(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = Ys8LpHnGll6() && !bK5LpxSFEOc;
	}

	private void YlgLpkkGfmL(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Reload();
	}

	private void bfBLpGCKXDb(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = Ys8LpHnGll6() && bK5LpxSFEOc;
	}

	private void OVWLpssWAYq(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Stop();
	}

	private bool Ys8LpHnGll6()
	{
		try
		{
			return webView != null && webView.CoreWebView2 != null;
		}
		catch (Exception ex) when (ex is ObjectDisposedException || ex is InvalidOperationException)
		{
			return false;
		}
	}

	private void GUqLp17vWQn(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && !bK5LpxSFEOc;
	}

	[AsyncStateMachine(typeof(_003CGoToPageCmdExecuted_003Ed__45))]
	private void Ne3LpbabbHf(object sender, ExecutedRoutedEventArgs e)
	{
		_003CGoToPageCmdExecuted_003Ed__45 stateMachine = default(_003CGoToPageCmdExecuted_003Ed__45);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!IDWLpnDJSyl)
		{
			IDWLpnDJSyl = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/webview2wrapper.xaml", UriKind.Relative);
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
			IDWLpnDJSyl = true;
			break;
		case 1:
			((CommandBinding)target).CanExecute += xYGLphxYrgS;
			((CommandBinding)target).Executed += QSaLpeyqmR9;
			break;
		case 2:
		{
			((CommandBinding)target).CanExecute += eZELpYXcmho;
			int num = 0;
			if (vWKTdkFoCrrvU3nAPSyd != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				((CommandBinding)target).Executed += cuuLpIoqLam;
				break;
			}
			break;
		}
		case 3:
			((CommandBinding)target).CanExecute += NTKLpWfUNSl;
			((CommandBinding)target).Executed += YlgLpkkGfmL;
			break;
		case 4:
			((CommandBinding)target).CanExecute += bfBLpGCKXDb;
			((CommandBinding)target).Executed += OVWLpssWAYq;
			break;
		case 5:
			((CommandBinding)target).CanExecute += GUqLp17vWQn;
			((CommandBinding)target).Executed += Ne3LpbabbHf;
			break;
		case 6:
			ToolbarWrapper = (DockPanel)target;
			break;
		case 7:
			url = (TextBox)target;
			break;
		case 8:
			Layout = (Grid)target;
			break;
		case 9:
			webView = (WebView2)target;
			break;
		}
	}

	static WebView2Wrapper()
	{
		bVRLpK3DDRV = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static bool U1WLp6u4RqG(Uri uri_0)
	{
		return uri_0.Host == "appassets.example";
	}

	internal static bool A3h0wiFo7kvCKbQjkB8C()
	{
		return vWKTdkFoCrrvU3nAPSyd == null;
	}
}
