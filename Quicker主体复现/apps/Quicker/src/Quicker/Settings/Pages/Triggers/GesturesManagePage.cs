using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.ProfileManagement;
using Quicker.View.ProfileManagement.ExeSettingControls;

namespace Quicker.Settings.Pages.Triggers;

public class GesturesManagePage : SettingPage, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public GesturesManagePage Rxvv9FJO1cV;

		public ExeChangedEventArgs mHiv9Ufy9gd;

		private static _003C_003Ec__DisplayClass3_0 rBcWS6cfX6xT1crOBnes;

		internal void JGmv9Oyku1M()
		{
			Rxvv9FJO1cV.Qrsd4vVI0e = AppState.DataService.yQWt6ownR4Z(mHiv9Ufy9gd.ExeInfo.Exe, true);
			Rxvv9FJO1cV.Ttyd50amIU = AppState.DataService.yQWt6ownR4Z("_global", true);
		}

		internal static bool PhY9B9cf28W44FYGQcW8()
		{
			return rBcWS6cfX6xT1crOBnes == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExeListControl_OnExeChanged_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GesturesManagePage _003C_003E4__this;

		public ExeChangedEventArgs e;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object VuhsPjcfnSXVap34lHF6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			GesturesManagePage gesturesManagePage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run((Action)new _003C_003Ec__DisplayClass3_0
					{
						Rxvv9FJO1cV = _003C_003E4__this,
						mHiv9Ufy9gd = e
					}.JGmv9Oyku1M).ConfigureAwait(true).GetAwaiter();
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
				gesturesManagePage.Qrsd4vVI0e.EnsureDataValid();
				int num2 = 0;
				if (!qt1FZgcfee7tgMjJxWsd())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					gesturesManagePage.Ttyd50amIU.EnsureDataValid();
					gesturesManagePage.GesturesSettingsControl.SetExe(gesturesManagePage.Qrsd4vVI0e, gesturesManagePage.Ttyd50amIU);
					break;
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

		internal static bool qt1FZgcfee7tgMjJxWsd()
		{
			return VuhsPjcfnSXVap34lHF6 == null;
		}
	}

	private ExeSettings Qrsd4vVI0e;

	private ExeSettings Ttyd50amIU;

	internal ExeListControl ExeListControl;

	internal ExeGesturesSettingsControl GesturesSettingsControl;

	private bool VvsdDqVtvk;

	private static GesturesManagePage O1dXeQCX983EBQP4y9I;

	public GesturesManagePage()
	{
		InitializeComponent();
		ExeListControl.Init(AppState.DataService, AppState.ExeBeforeShowConfigWindow.Or("_global"), AppState.AppServer, AppState.B2BtasP38AU(), true);
		GesturesSettingsControl.Init(AppState.DataService);
	}

	[AsyncStateMachine(typeof(_003CExeListControl_OnExeChanged_003Ed__3))]
	private void ExeListControl_OnExeChanged(object sender, ExeChangedEventArgs e)
	{
		_003CExeListControl_OnExeChanged_003Ed__3 stateMachine = default(_003CExeListControl_OnExeChanged_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void GesturesSettingsControl_OnDataChanged(object sender, EventArgs e)
	{
		if (Qrsd4vVI0e != null)
		{
			AppState.AppServer.SaveExeSettings(Qrsd4vVI0e);
			AppState.Y2RtaqSv0AQ().NotifyCommonDataUpdated(this, "user_mouseActions");
		}
		else
		{
			AppHelper.ShowWarning("要保存的数据为空。");
		}
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!VvsdDqVtvk)
		{
			VvsdDqVtvk = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/gesturesmanagepage.xaml", UriKind.Relative);
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
			VvsdDqVtvk = true;
			break;
		case 2:
			GesturesSettingsControl = (ExeGesturesSettingsControl)target;
			break;
		case 1:
			ExeListControl = (ExeListControl)target;
			break;
		}
	}

	static GesturesManagePage()
	{
	}

	internal static bool KxJ2gcC2oJKxLx2aRII()
	{
		return O1dXeQCX983EBQP4y9I == null;
	}

	internal static void IFwS1GC3VdqGmxT1riB()
	{
	}
}
