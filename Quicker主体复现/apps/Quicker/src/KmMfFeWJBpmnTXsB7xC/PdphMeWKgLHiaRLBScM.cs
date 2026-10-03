using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using EOqy55MyMeuU2apYyog;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.View;

namespace KmMfFeWJBpmnTXsB7xC;

internal class PdphMeWKgLHiaRLBScM : BaseTextTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditInCodeWindowAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string resultText)> _003C_003Et__builder;

		public ICollection<ActionVariable> variables;

		public string defaultHighlightingType;

		public Window ownerWindow;

		public string currentContent;

		private CodeEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object vGbt3FcR2OpAP8clRKoi;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new CodeEditorWindow(variables, true, defaultHighlightingType)
					{
						Owner = Window.GetWindow(ownerWindow),
						Text = currentContent
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						int num2 = 0;
						if (vGbt3FcR2OpAP8clRKoi != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				result = (true, _003Cdlg_003E5__2.Text);
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
			_003C_003Et__builder.SetResult(result);
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

		internal static bool QESgFvcRAJRmm9G7qEA9()
		{
			return vGbt3FcR2OpAP8clRKoi == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseDown_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PdphMeWKgLHiaRLBScM _003C_003E4__this;

		public object sender;

		private TaskAwaiter<(bool isSuccess, string resultText)> _003C_003Eu__1;

		internal static object Uq6JAPcReYJtZODySgqr;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PdphMeWKgLHiaRLBScM pdphMeWKgLHiaRLBScM = _003C_003E4__this;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				if (num != 0)
				{
					pdphMeWKgLHiaRLBScM.DY8t2NKC2k7(sender);
					awaiter = wwvt2u7wu0q(pdphMeWKgLHiaRLBScM.Context.ParentWindow, pdphMeWKgLHiaRLBScM.Context.TextControl.GetAllText(), pdphMeWKgLHiaRLBScM.Context.ActionVariables, pdphMeWKgLHiaRLBScM.Context.DefaultHighlightingType).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
				}
				(bool, string) result = awaiter.GetResult();
				if (result.Item1)
				{
					if (Uq6JAPcReYJtZODySgqr != null)
					{
						switch (0)
						{
						}
					}
					pdphMeWKgLHiaRLBScM.Context.ProcessSelectedTextFunc?.Invoke(result.Item2, true);
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

		static _003COnMouseDown_003Ed__1()
		{
		}

		internal static bool KIqZxncRjgaoJIJg1NK6()
		{
			return Uq6JAPcReYJtZODySgqr == null;
		}

		internal static void Y50kBIcR3Bytt4lBAaM1()
		{
		}
	}

	internal static PdphMeWKgLHiaRLBScM AyklwAQXMZLBEvi0IrW0;

	public PdphMeWKgLHiaRLBScM(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	[AsyncStateMachine(typeof(_003COnMouseDown_003Ed__1))]
	public override void OnMouseDown(object sender)
	{
		_003COnMouseDown_003Ed__1 stateMachine = default(_003COnMouseDown_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditInCodeWindowAsync_003Ed__2))]
	public static Task<(bool isSuccess, string resultText)> wwvt2u7wu0q(Window window_0, string string_0, ICollection<ActionVariable> icollection_0, string string_1)
	{
		_003CEditInCodeWindowAsync_003Ed__2 stateMachine = default(_003CEditInCodeWindowAsync_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.ownerWindow = window_0;
		stateMachine.currentContent = string_0;
		stateMachine.variables = icollection_0;
		stateMachine.defaultHighlightingType = string_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void DY8t2NKC2k7(object object_0)
	{
		base.OnMouseDown(object_0);
	}

	internal static bool kJYJJvQXUx9lgtjsDH50()
	{
		return AyklwAQXMZLBEvi0IrW0 == null;
	}
}
