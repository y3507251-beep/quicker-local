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

namespace xktMbIWWO7PMqiUnDME;

internal class BGfC5XWw8RJnOf7Mx5T : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public BGfC5XWw8RJnOf7Mx5T Rv6vktEuTLE;

		public qsQtMm5MtHtoYi1dcdV FQ0vkgGvo0o;

		public IntPtr VvMvkLHHGHp;

		internal static _003C_003Ec__DisplayClass1_0 QOowYfc54enmiCr8d5pI;

		internal void M70vWzpkHoK()
		{
			WindowHelper.MinimizeWindowAndOwner(Rv6vktEuTLE.Context.ParentWindow);
		}

		internal void yXuvkwQop7p()
		{
			FQ0vkgGvo0o = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Point);
			VvMvkLHHGHp = NativeMethods.GetRootWindow(NativeMethods.WindowFromPhysicalPoint(FQ0vkgGvo0o.zV7mV3Vu3D()));
			WindowHelper.RestoreWindowAndOwner(Rv6vktEuTLE.Context.ParentWindow);
		}

		internal static bool YLtyAwc5h594VhWJTcmA()
		{
			return QOowYfc54enmiCr8d5pI == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BGfC5XWw8RJnOf7Mx5T _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object OSECqecYQhmWRDbf66s0;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BGfC5XWw8RJnOf7Mx5T bGfC5XWw8RJnOf7Mx5T = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					goto IL_0098;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0101;
				IL_0098:
				_003C_003E8__1 = new _003C_003Ec__DisplayClass1_0();
				_003C_003E8__1.Rv6vktEuTLE = _003C_003E4__this;
				bGfC5XWw8RJnOf7Mx5T.X18tvyQcoJ2(sender);
				AppHelper.RunOnUiThread(true, _003C_003E8__1.M70vWzpkHoK);
				awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0101;
				IL_0101:
				awaiter.GetResult();
				_003C_003E8__1.VvMvkLHHGHp = IntPtr.Zero;
				int num2 = 0;
				if (OSECqecYQhmWRDbf66s0 != null)
				{
					goto IL_0081;
				}
				goto IL_0085;
				IL_0081:
				int num3 = default(int);
				num2 = num3;
				goto IL_0085;
				IL_0085:
				while (true)
				{
					switch (num2)
					{
					default:
						_003C_003E8__1.FQ0vkgGvo0o = null;
						AppHelper.RunOnUiThread(true, _003C_003E8__1.yXuvkwQop7p);
						if (!_003C_003E8__1.FQ0vkgGvo0o.IsSuccess)
						{
							bGfC5XWw8RJnOf7Mx5T.CancelSelection("");
							goto end_IL_0085;
						}
						goto IL_0074;
					case 2:
						break;
					case 1:
					{
						NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(_003C_003E8__1.VvMvkLHHGHp);
						int num4 = _003C_003E8__1.FQ0vkgGvo0o.zV7mV3Vu3D().X - windowRectangle.Left;
						int num5 = _003C_003E8__1.FQ0vkgGvo0o.zV7mV3Vu3D().Y - windowRectangle.Top;
						string text = $"{num4},{num5}";
						bGfC5XWw8RJnOf7Mx5T.Context.ProcessSelectedTextFunc(text, true);
						goto end_IL_0085;
					}
					}
					goto IL_0098;
					IL_0074:
					num2 = 1;
					if (OSECqecYQhmWRDbf66s0 == null)
					{
						continue;
					}
					goto IL_0081;
					continue;
					end_IL_0085:
					break;
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

		internal static bool DPulk4cYFMPEpJXCbagg()
		{
			return OSECqecYQhmWRDbf66s0 == null;
		}
	}

	internal static BGfC5XWw8RJnOf7Mx5T VgWn1fQyJGBFOfmI5ZDy;

	public BGfC5XWw8RJnOf7Mx5T(TextToolContext textToolContext_1)
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
	private void X18tvyQcoJ2(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool RQb4WqQykvismtZTcspJ()
	{
		return VgWn1fQyJGBFOfmI5ZDy == null;
	}
}
