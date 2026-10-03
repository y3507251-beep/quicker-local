using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using IOn6RhAJdTUbfGy6gwn;
using Microsoft.Win32;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;

namespace Quicker.View;

public class AppSelectorWindow : Window, IComponentConnector, IStyleConnector
{
	private delegate IList<WinAppItem> EkYg9luCMbaEkhqfgKp();

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec tMKSrR1dT25;

		public static Func<WinAppItem, string> i9XSrqrJjtb;

		public static Func<List<WinAppItem>> r0cSrcyoJqP;

		public static Func<WinAppItem, string> gcaSrV6gwoe;

		public static Func<WinAppItem, string> hMKSrZJ9yi2;

		private static _003C_003Ec J8xVeUWg6lLFaR0fqFrK;

		static _003C_003Ec()
		{
			tMKSrR1dT25 = new _003C_003Ec();
		}

		internal List<WinAppItem> SuoSryuxC7P()
		{
			return WinAppEnumerator.GetLnkFileItems(t9mgiEwGqJi()).OrderBy(i9XSrqrJjtb ?? (i9XSrqrJjtb = tMKSrR1dT25.z27Sr8pVluY)).ToList();
		}

		internal string z27Sr8pVluY(WinAppItem f)
		{
			return f.DisplayName;
		}

		internal string mLbSra2NJ5y(WinAppItem x)
		{
			return x.Name;
		}

		internal string MDFSr7fNf94(WinAppItem x)
		{
			return x.DisplayName;
		}

		internal static bool xt5DojWgtVtuBBX0MbwB()
		{
			return J8xVeUWg6lLFaR0fqFrK == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnRefreshList_OnClick_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AppSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object pMDWpSWgwlk2gDx4vduX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AppSelectorWindow appSelectorWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					ConfiguredTaskAwaitable configuredTaskAwaitable = appSelectorWindow.n5KgiLWHpVY().ConfigureAwait(true);
					if (M4n5ImWgTuiFCZGcKROa())
					{
						switch (0)
						{
						}
					}
					awaiter = configuredTaskAwaitable.GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool M4n5ImWgTuiFCZGcKROa()
		{
			return pMDWpSWgwlk2gDx4vduX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadExeListAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<List<WinAppItem>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object mYqDdrWgs8wReIcbyi4G;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AppSelectorWindow appSelectorWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					appSelectorWindow.BtnRefreshList.IsEnabled = false;
					appSelectorWindow.Cp0giVt9oOb = new WaitWindow();
					appSelectorWindow.Cp0giVt9oOb.Owner = appSelectorWindow;
					appSelectorWindow.Cp0giVt9oOb.WindowStartupLocation = WindowStartupLocation.CenterOwner;
					int num2 = 0;
					if (mYqDdrWgs8wReIcbyi4G != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					appSelectorWindow.Cp0giVt9oOb.UpdateLayout();
					appSelectorWindow.Cp0giVt9oOb.Show();
				}
				try
				{
					ConfiguredTaskAwaitable<List<WinAppItem>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(_003C_003Ec.r0cSrcyoJqP ?? (_003C_003Ec.r0cSrcyoJqP = _003C_003Ec.tMKSrR1dT25.SuoSryuxC7P)).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e5;
					}
					goto IL_0121;
					IL_00e5:
					List<WinAppItem> result = awaiter.GetResult();
					appSelectorWindow.Affgi7IdbuK = result;
					XRLgiyRKw9C(appSelectorWindow.Affgi7IdbuK);
					int num4 = 1;
					if (!hOfduRWgClAja4thxPO4())
					{
						int num5 = default(int);
						num4 = num5;
					}
					switch (num4)
					{
					case 1:
						appSelectorWindow.Cp0giVt9oOb.Close();
						appSelectorWindow.NRYgiRHlkQ2 = appSelectorWindow.Affgi7IdbuK;
						if (!string.IsNullOrEmpty(appSelectorWindow.TxtFilter.Text))
						{
							appSelectorWindow.NWigiSkTlMA();
						}
						else
						{
							appSelectorWindow.AppList.ItemsSource = appSelectorWindow.NRYgiRHlkQ2;
						}
						goto end_IL_007b;
					}
					goto IL_0121;
					IL_0121:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<List<WinAppItem>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00e5;
					end_IL_007b:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("加载应用列表出错：" + ex.Message);
				}
				appSelectorWindow.BtnRefreshList.IsEnabled = true;
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

		static _003CLoadExeListAsync_003Ed__18()
		{
		}

		internal static bool hOfduRWgClAja4thxPO4()
		{
			return mYqDdrWgs8wReIcbyi4G == null;
		}

		internal static void oPrD8mWgHP6YnupQdK8x()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AppSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object lDBlUXWgzOpfIFLAwYLi;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AppSelectorWindow appSelectorWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = appSelectorWindow.n5KgiLWHpVY().ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (lDBlUXWgzOpfIFLAwYLi != null)
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool HqdhxKWPVpGaj66Zvi5Y()
		{
			return lDBlUXWgzOpfIFLAwYLi == null;
		}
	}

