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
using Windows.Networking.Connectivity;

namespace jT53gVWdYZfWg40kEiC;

internal class sblFt5WmYnVfIZE2ajA : BaseTextTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnMouseUp_003Eb__1_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public sblFt5WmYnVfIZE2ajA _003C_003E4__this;

		private NetworkProfileSelectorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object vM7VufcYRJMiBRY6nwCT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			sblFt5WmYnVfIZE2ajA sblFt5WmYnVfIZE2ajA2 = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (DUoxpxcYg4dBApCBTZw6())
					{
						goto IL_007d;
					}
					goto IL_008a;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00e9;
				IL_00e9:
				if (awaiter.GetResult() == true)
				{
					ConnectionProfile selectedProfile = _003Cdlg_003E5__2.SelectedProfile;
					sblFt5WmYnVfIZE2ajA2.Context.ProcessSelectedTextFunc(selectedProfile.ProfileName, true);
					num2 = 1;
					if (!DUoxpxcYg4dBApCBTZw6())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_007d;
				}
				sblFt5WmYnVfIZE2ajA2.CancelSelection("");
				goto end_IL_0010;
				IL_007d:
				switch (num2)
				{
				case 1:
					goto end_IL_0010;
				}
				goto IL_008a;
				IL_008a:
				_003Cdlg_003E5__2 = new NetworkProfileSelectorWindow();
				if (sblFt5WmYnVfIZE2ajA2.Context.ParentWindow.zmGvuiv40H0())
				{
					_003Cdlg_003E5__2.Owner = sblFt5WmYnVfIZE2ajA2.Context.ParentWindow;
				}
				else
				{
					_003Cdlg_003E5__2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
				}
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00e9;
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

		internal static bool DUoxpxcYg4dBApCBTZw6()
		{
			return vM7VufcYRJMiBRY6nwCT == null;
		}
	}

	internal static sblFt5WmYnVfIZE2ajA COqbyUQpDsb14kfTrTW9;

	public sblFt5WmYnVfIZE2ajA(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
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
			AppHelper.RunOnUiThread(false, NM1tvUFcRyf);
		}
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnMouseUp_003Eb__1_0_003Ed))]
	private void NM1tvUFcRyf()
	{
		_003C_003COnMouseUp_003Eb__1_0_003Ed stateMachine = default(_003C_003COnMouseUp_003Eb__1_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool UmvjasQp3pTWdygY0ohQ()
	{
		return COqbyUQpDsb14kfTrTW9 == null;
	}
}
