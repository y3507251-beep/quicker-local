using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Settings.Controls;
using Quicker.Settings.Pages.Triggers.Editors;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.Hotkeys;
using sBtxL6X8ZmkfRQWgUC5;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Triggers;

public class LeftButtonPlusSettingPage : SettingPage, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public VirtualKeyCode gJav9fX0K8d;

		public LeftButtonPlusSettingPage gwlv9zXHoVA;

		internal static _003C_003Ec__DisplayClass15_0 kJff4fcf0Iisopv25HDv;

		internal bool kk5v93tZeCn(PowerKeyActionItem x)
		{
			return x.SecondaryKey == (int?)gJav9fX0K8d;
		}

		internal static bool B8x7ymcf1U65ev8kmffK()
		{
			return kJff4fcf0Iisopv25HDv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct vdxeVZHg7VtvmcZ9nfC : IAsyncStateMachine
		{
			public int uvO2aP9Pw2W;

			public AsyncVoidMethodBuilder KBc2aEg68GR;

			public _003C_003Ec__DisplayClass15_1 cCq2aylaTKR;

			private TaskAwaiter qt72a8X5BH9;

			private static object GItFAUy9s2mXZ2gSQLAb;

			private void MoveNext()
			{
				int num = uvO2aP9Pw2W;
				_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_ = cCq2aylaTKR;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003Ec__DisplayClass15_.dBBvhg9gOFU.gwlv9zXHoVA.LvActions.SelectedItem = _003C_003Ec__DisplayClass15_.d9RvhttID78;
						awaiter = _003C_003Ec__DisplayClass15_.dBBvhg9gOFU.gwlv9zXHoVA.dclox4aunt(_003C_003Ec__DisplayClass15_.d9RvhttID78).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							uvO2aP9Pw2W = 0;
							qt72a8X5BH9 = awaiter;
							KBc2aEg68GR.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = qt72a8X5BH9;
						qt72a8X5BH9 = default(TaskAwaiter);
						num = -1;
						uvO2aP9Pw2W = -1;
					}
					awaiter.GetResult();
					if (GItFAUy9s2mXZ2gSQLAb == null)
					{
						switch (0)
						{
						}
					}
				}
				catch (Exception exception)
				{
					uvO2aP9Pw2W = -2;
					KBc2aEg68GR.SetException(exception);
					return;
				}
				uvO2aP9Pw2W = -2;
				KBc2aEg68GR.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				KBc2aEg68GR.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool wrmKUhy9C5rl9X0G2OwA()
			{
				return GItFAUy9s2mXZ2gSQLAb == null;
			}
		}

		public PowerKeyActionItem d9RvhttID78;

		public _003C_003Ec__DisplayClass15_0 dBBvhg9gOFU;

		internal static _003C_003Ec__DisplayClass15_1 HwCGjDcfBKI3nsYPGFBo;

		[AsyncStateMachine(typeof(vdxeVZHg7VtvmcZ9nfC))]
		internal void dkOvhwX6rn5()
		{
			vdxeVZHg7VtvmcZ9nfC stateMachine = default(vdxeVZHg7VtvmcZ9nfC);
			stateMachine.KBc2aEg68GR = AsyncVoidMethodBuilder.Create();
			stateMachine.cCq2aylaTKR = this;
			stateMachine.uvO2aP9Pw2W = -1;
			stateMachine.KBc2aEg68GR.Start(ref stateMachine);
		}

		internal static bool E7hy6qcfv5F5NEKkQf9C()
		{
			return HwCGjDcfBKI3nsYPGFBo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditActionItem_OnClick_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public LeftButtonPlusSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object Ai11s6cfOcOQkgCRpb5U;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LeftButtonPlusSettingPage leftButtonPlusSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (!fZ9tg5cfJCgPsO9xSEru())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					PowerKeyActionItem powerKeyActionItem_ = (sender as FrameworkElement).Tag as PowerKeyActionItem;
					awaiter = leftButtonPlusSettingPage.dclox4aunt(powerKeyActionItem_).GetAwaiter();
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

		internal static bool fZ9tg5cfJCgPsO9xSEru()
		{
			return Ai11s6cfOcOQkgCRpb5U == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItem_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PowerKeyActionItem item;

		public LeftButtonPlusSettingPage _003C_003E4__this;

		private LeftButtonPlusEditWindow _003Ceditor_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object kZviUwcfaY1vtyQjBprQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LeftButtonPlusSettingPage leftButtonPlusSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Ceditor_003E5__2 = new LeftButtonPlusEditWindow(item);
					_003Ceditor_003E5__2.Owner = leftButtonPlusSettingPage.ParentWindow;
					awaiter = _003Ceditor_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (kZviUwcfaY1vtyQjBprQ != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
					leftButtonPlusSettingPage.vGBonDAO29[leftButtonPlusSettingPage.vGBonDAO29.IndexOf(item)] = _003Ceditor_003E5__2.ResultItem;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ceditor_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Ceditor_003E5__2 = null;
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

		internal static bool cQofRdcfrF7mO24B7hKL()
		{
			return kZviUwcfaY1vtyQjBprQ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLvActions_OnMouseDoubleClick_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MouseButtonEventArgs e;

		public LeftButtonPlusSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object YTWnvWcf96pvWim4SGC6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LeftButtonPlusSettingPage leftButtonPlusSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_008f;
				}
				if (((FrameworkElement)e.OriginalSource).DataContext is PowerKeyActionItem powerKeyActionItem_)
				{
					awaiter = leftButtonPlusSettingPage.dclox4aunt(powerKeyActionItem_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_008f;
				}
				goto end_IL_0010;
				IL_008f:
				awaiter.GetResult();
				int num2 = 0;
				if (!Pf4DZ3cfLSFXG7jxs4XJ())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
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

		internal static bool Pf4DZ3cfLSFXG7jxs4XJ()
		{
			return YTWnvWcf96pvWim4SGC6 == null;
		}
	}

	private SmartCollection<PowerKeyActionItem> vGBonDAO29 = new SmartCollection<PowerKeyActionItem>();

	private ListCollectionView Du1o40SviD;

	[CompilerGenerated]
	private bool? gd0o5AhuBr;

	private PowerKeyActionItem YCfoDn9Ngd;

	internal ToggleButton ToggleEnableLeftButtonPlus;

	internal ListView LvActions;

	internal MenuItem MenuDelete;

	internal Grid GridAddKeys;

	internal HotkeyEditorControl KeyEditor;

	internal Button BtnAddKey;

	internal Button BtnRestoreDefault;

	internal ProcessSelectorControl BlackListEditor;

	internal StackPanel PnlVersionTip;

	internal TextBlock LblVersionTip;

	private bool ge9odqQZxb;

	internal static LeftButtonPlusSettingPage wLcr73CTdB2NbT0AYOy;

	public bool? WindowResult
	{
		[CompilerGenerated]
		get
		{
			return gd0o5AhuBr;
		}
		[CompilerGenerated]
		private set
		{
			gd0o5AhuBr = value;
		}
	}

	public LeftButtonPlusSettingPage()
	{
		InitializeComponent();
		T92o1oMDLW();
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			PnlVersionTip.Visibility = Visibility.Visible;
			ListView lvActions = LvActions;
			GridAddKeys.IsEnabled = false;
			lvActions.IsEnabled = false;
		}
		else
		{
			PnlVersionTip.Visibility = Visibility.Collapsed;
			ListView lvActions2 = LvActions;
			GridAddKeys.IsEnabled = true;
			lvActions2.IsEnabled = true;
		}
	}

	private void T92o1oMDLW()
	{
		Du1o40SviD = new ListCollectionView(vGBonDAO29);
		Du1o40SviD.SortDescriptions.Add(new SortDescription("SecondaryKey", ListSortDirection.Ascending));
		LvActions.ItemsSource = Du1o40SviD;
	}

	private void m9wobd65ZW(object sender, RoutedEventArgs e)
	{
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		vGBonDAO29.Reset(AppHelper.Clone(GrZJHjXh9DrUnn7CH6P.nRytKYA0FUP()));
		ToggleEnableLeftButtonPlus.IsChecked = settings.EnableLeftButtonPlus;
		BlackListEditor.ProcessList = settings.LeftButtonPlusBlackList;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.LeftButtonPlusActions = GetResultActions();
		settings.EnableLeftButtonPlus = ToggleEnableLeftButtonPlus.IsChecked == true;
		settings.LeftButtonPlusBlackList = BlackListEditor.ProcessList;
		return true;
	}

	public IList<PowerKeyActionItem> GetResultActions()
	{
		return vGBonDAO29.ToList();
	}

	private void VpWo6vUZKt(object sender, SelectionChangedEventArgs e)
	{
		PowerKeyActionItem yCfoDn9Ngd = LvActions.SelectedItem as PowerKeyActionItem;
		YCfoDn9Ngd = yCfoDn9Ngd;
	}

	private void uXYoXsWrvW(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要还原系统默认设置么？"))
		{
			LvActions.SelectedItem = null;
			vGBonDAO29.Reset(AppHelper.Clone(GrZJHjXh9DrUnn7CH6P.eCntKe8gqVY()));
			Du1o40SviD.Refresh();
		}
	}

	private void VA9om7Ffg1(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.gwlv9zXHoVA = this;
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("请输入要添加的键。");
			return;
		}
		_003C_003Ec__DisplayClass15_.gJav9fX0K8d = KeyEditor.Hotkey.Key;
		if (vGBonDAO29.Any(_003C_003Ec__DisplayClass15_.kk5v93tZeCn))
		{
			KeyEditor.Hotkey = null;
			AppHelper.ShowWarning("已经添加了此键，不能再次添加。", true);
			return;
		}
		_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_1();
		_003C_003Ec__DisplayClass15_2.dBBvhg9gOFU = _003C_003Ec__DisplayClass15_;
		KeyEditor.Hotkey = null;
		_003C_003Ec__DisplayClass15_2.d9RvhttID78 = new PowerKeyActionItem
		{
			SecondaryKey = (int)_003C_003Ec__DisplayClass15_2.dBBvhg9gOFU.gJav9fX0K8d
		};
		int num = 0;
		if (!W9jly0CmgF9jYUIc2UE())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		vGBonDAO29.Add(_003C_003Ec__DisplayClass15_2.d9RvhttID78);
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass15_2.dkOvhwX6rn5);
	}

	[AsyncStateMachine(typeof(_003CBtnEditActionItem_OnClick_003Ed__16))]
	private void mc2oKllFUy(object sender, RoutedEventArgs e)
	{
		_003CBtnEditActionItem_OnClick_003Ed__16 stateMachine = default(_003CBtnEditActionItem_OnClick_003Ed__16);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItem_003Ed__17))]
	private Task dclox4aunt(PowerKeyActionItem powerKeyActionItem_1)
	{
		_003CEditItem_003Ed__17 stateMachine = default(_003CEditItem_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = powerKeyActionItem_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void XT0or0P5Y4(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement).Tag is PowerKeyActionItem item && AppHelper.Confirm("您确认要删除此项么？"))
		{
			vGBonDAO29.Remove(item);
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除按键。");
		}
	}

	[AsyncStateMachine(typeof(_003CLvActions_OnMouseDoubleClick_003Ed__19))]
	private void eDuopyqvZR(object sender, MouseButtonEventArgs e)
	{
		_003CLvActions_OnMouseDoubleClick_003Ed__19 stateMachine = default(_003CLvActions_OnMouseDoubleClick_003Ed__19);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void eqZoBh9DDa(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count > 0 && AppHelper.Confirm($"您确认要删除 {LvActions.SelectedItems.Count} 条规则么？\r\n删除后将无法恢复。"))
		{
			LvActions.SelectedItems.Cast<PowerKeyActionItem>().ToList().ForEach(bBuoQx80NB);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ge9odqQZxb)
		{
			ge9odqQZxb = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/leftbuttonplus/leftbuttonplussettingpage.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		case 1:
			ToggleEnableLeftButtonPlus = (ToggleButton)target;
			break;
		case 2:
			LvActions = (ListView)target;
			LvActions.MouseDoubleClick += eDuopyqvZR;
			LvActions.SelectionChanged += VpWo6vUZKt;
			break;
		case 3:
			MenuDelete = (MenuItem)target;
			MenuDelete.Click += eqZoBh9DDa;
			num = 0;
			if (!W9jly0CmgF9jYUIc2UE())
			{
				break;
			}
			goto IL_012f;
		default:
			ge9odqQZxb = true;
			break;
		case 6:
			GridAddKeys = (Grid)target;
			break;
		case 7:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 8:
			BtnAddKey = (Button)target;
			BtnAddKey.Click += VA9om7Ffg1;
			break;
		case 9:
			BtnRestoreDefault = (Button)target;
			BtnRestoreDefault.Click += uXYoXsWrvW;
			num = 0;
			if (wLcr73CTdB2NbT0AYOy == null)
			{
				break;
			}
			goto IL_012f;
		case 10:
			BlackListEditor = (ProcessSelectorControl)target;
			break;
		case 11:
			PnlVersionTip = (StackPanel)target;
			break;
		case 12:
			{
				LblVersionTip = (TextBlock)target;
				break;
			}
			IL_012f:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 5:
			((Button)target).Click += XT0or0P5Y4;
			break;
		case 4:
			((Button)target).Click += mc2oKllFUy;
			break;
		}
	}

	[CompilerGenerated]
	private void bBuoQx80NB(PowerKeyActionItem powerKeyActionItem_1)
	{
		if (vGBonDAO29.Contains(powerKeyActionItem_1))
		{
			vGBonDAO29.Remove(powerKeyActionItem_1);
		}
	}

	internal static bool W9jly0CmgF9jYUIc2UE()
	{
		return wLcr73CTdB2NbT0AYOy == null;
	}
}
