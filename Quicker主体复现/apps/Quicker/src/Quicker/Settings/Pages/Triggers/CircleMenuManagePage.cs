using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.ExeSettingControls;
using Quicker.View.ProfileManagement;

namespace Quicker.Settings.Pages.Triggers;

public class CircleMenuManagePage : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public CircleMenuManagePage Jogv9Mwp2uJ;

		public ExeChangedEventArgs uMCv9AvuhgF;

		private static _003C_003Ec__DisplayClass3_0 MgMWckcfVPcauoWU0Kvc;

		internal void pnjv9TReZfm()
		{
			Jogv9Mwp2uJ.R14dQo3F53 = AppState.DataService.yQWt6ownR4Z(uMCv9AvuhgF.ExeInfo.Exe, true);
			Jogv9Mwp2uJ.kA6djmWMEm = AppState.DataService.yQWt6ownR4Z("_global", true);
		}

		internal static bool MYRXlecfQNdlbl2lp5xQ()
		{
			return MgMWckcfVPcauoWU0Kvc == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExeListControl_OnExeChanged_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CircleMenuManagePage _003C_003E4__this;

		public ExeChangedEventArgs e;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object mTJndAcfckgxuHbNC9eq;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CircleMenuManagePage circleMenuManagePage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run((Action)new _003C_003Ec__DisplayClass3_0
					{
						Jogv9Mwp2uJ = _003C_003E4__this,
						uMCv9AvuhgF = e
					}.pnjv9TReZfm).ConfigureAwait(true).GetAwaiter();
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
				circleMenuManagePage.R14dQo3F53.EnsureDataValid();
				circleMenuManagePage.kA6djmWMEm.EnsureDataValid();
				if (mTJndAcfckgxuHbNC9eq == null)
				{
					switch (0)
					{
					}
				}
				circleMenuManagePage.CircleMenuSettings.SetExe(circleMenuManagePage.R14dQo3F53, circleMenuManagePage.kA6djmWMEm);
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

		internal static bool miIVlbcfWx1r8JPjJs7f()
		{
			return mTJndAcfckgxuHbNC9eq == null;
		}
	}

	private ExeSettings R14dQo3F53;

	private ExeSettings kA6djmWMEm;

	internal ExeListControl ExeListControl;

	internal ExeCircleMenuSettingsControl CircleMenuSettings;

	private bool phpdnFH3qe;

	internal static CircleMenuManagePage YohL73CcbLpZBkWM8B6;

	public CircleMenuManagePage()
	{
		InitializeComponent();
		ExeListControl.Init(AppState.DataService, AppState.ExeBeforeShowConfigWindow.Or("_global"), AppState.AppServer, AppState.B2BtasP38AU(), true);
		CircleMenuSettings.Init(AppState.DataService);
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

	private void CircleMenuSettings_OnDataChanged(object sender, EventArgs e)
	{
		if (R14dQo3F53 != null)
		{
			AppState.AppServer.SaveExeSettings(R14dQo3F53);
			AppState.Y2RtaqSv0AQ().NotifyCommonDataUpdated(this, "user_mouseActions");
		}
		else
		{
			AppHelper.ShowWarning("要保存的数据为空。");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!phpdnFH3qe)
		{
			phpdnFH3qe = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/circlemenumanagepage.xaml", UriKind.Relative);
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
		default:
			phpdnFH3qe = true;
			break;
		case 2:
			CircleMenuSettings = (ExeCircleMenuSettingsControl)target;
			break;
		case 1:
			ExeListControl = (ExeListControl)target;
			break;
		}
	}

	static CircleMenuManagePage()
	{
	}

	internal static bool XTU8I4CWZwleuP6Lbc9()
	{
		return YohL73CcbLpZBkWM8B6 == null;
	}

	internal static void JgELSiCpfU3lL6fjMTY()
	{
	}
}
