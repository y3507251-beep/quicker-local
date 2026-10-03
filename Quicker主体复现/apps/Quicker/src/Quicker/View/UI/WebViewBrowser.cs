using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Media.Imaging;
using log4net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json.Linq;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using upLrfmibGdtSX9dWuOT;

namespace Quicker.View.UI;

public class WebViewBrowser : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public WebViewBrowser oqJSDcx6SYT;

		public CoreWebView2ProcessFailedEventArgs I1SSDVm9jYG;

		private static _003C_003Ec__DisplayClass22_0 BOd6i0WTzHoSVThMmMM2;

		internal void seLSDaqKO4s(CoreWebView2ProcessFailedKind kind)
		{
			string caption;
			string messageBoxText;
			if (kind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
			{
				caption = "Browser process exited";
				int num = 0;
				if (BOd6i0WTzHoSVThMmMM2 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				messageBoxText = "WebView2 Runtime's browser process exited unexpectedly. Recreate WebView?";
			}
			else
			{
				caption = "Web page unresponsive";
				messageBoxText = "WebView2 Runtime's render process stopped responding. Recreate WebView?";
			}
			if (MessageBoxHelper.Show(messageBoxText, caption, MessageBoxButton.YesNo) != MessageBoxResult.Yes)
			{
				return;
			}
			if (oqJSDcx6SYT.DLmLaYchGIw)
			{
				oqJSDcx6SYT.n8RLagrgbdy(oqJSDcx6SYT.webView);
			}
			try
			{
				if (!AppState.sD1t7gME9aw())
				{
					oqJSDcx6SYT.webView.Dispose();
				}
			}
			catch (Exception ex)
			{
				laTLaV2Au8A.Warn("Dispose WebView出错：" + ex.Message, ex);
			}
			oqJSDcx6SYT.webView = oqJSDcx6SYT.u9VLawYM0bP(false);
			oqJSDcx6SYT.HBILaLIij4Y(oqJSDcx6SYT.webView);
		}

		internal void PiOSD7mbrvX(CoreWebView2ProcessFailedKind kind)
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
			if (MessageBoxHelper.Show(messageBoxText, caption, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				oqJSDcx6SYT.webView.Reload();
			}
		}

		internal void jhkSDRhhLhQ(object _)
		{
			seLSDaqKO4s(I1SSDVm9jYG.ProcessFailedKind);
		}

		internal void MQ3SDqQYIco(object _)
		{
			PiOSD7mbrvX(I1SSDVm9jYG.ProcessFailedKind);
		}

		internal static bool Jp2tldWmVc1VLh2A9YW7()
		{
			return BOd6i0WTzHoSVThMmMM2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_1
	{
		public StringBuilder DQWSD9PCGqS;

		internal static _003C_003Ec__DisplayClass22_1 XGaMclWmFFrVKF7ccoHo;

		internal void b9KSDZrtKZU(object _)
		{
			MessageBoxHelper.Show(DQWSD9PCGqS.ToString(), "Child process failed");
		}

		internal static bool CMqpvgWmctaUXLJs0F7e()
		{
			return XGaMclWmFFrVKF7ccoHo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCoreWebView2OnFaviconChanged_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebViewBrowser _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		internal static object ExhAlaWmyTw5d0Mff2uG;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebViewBrowser webViewBrowser = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Stream> awaiter;
					if (num != 0)
					{
						awaiter = webViewBrowser.webView.CoreWebView2.GetFaviconAsync(CoreWebView2FaviconImageFormat.Png).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Stream>);
						num = -1;
						_003C_003E1__state = -1;
					}
					Stream result = awaiter.GetResult();
					if (result != null && result.Length != 0L)
					{
						webViewBrowser.Icon = BitmapFrame.Create(result);
					}
					else
					{
						webViewBrowser.Icon = null;
						if (wSE4ERWmpS0LAMBVeimW())
						{
							switch (0)
							{
							}
						}
					}
				}
				catch (Exception ex)
				{
					laTLaV2Au8A.Warn("设置图标出错：" + ex.Message + " uri:" + webViewBrowser.webView.CoreWebView2?.FaviconUri, ex);
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

		internal static bool wSE4ERWmpS0LAMBVeimW()
		{
			return ExhAlaWmyTw5d0Mff2uG == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToPageCmdExecuted_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExecutedRoutedEventArgs e;

		public WebViewBrowser _003C_003E4__this;

		internal static object IFdww9Wm2a8PmNsg0oy4;

		private void MoveNext()
		{
			WebViewBrowser webViewBrowser = _003C_003E4__this;
			try
			{
				try
				{
					string text = (string)e.Parameter;
					Uri uri = null;
					if (IFdww9Wm2a8PmNsg0oy4 == null)
					{
						switch (0)
						{
						}
					}
					uri = (Uri.IsWellFormedUriString(text, UriKind.Absolute) ? new Uri(text) : ((text.Contains(" ") || !text.Contains(".")) ? new Uri("https://bing.com/search?q=" + string.Join("+", Uri.EscapeDataString(text).Split(new string[1] { "%20" }, StringSplitOptions.RemoveEmptyEntries))) : new Uri("http://" + text)));
					webViewBrowser.webView.CoreWebView2.Navigate(uri.ToString());
				}
				catch (Exception ex)
				{
					laTLaV2Au8A.Warn("GoToPageCmdExecuted出错：" + ex.Message, ex);
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

		internal static bool csn83AWmAaD4l6ER0IZ0()
		{
			return IFdww9Wm2a8PmNsg0oy4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebViewBrowser _003C_003E4__this;

		public string url;

		private TaskAwaiter _003C_003Eu__1;

		internal static object FmyxsAWmDmQkWNk1t0if;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebViewBrowser webViewBrowser = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					int num2;
					if (num != 0)
					{
						webViewBrowser.webView.CreationProperties = V1kWZri8vrLTHgNDH0k.y0qvSaX2h6Z();
						awaiter = webViewBrowser.webView.EnsureCoreWebView2Async(null, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						num2 = 0;
						if (YOVnq2Wm3WoVQwLIiR0E())
						{
							goto IL_0096;
						}
					}
					goto IL_00bd;
					IL_0096:
					switch (num2)
					{
					case 1:
						goto end_IL_0011;
					}
					goto IL_00bd;
					IL_00bd:
					awaiter.GetResult();
					webViewBrowser.webView.CoreWebView2.NewWindowRequested += webViewBrowser.m65L8OCtZZE;
					webViewBrowser.webView.CoreWebView2.WindowCloseRequested += webViewBrowser.BSUL8AA7lpS;
					webViewBrowser.webView.CoreWebView2.ContainsFullScreenElementChanged += webViewBrowser.dcnL8MmfTVB;
					webViewBrowser.webView.CoreWebView2.DocumentTitleChanged += webViewBrowser.bosL8TNvNx5;
					webViewBrowser.webView.CoreWebView2.FaviconChanged += webViewBrowser.FHZL8obydp2;
					webViewBrowser.webView.CoreWebView2.WebMessageReceived += webViewBrowser.GFjL8fbT7Un;
					if (webViewBrowser.webView.CoreWebView2 == null)
					{
						AppWindowManager.ShowWebViewInstaller();
						num2 = 1;
						if (!YOVnq2Wm3WoVQwLIiR0E())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_0096;
					}
					webViewBrowser.EIQLaSQtfZB(url);
					end_IL_0011:;
				}
				catch (Exception exception)
				{
					laTLaV2Au8A.Error("初始化WebView2组件失败。", exception);
					AppHelper.ShowWarning("无法初始化WebView2组件。\r\n" + exception.GetMessageWithInner(), true);
					AppHelper.RunOnUiThread(false, webViewBrowser.vN7La7vgsEM);
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

		internal static bool YOVnq2Wm3WoVQwLIiR0E()
		{
			return FmyxsAWmDmQkWNk1t0if == null;
		}
	}

	private static readonly ILog laTLaV2Au8A;

	private bool YBrLaZvr48e;

	private CoreWebView2Environment DwALa9dwGTb;

	private bool tvvLahZ7EcS = true;

	private bool JxMLae15nEw;

	private bool DLmLaYchGIw = true;

	internal TextBox url;

	internal Grid Layout;

	internal WebView2 webView;

	private bool oM0LaIScjYu;

	private static WebViewBrowser pcRkkCF0yfBrOdmp1owa;

	[SpecialName]
	private CoreWebView2Environment IcCLaqGqwTc()
	{
		if (DwALa9dwGTb == null && webView?.CoreWebView2 != null)
		{
			DwALa9dwGTb = webView.CoreWebView2.Environment;
		}
		return DwALa9dwGTb;
	}

	public WebViewBrowser(string url)
	{
		InitializeComponent();
		iaoL8dgpabm(url);
	}

	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__6))]
	private void iaoL8dgpabm(string string_0)
	{
		_003CInitializeAsync_003Ed__6 stateMachine = default(_003CInitializeAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CCoreWebView2OnFaviconChanged_003Ed__7))]
	private void FHZL8obydp2(object object_0, object object_1)
	{
		_003CCoreWebView2OnFaviconChanged_003Ed__7 stateMachine = default(_003CCoreWebView2OnFaviconChanged_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void bosL8TNvNx5(object object_0, object object_1)
	{
		base.Title = webView.CoreWebView2.DocumentTitle;
	}

	private void dcnL8MmfTVB(object object_0, object object_1)
	{
		if (webView.CoreWebView2.ContainsFullScreenElement)
		{
			base.WindowState = WindowState.Maximized;
			base.WindowStyle = WindowStyle.None;
			base.ResizeMode = ResizeMode.NoResize;
		}
		else
		{
			base.WindowState = WindowState.Normal;
			base.WindowStyle = WindowStyle.SingleBorderWindow;
			base.ResizeMode = ResizeMode.CanResize;
		}
	}

	private void BSUL8AA7lpS(object object_0, object object_1)
	{
		Close();
	}

	private void m65L8OCtZZE(object sender, CoreWebView2NewWindowRequestedEventArgs e)
	{
		if (e.Uri.StartsWith("http", StringComparison.OrdinalIgnoreCase) && e.Uri.IndexOf("ext=true", StringComparison.OrdinalIgnoreCase) > 0)
		{
			e.Handled = true;
			AppHelper.TryOpenUrlOrFile(e.Uri);
		}
	}

	private void tSyL8FU0lhx(WebView2 webView2_0)
	{
		webView2_0.NavigationStarting += iWML8UF9QeH;
		webView2_0.NavigationCompleted += mTNL8lIECpg;
		webView2_0.CoreWebView2InitializationCompleted += at7L839vsgG;
	}

	private void iWML8UF9QeH(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		YBrLaZvr48e = true;
		SXiLavU3Xvt();
	}

	private void mTNL8lIECpg(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		YBrLaZvr48e = false;
		SXiLavU3Xvt();
	}

	private void O8hL8iAMjYp(object object_0, object object_1)
	{
		base.Title = webView.CoreWebView2.DocumentTitle;
	}

	private void at7L839vsgG(object sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			webView.CoreWebView2.ProcessFailed += mE5LatGsRyU;
			webView.CoreWebView2.DocumentTitleChanged += O8hL8iAMjYp;
			if (tvvLahZ7EcS)
			{
				try
				{
					IcCLaqGqwTc().BrowserProcessExited += Wr9L8zuMu5l;
				}
				catch (NotImplementedException)
				{
				}
				tvvLahZ7EcS = false;
			}
		}
		else
		{
			MessageBoxHelper.Show($"WebView2 creation failed with exception = {e.InitializationException}");
		}
	}

	private void GFjL8fbT7Un(object sender, CoreWebView2WebMessageReceivedEventArgs e)
	{
		try
		{
			if (JObject.Parse(e.WebMessageAsJson)["op"]?.Value<string>() == "close")
			{
				Close();
			}
		}
		catch (Exception ex)
		{
			laTLaV2Au8A.Warn("处理网页消息出错：" + ex.Message + " 消息内容：" + e.WebMessageAsJson, ex);
			AppHelper.ShowWarning("处理网页消息出错：" + ex.Message);
		}
	}

	private void Wr9L8zuMu5l(object sender, CoreWebView2BrowserProcessExitedEventArgs e)
	{
		if (e.BrowserProcessExitKind != CoreWebView2BrowserProcessExitKind.Failed && JxMLae15nEw)
		{
			DwALa9dwGTb = null;
			webView = u9VLawYM0bP(true);
			HBILaLIij4Y(webView);
			JxMLae15nEw = false;
		}
	}

	private WebView2 u9VLawYM0bP(bool bool_5)
	{
		WebView2 webView = new WebView2();
		((ISupportInitialize)webView).BeginInit();
		if (bool_5)
		{
			if (pcRkkCF0yfBrOdmp1owa == null)
			{
				switch (0)
				{
				}
			}
			webView.CreationProperties = new CoreWebView2CreationProperties();
			webView.CreationProperties.BrowserExecutableFolder = this.webView.CreationProperties.BrowserExecutableFolder;
			webView.CreationProperties.Language = this.webView.CreationProperties.Language;
			webView.CreationProperties.UserDataFolder = this.webView.CreationProperties.UserDataFolder;
			tvvLahZ7EcS = true;
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
		tSyL8FU0lhx(webView);
		webView.Source = this.webView.Source ?? new Uri("https://www.bing.com");
		((ISupportInitialize)webView).EndInit();
		return webView;
	}

	private void mE5LatGsRyU(object sender, CoreWebView2ProcessFailedEventArgs e)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.oqJSDcx6SYT = this;
		if (pcRkkCF0yfBrOdmp1owa == null)
		{
			switch (1)
			{
			case 1:
				break;
			default:
				goto IL_0114;
			}
		}
		_003C_003Ec__DisplayClass22_.I1SSDVm9jYG = e;
		_003C_003Ec__DisplayClass22_1 _003C_003Ec__DisplayClass22_2 = new _003C_003Ec__DisplayClass22_1();
		switch (_003C_003Ec__DisplayClass22_.I1SSDVm9jYG.ProcessFailedKind)
		{
		default:
			_003C_003Ec__DisplayClass22_2.DQWSD9PCGqS = new StringBuilder();
			_003C_003Ec__DisplayClass22_2.DQWSD9PCGqS.AppendLine($"Process kind: {_003C_003Ec__DisplayClass22_.I1SSDVm9jYG.ProcessFailedKind}");
			_003C_003Ec__DisplayClass22_2.DQWSD9PCGqS.AppendLine($"Reason: {_003C_003Ec__DisplayClass22_.I1SSDVm9jYG.Reason}");
			_003C_003Ec__DisplayClass22_2.DQWSD9PCGqS.AppendLine($"Exit code: {_003C_003Ec__DisplayClass22_.I1SSDVm9jYG.ExitCode}");
			_003C_003Ec__DisplayClass22_2.DQWSD9PCGqS.AppendLine("Process description: " + _003C_003Ec__DisplayClass22_.I1SSDVm9jYG.ProcessDescription);
			SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass22_2.b9KSDZrtKZU, null);
			return;
		case CoreWebView2ProcessFailedKind.BrowserProcessExited:
			break;
		case CoreWebView2ProcessFailedKind.RenderProcessUnresponsive:
			goto IL_0120;
		case CoreWebView2ProcessFailedKind.FrameRenderProcessExited:
		{
			using (IEnumerator<CoreWebView2FrameInfo> enumerator = _003C_003Ec__DisplayClass22_.I1SSDVm9jYG.FrameInfosForFailedProcess.GetEnumerator())
			{
				do
				{
					if (!enumerator.MoveNext())
					{
						return;
					}
				}
				while (!W8WLaRarVkD(new Uri(enumerator.Current.Source)));
			}
			goto case CoreWebView2ProcessFailedKind.RenderProcessExited;
		}
		case CoreWebView2ProcessFailedKind.RenderProcessExited:
			SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass22_.MQ3SDqQYIco, null);
			return;
		}
		goto IL_0114;
		IL_0120:
		SynchronizationContext.Current.Post(_003C_003Ec__DisplayClass22_.jhkSDRhhLhQ, null);
		return;
		IL_0114:
		n8RLagrgbdy(webView);
		goto IL_0120;
	}

	private void n8RLagrgbdy(WebView2 webView2_0)
	{
		Layout.Children.Remove(webView2_0);
		DLmLaYchGIw = false;
	}

	private void HBILaLIij4Y(WebView2 webView2_0)
	{
		Layout.Children.Add(webView2_0);
		DLmLaYchGIw = true;
	}

	private void SXiLavU3Xvt()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	private void EIQLaSQtfZB(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			webView.CoreWebView2.Navigate(string_0);
		}
	}

	private void xNXLa2P50Hg(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoBack;
	}

	private void FPZLauHCiyU(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoBack();
	}

	private void ymmLaNIvv88(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && webView.CanGoForward;
	}

	private void j4tLaJK4yJe(object sender, ExecutedRoutedEventArgs e)
	{
		webView.GoForward();
	}

	private void zb3La0ileR4(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = qkVLaybQl1l() && !YBrLaZvr48e;
	}

	private void Jr1LaCEEHCh(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Reload();
	}

	private void qHkLaPIZyEI(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = qkVLaybQl1l() && YBrLaZvr48e;
	}

	private void cO0LaEHk5R1(object sender, ExecutedRoutedEventArgs e)
	{
		webView.Stop();
	}

	private bool qkVLaybQl1l()
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

	private void libLa8r8jcg(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = webView != null && !YBrLaZvr48e;
	}

	[AsyncStateMachine(typeof(_003CGoToPageCmdExecuted_003Ed__38))]
	private void gSfLaaCOnBV(object sender, ExecutedRoutedEventArgs e)
	{
		_003CGoToPageCmdExecuted_003Ed__38 stateMachine = default(_003CGoToPageCmdExecuted_003Ed__38);
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
		if (!oM0LaIScjYu)
		{
			oM0LaIScjYu = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/webviewbrowser.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			oM0LaIScjYu = true;
			break;
		case 1:
			((CommandBinding)target).CanExecute += xNXLa2P50Hg;
			((CommandBinding)target).Executed += FPZLauHCiyU;
			break;
		case 2:
		{
			((CommandBinding)target).CanExecute += ymmLaNIvv88;
			((CommandBinding)target).Executed += j4tLaJK4yJe;
			int num = 0;
			if (!dky6jZF0piMJsMa7FpJh())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 3:
			((CommandBinding)target).CanExecute += zb3La0ileR4;
			((CommandBinding)target).Executed += Jr1LaCEEHCh;
			break;
		case 4:
			((CommandBinding)target).CanExecute += qHkLaPIZyEI;
			((CommandBinding)target).Executed += cO0LaEHk5R1;
			break;
		case 5:
			((CommandBinding)target).CanExecute += libLa8r8jcg;
			((CommandBinding)target).Executed += gSfLaaCOnBV;
			break;
		case 6:
			url = (TextBox)target;
			break;
		case 7:
			Layout = (Grid)target;
			break;
		case 8:
			webView = (WebView2)target;
			break;
		}
	}

	static WebViewBrowser()
	{
		laTLaV2Au8A = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void vN7La7vgsEM()
	{
		Close();
	}

	[CompilerGenerated]
	internal static bool W8WLaRarVkD(Uri uri_0)
	{
		return uri_0.Host == "appassets.example";
	}

	internal static bool dky6jZF0piMJsMa7FpJh()
	{
		return pcRkkCF0yfBrOdmp1owa == null;
	}
}
