using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Domain.SQL.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Settings.Pages.Tools;

public class SyncSettingPage : SettingPage, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnLoaded_003Eb__3_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SyncSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object BWyOTwcuBPKKC1VvxPAP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncSettingPage syncSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					if (BWyOTwcuBPKKC1VvxPAP != null)
					{
						switch (0)
						{
						}
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					awaiter = syncSettingPage.VxvDurDYJw().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
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

		static _003C_003COnLoaded_003Eb__3_0_003Ed()
		{
		}

		internal static bool k9eaqCcuvdCHTUMFG2tf()
		{
			return BWyOTwcuBPKKC1VvxPAP == null;
		}

		internal static void It2MIwcuOZbOUjmocB7g()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public int xK9vZAbX6ei;

		public SyncSettingPage Cu0vZOJ2SEg;

		public IList<SyncLogItem> Wt7vZFypyH0;

		private static _003C_003Ec__DisplayClass6_0 iF0nJdcuJO4k6PXxjYho;

		internal void T7jvZMBVWn5()
		{
			xK9vZAbX6ei = Cu0vZOJ2SEg.O8ODPULs8O.GetPendingSyncItemCount();
			Wt7vZFypyH0 = Cu0vZOJ2SEg.O8ODPULs8O.GetRecentSyncLogs();
		}

		internal static bool jwFX6ncukmFEdw4RWwur()
		{
			return iF0nJdcuJO4k6PXxjYho == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSyncNow_OnClick_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SyncSettingPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object k2TtQecuNWUIQWODWhEW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncSettingPage syncSettingPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				TaskAwaiter awaiter2;
				if (num != 0)
				{
					if (num != 1)
					{
						syncSettingPage.BtnSyncNow.IsEnabled = false;
						awaiter = Task.Run((Action)syncSettingPage.IRJDCmpqOY).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00ca;
					}
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_012a;
				}
				awaiter = _003C_003Eu__1;
				int num2 = 0;
				if (!g77aQfcu9QI7LmyeV6wB())
				{
					goto IL_00de;
				}
				goto IL_00e2;
				IL_00e2:
				switch (num2)
				{
				case 1:
					goto IL_00f1;
				}
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00ca;
				IL_00de:
				int num3 = default(int);
				num2 = num3;
				goto IL_00e2;
				IL_012a:
				awaiter2.GetResult();
				syncSettingPage.BtnSyncNow.IsEnabled = true;
				goto end_IL_0010;
				IL_00f1:
				awaiter2 = syncSettingPage.VxvDurDYJw().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				goto IL_012a;
				IL_00ca:
				awaiter.GetResult();
				num2 = 1;
				if (k2TtQecuNWUIQWODWhEW != null)
				{
					goto IL_00de;
				}
				goto IL_00e2;
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

		internal static bool g77aQfcu9QI7LmyeV6wB()
		{
			return k2TtQecuNWUIQWODWhEW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SyncSettingPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object FUhSF6cuoTeMo2Xl0jog;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncSettingPage syncSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = syncSettingPage.VxvDurDYJw().GetAwaiter();
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
				syncSettingPage.BO3DECxTfP = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.ApplicationIdle, syncSettingPage.eO3D0MTuqR, Dispatcher.CurrentDispatcher);
				int num2 = 0;
				if (FUhSF6cuoTeMo2Xl0jog != null)
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

		internal static bool ymS07DcufMI8TToPFVvn()
		{
			return FUhSF6cuoTeMo2Xl0jog == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSyncStates_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SyncSettingPage _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object wPMvDIcuqSZalpg9eM2p;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncSettingPage syncSettingPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				int num2;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass6_0();
					_003C_003E8__1.Cu0vZOJ2SEg = _003C_003E4__this;
					_003C_003E8__1.xK9vZAbX6ei = 0;
					_003C_003E8__1.Wt7vZFypyH0 = null;
					awaiter = Task.Run((Action)_003C_003E8__1.T7jvZMBVWn5).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						num2 = 0;
						if (wPMvDIcuqSZalpg9eM2p != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00d4;
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
				num2 = 1;
				if (wPMvDIcuqSZalpg9eM2p != null)
				{
					goto IL_00d4;
				}
				goto IL_00f4;
				IL_00f4:
				syncSettingPage.LblSyncPendingItems.Text = _003C_003E8__1.xK9vZAbX6ei.ToString(CultureInfo.InvariantCulture);
				syncSettingPage.LblSyncState.Text = AppState.DataService.SyncState.GetEnumDisplayName();
				StringBuilder stringBuilder = new StringBuilder(1000);
				IEnumerator<SyncLogItem> enumerator = _003C_003E8__1.Wt7vZFypyH0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SyncLogItem current = enumerator.Current;
						stringBuilder.Append(current.SyncTimeUtc.ToLocalTime().ToString("yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture));
						stringBuilder.Append(" ");
						stringBuilder.AppendLine(current.IsSuccess ? "成功" : "失败");
						stringBuilder.AppendLine(current.Message);
						stringBuilder.AppendLine("-----------------------------");
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
				syncSettingPage.TxtLog.Text = stringBuilder.ToString();
				goto end_IL_0010;
				IL_00d4:
				switch (num2)
				{
				default:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				case 1:
					break;
				}
				goto IL_00f4;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool UO2PRecuiJlpyHwFJKdM()
		{
			return wPMvDIcuqSZalpg9eM2p == null;
		}
	}

	private readonly DataService O8ODPULs8O;

	private DispatcherTimer BO3DECxTfP;

	internal TextBlock LblSyncPendingItems;

	internal TextBlock LblSyncState;

	internal TextBox TxtLog;

	internal Button BtnSyncNow;

	internal Button BtnWindowsTimeSettings;

	private bool YI2DyU3y0N;

	internal static SyncSettingPage EHE2yumSZiI7Hg3kvHT;

	public SyncSettingPage()
	{
		O8ODPULs8O = AppState.DataService;
		InitializeComponent();
		base.Loaded += M60D2GFADC;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__3))]
	private void M60D2GFADC(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__3 stateMachine = default(_003COnLoaded_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		BO3DECxTfP?.Stop();
		return true;
	}

	[AsyncStateMachine(typeof(_003CUpdateSyncStates_003Ed__6))]
	private Task VxvDurDYJw()
	{
		_003CUpdateSyncStates_003Ed__6 stateMachine = default(_003CUpdateSyncStates_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnSyncNow_OnClick_003Ed__7))]
	private void DoVDNXLBfA(object sender, RoutedEventArgs e)
	{
		_003CBtnSyncNow_OnClick_003Ed__7 stateMachine = default(_003CBtnSyncNow_OnClick_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void z9yDJEv7xt(object sender, RoutedEventArgs e)
	{
		try
		{
			if (!NativeMethods.IsOnWindows10OrLater())
			{
				Process.Start("timedate.cpl");
			}
			else
			{
				Process.Start("ms-settings:dateandtime");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("启动命令出错：" + ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YI2DyU3y0N)
		{
			YI2DyU3y0N = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/syncsettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			YI2DyU3y0N = true;
			break;
		case 1:
			LblSyncPendingItems = (TextBlock)target;
			break;
		case 2:
			LblSyncState = (TextBlock)target;
			if (EHE2yumSZiI7Hg3kvHT != null)
			{
				switch (0)
				{
				}
			}
			break;
		case 3:
			TxtLog = (TextBox)target;
			break;
		case 4:
			BtnSyncNow = (Button)target;
			BtnSyncNow.Click += DoVDNXLBfA;
			break;
		case 5:
			BtnWindowsTimeSettings = (Button)target;
			BtnWindowsTimeSettings.Click += z9yDJEv7xt;
			break;
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnLoaded_003Eb__3_0_003Ed))]
	private void eO3D0MTuqR(object sender, EventArgs e)
	{
		_003C_003COnLoaded_003Eb__3_0_003Ed stateMachine = default(_003C_003COnLoaded_003Eb__3_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[CompilerGenerated]
	private void IRJDCmpqOY()
	{
		O8ODPULs8O.CbQt6821R73(true, true);
	}

	internal static void tbcvUWmmGEl44d82dsF()
	{
	}

	internal static bool OXdFIgmwnLDXlpONaEH()
	{
		return EHE2yumSZiI7Hg3kvHT == null;
	}
}
