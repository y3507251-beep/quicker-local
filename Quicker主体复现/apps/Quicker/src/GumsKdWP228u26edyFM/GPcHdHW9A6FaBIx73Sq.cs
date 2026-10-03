using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using log4net;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using UIAutoHelper;
using w9EMkUMAtDtgf3V0lLP;

namespace GumsKdWP228u26edyFM;

internal class GPcHdHW9A6FaBIx73Sq : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public GPcHdHW9A6FaBIx73Sq WKvvGiPBMo8;

		public string dBFvG3lrRqJ;

		private static _003C_003Ec__DisplayClass2_0 mWdeA7c8Mg4LcarJPw3X;

		internal void o90vGUWwSMX()
		{
			WindowHelper.MinimizeWindowAndOwner(WKvvGiPBMo8.Context.ParentWindow);
		}

		internal void P0uvGlCX53i()
		{
			AutomationElement automationElement = null;
			QTP3xxM50biGA830fZg qTP3xxM50biGA830fZg = new QTP3xxM50biGA830fZg();
			qTP3xxM50biGA830fZg.ShowDialog();
			qTP3xxM50biGA830fZg.Dispose();
			automationElement = qTP3xxM50biGA830fZg.L1XLDjRrVi1();
			AutomationElement automationElement_ = qTP3xxM50biGA830fZg.hILLD5ZHybZ();
			if (automationElement != null)
			{
				try
				{
					dBFvG3lrRqJ = AutomationHelper4FlaUI.vwrEaeusyU(automationElement, automationElement_);
				}
				catch (Exception ex)
				{
					Ja1tSpWLAa5.Warn("无法获取此对象的XPath。错误：" + ex.Message, ex);
					AppHelper.ShowWarning("无法获取此对象的XPath。错误：" + ex.Message);
				}
			}
			WindowHelper.RestoreWindowAndOwner(WKvvGiPBMo8.Context.ParentWindow);
		}

		internal static bool cQ5tjYc8U5R42HRfMFUS()
		{
			return mWdeA7c8Mg4LcarJPw3X == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GPcHdHW9A6FaBIx73Sq _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object xtuauyc8SWQZXHh8yQXn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			GPcHdHW9A6FaBIx73Sq gPcHdHW9A6FaBIx73Sq = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
				int num2;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass2_0();
					_003C_003E8__1.WKvvGiPBMo8 = _003C_003E4__this;
					gPcHdHW9A6FaBIx73Sq.cbotSr3BHUg(sender);
					AppHelper.RunOnUiThread(true, _003C_003E8__1.o90vGUWwSMX);
					configuredTaskAwaitable = Task.Delay(300).ConfigureAwait(true);
					num2 = 0;
					if (xtuauyc8SWQZXHh8yQXn == null)
					{
						goto IL_0097;
					}
					goto IL_00a4;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00b6;
				IL_00b6:
				awaiter.GetResult();
				_003C_003E8__1.dBFvG3lrRqJ = "";
				AppHelper.RunOnUiThread(true, _003C_003E8__1.P0uvGlCX53i);
				num2 = 1;
				if (xtuauyc8SWQZXHh8yQXn != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_0097;
				IL_0097:
				switch (num2)
				{
				case 1:
					if (!string.IsNullOrEmpty(_003C_003E8__1.dBFvG3lrRqJ))
					{
						gPcHdHW9A6FaBIx73Sq.Context.ProcessSelectedTextFunc(_003C_003E8__1.dBFvG3lrRqJ, true);
					}
					else
					{
						gPcHdHW9A6FaBIx73Sq.CancelSelection("");
					}
					goto end_IL_0010;
				}
				goto IL_00a4;
				IL_00a4:
				awaiter = configuredTaskAwaitable.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00b6;
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

		static _003COnMouseUp_003Ed__2()
		{
		}

		internal static bool rdI6gwc8wXPP16j2OYO4()
		{
			return xtuauyc8SWQZXHh8yQXn == null;
		}

		internal static void Q45ErPc8sVq6ocrieHp9()
		{
		}
	}

	private static readonly ILog Ja1tSpWLAa5;

	private static GPcHdHW9A6FaBIx73Sq aIUWk8QpTvv9FMmWUXdS;

	public GPcHdHW9A6FaBIx73Sq(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	[AsyncStateMachine(typeof(_003COnMouseUp_003Ed__2))]
	public override void OnMouseUp(object sender)
	{
		_003COnMouseUp_003Ed__2 stateMachine = default(_003COnMouseUp_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	static GPcHdHW9A6FaBIx73Sq()
	{
		Ja1tSpWLAa5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void cbotSr3BHUg(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static void BhvytgQpCbfEt12KYQLS()
	{
	}

	internal static bool EtmUFtQpm77dlPoRxd53()
	{
		return aIUWk8QpTvv9FMmWUXdS == null;
	}
}
