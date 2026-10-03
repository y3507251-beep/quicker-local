using System;
using System.Diagnostics;
using System.Drawing;
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

namespace mNyUJHWjQrNgLgXvnop;

internal class mujO6YW2ZeYImP56lHw : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public mujO6YW2ZeYImP56lHw vb7vk2F2RmY;

		public qsQtMm5MtHtoYi1dcdV brHvkuq4mrw;

		internal static _003C_003Ec__DisplayClass1_0 BNnXXacYybfviuJBKMhj;

		internal void iowvkvqCMtK()
		{
			WindowHelper.MinimizeWindowAndOwner(vb7vk2F2RmY.Context.ParentWindow);
		}

		internal void s8SvkSYCCp2()
		{
			try
			{
				brHvkuq4mrw = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Rectangle);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(vb7vk2F2RmY.Context.ParentWindow);
		}

		internal static bool nWlFIJcYpZSOpt5gAYJt()
		{
			return BNnXXacYybfviuJBKMhj == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public mujO6YW2ZeYImP56lHw _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object ULa6f2cY2XN3oBZxsNUN;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			mujO6YW2ZeYImP56lHw mujO6YW2ZeYImP56lHw2 = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass1_0();
					_003C_003E8__1.vb7vk2F2RmY = _003C_003E4__this;
					mujO6YW2ZeYImP56lHw2.uJ8tv8oATvB(sender);
					AppHelper.RunOnUiThread(true, _003C_003E8__1.iowvkvqCMtK);
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
					while (true)
					{
						awaiter = _003C_003Eu__1;
						if (ULa6f2cY2XN3oBZxsNUN != null)
						{
							switch (1)
							{
							default:
								continue;
							case 1:
								break;
							}
						}
						break;
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				_003C_003E8__1.brHvkuq4mrw = null;
				AppHelper.RunOnUiThread(true, _003C_003E8__1.s8SvkSYCCp2);
				if (_003C_003E8__1.brHvkuq4mrw.IsSuccess)
				{
					Rectangle rectangle = _003C_003E8__1.brHvkuq4mrw.tyEmRRGGv3();
					string text = $"{rectangle.Left},{rectangle.Top},{rectangle.Right},{rectangle.Bottom}";
					mujO6YW2ZeYImP56lHw2.Context.ProcessSelectedTextFunc(text, true);
				}
				else
				{
					mujO6YW2ZeYImP56lHw2.CancelSelection("");
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

		internal static bool TUF1mDcYAJNNXrajxaoA()
		{
			return ULa6f2cY2XN3oBZxsNUN == null;
		}
	}

	private static mujO6YW2ZeYImP56lHw Ekh8CKQyr4KEYbqdLg7T;

	public mujO6YW2ZeYImP56lHw(TextToolContext textToolContext_1)
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
	private void uJ8tv8oATvB(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool msYH2FQyNbflpkaySgol()
	{
		return Ekh8CKQyr4KEYbqdLg7T == null;
	}
}
