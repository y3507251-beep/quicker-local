using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Modules.Gestures.Manage;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Settings.Pages.Triggers;

public class HotkeyWatchersSettingPage : SettingPage, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditActionItem_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public HotkeyWatchersSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object kuVrmEcobY772ISrWyCX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HotkeyWatchersSettingPage hotkeyWatchersSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a9;
				}
				HotkeyWatcherItem hotkeyWatcherItem = (sender as FrameworkElement)?.Tag as HotkeyWatcherItem;
				int num2 = 0;
				if (!LXgva8coq9S8wIdV5Xak())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (hotkeyWatcherItem != null)
				{
					awaiter = hotkeyWatchersSettingPage.SpGdY8ISdV(hotkeyWatcherItem).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a9;
				}
				goto end_IL_0010;
				IL_00a9:
				awaiter.GetResult();
				end_IL_0010:;
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

		internal static bool LXgva8coq9S8wIdV5Xak()
		{
			return kuVrmEcobY772ISrWyCX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNew_OnClick_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HotkeyWatchersSettingPage _003C_003E4__this;

		private EditHotkeyWatcherItemWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object PVw85icolpwLKE3cPD2F;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HotkeyWatchersSettingPage hotkeyWatchersSettingPage = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					goto IL_008e;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00c8;
				IL_00c8:
				if (awaiter.GetResult() == true)
				{
					hotkeyWatchersSettingPage._list.Add(_003Cdlg_003E5__2.ResultItem);
					int num2 = 0;
					if (PVw85icolpwLKE3cPD2F != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						goto end_IL_0010;
					case 1:
						break;
					case 0:
						goto end_IL_0010;
					}
					goto IL_007f;
				}
				goto end_IL_0010;
				IL_007f:
				goto IL_008e;
				IL_008e:
				_003Cdlg_003E5__2 = new EditHotkeyWatcherItemWindow(null);
				_003Cdlg_003E5__2.Owner = Window.GetWindow(hotkeyWatchersSettingPage);
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00c8;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool mp2qalcoZdu1q9HGDvB1()
		{
			return PVw85icolpwLKE3cPD2F == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItem_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HotkeyWatcherItem item;

		public HotkeyWatchersSettingPage _003C_003E4__this;

		private EditHotkeyWatcherItemWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object oefyX4coYdN7C0AZOWTk;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HotkeyWatchersSettingPage hotkeyWatchersSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new EditHotkeyWatcherItemWindow(item);
					_003Cdlg_003E5__2.Owner = Window.GetWindow(hotkeyWatchersSettingPage);
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
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
					int num2 = 0;
					if (!HqpftYco8SgeI3sgj47R())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					_003Cdlg_003E5__2.ResultItem.IsEnabled = item.IsEnabled;
					hotkeyWatchersSettingPage._list.Replace(item, _003Cdlg_003E5__2.ResultItem);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool HqpftYco8SgeI3sgj47R()
		{
			return oefyX4coYdN7C0AZOWTk == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLvActions_OnMouseDoubleClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HotkeyWatchersSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object oxvMcCcogo2qJ7Rp80CW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HotkeyWatchersSettingPage hotkeyWatchersSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009e;
				}
				if (hotkeyWatchersSettingPage.LvActions.SelectedItem is HotkeyWatcherItem hotkeyWatcherItem_)
				{
					awaiter = hotkeyWatchersSettingPage.SpGdY8ISdV(hotkeyWatcherItem_).GetAwaiter();
					int num2 = 0;
					if (oxvMcCcogo2qJ7Rp80CW != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009e;
				}
				goto end_IL_0010;
				IL_009e:
				awaiter.GetResult();
				end_IL_0010:;
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

		internal static bool f3NMf0coPv3TtykZBwiv()
		{
			return oxvMcCcogo2qJ7Rp80CW == null;
		}
	}

	[CompilerGenerated]
	private SmartCollection<HotkeyWatcherItem> jiSdGqF6Ih = new SmartCollection<HotkeyWatcherItem>();

	internal ListView LvActions;

	internal Button BtnNew;

	internal TextBlock LblLimit;

	private bool Bd3dsG6xka;

	internal static HotkeyWatchersSettingPage qVCcdwssSxVQliBJucS;

	public SmartCollection<HotkeyWatcherItem> _list
	{
		[CompilerGenerated]
		get
		{
			return jiSdGqF6Ih;
		}
		[CompilerGenerated]
		private set
		{
			jiSdGqF6Ih = value;
		}
	}

	public HotkeyWatchersSettingPage()
	{
		InitializeComponent();
		{
			LblLimit.Visibility = Visibility.Collapsed;
		}
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ExeSettings exeSettings = AppState.DataService.yQWt6ownR4Z("_global", true);
		if (exeSettings.HotkeyWatcherItems != null)
		{
			_list.Reset(exeSettings.HotkeyWatcherItems);
		}
		CollectionView itemsSource = (CollectionView)CollectionViewSource.GetDefaultView(_list);
		LvActions.ItemsSource = itemsSource;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		ExeSettings exeSettings = AppState.DataService.yQWt6ownR4Z("_global", true);
		exeSettings.HotkeyWatcherItems = _list.ToList();
		AppState.DataService.a65t6APblky(exeSettings);
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnNew_OnClick_003Ed__7))]
	private void eqfdVRtiBX(object sender, RoutedEventArgs e)
	{
		_003CBtnNew_OnClick_003Ed__7 stateMachine = default(_003CBtnNew_OnClick_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void y5edZUqb7T(object sender, SelectionChangedEventArgs e)
	{
	}

	private void aiZd9wXwhp(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItem != null)
		{
			_list.Remove(LvActions.SelectedItem as HotkeyWatcherItem);
			LvActions.SelectedItem = null;
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除按键。");
		}
	}

	private void j66dh8uknw(object sender, MouseButtonEventArgs e)
	{
		object dataContext = ((ListViewItem)sender).DataContext;
	}

	[AsyncStateMachine(typeof(_003CLvActions_OnMouseDoubleClick_003Ed__11))]
	private void vendeOvgn9(object sender, MouseButtonEventArgs e)
	{
		_003CLvActions_OnMouseDoubleClick_003Ed__11 stateMachine = default(_003CLvActions_OnMouseDoubleClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItem_003Ed__12))]
	private Task SpGdY8ISdV(HotkeyWatcherItem hotkeyWatcherItem_0)
	{
		_003CEditItem_003Ed__12 stateMachine = default(_003CEditItem_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = hotkeyWatcherItem_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnEditActionItem_OnClick_003Ed__13))]
	private void p6udIfZZgk(object sender, RoutedEventArgs e)
	{
		_003CBtnEditActionItem_OnClick_003Ed__13 stateMachine = default(_003CBtnEditActionItem_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void doydWU1KE9(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement)?.Tag is HotkeyWatcherItem item && AppHelper.Confirm("您确定要删除么？"))
		{
			_list.Remove(item);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Bd3dsG6xka)
		{
			Bd3dsG6xka = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/hotkeywatchers/hotkeywatcherssettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			LvActions = (ListView)target;
			LvActions.MouseDoubleClick += vendeOvgn9;
			LvActions.SelectionChanged += y5edZUqb7T;
			return;
		case 4:
			BtnNew = (Button)target;
			BtnNew.Click += eqfdVRtiBX;
			return;
		case 5:
			LblLimit = (TextBlock)target;
			return;
		}
		Bd3dsG6xka = true;
		int num = 0;
		if (qVCcdwssSxVQliBJucS != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += doydWU1KE9;
			break;
		case 2:
			((Button)target).Click += p6udIfZZgk;
			break;
		}
	}

	internal static bool BBGk9GsCTXOUlm6a72H()
	{
		return qVCcdwssSxVQliBJucS == null;
	}
}
