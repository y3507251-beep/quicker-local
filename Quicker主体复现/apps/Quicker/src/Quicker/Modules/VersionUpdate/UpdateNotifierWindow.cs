using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using log4net;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Account;
using Quicker.View.Controls;
using upLrfmibGdtSX9dWuOT;
using vWqIxxMqTcYJW8kXilN;

namespace Quicker.Modules.VersionUpdate;

public class UpdateNotifierWindow : Window, IComponentConnector
{


	private readonly bool DpNABw6HeT;

	[CompilerGenerated]
	private readonly string dgeAQbWIWe;

	[CompilerGenerated]
	private readonly string ru1AjuQlpp;

	[CompilerGenerated]
	private readonly string Y34AnKasr1;

	[CompilerGenerated]
	private string KAeA4nf7ZC;

	[CompilerGenerated]
	private bool kFxA5M5fcq;

	private static readonly ILog KVnAD7FUGt;

	private WebView2Wrapper yGfAdosJfq;

	private bool cbpAolrKgj;

	private string p7wATGAFLq = "";

	internal TextBlock LblSummary;

	internal TextBlock LblCurrVersion;

	internal StackPanel pnlNewVersion;

	internal Hyperlink LnkSlowVersion;

	internal TextBlock LblSlowVersion;

	internal Button BtnDownload;

	internal Hyperlink LnkFastVersion;

	internal TextBlock LblFastChannelVersion;

	internal Button BtnDownloadFast;

	internal Hyperlink LnkPreviewVersion;

	internal TextBlock LblPreviewChannelVersion;

	internal Button BtnDownloadPreview;

	internal ProgressBar ProgressBar;

	internal Border BrowserWrapper;

	internal WebBrowser Browser;

	private bool cbNAMBGQsU;

	internal static UpdateNotifierWindow KhAd8uHrQcUyREjFLdD;

	public string SlowVersion
	{
		[CompilerGenerated]
		get
		{
			return dgeAQbWIWe;
		}
	}

	public string FastVersion
	{
		[CompilerGenerated]
		get
		{
			return ru1AjuQlpp;
		}
	}

	public string PreviewChanelVersion
	{
		[CompilerGenerated]
		get
		{
			return Y34AnKasr1;
		}
	}

	public string CurrVersion
	{
		[CompilerGenerated]
		get
		{
			return KAeA4nf7ZC;
		}
		[CompilerGenerated]
		set
		{
			KAeA4nf7ZC = value;
		}
	}

