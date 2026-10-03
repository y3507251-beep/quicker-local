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
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GongSolutions.Wpf.DragDrop;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Modules.Gestures.Manage;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View.X;

namespace Quicker.Settings.Pages.Triggers;

public class KeyActionsSettingPage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xchv9dYe5U4;

		public static Comparison<KeyActionItem> kxTv9oDFO2n;

		private static _003C_003Ec FyjtjLcoU7bqnuEqTjJi;

		static _003C_003Ec()
		{
			xchv9dYe5U4 = new _003C_003Ec();
		}

		internal int ONvv9DN6Mho(KeyActionItem action1, KeyActionItem action2)
		{
			return action1.Key - action2.Key;
		}

		internal static bool vl9NhxcoxAFBgMFH4DBA()
		{
			return FyjtjLcoU7bqnuEqTjJi == null;
		}

		internal static void oMZIT4co62cU45RY5UFa()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditActionItem_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public KeyActionsSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object RuYdo6cotJ3jj0pRDvep;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			KeyActionsSettingPage keyActionsSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0083;
				}
				if ((sender as FrameworkElement)?.Tag is KeyActionItem keyActionItem_)
				{
					awaiter = keyActionsSettingPage.NEedmpxTMs(keyActionItem_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0083;
				}
				goto end_IL_000e;
				IL_0083:
				awaiter.GetResult();
				if (RuYdo6cotJ3jj0pRDvep != null)
				{
					switch (0)
					{
					}
				}
				end_IL_000e:;
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

		internal static bool IoiLyWcoSsa4ID57fbVF()
		{
			return RuYdo6cotJ3jj0pRDvep == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNew_OnClick_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyActionsSettingPage _003C_003E4__this;

		private EditKeyActionWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object RrrxlRcoTdVRdotAM78a;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			KeyActionsSettingPage keyActionsSettingPage = _003C_003E4__this;
			try
			{
				int num2;
				TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
				if (num != 0)
				{
					if (AppState.DataService.Hb9tmk3OsJ7())
					{
						goto IL_008f;
					}
					num2 = 1;
					if (!xBHu4xcomi6eQT6pycIf())
					{
						goto IL_0044;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num2 = 0;
					if (RrrxlRcoTdVRdotAM78a != null)
					{
						goto IL_0044;
					}
				}
				goto IL_0048;
				IL_008f:
				_003Cdlg_003E5__2 = new EditKeyActionWindow(keyActionsSettingPage._list, null);
				_003Cdlg_003E5__2.Owner = Window.GetWindow(keyActionsSettingPage);
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00f2;
				IL_0070:
				if (keyActionsSettingPage._list.Count < 1)
				{
					goto IL_008f;
				}
				AppHelper.ShowWarning("免费版支持创建1条按键触发规则，当前已达到限额。\n如您已购买专业版，请重启软件生效。");
				goto end_IL_0010;
				IL_00f2:
				if (awaiter.GetResult() == true)
				{
					keyActionsSettingPage._list.Add(_003Cdlg_003E5__2.ResultItem);
				}
				goto end_IL_0010;
				IL_0044:
				int num3 = default(int);
				num2 = num3;
				goto IL_0048;
				IL_0048:
				switch (num2)
				{
				case 1:
					goto IL_0070;
				}
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00f2;
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

		internal static bool xBHu4xcomi6eQT6pycIf()
		{
			return RrrxlRcoTdVRdotAM78a == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItem_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public KeyActionsSettingPage _003C_003E4__this;

		public KeyActionItem item;

		private EditKeyActionWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object fDF96QcoCJFvGLp3xlRL;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			KeyActionsSettingPage keyActionsSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new EditKeyActionWindow(keyActionsSettingPage._list, item);
					_003Cdlg_003E5__2.Owner = Window.GetWindow(keyActionsSettingPage);
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
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					int num2 = 0;
					if (!DEtJOrco78Ui9Z6frV8p())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						keyActionsSettingPage._list.Replace(item, _003Cdlg_003E5__2.ResultItem);
						keyActionsSettingPage._list.Sort(_003C_003Ec.kxTv9oDFO2n ?? (_003C_003Ec.kxTv9oDFO2n = _003C_003Ec.xchv9dYe5U4.ONvv9DN6Mho));
						break;
					}
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

		internal static bool DEtJOrco78Ui9Z6frV8p()
		{
			return fDF96QcoCJFvGLp3xlRL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLvActions_OnMouseDoubleClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyActionsSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object TwiJNCcohe311fc9cm9Q;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			KeyActionsSettingPage keyActionsSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!ws7ynAcoH8PNDypdmVYm())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_009e;
				}
				if (keyActionsSettingPage.LvActions.SelectedItem is KeyActionItem keyActionItem_)
				{
					awaiter = keyActionsSettingPage.NEedmpxTMs(keyActionItem_).GetAwaiter();
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

		internal static bool ws7ynAcoH8PNDypdmVYm()
		{
			return TwiJNCcohe311fc9cm9Q == null;
		}
	}

	[CompilerGenerated]
	private SmartCollection<KeyActionItem> VundpwTPZK = new SmartCollection<KeyActionItem>();

	internal ListView LvActions;

	internal Button BtnNew;

	internal TextBlock LblLimit;

	private bool hopdBmPacF;

	internal static KeyActionsSettingPage M84n41sHxu8piEyT5Co;

	public SmartCollection<KeyActionItem> _list
	{
		[CompilerGenerated]
		get
		{
			return VundpwTPZK;
		}
		[CompilerGenerated]
		private set
		{
			VundpwTPZK = value;
		}
	}

	public KeyActionsSettingPage()
	{
		InitializeComponent();
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			LblLimit.Visibility = Visibility.Visible;
		}
		else
		{
			LblLimit.Visibility = Visibility.Collapsed;
		}
		LvActions.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ExeSettings exeSettings = AppState.DataService.yQWt6ownR4Z("_global", true);
		if (exeSettings.KeyActionItems != null)
		{
			_list.Reset(exeSettings.KeyActionItems);
		}
		LvActions.ItemsSource = _list;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		ExeSettings exeSettings = AppState.DataService.yQWt6ownR4Z("_global", true);
		exeSettings.KeyActionItems = _list.ToList();
		AppState.DataService.a65t6APblky(exeSettings);
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnNew_OnClick_003Ed__7))]
	private void Pj1dHM6REr(object sender, RoutedEventArgs e)
	{
		_003CBtnNew_OnClick_003Ed__7 stateMachine = default(_003CBtnNew_OnClick_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void ifSd19mjgm(object sender, SelectionChangedEventArgs e)
	{
	}

	private void VvgdbVYF8H(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItem != null)
		{
			_list.Remove(LvActions.SelectedItem as KeyActionItem);
			LvActions.SelectedItem = null;
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除按键。");
		}
	}

	private void S3Jd6brmNp(object sender, MouseButtonEventArgs e)
	{
		object dataContext = ((ListViewItem)sender).DataContext;
	}

	[AsyncStateMachine(typeof(_003CLvActions_OnMouseDoubleClick_003Ed__11))]
	private void jaOdXGkXHd(object sender, MouseButtonEventArgs e)
	{
		_003CLvActions_OnMouseDoubleClick_003Ed__11 stateMachine = default(_003CLvActions_OnMouseDoubleClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItem_003Ed__12))]
	private Task NEedmpxTMs(KeyActionItem keyActionItem_0)
	{
		_003CEditItem_003Ed__12 stateMachine = default(_003CEditItem_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = keyActionItem_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnEditActionItem_OnClick_003Ed__13))]
	private void kMjdK79Vnr(object sender, RoutedEventArgs e)
	{
		_003CBtnEditActionItem_OnClick_003Ed__13 stateMachine = default(_003CBtnEditActionItem_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void RXZdxdX2CM(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement)?.Tag is KeyActionItem item && AppHelper.Confirm("您确定要删除么？"))
		{
			_list.Remove(item);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!hopdBmPacF)
		{
			hopdBmPacF = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/keyaction/keyactionssettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			LvActions = (ListView)target;
			LvActions.MouseDoubleClick += jaOdXGkXHd;
			LvActions.SelectionChanged += ifSd19mjgm;
			break;
		default:
			hopdBmPacF = true;
			break;
		case 4:
			BtnNew = (Button)target;
			BtnNew.Click += Pj1dHM6REr;
			break;
		case 5:
			LblLimit = (TextBlock)target;
			if (!eRpVbpszCWoc5QsRkRN())
			{
				switch (0)
				{
				}
			}
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += RXZdxdX2CM;
			break;
		case 2:
			((Button)target).Click += kMjdK79Vnr;
			break;
		}
	}

	internal static bool eRpVbpszCWoc5QsRkRN()
	{
		return M84n41sHxu8piEyT5Co == null;
	}
}
