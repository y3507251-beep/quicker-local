using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using log4net;
using Quicker.Domain;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;
using Quicker.Utilities.Win32;

namespace nexm4sW6Ab9LJOoG75C;

internal class SRIiC1Wfvh2P4N7rR6W : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string YHJvGVtrAse;

		public SRIiC1Wfvh2P4N7rR6W RS3vGZQZZLD;

		internal static _003C_003Ec__DisplayClass3_0 DBlA7ScYrD0hS6kcPRZN;

		internal string SScvGcRtVSy()
		{
			return ChromeControl.uktvwgsaRp5(YHJvGVtrAse, null, RS3vGZQZZLD.CancellationToken);
		}

		internal static bool l8Vp1PcYNNIZk8uBOnVv()
		{
			return DBlA7ScYrD0hS6kcPRZN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoPickAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string process;

		public SRIiC1Wfvh2P4N7rR6W _003C_003E4__this;

		private string _003Cselector_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object ffyHsYcYL6MhOVqEmi03;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string result2;
			try
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
				if (num != 0)
				{
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0
					{
						YHJvGVtrAse = process,
						RS3vGZQZZLD = _003C_003E4__this
					};
					_003Cselector_003E5__2 = "";
				}
				int num2 = 0;
				if (!KffUhTcYuZDTPwX4HFij())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run((Func<string>)_003C_003Ec__DisplayClass3_.SScvGcRtVSy).GetAwaiter();
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
							_003C_003Eu__1 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result = awaiter.GetResult();
						int num4 = 0;
						if (ffyHsYcYL6MhOVqEmi03 != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						switch (num4)
						{
						default:
							_003Cselector_003E5__2 = result;
							break;
						}
					}
					catch (Exception ex)
					{
						GugtvAHJw1w.Warn("选择元素出错了：" + ex.Message, ex);
						AppHelper.ShowWarning("选择元素出错了：" + ex.Message);
					}
					result2 = _003Cselector_003E5__2;
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cselector_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cselector_003E5__2 = null;
			_003C_003Et__builder.SetResult(result2);
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

		internal static bool KffUhTcYuZDTPwX4HFij()
		{
			return ffyHsYcYL6MhOVqEmi03 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SRIiC1Wfvh2P4N7rR6W _003C_003E4__this;

		public object sender;

		private string _003Cselector_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object KJOr2lcYfjtptBu3qAlx;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SRIiC1Wfvh2P4N7rR6W sRIiC1Wfvh2P4N7rR6W = _003C_003E4__this;
			try
			{
				int num2;
				TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				string foregroundProcessName = default(string);
				int num3 = default(int);
				string result;
				switch (num)
				{
				default:
					sRIiC1Wfvh2P4N7rR6W.QlntvM6XGWw(sender);
					AppHelper.RunOnUiThread(true, sRIiC1Wfvh2P4N7rR6W.rJHtvooH7qm);
					num2 = 1;
					if (KJOr2lcYfjtptBu3qAlx != null)
					{
						goto IL_013a;
					}
					goto IL_01a4;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0161;
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0118;
				case 2:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0205;
				case 3:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_02d4;
					}
					IL_01a4:
					while (true)
					{
						switch (num2)
						{
						case 4:
							break;
						case 1:
							goto IL_013a;
						default:
							goto IL_016d;
						case 3:
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 5:
							goto IL_02e5;
						case 2:
							goto end_IL_0012;
						}
						break;
						IL_016d:
						awaiter = sRIiC1Wfvh2P4N7rR6W.TH9tvddXMiU(foregroundProcessName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 3;
							_003C_003E1__state = 3;
							num2 = 3;
							if (KJOr2lcYfjtptBu3qAlx == null)
							{
								continue;
							}
							goto IL_01a0;
						}
						goto IL_02d4;
					}
					goto IL_00d9;
					IL_02d4:
					result = awaiter.GetResult();
					_003Cselector_003E5__2 = result;
					goto IL_02e5;
					IL_013a:
					awaiter2 = Task.Delay(400).ConfigureAwait(true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0161;
					IL_0161:
					awaiter2.GetResult();
					goto IL_00d9;
					IL_0205:
					awaiter2.GetResult();
					foregroundProcessName = NativeMethods.GetForegroundProcessName();
					if (AppState.vjAt7Seco0Y().m8ItGmyxjPV(foregroundProcessName))
					{
						num2 = 0;
						if (!bnYW8rcYb4wlTITgYJtl())
						{
							goto IL_01a0;
						}
						goto IL_01a4;
					}
					goto IL_02e5;
					IL_00d9:
					_003Cselector_003E5__2 = "";
					foregroundProcessName = NativeMethods.GetForegroundProcessName();
					if (AppState.vjAt7Seco0Y().m8ItGmyxjPV(foregroundProcessName))
					{
						awaiter = sRIiC1Wfvh2P4N7rR6W.TH9tvddXMiU(foregroundProcessName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0118;
					}
					if (MessageBoxHelper.Show("请打开要获取CSS选择器的浏览器窗口和标签页，然后点击确定。", "获取CSS选择器", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
					{
						awaiter2 = Task.Delay(400).ConfigureAwait(true).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0205;
					}
					goto IL_02e5;
					IL_01a0:
					num2 = num3;
					goto IL_01a4;
					IL_0118:
					result = awaiter.GetResult();
					_003Cselector_003E5__2 = result;
					num2 = 2;
					if (!bnYW8rcYb4wlTITgYJtl())
					{
						goto IL_01a4;
					}
					goto IL_02e5;
					IL_02e5:
					AppHelper.RunOnUiThread(true, sRIiC1Wfvh2P4N7rR6W.taitvTw2iED);
					break;
					end_IL_0012:
					break;
				}
				if (!string.IsNullOrEmpty(_003Cselector_003E5__2))
				{
					sRIiC1Wfvh2P4N7rR6W.Context.ProcessSelectedTextFunc?.Invoke(_003Cselector_003E5__2, true);
				}
				else if (sRIiC1Wfvh2P4N7rR6W.ForStepUse)
				{
					sRIiC1Wfvh2P4N7rR6W.CancelSelection("");
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cselector_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cselector_003E5__2 = null;
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

		internal static bool bnYW8rcYb4wlTITgYJtl()
		{
			return KJOr2lcYfjtptBu3qAlx == null;
		}
	}

	private static readonly ILog GugtvAHJw1w;

	internal static SRIiC1Wfvh2P4N7rR6W KVTHHQQpp5J3s1cr1u0Q;

	public SRIiC1Wfvh2P4N7rR6W(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	[AsyncStateMachine(typeof(_003COnMouseUp_003Ed__2))]
	public override void OnMouseUp(object sender)
	{
		_003COnMouseUp_003Ed__2 stateMachine = default(_003COnMouseUp_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoPickAsync_003Ed__3))]
	private Task<string> TH9tvddXMiU(string string_0)
	{
		_003CDoPickAsync_003Ed__3 stateMachine = default(_003CDoPickAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.process = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static SRIiC1Wfvh2P4N7rR6W()
	{
		GugtvAHJw1w = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void rJHtvooH7qm()
	{
		WindowHelper.MinimizeWindowAndOwner(base.Context.ParentWindow);
	}

	[CompilerGenerated]
	private void taitvTw2iED()
	{
		WindowHelper.RestoreWindowAndOwner(base.Context.ParentWindow);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void QlntvM6XGWw(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool eiW2lsQpXpw63mETYy01()
	{
		return KVTHHQQpp5J3s1cr1u0Q == null;
	}
}
