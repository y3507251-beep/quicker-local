using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View;

public class ActionFeedbackWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec FaZSx3kKED4;

		public static EventHandler XnXSxfgS0O0;

		private static _003C_003Ec XfIbLtWgEMiaU37jLbbM;

		static _003C_003Ec()
		{
			FaZSx3kKED4 = new _003C_003Ec();
		}

		internal void N45SxiP2Uol(object sender, EventArgs e)
		{
		}

		internal static bool FWe8RQWgGJrRjby7HxSE()
		{
			return XfIbLtWgEMiaU37jLbbM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnFail_OnClick_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionFeedbackWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object hM73fZWg1LwL3BKTZso4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionFeedbackWindow actionFeedbackWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					actionFeedbackWindow.BtnPanel.IsEnabled = false;
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.T4Ct1iQlGVJ(new ActionVerifyVm
						{
							IsSuccess = false,
							RetryCount = 0,
							Revision = actionFeedbackWindow.Action.TemplateRevision,
							SharedActionId = Guid.Parse(actionFeedbackWindow.Action.TemplateId),
							Content = "",
							QuickerVersion = AppHelper.GetCurrAppVersion()
						}).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00f0;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 1;
					if (hM73fZWg1LwL3BKTZso4 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0105;
					IL_0105:
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_0115;
					}
					goto IL_00f0;
					IL_0115:
					ApiResult<string> result = default(ApiResult<string>);
					if (result.IsSuccess)
					{
						AppHelper.TryOpenUrlOrFile("https://getquicker.net/share/NewActionFeedback?feedbackId=" + result.Data);
						AppHelper.ShowInformation("提交成功。请在打开的网页中补充详细信息，谢谢！");
						actionFeedbackWindow.Close();
					}
					else
					{
						AppHelper.ShowWarning("提交出错：" + result.Message);
					}
					goto end_IL_0022;
					IL_00f0:
					result = awaiter.GetResult();
					num2 = 0;
					if (hM73fZWg1LwL3BKTZso4 == null)
					{
						goto IL_0105;
					}
					goto IL_0115;
					end_IL_0022:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowInformation("提交失败了。" + ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						actionFeedbackWindow.BtnPanel.IsEnabled = true;
					}
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

		internal static bool JL8eXvWgK05lsJJ5cY7V()
		{
			return hM73fZWg1LwL3BKTZso4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSuccess_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionFeedbackWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object WEJOLVWgONxUU5V5AvCW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionFeedbackWindow actionFeedbackWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					actionFeedbackWindow.BtnPanel.IsEnabled = false;
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.T4Ct1iQlGVJ(new ActionVerifyVm
						{
							IsSuccess = true,
							RetryCount = 0,
							Revision = actionFeedbackWindow.Action.TemplateRevision,
							SharedActionId = Guid.Parse(actionFeedbackWindow.Action.TemplateId),
							QuickerVersion = AppHelper.GetCurrAppVersion()
						}).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (!QiQvd6WgJK598CPgST3w())
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
					AppHelper.ShowInformation("提交成功。谢谢你！");
					actionFeedbackWindow.Close();
				}
				catch (Exception ex)
				{
					AppHelper.ShowInformation("提交失败了。" + ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						actionFeedbackWindow.BtnPanel.IsEnabled = true;
					}
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

		internal static bool QiQvd6WgJK598CPgST3w()
		{
			return WEJOLVWgONxUU5V5AvCW == null;
		}
	}

	[CompilerGenerated]
	private ActionItem zkfgl8ORjKo;

	private readonly bool fVNglaBZNhd;

	internal ActionButton BtnAction;

	internal StackPanel BtnPanel;

	internal Button BtnSuccess;

	internal Button BtnFail;

	internal Button BtnRetry;

	private bool LPKgl7HDGU3;

	private static ActionFeedbackWindow lgo0wiFyNSVJMN9BrwLy;

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return zkfgl8ORjKo;
		}
		[CompilerGenerated]
		set
		{
			zkfgl8ORjKo = value;
		}
	}

	public ActionFeedbackWindow(ActionItem action, bool isAutoFeedback)
	{
		Action = action;
		fVNglaBZNhd = isAutoFeedback;
		InitializeComponent();
		base.SourceInitialized += _003C_003Ec.XnXSxfgS0O0 ?? (_003C_003Ec.XnXSxfgS0O0 = _003C_003Ec.FaZSx3kKED4.N45SxiP2Uol);
		base.Loaded += iGjglCT6nby;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void iGjglCT6nby(object sender, RoutedEventArgs e)
	{
		BtnAction.ActionItem = Action;
	}

	[AsyncStateMachine(typeof(_003CBtnSuccess_OnClick_003Ed__8))]
	private void SthglPGas2j(object sender, RoutedEventArgs e)
	{
		_003CBtnSuccess_OnClick_003Ed__8 stateMachine = default(_003CBtnSuccess_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnFail_OnClick_003Ed__9))]
	private void NXEglEpaHtD(object sender, RoutedEventArgs e)
	{
		_003CBtnFail_OnClick_003Ed__9 stateMachine = default(_003CBtnFail_OnClick_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void cdngly7FIZ4(object sender, RoutedEventArgs e)
	{
		if (fVNglaBZNhd)
		{
			ActionFeedbackHelper.RetryAction(Guid.Parse(Action.TemplateId));
		}
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!LPKgl7HDGU3)
		{
			LPKgl7HDGU3 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/share/actionfeedbackwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		default:
			LPKgl7HDGU3 = true;
			break;
		case 1:
			BtnAction = (ActionButton)target;
			break;
		case 2:
			BtnPanel = (StackPanel)target;
			break;
		case 3:
			BtnSuccess = (Button)target;
			BtnSuccess.Click += SthglPGas2j;
			break;
		case 4:
			BtnFail = (Button)target;
			BtnFail.Click += NXEglEpaHtD;
			break;
		case 5:
		{
			BtnRetry = (Button)target;
			BtnRetry.Click += cdngly7FIZ4;
			int num = 0;
			if (!yoQYoaFy9MZ5OZX7loDo())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	internal static bool yoQYoaFy9MZ5OZX7loDo()
	{
		return lgo0wiFyNSVJMN9BrwLy == null;
	}
}
