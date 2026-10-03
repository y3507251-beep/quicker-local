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
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Domain.SQL.Entities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class SyncStateWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public int KA1Sxh1T6Im;

		public SyncStateWindow oVXSxeOfXjp;

		internal static _003C_003Ec__DisplayClass4_0 aY5lbEW8oB4uPHGcxvru;

		internal void Ek2Sx98MUSv()
		{
			KA1Sxh1T6Im = oVXSxeOfXjp.pUGgFsviJH1.GetPendingSyncItemCount();
		}

		internal static bool B9tCRXW8f1dTbuTChxb8()
		{
			return aY5lbEW8oB4uPHGcxvru == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSyncNow_OnClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SyncStateWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object zUtNwyW8qSsJAeFYQ4Wh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncStateWindow syncStateWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num != 0)
				{
					int num2;
					if (num != 1)
					{
						syncStateWindow.BtnSyncNow.IsEnabled = false;
						num2 = 1;
						if (zUtNwyW8qSsJAeFYQ4Wh != null)
						{
							goto IL_005e;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num2 = 0;
						if (zUtNwyW8qSsJAeFYQ4Wh != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
					}
					switch (num2)
					{
					case 1:
						goto IL_0079;
					}
					goto IL_005e;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2 = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00e8;
				IL_0079:
				awaiter2 = Task.Run((Action)syncStateWindow.xkCgFGN1KQq).ConfigureAwait(true).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				goto IL_00e8;
				IL_00e8:
				awaiter2.GetResult();
				awaiter = syncStateWindow.UaxgFYmmVie().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0128;
				IL_0128:
				awaiter.GetResult();
				syncStateWindow.BtnSyncNow.IsEnabled = true;
				goto end_IL_0010;
				IL_005e:
				_003C_003Eu__2 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0128;
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

		internal static bool NMSQUiW8i5lFnXdbgVOo()
		{
			return zUtNwyW8qSsJAeFYQ4Wh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SyncStateWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object UoLP7hW85JvSvLbwSnEH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncStateWindow syncStateWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = syncStateWindow.UaxgFYmmVie().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (UoLP7hW85JvSvLbwSnEH != null)
						{
							switch (0)
							{
							}
						}
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

		internal static bool TAsx1tW8YQrxgt5XuQrD()
		{
			return UoLP7hW85JvSvLbwSnEH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSyncStates_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SyncStateWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		internal static object UeNGIUW8R9CrJyjQwqaW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SyncStateWindow syncStateWindow = _003C_003E4__this;
			try
			{
				int num2;
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass4_0();
					num2 = 0;
					if (UeNGIUW8R9CrJyjQwqaW != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					num2 = 1;
					if (UeNGIUW8R9CrJyjQwqaW != null)
					{
						goto IL_00d4;
					}
				}
				switch (num2)
				{
				default:
					_003C_003E8__1.oVXSxeOfXjp = _003C_003E4__this;
					_003C_003E8__1.KA1Sxh1T6Im = 0;
					awaiter = Task.Run((Action)_003C_003E8__1.Ek2Sx98MUSv).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				case 1:
					break;
				}
				goto IL_00d4;
				IL_00d4:
				awaiter.GetResult();
				syncStateWindow.LblSyncPendingItems.Content = _003C_003E8__1.KA1Sxh1T6Im.ToString(CultureInfo.InvariantCulture);
				IList<SyncLogItem> recentSyncLogs = syncStateWindow.pUGgFsviJH1.GetRecentSyncLogs();
				StringBuilder stringBuilder = new StringBuilder(1000);
				IEnumerator<SyncLogItem> enumerator = recentSyncLogs.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SyncLogItem current = enumerator.Current;
						stringBuilder.Append(current.SyncTimeUtc.ToLocalTime().ToString("yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture));
						stringBuilder.Append(" ");
						stringBuilder.AppendLine((!current.IsSuccess) ? "失败" : "成功");
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
				syncStateWindow.TxtLog.Text = stringBuilder.ToString();
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

		internal static bool eNaFbZW8ggcZoWkwPhEI()
		{
			return UeNGIUW8R9CrJyjQwqaW == null;
		}
	}

	private readonly DataService pUGgFsviJH1;

	internal Label LblSyncPendingItems;

	internal TextBox TxtLog;

	internal Button BtnSyncNow;

	internal Button BtnClose;

	private bool dS7gFH0Tcsq;

	private static SyncStateWindow nYUuryFWsIjRKmaIYEjB;

	public SyncStateWindow(DataService dataService)
	{
		pUGgFsviJH1 = dataService;
		InitializeComponent();
		base.Loaded += cj8gFe62QLb;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__3))]
	private void cj8gFe62QLb(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__3 stateMachine = default(_003COnLoaded_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CUpdateSyncStates_003Ed__4))]
	private Task UaxgFYmmVie()
	{
		_003CUpdateSyncStates_003Ed__4 stateMachine = default(_003CUpdateSyncStates_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnSyncNow_OnClick_003Ed__5))]
	private void dOMgFINNwiK(object sender, RoutedEventArgs e)
	{
		_003CBtnSyncNow_OnClick_003Ed__5 stateMachine = default(_003CBtnSyncNow_OnClick_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void DuqgFWoTJMu(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void dgXgFkaAHqs(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!dS7gFH0Tcsq)
		{
			dS7gFH0Tcsq = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/syncstatewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			dS7gFH0Tcsq = true;
			break;
		case 1:
			((SyncStateWindow)target).PreviewKeyDown += dgXgFkaAHqs;
			break;
		case 2:
			LblSyncPendingItems = (Label)target;
			break;
		case 3:
			TxtLog = (TextBox)target;
			break;
		case 4:
			BtnSyncNow = (Button)target;
			BtnSyncNow.Click += dOMgFINNwiK;
			break;
		case 5:
		{
			BtnClose = (Button)target;
			int num = 0;
			if (nYUuryFWsIjRKmaIYEjB != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnClose.Click += DuqgFWoTJMu;
				break;
			}
			break;
		}
		}
	}

	[CompilerGenerated]
	private void xkCgFGN1KQq()
	{
		pUGgFsviJH1.CbQt6821R73(true, true);
	}

	internal static bool nChBvqFWCWwftgGJyT2V()
	{
		return nYUuryFWsIjRKmaIYEjB == null;
	}
}
