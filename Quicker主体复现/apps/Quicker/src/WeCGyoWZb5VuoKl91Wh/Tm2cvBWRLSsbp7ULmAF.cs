using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Quicker.Utilities;
using Quicker.View;
using WindowsInput;

namespace WeCGyoWZb5VuoKl91Wh;

internal class Tm2cvBWRLSsbp7ULmAF
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct GJXpk0HsDvoGS3MgjxG : IAsyncStateMachine
		{
			public int Hx62arSsOOh;

			public AsyncVoidMethodBuilder Wt22apBVQsl;

			public _003C_003Ec__DisplayClass0_0 I3v2aBf3laj;

			private TaskAwaiter g062aQ6vltF;

			internal static object T2cTQ3yLKwE52jEyEOaE;

			private void MoveNext()
			{
				int num = Hx62arSsOOh;
				_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = I3v2aBf3laj;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003Ec__DisplayClass0_.nPHvsrBdPqo?.RequestHide();
						awaiter = Task.Delay(250).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (!jVjLvTyLBtwfRrVlfU9R())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							Hx62arSsOOh = 0;
							g062aQ6vltF = awaiter;
							Wt22apBVQsl.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = g062aQ6vltF;
						g062aQ6vltF = default(TaskAwaiter);
						num = -1;
						Hx62arSsOOh = -1;
					}
					awaiter.GetResult();
					if (AppHelper.TryCopy(_003C_003Ec__DisplayClass0_.XbFvspkw5Im, false))
					{
						AppHelper.SendPasteKeys();
					}
				}
				catch (Exception exception)
				{
					Hx62arSsOOh = -2;
					Wt22apBVQsl.SetException(exception);
					return;
				}
				Hx62arSsOOh = -2;
				Wt22apBVQsl.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Wt22apBVQsl.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool jVjLvTyLBtwfRrVlfU9R()
			{
				return T2cTQ3yLKwE52jEyEOaE == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct aaUs8mH3OVjkNxJrtMA : IAsyncStateMachine
		{
			public int Lc02aj8q7XQ;

			public AsyncVoidMethodBuilder PNa2anqMK6K;

			public _003C_003Ec__DisplayClass0_0 yX32a4N298S;

			private TaskAwaiter Taq2a5dRwEY;

			private static object R7nIrnyLdmxRBDsNKs6H;

			private void MoveNext()
			{
				int num = Lc02aj8q7XQ;
				_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = yX32a4N298S;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						SearchWindow searchWindow = _003C_003Ec__DisplayClass0_.nPHvsrBdPqo;
						if (searchWindow != null)
						{
							searchWindow.RequestHide();
							if (!cErnNGyLOdN2aES5fpZQ())
							{
								switch (0)
								{
								}
							}
						}
						awaiter = Task.Delay(250).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							Lc02aj8q7XQ = 0;
							Taq2a5dRwEY = awaiter;
							PNa2anqMK6K.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Taq2a5dRwEY;
						Taq2a5dRwEY = default(TaskAwaiter);
						num = -1;
						Lc02aj8q7XQ = -1;
					}
					awaiter.GetResult();
					try
					{
						InputSimulator.Instance.Keyboard.TextEntry(_003C_003Ec__DisplayClass0_.XbFvspkw5Im);
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning(ex.Message);
					}
				}
				catch (Exception exception)
				{
					Lc02aj8q7XQ = -2;
					PNa2anqMK6K.SetException(exception);
					return;
				}
				Lc02aj8q7XQ = -2;
				PNa2anqMK6K.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				PNa2anqMK6K.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool cErnNGyLOdN2aES5fpZQ()
			{
				return R7nIrnyLdmxRBDsNKs6H == null;
			}
		}

		public SearchWindow nPHvsrBdPqo;

		public string XbFvspkw5Im;

		internal static _003C_003Ec__DisplayClass0_0 PXeRqLcgnh5KgwEPeGR2;

		internal void TWVvsmv0Qst(object sender, RoutedEventArgs e)
		{
			nPHvsrBdPqo?.RequestHide();
			AppHelper.TryCopy(XbFvspkw5Im, true);
		}

		[AsyncStateMachine(typeof(GJXpk0HsDvoGS3MgjxG))]
		internal void lrPvsKGrl5X(object sender, RoutedEventArgs e)
		{
			GJXpk0HsDvoGS3MgjxG stateMachine = default(GJXpk0HsDvoGS3MgjxG);
			stateMachine.Wt22apBVQsl = AsyncVoidMethodBuilder.Create();
			stateMachine.I3v2aBf3laj = this;
			stateMachine.Hx62arSsOOh = -1;
			stateMachine.Wt22apBVQsl.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(aaUs8mH3OVjkNxJrtMA))]
		internal void MHgvsxYLnxX(object sender, RoutedEventArgs e)
		{
			aaUs8mH3OVjkNxJrtMA stateMachine = default(aaUs8mH3OVjkNxJrtMA);
			stateMachine.PNa2anqMK6K = AsyncVoidMethodBuilder.Create();
			stateMachine.yX32a4N298S = this;
			stateMachine.Lc02aj8q7XQ = -1;
			stateMachine.PNa2anqMK6K.Start(ref stateMachine);
		}

		internal static bool lKadvQcgeCJcrlpf673o()
		{
			return PXeRqLcgnh5KgwEPeGR2 == null;
		}
	}

	private static Tm2cvBWRLSsbp7ULmAF BUNTihQ24ORoOgE4KgPw;

	public static void x5Mtum8HnTA(string string_0, ContextMenu contextMenu_0, SearchWindow searchWindow_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.nPHvsrBdPqo = searchWindow_0;
		_003C_003Ec__DisplayClass0_.XbFvspkw5Im = string_0;
		AppHelper.AddMenuItem(contextMenu_0.Items, "复制(_C)", "将结果复制到剪贴板。", "fa:Light_Copy", _003C_003Ec__DisplayClass0_.TWVvsmv0Qst);
		AppHelper.AddMenuItem(contextMenu_0.Items, "粘贴到窗口(_P)", "将结果粘贴到当前窗口。", "fa:Light_Paste", _003C_003Ec__DisplayClass0_.lrPvsKGrl5X);
		AppHelper.AddMenuItem(contextMenu_0.Items, "输入到窗口(_I)", "将结果模拟输入到当前窗口。", "fa:Light_Keyboard", _003C_003Ec__DisplayClass0_.MHgvsxYLnxX);
	}

	internal static bool ktPYv4Q2h8MpwlonX4N9()
	{
		return BUNTihQ24ORoOgE4KgPw == null;
	}
}
