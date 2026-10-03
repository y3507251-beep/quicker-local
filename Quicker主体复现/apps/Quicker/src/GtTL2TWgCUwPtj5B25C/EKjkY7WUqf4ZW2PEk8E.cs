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

namespace GtTL2TWgCUwPtj5B25C;

internal class EKjkY7WUqf4ZW2PEk8E : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public EKjkY7WUqf4ZW2PEk8E Ep8vsw95M2J;

		public qsQtMm5MtHtoYi1dcdV VLRvstGUU2n;

		internal static _003C_003Ec__DisplayClass1_0 bGFjTCc8CIjsFwRMyV2g;

		internal void I6ovGf1U4Pk()
		{
			WindowHelper.MinimizeWindowAndOwner(Ep8vsw95M2J.Context.ParentWindow);
		}

		internal void CyWvGzEGGkY()
		{
			try
			{
				VLRvstGUU2n = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(Ep8vsw95M2J.Context.ParentWindow);
		}

		internal static bool WM8peGc87aBbjOnehCKJ()
		{
			return bGFjTCc8CIjsFwRMyV2g == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EKjkY7WUqf4ZW2PEk8E _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object CPf286c8hIE6h5RqacWl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EKjkY7WUqf4ZW2PEk8E eKjkY7WUqf4ZW2PEk8E = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				int num2;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass1_0();
					_003C_003E8__1.Ep8vsw95M2J = _003C_003E4__this;
					eKjkY7WUqf4ZW2PEk8E.jKMtSloAmsO(sender);
					AppHelper.RunOnUiThread(true, _003C_003E8__1.I6ovGf1U4Pk);
					awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
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
					num2 = 0;
					if (!RIFVlQc8HQ7ecrLQskFC())
					{
						goto IL_00d2;
					}
				}
				goto IL_0114;
				IL_00d2:
				string text = default(string);
				switch (num2)
				{
				case 1:
					break;
				default:
					eKjkY7WUqf4ZW2PEk8E.Context.ProcessSelectedTextFunc(text, true);
					goto end_IL_0010;
				}
				goto IL_0114;
				IL_0114:
				awaiter.GetResult();
				_003C_003E8__1.VLRvstGUU2n = null;
				AppHelper.RunOnUiThread(true, _003C_003E8__1.CyWvGzEGGkY);
				if (_003C_003E8__1.VLRvstGUU2n.IsSuccess)
				{
					text = _003C_003E8__1.VLRvstGUU2n.wZFmIfirit().ToRgbHexString() ?? "";
					num2 = 0;
					if (!RIFVlQc8HQ7ecrLQskFC())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_00d2;
				}
				eKjkY7WUqf4ZW2PEk8E.CancelSelection("");
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

		internal static bool RIFVlQc8HQ7ecrLQskFC()
		{
			return CPf286c8hIE6h5RqacWl == null;
		}
	}

	internal static EKjkY7WUqf4ZW2PEk8E kqUrHqQXASggf6OsuaIa;

	public EKjkY7WUqf4ZW2PEk8E(TextToolContext textToolContext_1)
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
	private void jKMtSloAmsO(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool bbrf9PQXntfkiPlRg5dn()
	{
		return kqUrHqQXASggf6OsuaIa == null;
	}
}
