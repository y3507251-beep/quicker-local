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
using Quicker.Utilities.Win32;

namespace LTbL06Wo7atseX0r4k4;

internal class OUx8mCWXI8eYs5gUtkb : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public OUx8mCWXI8eYs5gUtkb CfZvk0JuhRe;

		public qsQtMm5MtHtoYi1dcdV aaZvkC3PPQD;

		private static _003C_003Ec__DisplayClass1_0 RWJ3EecYe4kaynPHPOnP;

		internal void hAtvkNb7Tpm()
		{
			WindowHelper.MinimizeWindowAndOwner(CfZvk0JuhRe.Context.ParentWindow);
		}

		internal void Sk6vkJqYxWW()
		{
			aaZvkC3PPQD = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Point);
			WindowHelper.RestoreWindowAndOwner(CfZvk0JuhRe.Context.ParentWindow);
		}

		internal static bool qSxKPXcYjmAg96ypVQGu()
		{
			return RWJ3EecYe4kaynPHPOnP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OUx8mCWXI8eYs5gUtkb _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object FoWT1dcY3ykTbDfMfZH1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OUx8mCWXI8eYs5gUtkb oUx8mCWXI8eYs5gUtkb = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass1_0();
					_003C_003E8__1.CfZvk0JuhRe = _003C_003E4__this;
					oUx8mCWXI8eYs5gUtkb.QMytvaHiN7D(sender);
					AppHelper.RunOnUiThread(true, _003C_003E8__1.hAtvkNb7Tpm);
					awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a2;
				}
				goto IL_015d;
				IL_015d:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00a2;
				IL_00a2:
				awaiter.GetResult();
				_003C_003E8__1.aaZvkC3PPQD = null;
				AppHelper.RunOnUiThread(true, _003C_003E8__1.Sk6vkJqYxWW);
				if (_003C_003E8__1.aaZvkC3PPQD.IsSuccess)
				{
					string text = $"{_003C_003E8__1.aaZvkC3PPQD.zV7mV3Vu3D().X},{_003C_003E8__1.aaZvkC3PPQD.zV7mV3Vu3D().Y}";
					oUx8mCWXI8eYs5gUtkb.Context.ProcessSelectedTextFunc(text, true);
					int num2 = 1;
					if (FoWT1dcY3ykTbDfMfZH1 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto end_IL_0010;
					}
					goto IL_015d;
				}
				oUx8mCWXI8eYs5gUtkb.CancelSelection("");
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

		internal static bool wj0lqAcYEAcbx87T5FMG()
		{
			return FoWT1dcY3ykTbDfMfZH1 == null;
		}
	}

	private static OUx8mCWXI8eYs5gUtkb I5aeAPQyu0JtsWhosQ0a;

	public OUx8mCWXI8eYs5gUtkb(TextToolContext textToolContext_1)
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

	[CompilerGenerated]
	[DebuggerHidden]
	private void QMytvaHiN7D(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool IlxZQpQyosJKBBGYY7xS()
	{
		return I5aeAPQyu0JtsWhosQ0a == null;
	}
}
