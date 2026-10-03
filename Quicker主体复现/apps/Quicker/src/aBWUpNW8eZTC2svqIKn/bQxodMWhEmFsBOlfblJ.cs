using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EOqy55MyMeuU2apYyog;
using Quicker.Modules.ExpressionTester;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace aBWUpNW8eZTC2svqIKn;

internal class bQxodMWhEmFsBOlfblJ : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct cPAJybHODj8OT7CUdpN : IAsyncStateMachine
		{
			public int M5X2a6gxtrq;

			public AsyncVoidMethodBuilder as22aXjjIDP;

			public _003C_003Ec__DisplayClass1_0 mnF2amGecq9;

			private BoolExpressionHelperWindow mbN2aK1kfXM;

			private TaskAwaiter<bool?> xtV2axJcaXK;

			private static object e5mqJOyLErNWgTX6l8Lk;

			private void MoveNext()
			{
				int num = M5X2a6gxtrq;
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = mnF2amGecq9;
				try
				{
					TaskAwaiter<bool?> awaiter;
					if (num != 0)
					{
						mbN2aK1kfXM = new BoolExpressionHelperWindow(_003C_003Ec__DisplayClass1_.l5tvGn3e9h3.Context.ActionVariables, VarType.Boolean)
						{
							Owner = _003C_003Ec__DisplayClass1_.l5tvGn3e9h3.Context.ParentWindow
						};
						awaiter = mbN2aK1kfXM.MjdLOXIjD10(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							M5X2a6gxtrq = 0;
							xtV2axJcaXK = awaiter;
							as22aXjjIDP.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = xtV2axJcaXK;
						xtV2axJcaXK = default(TaskAwaiter<bool?>);
						num = -1;
						M5X2a6gxtrq = -1;
					}
					if (awaiter.GetResult() == true)
					{
						_003C_003Ec__DisplayClass1_.mMPvG4QSq5A = mbN2aK1kfXM.ResultExpression;
						_003C_003Ec__DisplayClass1_.syDvG5fHcgx = mbN2aK1kfXM.Replace;
						if (_003C_003Ec__DisplayClass1_.syDvG5fHcgx)
						{
							int num2 = 1;
							if (!Q7IQxYyLGenhJqnoUl50())
							{
								int num3 = default(int);
								num2 = num3;
							}
							do
							{
								switch (num2)
								{
								case 1:
									if (_003C_003Ec__DisplayClass1_.mMPvG4QSq5A.StartsWith("$="))
									{
										break;
									}
									goto IL_0114;
								}
								break;
								IL_0114:
								_003C_003Ec__DisplayClass1_.mMPvG4QSq5A = "$= " + _003C_003Ec__DisplayClass1_.mMPvG4QSq5A;
								num2 = 0;
							}
							while (Q7IQxYyLGenhJqnoUl50());
						}
						_003C_003Ec__DisplayClass1_.l5tvGn3e9h3.Context.ProcessSelectedTextFunc(_003C_003Ec__DisplayClass1_.mMPvG4QSq5A, _003C_003Ec__DisplayClass1_.syDvG5fHcgx);
					}
				}
				catch (Exception exception)
				{
					M5X2a6gxtrq = -2;
					mbN2aK1kfXM = null;
					as22aXjjIDP.SetException(exception);
					return;
				}
				M5X2a6gxtrq = -2;
				mbN2aK1kfXM = null;
				as22aXjjIDP.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				as22aXjjIDP.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Q7IQxYyLGenhJqnoUl50()
			{
				return e5mqJOyLErNWgTX6l8Lk == null;
			}
		}

		public bQxodMWhEmFsBOlfblJ l5tvGn3e9h3;

		public string mMPvG4QSq5A;

		public bool syDvG5fHcgx;

		internal static _003C_003Ec__DisplayClass1_0 GICnVoc8fxWUmtjoBwcB;

		[AsyncStateMachine(typeof(cPAJybHODj8OT7CUdpN))]
		internal void A1HvGjYWTx9()
		{
			cPAJybHODj8OT7CUdpN stateMachine = default(cPAJybHODj8OT7CUdpN);
			stateMachine.as22aXjjIDP = AsyncVoidMethodBuilder.Create();
			stateMachine.mnF2amGecq9 = this;
			stateMachine.M5X2a6gxtrq = -1;
			stateMachine.as22aXjjIDP.Start(ref stateMachine);
		}

		internal static bool SSpfNvc8bD5DxdbITf43()
		{
			return GICnVoc8fxWUmtjoBwcB == null;
		}
	}

	internal static bQxodMWhEmFsBOlfblJ Qkn2ydQpgdkjCg22FLTp;

	public bQxodMWhEmFsBOlfblJ(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseUp(object sender)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.l5tvGn3e9h3 = this;
		base.OnMouseUp(sender);
		_003C_003Ec__DisplayClass1_.mMPvG4QSq5A = "";
		_003C_003Ec__DisplayClass1_.syDvG5fHcgx = true;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass1_.A1HvGjYWTx9);
	}

	internal static bool J2q3mXQpPI8MJQOjXPRo()
	{
		return Qkn2ydQpgdkjCg22FLTp == null;
	}
}
