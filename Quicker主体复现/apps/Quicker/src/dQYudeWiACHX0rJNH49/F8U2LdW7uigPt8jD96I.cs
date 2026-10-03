using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Modules.TextTools;
using Quicker.Modules.TextTools.Tools;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace dQYudeWiACHX0rJNH49;

internal class F8U2LdW7uigPt8jD96I : BaseTextTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnMouseUp_003Eb__2_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public F8U2LdW7uigPt8jD96I _003C_003E4__this;

		private BluetoothDeviceSelectorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object T6jBYIcYZaOj8JQed6ew;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			F8U2LdW7uigPt8jD96I f8U2LdW7uigPt8jD96I = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new BluetoothDeviceSelectorWindow(f8U2LdW7uigPt8jD96I.TsLtvFi12gd);
					if (!f8U2LdW7uigPt8jD96I.Context.ParentWindow.zmGvuiv40H0())
					{
						goto IL_0073;
					}
					int num2 = 0;
					if (T6jBYIcYZaOj8JQed6ew != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_0073;
					}
					_003Cdlg_003E5__2.Owner = f8U2LdW7uigPt8jD96I.Context.ParentWindow;
					goto IL_007f;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00de;
				IL_00de:
				if (awaiter.GetResult() == true)
				{
					BluetoothLEDeviceDisplay selectedDevice = _003Cdlg_003E5__2.SelectedDevice;
					f8U2LdW7uigPt8jD96I.Context.ProcessSelectedTextFunc(selectedDevice.Name, true);
				}
				else
				{
					f8U2LdW7uigPt8jD96I.CancelSelection("");
				}
				goto end_IL_0010;
				IL_007f:
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00de;
				IL_0073:
				_003Cdlg_003E5__2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
				goto IL_007f;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool HYPAlYcY576W2ov6AhVj()
		{
			return T6jBYIcYZaOj8JQed6ew == null;
		}
	}

	private readonly bool TsLtvFi12gd;

	private static F8U2LdW7uigPt8jD96I FLFJpEQpn5rRSRie4Rd9;

	public F8U2LdW7uigPt8jD96I(TextToolContext textToolContext_1, bool bool_2)
		: base(textToolContext_1)
	{
		TsLtvFi12gd = bool_2;
	}

	public override void OnMouseUp(object sender)
	{
		base.OnMouseUp(sender);
		if (!NativeMethods.IsOnWindows10OrLater())
		{
			AppHelper.ShowWarning("本功能仅支持Win10+操作系统。");
		}
		else
		{
			AppHelper.RunOnUiThread(false, oLJtvOKVPS3);
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnMouseUp_003Eb__2_0_003Ed))]
	private void oLJtvOKVPS3()
	{
		_003C_003COnMouseUp_003Eb__2_0_003Ed stateMachine = default(_003C_003COnMouseUp_003Eb__2_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool nufJSvQpeo8QK65U0Lky()
	{
		return FLFJpEQpn5rRSRie4Rd9 == null;
	}
}
