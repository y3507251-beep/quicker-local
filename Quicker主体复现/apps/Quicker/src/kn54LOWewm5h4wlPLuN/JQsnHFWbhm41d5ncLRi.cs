using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using c4LBdq5YohQFUgxFYw4;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Modules.TextTools;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace kn54LOWewm5h4wlPLuN;

internal class JQsnHFWbhm41d5ncLRi : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public JQsnHFWbhm41d5ncLRi tcEvGoCk8J1;

		public string HeZvGTqPEpc;

		internal static _003C_003Ec__DisplayClass1_0 uuU9A5c8itfnfDS4hmeA;

		internal void OgevGDuU7pS()
		{
			WindowHelper.MinimizeWindowAndOwner(tcEvGoCk8J1.Context.ParentWindow);
		}

		internal void QkbvGdQfekU()
		{
			try
			{
				qsQtMm5MtHtoYi1dcdV qsQtMm5MtHtoYi1dcdV = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Rectangle, true);
				if (qsQtMm5MtHtoYi1dcdV.IsSuccess)
				{
					(bool, string) tuple = AppHelper.ShowSaveFileDialog("png 图片(*.png)|*.png", ".png", "", "", "保存截图");
					if (tuple.Item1)
					{
						HeZvGTqPEpc = tuple.Item2;
						qsQtMm5MtHtoYi1dcdV.Image.Save(HeZvGTqPEpc);
					}
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(tcEvGoCk8J1.Context.ParentWindow);
		}

		internal static bool fuHdTHc8lyf88MZuBdIl()
		{
			return uuU9A5c8itfnfDS4hmeA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public JQsnHFWbhm41d5ncLRi _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object T7rIubc85kiCk3v8ejR6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			JQsnHFWbhm41d5ncLRi jQsnHFWbhm41d5ncLRi = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00c2;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass1_0();
				_003C_003E8__1.tcEvGoCk8J1 = _003C_003E4__this;
				int num2 = 1;
				if (!ieL692c8YdZxbnS2h8XH())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_00c2;
				}
				jQsnHFWbhm41d5ncLRi.m6ItSKGs2jO(sender);
				AppHelper.RunOnUiThread(true, _003C_003E8__1.OgevGDuU7pS);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00e0;
				IL_00c2:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00e0;
				IL_00e0:
				awaiter.GetResult();
				_003C_003E8__1.HeZvGTqPEpc = "";
				AppHelper.RunOnUiThread(true, _003C_003E8__1.QkbvGdQfekU);
				if (!string.IsNullOrEmpty(_003C_003E8__1.HeZvGTqPEpc))
				{
					jQsnHFWbhm41d5ncLRi.Context.ProcessSelectedTextFunc(_003C_003E8__1.HeZvGTqPEpc, false);
				}
				else
				{
					jQsnHFWbhm41d5ncLRi.CancelSelection("");
				}
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

		internal static bool ieL692c8YdZxbnS2h8XH()
		{
			return T7rIubc85kiCk3v8ejR6 == null;
		}
	}

	private static JQsnHFWbhm41d5ncLRi ITc5DUQpULupm9YXQ2in;

	public JQsnHFWbhm41d5ncLRi(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	[AsyncStateMachine(typeof(_003COnMouseUp_003Ed__1))]
	public override void OnMouseUp(object sender)
	{
		_003COnMouseUp_003Ed__1 stateMachine = default(_003COnMouseUp_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void m6ItSKGs2jO(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	static JQsnHFWbhm41d5ncLRi()
	{
	}

	internal static bool rRq7AbQpxikOo3e4XAXh()
	{
		return ITc5DUQpULupm9YXQ2in == null;
	}

	internal static void M0x5LVQp6BxjTQ84PTuU()
	{
	}
}
