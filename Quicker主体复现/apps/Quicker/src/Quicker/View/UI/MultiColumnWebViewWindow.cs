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

public class MultiColumnWebViewWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CMultiWebViewWindow_Loaded_003Eb__24_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MultiColumnWebViewWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object efxJOmWwQLMw9ZI0AAVp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MultiColumnWebViewWindow multiColumnWebViewWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(1000).GetAwaiter();
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
				}
				awaiter.GetResult();
				multiColumnWebViewWindow.Dispatcher.InvokeAsync((Func<bool>)multiColumnWebViewWindow.oVYLCUXKB06, DispatcherPriority.ApplicationIdle);
				int num2 = 0;
				if (efxJOmWwQLMw9ZI0AAVp != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
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

		internal static bool TaVHuqWwFZfdvX1lSOxo()
		{
			return efxJOmWwQLMw9ZI0AAVp == null;
		}
	}

	[CompilerGenerated]
	private readonly ObservableCollection<MultiTabWebViewItem> KpWLCzmCrJ0 = new ObservableCollection<MultiTabWebViewItem>();

	[CompilerGenerated]
	private bool oluLPw5I7EI;

	[CompilerGenerated]
	private string iNaLPtcb26R;

	[CompilerGenerated]
	private string osSLPgf8QpJ;

	[CompilerGenerated]
	private string qkQLPLdDWNa;

	[CompilerGenerated]
	private ShowWindowLocation B6uLPvW4AX8;

	[CompilerGenerated]
	private string J9ILPS83WAc;

	internal SkipKeysListBox LbViewList;

	private bool pVKLP2jTYiE;

	private static MultiColumnWebViewWindow tw13tZFEKMOPGAGTf7rf;

	public ObservableCollection<MultiTabWebViewItem> TabItems
	{
		[CompilerGenerated]
		get
		{
			return KpWLCzmCrJ0;
		}
	}

	public bool SetTopmost
	{
		[CompilerGenerated]
		get
		{
			return oluLPw5I7EI;
		}
		[CompilerGenerated]
		set
		{
			oluLPw5I7EI = value;
		}
	}

	public string WindowId
	{
		[CompilerGenerated]
		get
		{
			return iNaLPtcb26R;
		}
		[CompilerGenerated]
		set
		{
			iNaLPtcb26R = value;
		}
	}

	public string UserAgent
	{
		[CompilerGenerated]
		get
		{
			return osSLPgf8QpJ;
		}
		[CompilerGenerated]
		set
		{
			osSLPgf8QpJ = value;
		}
	}

	public string DefaultDownloadFolderPath
	{
		[CompilerGenerated]
		get
		{
			return qkQLPLdDWNa;
		}
		[CompilerGenerated]
		set
		{
			qkQLPLdDWNa = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return B6uLPvW4AX8;
		}
		[CompilerGenerated]
		set
		{
			B6uLPvW4AX8 = value;
		}
	}

	public string WindowSizeStr
	{
		[CompilerGenerated]
		get
		{
			return J9ILPS83WAc;
		}
		[CompilerGenerated]
		set
		{
			J9ILPS83WAc = value;
		}
	}

	public MultiColumnWebViewWindow(IList<CommonOperationItem> tabItems, string userAgent, string defaultDownloadFolderPath)
	{
		UserAgent = userAgent;
		DefaultDownloadFolderPath = defaultDownloadFolderPath;
		InitializeComponent();
		base.Loaded += cwqLCxnIcV7;
		base.PreviewKeyDown += iNBLCKlsCGM;
		base.Closing += OHZLCXNtbmw;
		rFxLCmv0M4J(tabItems);
		LbViewList.ItemsSource = TabItems;
		LbViewList.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
		base.Closed += eQnLC6VYd35;
	}

	private void eQnLC6VYd35(object sender, EventArgs e)
	{
		foreach (MultiTabWebViewItem tabItem in TabItems)
		{
			tabItem.ShutDown();
		}
	}

	private void OHZLCXNtbmw(object sender, CancelEventArgs e)
	{
		foreach (MultiTabWebViewItem tabItem in TabItems)
		{
			if (tabItem.WebView != null)
			{
				tabItem.ShutDown();
			}
		}
	}

	private void rFxLCmv0M4J(IList<CommonOperationItem> ilist_0)
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
			MultiTabWebViewItem multiTabWebViewItem = new MultiTabWebViewItem(item2.Title, item2.Data, item2.Icon, item2.Description)
			{
				UserAgent = UserAgent,
				DefaultDownloadFolderPath = DefaultDownloadFolderPath
			};
			multiTabWebViewItem.GotFocus = (EventHandler)Delegate.Combine(multiTabWebViewItem.GotFocus, new EventHandler(EDBLCOSqnG4));
			TabItems.Add(multiTabWebViewItem);
		}
	}

	private void iNBLCKlsCGM(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.W && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
		{
			CloseTab();
			e.Handled = true;
		}
	}

	private void cwqLCxnIcV7(object sender, RoutedEventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false);
		if (SetTopmost)
		{
			Task.Run((Func<Task>)SEPLCFrllqP);
		}
	}

	private void iSZLCrcAKrD(object sender, RoutedEventArgs e)
	{
		if (Xa1LClfDX6i() != null)
		{
			AppHelper.TryOpenUrlOrFile(Xa1LClfDX6i().Source);
		}
	}

	[SpecialName]
	private MultiTabWebViewItem Xa1LClfDX6i()
	{
		return LbViewList.SelectedItem as MultiTabWebViewItem;
	}

	[SpecialName]
	private WebView2 k72LC3Wa3So()
	{
		return Xa1LClfDX6i()?.WebView;
	}

	private void eGhLCphjllf(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = k72LC3Wa3So()?.CanGoBack ?? false;
	}

	private void dZFLCB8bSt0(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			k72LC3Wa3So()?.GoBack();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void n1JLCQW4EnE(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = k72LC3Wa3So()?.CanGoForward ?? false;
	}

	private void W7rLCjFDSwJ(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			k72LC3Wa3So()?.GoForward();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void CkILCnQilZa(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = k72LC3Wa3So() != null;
	}

	private void g3MLC48FYSi(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			k72LC3Wa3So()?.Reload();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void tqTLC5jVTJ6()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	private void tCKLCD2lHix(object sender, RoutedEventArgs e)
	{
		CloseTab();
	}

	private void CloseTab()
	{
		if (LbViewList.SelectedIndex < 0)
		{
			return;
		}
		try
		{
			if (LbViewList.SelectedItem is MultiTabWebViewItem { WebView: not null } multiTabWebViewItem)
			{
				multiTabWebViewItem.ShutDown();
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("释放资源出错：" + ex.Message);
		}
		TabItems.RemoveAt(LbViewList.SelectedIndex);
		if (TabItems.Count == 0)
		{
			Close();
		}
	}

	private void KuRLCdEjmar(object sender, RoutedEventArgs e)
	{
		if (Xa1LClfDX6i() != null)
		{
			AppHelper.TryOpenUrlOrFile(Xa1LClfDX6i().Source);
		}
	}

	private void SeWLCoFq5qR(object sender, RoutedEventArgs e)
	{
		if (Xa1LClfDX6i() != null)
		{
			ClipboardHelper.SetHtml("<a href='" + Xa1LClfDX6i().Source + "'>" + Xa1LClfDX6i().Source + "</a>", Xa1LClfDX6i().Source);
		}
	}

	private void VyILCTAa7ix(object sender, RoutedEventArgs e)
	{
		if (Xa1LClfDX6i() != null)
		{
			ClipboardHelper.SetText("[" + Xa1LClfDX6i().Title + "](" + Xa1LClfDX6i().Source + " )");
		}
	}

	private void lCpLCMhpERn(object sender, RoutedEventArgs e)
	{
		if (Xa1LClfDX6i() != null)
		{
			ClipboardHelper.SetHtml("<a href='" + Xa1LClfDX6i().Source + "'>" + Xa1LClfDX6i().Title + "</a>", "<a href='" + Xa1LClfDX6i().Source + "'>" + Xa1LClfDX6i().Title + "</a>");
		}
	}

	public void UpdateTabs(IList<CommonOperationItem> tabs)
	{
		rFxLCmv0M4J(tabs);
		if (base.WindowState == WindowState.Minimized)
		{
			base.WindowState = WindowState.Normal;
		}
	}

	private void PHMLCAGodwn(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount >= 2)
		{
			CloseTab();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!pVKLP2jTYiE)
		{
			pVKLP2jTYiE = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/multicolumnwebviewwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			pVKLP2jTYiE = true;
			break;
		case 1:
			((CommandBinding)target).CanExecute += eGhLCphjllf;
			((CommandBinding)target).Executed += dZFLCB8bSt0;
			break;
		case 2:
		{
			((CommandBinding)target).CanExecute += n1JLCQW4EnE;
			((CommandBinding)target).Executed += W7rLCjFDSwJ;
			int num = 0;
			if (!d3bQlBFEB5duuIfcuvPN())
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
			((CommandBinding)target).CanExecute += CkILCnQilZa;
			((CommandBinding)target).Executed += g3MLC48FYSi;
			break;
		case 4:
			LbViewList = (SkipKeysListBox)target;
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 5:
			((MenuItem)target).Click += tCKLCD2lHix;
			break;
		case 6:
			((MenuItem)target).Click += KuRLCdEjmar;
			break;
		case 7:
			((MenuItem)target).Click += SeWLCoFq5qR;
			break;
		case 8:
			((MenuItem)target).Click += VyILCTAa7ix;
			break;
		case 9:
			((MenuItem)target).Click += lCpLCMhpERn;
			break;
		}
	}

	[CompilerGenerated]
	private void EDBLCOSqnG4(object sender, EventArgs e)
	{
		if (sender is MultiTabWebViewItem selectedItem)
		{
			LbViewList.SelectedItem = selectedItem;
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CMultiWebViewWindow_Loaded_003Eb__24_0_003Ed))]
	private Task SEPLCFrllqP()
	{
		_003C_003CMultiWebViewWindow_Loaded_003Eb__24_0_003Ed stateMachine = default(_003C_003CMultiWebViewWindow_Loaded_003Eb__24_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private bool oVYLCUXKB06()
	{
		base.Topmost = true;
		return true;
	}

	internal static bool d3bQlBFEB5duuIfcuvPN()
	{
		return tw13tZFEKMOPGAGTf7rf == null;
	}
}
