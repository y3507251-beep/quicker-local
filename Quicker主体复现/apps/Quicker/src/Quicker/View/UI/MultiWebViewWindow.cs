using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using GongSolutions.Wpf.DragDrop;
using HandyControl.Controls;
using Microsoft.Web.WebView2.Wpf;
using Quicker.Domain;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.X;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View.UI;

public class MultiWebViewWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CMultiWebViewWindow_Loaded_003Eb__23_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MultiWebViewWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object MN83H2WwWrvp8gEgUYto;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MultiWebViewWindow multiWebViewWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!k2gyxLWwyiqIBSWvgbsM())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
				}
				awaiter.GetResult();
				multiWebViewWindow.Dispatcher.InvokeAsync((Func<bool>)multiWebViewWindow.ieqLPIt1807, DispatcherPriority.ApplicationIdle);
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

		internal static bool k2gyxLWwyiqIBSWvgbsM()
		{
			return MN83H2WwWrvp8gEgUYto == null;
		}
	}

	[CompilerGenerated]
	private readonly ObservableCollection<MultiTabWebViewItem> H13LP1dVujW = new ObservableCollection<MultiTabWebViewItem>();

	[CompilerGenerated]
	private bool OnILPbHWCAu;

	[CompilerGenerated]
	private string oBlLP6ElvI9;

	[CompilerGenerated]
	private string zUaLPXf2ygJ;

	[CompilerGenerated]
	private string uhCLPmOn36J;

	[CompilerGenerated]
	private ShowWindowLocation r2TLPKfZOGZ;

	[CompilerGenerated]
	private string QrKLPx3ICNS;

	internal SkipKeysTabControl MasterTab;

	private bool zH3LPrp7rWq;

	internal static MultiWebViewWindow EWUyYnFEkJsPITqvMARj;

	public ObservableCollection<MultiTabWebViewItem> TabItems
	{
		[CompilerGenerated]
		get
		{
			return H13LP1dVujW;
		}
	}

	public bool SetTopmost
	{
		[CompilerGenerated]
		get
		{
			return OnILPbHWCAu;
		}
		[CompilerGenerated]
		set
		{
			OnILPbHWCAu = value;
		}
	}

	public string WindowId
	{
		[CompilerGenerated]
		get
		{
			return oBlLP6ElvI9;
		}
		[CompilerGenerated]
		set
		{
			oBlLP6ElvI9 = value;
		}
	}

	public string UserAgent
	{
		[CompilerGenerated]
		get
		{
			return zUaLPXf2ygJ;
		}
		[CompilerGenerated]
		set
		{
			zUaLPXf2ygJ = value;
		}
	}

	public string DefaultDownloadFolderPath
	{
		[CompilerGenerated]
		get
		{
			return uhCLPmOn36J;
		}
		[CompilerGenerated]
		set
		{
			uhCLPmOn36J = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return r2TLPKfZOGZ;
		}
		[CompilerGenerated]
		set
		{
			r2TLPKfZOGZ = value;
		}
	}

	public string WindowSizeStr
	{
		[CompilerGenerated]
		get
		{
			return QrKLPx3ICNS;
		}
		[CompilerGenerated]
		set
		{
			QrKLPx3ICNS = value;
		}
	}

	public MultiWebViewWindow(IList<CommonOperationItem> tabItems, string userAgent, string defaultDownloadFolderPath)
	{
		UserAgent = userAgent;
		DefaultDownloadFolderPath = defaultDownloadFolderPath;
		InitializeComponent();
		base.Loaded += hNKLP0Zj21N;
		base.PreviewKeyDown += bvHLPJBR3MZ;
		iamLPNEOFHa(tabItems);
		MasterTab.ItemsSource = TabItems;
		MasterTab.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
		base.Closed += uPXLPuoEpfb;
	}

	private void uPXLPuoEpfb(object sender, EventArgs e)
	{
		foreach (MultiTabWebViewItem tabItem in TabItems)
		{
			tabItem.ShutDown();
		}
	}

	private void iamLPNEOFHa(IList<CommonOperationItem> ilist_0)
	{
		if (TabItems.HasData())
		{
			foreach (MultiTabWebViewItem item in TabItems.ToList())
			{
				item.ShutDown();
			}
			TabItems.Clear();
		}
		foreach (CommonOperationItem item2 in ilist_0)
		{
			TabItems.Add(new MultiTabWebViewItem(item2.Title, item2.Data, item2.Icon, item2.Description)
			{
				UserAgent = UserAgent,
				DefaultDownloadFolderPath = DefaultDownloadFolderPath
			});
		}
	}

	private void bvHLPJBR3MZ(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.W && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
		{
			CloseTab();
			e.Handled = true;
		}
	}

	private void hNKLP0Zj21N(object sender, RoutedEventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false);
		if (SetTopmost)
		{
			Task.Run((Func<Task>)mfgLPY1aR58);
		}
	}

	private void bN1LPCNwvdR(object sender, RoutedEventArgs e)
	{
		if (dadLPkj4AI8() != null)
		{
			AppHelper.TryOpenUrlOrFile(dadLPkj4AI8().Source);
		}
	}

	[SpecialName]
	private MultiTabWebViewItem dadLPkj4AI8()
	{
		return MasterTab.SelectedItem as MultiTabWebViewItem;
	}

	[SpecialName]
	private WebView2 u7yLPsZROdI()
	{
		return dadLPkj4AI8()?.WebView;
	}

	private void YqfLPPRXy4K(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = u7yLPsZROdI()?.CanGoBack ?? false;
	}

	private void Dt0LPE0VeST(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			u7yLPsZROdI()?.GoBack();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void wsHLPyTNTCk(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = u7yLPsZROdI()?.CanGoForward ?? false;
	}

	private void N1SLP8688Rr(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			u7yLPsZROdI()?.GoForward();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void JoKLPatZkxc(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = u7yLPsZROdI() != null;
	}

	private void n3ULP7EK40D(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			u7yLPsZROdI()?.Reload();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void xc8LPR5J7e3()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	private void rKALPqFf9ud(object sender, RoutedEventArgs e)
	{
		if ((sender as MenuItem).DataContext is MultiTabWebViewItem multiTabWebViewItem && multiTabWebViewItem != dadLPkj4AI8())
		{
			int num = TabItems.IndexOf(multiTabWebViewItem);
			if (num >= 0)
			{
				TabItems.RemoveAt(num);
			}
		}
		else
		{
			CloseTab();
		}
	}

	private void CloseTab()
	{
		while (MasterTab.SelectedIndex >= 0)
		{
			if (!IwM3tEFEa0S450xGYZfB())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			int selectedIndex = MasterTab.SelectedIndex;
			try
			{
				if (MasterTab.SelectedItem is MultiTabWebViewItem { WebView: not null } multiTabWebViewItem)
				{
					multiTabWebViewItem.ShutDown();
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("释放资源出错：" + ex.Message);
			}
			TabItems.RemoveAt(MasterTab.SelectedIndex);
			if (TabItems.Count != 0)
			{
				if (TabItems.Count <= selectedIndex)
				{
					MasterTab.SelectedIndex = -1;
					MasterTab.SelectedIndex = TabItems.Count - 1;
				}
				else
				{
					MasterTab.SelectedIndex = -1;
					MasterTab.SelectedIndex = selectedIndex;
				}
				base.Dispatcher.InvokeAsync(x3tLPWZ2lYk);
			}
			else
			{
				Close();
			}
			break;
		}
	}

	private void RmkLPc0TbWT(object sender, RoutedEventArgs e)
	{
		MultiTabWebViewItem multiTabWebViewItem = ((sender as MenuItem).DataContext as MultiTabWebViewItem) ?? dadLPkj4AI8();
		if (multiTabWebViewItem != null)
		{
			AppHelper.TryOpenUrlOrFile(multiTabWebViewItem.Source);
		}
	}

	private void PZPLPVhBobB(object sender, RoutedEventArgs e)
	{
		MultiTabWebViewItem multiTabWebViewItem = ((sender as MenuItem).DataContext as MultiTabWebViewItem) ?? dadLPkj4AI8();
		if (multiTabWebViewItem != null)
		{
			ClipboardHelper.SetHtml("<a href='" + multiTabWebViewItem.Source + "'>" + multiTabWebViewItem.Source + "</a>", multiTabWebViewItem.Source);
		}
	}

	private void YDKLPZO4dRm(object sender, RoutedEventArgs e)
	{
		MultiTabWebViewItem multiTabWebViewItem = ((sender as MenuItem).DataContext as MultiTabWebViewItem) ?? dadLPkj4AI8();
		if (multiTabWebViewItem != null)
		{
			ClipboardHelper.SetText("[" + multiTabWebViewItem.Title + "](" + multiTabWebViewItem.Source + " )");
		}
	}

	private void r48LP9ri0xC(object sender, RoutedEventArgs e)
	{
		MultiTabWebViewItem multiTabWebViewItem = ((sender as MenuItem).DataContext as MultiTabWebViewItem) ?? dadLPkj4AI8();
		if (multiTabWebViewItem != null)
		{
			ClipboardHelper.SetHtml("<a href='" + multiTabWebViewItem.Source + "'>" + multiTabWebViewItem.Title + "</a>", "<a href='" + multiTabWebViewItem.Source + "'>" + multiTabWebViewItem.Title + "</a>");
		}
	}

	public void UpdateTabs(IList<CommonOperationItem> tabs)
	{
		iamLPNEOFHa(tabs);
		if (base.WindowState == WindowState.Minimized)
		{
			base.WindowState = WindowState.Normal;
		}
	}

	private void tQ1LPhm4Ryc(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount >= 2)
		{
			CloseTab();
		}
	}

	private void uVaLPeX2YvE(object sender, KeyEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!zH3LPrp7rWq)
		{
			zH3LPrp7rWq = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/multiwebviewwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			zH3LPrp7rWq = true;
			break;
		case 1:
			((CommandBinding)target).CanExecute += YqfLPPRXy4K;
			((CommandBinding)target).Executed += Dt0LPE0VeST;
			break;
		case 2:
			((CommandBinding)target).CanExecute += wsHLPyTNTCk;
			if (EWUyYnFEkJsPITqvMARj != null)
			{
				switch (0)
				{
				}
			}
			((CommandBinding)target).Executed += N1SLP8688Rr;
			break;
		case 3:
			((CommandBinding)target).CanExecute += JoKLPatZkxc;
			((CommandBinding)target).Executed += n3ULP7EK40D;
			break;
		case 4:
			MasterTab = (SkipKeysTabControl)target;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 5:
			((Grid)target).PreviewMouseLeftButtonDown += tQ1LPhm4Ryc;
			break;
		case 6:
			((MenuItem)target).Click += rKALPqFf9ud;
			break;
		case 7:
			((MenuItem)target).Click += RmkLPc0TbWT;
			break;
		case 8:
			((MenuItem)target).Click += PZPLPVhBobB;
			break;
		case 9:
			((MenuItem)target).Click += YDKLPZO4dRm;
			break;
		case 10:
			((MenuItem)target).Click += r48LP9ri0xC;
			break;
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CMultiWebViewWindow_Loaded_003Eb__23_0_003Ed))]
	private Task mfgLPY1aR58()
	{
		_003C_003CMultiWebViewWindow_Loaded_003Eb__23_0_003Ed stateMachine = default(_003C_003CMultiWebViewWindow_Loaded_003Eb__23_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private bool ieqLPIt1807()
	{
		base.Topmost = true;
		return true;
	}

	[CompilerGenerated]
	private void x3tLPWZ2lYk()
	{
		Focus();
	}

	internal static bool IwM3tEFEa0S450xGYZfB()
	{
		return EWUyYnFEkJsPITqvMARj == null;
	}
}
