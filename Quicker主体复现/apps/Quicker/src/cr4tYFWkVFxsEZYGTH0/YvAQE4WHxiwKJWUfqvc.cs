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

namespace cr4tYFWkVFxsEZYGTH0;

internal class YvAQE4WHxiwKJWUfqvc : BaseTextTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnMouseUp_003Eb__1_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public YvAQE4WHxiwKJWUfqvc _003C_003E4__this;

		private ProfileExeSelectWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object Tq1LiAc8LJZCJqtmMy1K;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YvAQE4WHxiwKJWUfqvc yvAQE4WHxiwKJWUfqvc = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 1;
					if (Tq1LiAc8LJZCJqtmMy1K == null)
					{
						goto IL_0024;
					}
					goto IL_0064;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00f5;
				IL_0064:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0071;
				}
				goto IL_0024;
				IL_00f5:
				if (awaiter.GetResult() == true)
				{
					string selectedExe = _003Cdlg_003E5__2.SelectedExe;
					yvAQE4WHxiwKJWUfqvc.Context.ProcessSelectedTextFunc(selectedExe, true);
				}
				goto end_IL_0010;
				IL_0024:
				_003Cdlg_003E5__2 = new ProfileExeSelectWindow(yvAQE4WHxiwKJWUfqvc.Context.TextControl.GetAllText());
				if (yvAQE4WHxiwKJWUfqvc.Context.ParentWindow.zmGvuiv40H0())
				{
					num2 = 0;
					if (Tq1LiAc8LJZCJqtmMy1K != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0064;
				}
				_003Cdlg_003E5__2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
				goto IL_0096;
				IL_0096:
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00f5;
				IL_0071:
				_003Cdlg_003E5__2.Owner = yvAQE4WHxiwKJWUfqvc.Context.ParentWindow;
				goto IL_0096;
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

		internal static bool iTN0kkc8uwVJlp476e1w()
		{
			return Tq1LiAc8LJZCJqtmMy1K == null;
		}
	}

	internal static YvAQE4WHxiwKJWUfqvc SZD16OQpqsNuqW5iT0kc;

	public YvAQE4WHxiwKJWUfqvc(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseUp(object sender)
	{
		base.OnMouseUp(sender);
		AppHelper.RunOnUiThread(false, JtptSG6K3mP);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnMouseUp_003Eb__1_0_003Ed))]
	private void JtptSG6K3mP()
	{
		_003C_003COnMouseUp_003Eb__1_0_003Ed stateMachine = default(_003C_003COnMouseUp_003Eb__1_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool BnnBP4QpiFpUKn6HtDEo()
	{
		return SZD16OQpqsNuqW5iT0kc == null;
	}
}