	public bool IsFastChannel
	{
		[CompilerGenerated]
		get
		{
			return kFxA5M5fcq;
		}
		[CompilerGenerated]
		set
		{
			kFxA5M5fcq = value;
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

	public UpdateNotifierWindow(AppVersionInfo appVersionInfo, bool isManualCheckUpdate)
	{
		if (isManualCheckUpdate)
		{
			base.Title = "检查版本更新";
		}
		DpNABw6HeT = isManualCheckUpdate;
		dgeAQbWIWe = appVersionInfo.LastVersion;
		ru1AjuQlpp = appVersionInfo.FastChannelVersion;
		Y34AnKasr1 = appVersionInfo.PreviewChanelVersion;
		CurrVersion = AppHelper.GetCurrAppVersion();
		IsFastChannel = SoftVersionHelper.IsOnFastChannel();
		InitializeComponent();
		base.Loaded += WtrAs9fpB6;
		LblCurrVersion.Text = SoftVersionHelper.GetShortVersionString(CurrVersion);
		LblSlowVersion.Text = SoftVersionHelper.GetShortVersionString(SlowVersion);
		LblFastChannelVersion.Text = SoftVersionHelper.GetShortVersionString(FastVersion);
		LblPreviewChannelVersion.Text = SoftVersionHelper.GetShortVersionString(PreviewChanelVersion);
		if (SoftVersionHelper.IsVersionNewer(SlowVersion, CurrVersion))
		{
			BtnDownload.Visibility = Visibility.Visible;
			LblSlowVersion.FontWeight = FontWeights.Bold;
		}
		else
		{
			BtnDownload.Visibility = Visibility.Collapsed;
		}
		if (SoftVersionHelper.IsVersionNewer(FastVersion, CurrVersion))
		{
			BtnDownloadFast.Visibility = Visibility.Visible;
			LblFastChannelVersion.FontWeight = FontWeights.Bold;
		}
		else
		{
			BtnDownloadFast.Visibility = Visibility.Collapsed;
		}
		if (SoftVersionHelper.IsVersionNewer(PreviewChanelVersion, CurrVersion))
		{
			BtnDownloadPreview.Visibility = Visibility.Visible;
			LblPreviewChannelVersion.FontWeight = FontWeights.Bold;
		}
		else
		{
			BtnDownloadPreview.Visibility = Visibility.Collapsed;
		}
		if (SlowVersion == FastVersion)
		{
			BtnDownloadFast.Visibility = Visibility.Collapsed;
		}
		if (FastVersion == PreviewChanelVersion)
		{
			BtnDownloadPreview.Visibility = Visibility.Collapsed;
		}
		base.Closed += dDQAGawUGK;
	}

	private void dDQAGawUGK(object sender, EventArgs e)
	{
		Browser.Navigated -= wDWAbnl9LW;
		Browser.Navigating -= DE6A1JJxQF;
		Browser.Dispose();
	}

	private void WtrAs9fpB6(object sender, RoutedEventArgs e)
	{
		try
		{
			int num;
			string text2 = default(string);
			if (!SoftVersionHelper.IsVersionNewer(SlowVersion, CurrVersion) && !SoftVersionHelper.IsVersionNewer(FastVersion, CurrVersion))
			{
				BrowserWrapper.Visibility = Visibility.Collapsed;
				LblSummary.Foreground = Brushes.OrangeRed;
				LblSummary.Text = "暂无新版本。";
				num = 0;
				if (KhAd8uHrQcUyREjFLdD != null)
				{
					goto IL_00f2;
				}
			}
			else
			{
				LblSummary.Foreground = Brushes.Green;
				LblSummary.Text = "有新版本可以升级！";
				string text = (IsFastChannel ? FastVersion : SlowVersion);
				text2 = "about:blank";
				if (!V1kWZri8vrLTHgNDH0k.kthvSy0kT0j())
				{
					Browser.Navigate(text2);
					return;
				}
				yGfAdosJfq = new WebView2Wrapper();
				num = 1;
				if (KhAd8uHrQcUyREjFLdD != null)
				{
					goto IL_00f2;
				}
			}
			goto IL_00f6;
			IL_00f2:
			int num2 = default(int);
			num = num2;
			goto IL_00f6;
			IL_00f6:
			switch (num)
			{
			case 1:
				yGfAdosJfq.ShowToolbar = false;
				BrowserWrapper.Child = yGfAdosJfq;
				yGfAdosJfq.Source = new Uri(text2);
				break;
			case 0:
				break;
			}
		}
		catch (Exception ex)
		{
			KVnAD7FUGt.Warn(ex.Message, ex);
			AppHelper.ShowWarning("加载控件异常：" + ex.Message);
		}
	}

	private void SgjAHgjTjP(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void DE6A1JJxQF(object sender, NavigatingCancelEventArgs e)
	{
		if (!cbpAolrKgj)
		{
			cbpAolrKgj = true;
			return;
		}
		e.Cancel = true;
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = e.Uri.ToString()
		};
		try
		{
			Process.Start(startInfo);
		}
		catch (Exception exception)
		{
			KVnAD7FUGt.Warn("无法使用Windows默认浏览器打开网址。", exception);
			AppHelper.ShowWarning("无法使用Windows默认浏览器打开网址。请检查您电脑的默认浏览器设置是否正常。");
		}
	}

	private void wDWAbnl9LW(object sender, NavigationEventArgs e)
	{
		ExternalLoginWindow.SetSilent(Browser, true);
	}

	private void scGA6mFuhN(object sender, RoutedEventArgs e)
	{
		DZ8AKb8KD8(PreviewChanelVersion);
	}

	private void gnLAX2Oscb(object sender, RoutedEventArgs e)
	{
		DZ8AKb8KD8(SlowVersion);
	}

	private void cm2Amty2yy(object sender, RoutedEventArgs e)
	{
		DZ8AKb8KD8(FastVersion);
	}

	private void DZ8AKb8KD8(string string_5)
	{
		AppHelper.ShowWarning("请到本项目 GitHub Releases 手动下载和安装新版本。");
	}




	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!cbNAMBGQsU)
		{
			cbNAMBGQsU = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/versionupdate/updatenotifierwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 5:
				LblSlowVersion = (TextBlock)target;
				num2 = 2;
				if (KhAd8uHrQcUyREjFLdD != null)
				{
					goto IL_0024;
				}
				goto IL_0028;
			default:
				num2 = 0;
				if (!sVmbBKHN7rCFvAojNIm())
				{
					goto IL_0024;
				}
				goto IL_0028;
			case 1:
				LblSummary = (TextBlock)target;
				return;
			case 2:
				LblCurrVersion = (TextBlock)target;
				return;
			case 3:
				pnlNewVersion = (StackPanel)target;
				return;
			case 4:
				LnkSlowVersion = (Hyperlink)target;
				return;
			case 6:
				BtnDownload = (Button)target;
				BtnDownload.Click += gnLAX2Oscb;
				return;
			case 7:
				LnkFastVersion = (Hyperlink)target;
				return;
			case 8:
				LblFastChannelVersion = (TextBlock)target;
				return;
			case 9:
				BtnDownloadFast = (Button)target;
				BtnDownloadFast.Click += cm2Amty2yy;
				return;
			case 10:
				LnkPreviewVersion = (Hyperlink)target;
				return;
			case 11:
				LblPreviewChannelVersion = (TextBlock)target;
				return;
			case 12:
				BtnDownloadPreview = (Button)target;
				BtnDownloadPreview.Click += scGA6mFuhN;
				return;
			case 13:
				ProgressBar = (ProgressBar)target;
				return;
			case 14:
				((Button)target).Click += SgjAHgjTjP;
				return;
			case 15:
				BrowserWrapper = (Border)target;
				return;
			case 16:
				{
					Browser = (WebBrowser)target;
					Browser.Navigated += wDWAbnl9LW;
					Browser.Navigating += DE6A1JJxQF;
					return;
				}
				IL_0024:
				num2 = num;
				goto IL_0028;
				IL_0028:
				switch (num2)
				{
				case 1:
					break;
				default:
					cbNAMBGQsU = true;
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}

	static UpdateNotifierWindow()
	{
		KVnAD7FUGt = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool sVmbBKHN7rCFvAojNIm()
	{
		return KhAd8uHrQcUyREjFLdD == null;
	}
}
