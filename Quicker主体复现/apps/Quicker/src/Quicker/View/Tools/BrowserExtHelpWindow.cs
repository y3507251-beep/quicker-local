using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using log4net;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using wRnoADYMWoP6pH6Uoa0;

namespace Quicker.View.Tools;

public class BrowserExtHelpWindow : Window, IComponentConnector
{
	private static readonly ILog lthLSu2cYot;

	internal TextBlock LblConnected;

	internal Button BtnRepairMessageHosts;

	internal Button BtnRefreshContextMenu;

	internal Button BtnChromeEnableMv2;

	internal Button BtnInstallChromeExt;

	internal TextBlock LblChromeBtn;

	internal Button BtnInstallEdgeExt;

	internal TextBlock LblEdgeBtn;

	private bool paSLSNo8lJp;

	internal static BrowserExtHelpWindow NLRD2FFnUwxI9LdZ1rFX;

	public BrowserExtHelpWindow()
	{
		InitializeComponent();
		base.Loaded += MesLSwTubqT;
	}

	private void MesLSwTubqT(object sender, RoutedEventArgs e)
	{
		if (BrowserExtensionHelper.ChromeInfo.IsInstalled())
		{
			LblChromeBtn.Text = "已安装";
			int num = 0;
			if (!L1bLVJFnxZoVHGQpgPqt())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			BtnInstallChromeExt.Foreground = Brushes.Green;
			BtnInstallChromeExt.IsEnabled = false;
		}
		if (BrowserExtensionHelper.EdgeInfo.IsInstalled())
		{
			LblEdgeBtn.Text = "已安装";
			BtnInstallEdgeExt.Foreground = Brushes.Green;
			BtnInstallEdgeExt.IsEnabled = false;
		}
		if (AppState.vjAt7Seco0Y() == null)
		{
			LblConnected.Text = "错误：浏览器服务启动异常";
			return;
		}
		LblConnected.Text = AppState.vjAt7Seco0Y().jlntGMKVuJL();
		if (!string.IsNullOrEmpty(LblConnected.Text))
		{
			LblConnected.FontWeight = FontWeights.Bold;
			LblConnected.Foreground = Brushes.Green;
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

	private void sDiLStAStIy(object sender, RoutedEventArgs e)
	{
		try
		{
			BrowserExtensionHelper.ChromeInfo.InstallExt();
			AppHelper.ShowSuccess("已写入注册表，请重启浏览器。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("写入注册表出错！" + ex.Message);
		}
	}

	private void TFuLSgk2gXV(object sender, RoutedEventArgs e)
	{
		try
		{
			BrowserExtensionHelper.InstallChromeMessageHost(true);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void iOLLSLZH2pp(object sender, RoutedEventArgs e)
	{
		try
		{
			BrowserExtensionHelper.EdgeInfo.InstallExt();
			AppHelper.ShowSuccess("已写入注册表，请重启浏览器。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("写入注册表出错！" + ex.Message);
		}
	}

	private void uyxLSv8F5u0(object sender, RoutedEventArgs e)
	{
		try
		{
			AppState.vjAt7Seco0Y().YyrtG5nkZFy(null);
		}
		catch (Exception ex)
		{
			lthLSu2cYot.Error("更新浏览器出错：" + ex.Message, ex);
			AppHelper.ShowWarning("更新浏览器出错：" + ex.Message);
		}
	}

	private void s2BLSSLACBr(object sender, MouseButtonEventArgs e)
	{
		LblConnected.Text = AppState.vjAt7Seco0Y().jlntGMKVuJL();
	}

	private void QckLS2Hk7qn(object sender, RoutedEventArgs e)
	{
		dGYI6iYYvlg2idKQBAd.QONLSJOMusv();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!paSLSNo8lJp)
		{
			paSLSNo8lJp = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/tools/browserexthelpwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 1:
				((TextBlock)target).PreviewMouseDown += s2BLSSLACBr;
				num2 = 2;
				if (NLRD2FFnUwxI9LdZ1rFX != null)
				{
					goto IL_002f;
				}
				goto IL_0033;
			default:
				num2 = 0;
				if (NLRD2FFnUwxI9LdZ1rFX != null)
				{
					goto IL_002f;
				}
				goto IL_0033;
			case 2:
				LblConnected = (TextBlock)target;
				LblConnected.PreviewMouseDown += s2BLSSLACBr;
				return;
			case 3:
				BtnRepairMessageHosts = (Button)target;
				BtnRepairMessageHosts.Click += TFuLSgk2gXV;
				return;
			case 4:
				BtnRefreshContextMenu = (Button)target;
				BtnRefreshContextMenu.Click += uyxLSv8F5u0;
				return;
			case 5:
				BtnChromeEnableMv2 = (Button)target;
				BtnChromeEnableMv2.Click += QckLS2Hk7qn;
				return;
			case 6:
				BtnInstallChromeExt = (Button)target;
				BtnInstallChromeExt.Click += sDiLStAStIy;
				return;
			case 7:
				LblChromeBtn = (TextBlock)target;
				return;
			case 8:
				BtnInstallEdgeExt = (Button)target;
				BtnInstallEdgeExt.Click += iOLLSLZH2pp;
				return;
			case 9:
				{
					LblEdgeBtn = (TextBlock)target;
					return;
				}
				IL_002f:
				num2 = num;
				goto IL_0033;
				IL_0033:
				switch (num2)
				{
				case 1:
					break;
				default:
					paSLSNo8lJp = true;
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}

	static BrowserExtHelpWindow()
	{
		lthLSu2cYot = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool L1bLVJFnxZoVHGQpgPqt()
	{
		return NLRD2FFnUwxI9LdZ1rFX == null;
	}
}