	[CompilerGenerated]
	private readonly bool RfhgiannMpf;

	private IList<WinAppItem> Affgi7IdbuK;

	private IList<WinAppItem> NRYgiRHlkQ2;

	[CompilerGenerated]
	private static IList<WinAppItem> QJxgiq1rLdH;

	[CompilerGenerated]
	private WinAppItem tc6gicwg2uM;

	private WaitWindow Cp0giVt9oOb;

	internal TextBox TxtFilter;

	internal Button BtnFilter;

	internal Button BtnRefreshList;

	internal Button BtnChoose;

	internal WindowSelector TheWindowSelector;

	internal ListView AppList;

	internal Button BtnOk;

	internal Button BtnClose;

	private bool eARgiZc00PH;

	internal static AppSelectorWindow Qs9Te7Fysc89ojrJEqY8;

	public bool IsModal
	{
		[CompilerGenerated]
		get
		{
			return RfhgiannMpf;
		}
	}

	public WinAppItem SelectedFile
	{
		[CompilerGenerated]
		get
		{
			return tc6gicwg2uM;
		}
		[CompilerGenerated]
		set
		{
			tc6gicwg2uM = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static IList<WinAppItem> t9mgiEwGqJi()
	{
		return QJxgiq1rLdH;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void XRLgiyRKw9C(IList<WinAppItem> value)
	{
		QJxgiq1rLdH = value;
	}

	public AppSelectorWindow(bool isModal = true)
	{
		RfhgiannMpf = isModal;
		InitializeComponent();
		base.Loaded += Xe7gigWlVBm;
		if (!IsModal)
		{
			BtnOk.Visibility = Visibility.Collapsed;
			BtnChoose.Visibility = Visibility.Collapsed;
			base.WindowStartupLocation = WindowStartupLocation.Manual;
			TheWindowSelector.Visibility = Visibility.Collapsed;
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

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__17))]
	private void Xe7gigWlVBm(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__17 stateMachine = default(_003COnLoaded_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadExeListAsync_003Ed__18))]
	private Task n5KgiLWHpVY()
	{
		_003CLoadExeListAsync_003Ed__18 stateMachine = default(_003CLoadExeListAsync_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void PW8givDbpNp(object sender, RoutedEventArgs e)
	{
		NWigiSkTlMA();
	}

	private void NWigiSkTlMA()
	{
		if (Affgi7IdbuK != null)
		{
			if (!string.IsNullOrEmpty(TxtFilter.Text))
			{
				string text = TxtFilter.Text;
				NRYgiRHlkQ2 = tkxn6HAKAgMT8gvXbyh.E5FiUUSTVG(Affgi7IdbuK, _003C_003Ec.gcaSrV6gwoe ?? (_003C_003Ec.gcaSrV6gwoe = _003C_003Ec.tMKSrR1dT25.mLbSra2NJ5y), 1.0, _003C_003Ec.hMKSrZJ9yi2 ?? (_003C_003Ec.hMKSrZJ9yi2 = _003C_003Ec.tMKSrR1dT25.MDFSr7fNf94), 1.0, false, text, true);
				AppList.ItemsSource = NRYgiRHlkQ2;
			}
			else
			{
				NRYgiRHlkQ2 = Affgi7IdbuK;
				AppList.ItemsSource = NRYgiRHlkQ2;
			}
		}
	}

	private void o9Hgi2Kvvls(object sender, TextChangedEventArgs e)
	{
		NWigiSkTlMA();
	}

	private void gyCgiuA9S6r(object sender, RoutedEventArgs e)
	{
		if (AppList.SelectedItem != null)
		{
			SelectedFile = AppList.SelectedItem as WinAppItem;
			if (IsModal)
			{
				base.DialogResult = true;
			}
		}
		else
		{
			MessageBoxHelper.Show(this, "请选择程序！", "Quicker");
		}
	}

	private void isdgiNUE0Q3(object sender, MouseButtonEventArgs e)
	{
		if (AppList.SelectedItem != null)
		{
			SelectedFile = AppList.SelectedItem as WinAppItem;
			if (IsModal)
			{
				base.DialogResult = true;
			}
		}
	}

	private void vxigiJpBTkm(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.ValidateNames = false;
		openFileDialog.CheckFileExists = false;
		openFileDialog.CheckPathExists = true;
		openFileDialog.DereferenceLinks = false;
		openFileDialog.FileName = "";
		openFileDialog.DefaultExt = ".exe";
		openFileDialog.Filter = "可执行程序 (.exe)|*.exe|任意文件 (*.*)|*.*";
		if (openFileDialog.ShowDialog() != true)
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		SelectedFile = new WinAppItem
		{
			DisplayName = Path.GetFileNameWithoutExtension(fileName),
			Name = Path.GetFileNameWithoutExtension(fileName),
			FullPath = fileName
		};
		if (IsModal)
		{
			int num = 0;
			if (!VjYwAjFyCvnOuO91QRgZ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			base.DialogResult = true;
		}
	}

	[AsyncStateMachine(typeof(_003CBtnRefreshList_OnClick_003Ed__25))]
	private void sA1gi0ovrhJ(object sender, RoutedEventArgs e)
	{
		_003CBtnRefreshList_OnClick_003Ed__25 stateMachine = default(_003CBtnRefreshList_OnClick_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void dhggiCeXAQR(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void Ff4giPYw8H9(object sender, MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (e.LeftButton == MouseButtonState.Pressed && (sender as FrameworkElement).Tag is WinAppItem data)
		{
			DataObject dataObject = new DataObject();
			dataObject.SetData("win-app-item", data);
			try
			{
				AppHelper.DoDragDropWrap(this, dataObject, DragDropEffects.Copy | DragDropEffects.Move);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法开始拖动：" + ex.Message);
			}
		}
	}

	private void TheWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		try
		{
			string text = e.Process.MainModule?.FileName;
			SelectedFile = new WinAppItem
			{
				DisplayName = Path.GetFileNameWithoutExtension(text),
				Name = Path.GetFileNameWithoutExtension(text),
				FullPath = text
			};
			if (IsModal)
			{
				base.DialogResult = true;
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("获取进程失败。" + ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!eARgiZc00PH)
		{
			eARgiZc00PH = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/appselectorwindow.xaml", UriKind.Relative);
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
		case 1:
		{
			TxtFilter = (TextBox)target;
			TxtFilter.TextChanged += o9Hgi2Kvvls;
			int num = 0;
			if (Qs9Te7Fysc89ojrJEqY8 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 2:
			BtnFilter = (Button)target;
			BtnFilter.Click += PW8givDbpNp;
			break;
		case 3:
			BtnRefreshList = (Button)target;
			BtnRefreshList.Click += sA1gi0ovrhJ;
			break;
		case 4:
			BtnChoose = (Button)target;
			BtnChoose.Click += vxigiJpBTkm;
			break;
		case 5:
			TheWindowSelector = (WindowSelector)target;
			break;
		case 6:
			AppList = (ListView)target;
			break;
		default:
			eARgiZc00PH = true;
			break;
		case 9:
			BtnOk = (Button)target;
			BtnOk.Click += gyCgiuA9S6r;
			break;
		case 10:
			BtnClose = (Button)target;
			BtnClose.Click += dhggiCeXAQR;
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
		case 8:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(isdgiNUE0Q3);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		case 7:
			((StackPanel)target).PreviewMouseMove += Ff4giPYw8H9;
			break;
		}
	}

	internal static bool VjYwAjFyCvnOuO91QRgZ()
	{
		return Qs9Te7Fysc89ojrJEqY8 == null;
	}
}
