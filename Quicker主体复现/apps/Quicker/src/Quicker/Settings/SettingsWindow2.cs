using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using bpNbEZj0vTDod37Z02B;
using c4LBdq5YohQFUgxFYw4;
using HandyControl.Controls;
using HandyControl.Tools;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.ScreenSelectLib;
using Quicker.Settings.Code;
using Quicker.Settings.Controls;
using Quicker.Settings.Controls2;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using ViNASxihuuLY1Gg9m6p;
using WcdJQYXW9E2moeWW9Np;
using Xceed.Wpf.Toolkit;

namespace Quicker.Settings;

public class SettingsWindow2 : HandyControl.Controls.Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public SettingPageId xmFvVJy4Z50;

		public Func<SettingPageInfo, bool> CpRvV0SN79q;

		internal static _003C_003Ec__DisplayClass24_0 vRsC9scNZeAVQEJgLnPW;

		internal bool vV3vVuxhM1w(SettingMenuItem m)
		{
			return m.Pages?.Any(CpRvV0SN79q ?? (CpRvV0SN79q = Jh2vVNyWVst)) ?? false;
		}

		internal bool Jh2vVNyWVst(SettingPageInfo x)
		{
			return x.Id == xmFvVJy4Z50;
		}

		internal static bool b4yCJrcN506KQb5aE3VG()
		{
			return vRsC9scNZeAVQEJgLnPW == null;
		}
	}

	[CompilerGenerated]
	private SettingPageId? ukKjaIyOtw;

	private CollectionView zXXj7mZ1VZ;

	private SettingMenuItem oENjRt894W;

	private bool G4sjqeVCtU;

	internal NavBar NavBar;

	internal SettingPageSearcherControl SearchControl;

	internal ListBox LbMenu;

	internal SettingDetailScreenControl DetailedContent;

	private bool TQhjcignQ1;

	private static SettingsWindow2 DnE5DTSjGbsoRaDJ26Y;

	public SettingPageId? _preloadPageId
	{
		[CompilerGenerated]
		get
		{
			return ukKjaIyOtw;
		}
		[CompilerGenerated]
		set
		{
			ukKjaIyOtw = value;
		}
	}

	public SettingPageId? CurrentSettingPageId => DetailedContent?.CurrentPage?.Id;

	public SettingsWindow2(SettingPageId? preloadPageId = null)
	{
		_preloadPageId = preloadPageId;
		if (!_preloadPageId.HasValue && AppState.HHxtaMaoqJr().RememberLastConfigPage && dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf().HasValue)
		{
			_preloadPageId = dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf().Value;
		}
		if (!_preloadPageId.HasValue)
		{
			_preloadPageId = SettingPageId.BasicInfo;
		}
		InitializeComponent();
		base.Closing += vuvjubZ0tZ;
		base.Closed += S3mjNVVeKX;
		base.Loaded += cUXj2lg722;
		base.SourceInitialized += cT6jvNXbR5;
		MpejLh9kar();
		D90jJxXuxK();
		if (!string.IsNullOrEmpty(uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().xYZtBfrZKOG()))
		{
			NavBar.SetAvatar(uT4WJujEfNmOl8aWJJC.k25tkYhXNMI().xYZtBfrZKOG());
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

	static SettingsWindow2()
	{
		EventManager.RegisterClassHandler(typeof(Xceed.Wpf.Toolkit.ColorPicker), UIElement.MouseRightButtonDownEvent, new RoutedEventHandler(ASWjgs66cj));
	}

	private static void ASWjgs66cj(object sender, RoutedEventArgs e)
	{
		if (sender is Xceed.Wpf.Toolkit.ColorPicker colorPicker)
		{
			qsQtMm5MtHtoYi1dcdV qsQtMm5MtHtoYi1dcdV = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
			if (qsQtMm5MtHtoYi1dcdV.IsSuccess)
			{
				colorPicker.SelectedColor = qsQtMm5MtHtoYi1dcdV.wZFmIfirit().ToMediaColor();
			}
		}
	}

	private void MpejLh9kar()
	{
		RoutedCommand routedCommand = new RoutedCommand();
		routedCommand.InputGestures.Add(new KeyGesture(Key.F, ModifierKeys.Control));
		base.CommandBindings.Add(new CommandBinding(routedCommand, eq5jyKE06t));
	}

	private void cT6jvNXbR5(object sender, EventArgs e)
	{
		sQQjS7hyDA();
	}

	private void sQQjS7hyDA()
	{
		IHNRIiikxBwJdYmHpM3.i9avv3X72RU(this.GetHandle(), 1200.0, 900.0, 0.8, 0.85);
	}

	private void cUXj2lg722(object sender, RoutedEventArgs e)
	{
		base.Loaded -= cUXj2lg722;
		SearchControl.SetFocus();
		base.Dispatcher.InvokeAsync(VhLj8Hg3j0);
	}

	private void vuvjubZ0tZ(object sender, CancelEventArgs e)
	{
		if (DetailedContent.Visibility == Visibility.Visible && !DetailedContent.UnloadSettingPage())
		{
			e.Cancel = true;
		}
	}

	private void S3mjNVVeKX(object sender, EventArgs e)
	{
		zXXj7mZ1VZ.Filter = null;
		LbMenu.ItemsSource = null;
		this.ClearAllBindings();
	}

	private void D90jJxXuxK()
	{
		zXXj7mZ1VZ = CollectionViewSource.GetDefaultView(SettingsMenuProvider.MenuItems) as CollectionView;
		if (zXXj7mZ1VZ == null)
		{
			zXXj7mZ1VZ = new CollectionView(SettingsMenuProvider.MenuItems);
		}
		zXXj7mZ1VZ.Filter = Filter;
		LbMenu.ItemsSource = zXXj7mZ1VZ;
		if (_preloadPageId.HasValue)
		{
			p1KjCrxTxM(_preloadPageId.Value);
		}
		else
		{
			if (!dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf().HasValue)
			{
				return;
			}
			SettingPageId? settingPageId = dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf();
			int num = 0;
			if (!T1tSnESDGxM7GTS6Fka())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!((settingPageId.GetValueOrDefault() == SettingPageId.Invalid) & settingPageId.HasValue))
			{
				try
				{
					p1KjCrxTxM(dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf().Value);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("加载最后使用的设置页出错了。" + exception.GetMessageWithInner());
				}
			}
		}
	}

	private bool Filter(object obj)
	{
		SettingMenuItem settingMenuItem = (SettingMenuItem)obj;
		if (NavBar.SelectedCategory.HasValue && NavBar.SelectedCategory != settingMenuItem.Category)
		{
			return false;
		}
		return true;
	}

	private void NavBar_OnSelectionChanged(object sender, RoutedEventArgs e)
	{
		zXXj7mZ1VZ.Refresh();
		PWcj0sbfYv();
	}

	private void PWcj0sbfYv()
	{
		try
		{
			G4sjqeVCtU = true;
			if (zXXj7mZ1VZ.Contains(oENjRt894W) && LbMenu.SelectedItem != oENjRt894W)
			{
				LbMenu.SelectedItem = oENjRt894W;
			}
		}
		finally
		{
			G4sjqeVCtU = false;
		}
	}

	private void LbMenu_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
	{
		if (NavBar.SelectedCategory.HasValue)
		{
			NavBar.SelectedCategory = ((e.Delta < 0) ? NavBar.SelectedCategory.Value.Next(true) : NavBar.SelectedCategory.Value.Prev(true));
		}
	}

	public void SwitchToPage(SettingPageId pageId)
	{
		if (base.OwnedWindows.Count > 0)
		{
			AppHelper.ShowWarning("请关闭子窗口后再切换设置页。");
			return;
		}
		if (DetailedContent.IsVisible)
		{
			SettingPageInfo currentPage = DetailedContent.CurrentPage;
			if (currentPage == null || currentPage.Id != pageId)
			{
				CloseDetailPage();
			}
		}
		p1KjCrxTxM(pageId);
	}

	private void p1KjCrxTxM(SettingPageId settingPageId_0)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.xmFvVJy4Z50 = settingPageId_0;
		SettingMenuItem settingMenuItem = SettingsMenuProvider.MenuItems.FirstOrDefault(_003C_003Ec__DisplayClass24_.vV3vVuxhM1w);
		if (settingMenuItem != null)
		{
			V7EjEorwZq(settingMenuItem, _003C_003Ec__DisplayClass24_.xmFvVJy4Z50);
		}
		if (oENjRt894W != null)
		{
			NavBar.SelectedCategory = oENjRt894W.Category;
		}
	}

	private void wMLjPTrM66(object sender, SelectionChangedEventArgs e)
	{
		if (!G4sjqeVCtU && LbMenu.SelectedItem is SettingMenuItem settingMenuItem_)
		{
			V7EjEorwZq(settingMenuItem_, null);
		}
	}

	private void V7EjEorwZq(SettingMenuItem settingMenuItem_1, SettingPageId? nullable_0)
	{
		oENjRt894W = settingMenuItem_1;
		PWcj0sbfYv();
		if (DetailedContent.Load(settingMenuItem_1, nullable_0))
		{
			DetailedContent.Visibility = Visibility.Visible;
		}
	}

	public void CloseDetailPage()
	{
		DetailedContent.Visibility = Visibility.Collapsed;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!TQhjcignQ1)
		{
			TQhjcignQ1 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/settingswindow2.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				NavBar = (NavBar)target;
				return;
			case 2:
				SearchControl = (SettingPageSearcherControl)target;
				return;
			case 3:
				LbMenu = (ListBox)target;
				LbMenu.PreviewMouseWheel += LbMenu_OnPreviewMouseWheel;
				LbMenu.SelectionChanged += wMLjPTrM66;
				return;
			case 4:
				DetailedContent = (SettingDetailScreenControl)target;
				return;
			}
			int num2 = 0;
			if (!T1tSnESDGxM7GTS6Fka())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			TQhjcignQ1 = true;
			return;
		}
	}

	[CompilerGenerated]
	private void eq5jyKE06t(object sender, ExecutedRoutedEventArgs e)
	{
		SearchControl.SetFocus();
	}

	[CompilerGenerated]
	private void VhLj8Hg3j0()
	{
		UIHelper.MaximizeWindowIfTooHigh(this);
	}

	internal static bool T1tSnESDGxM7GTS6Fka()
	{
		return DnE5DTSjGbsoRaDJ26Y == null;
	}
}
