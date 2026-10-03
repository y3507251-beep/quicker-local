using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using log4net;
using Quicker.Common;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Utilities;
using Quicker.View.UI;

namespace MLMnVBjUTJtuByCFXLA;

internal class oRXTm6j4SiAmjKM7eyR
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct pltZxtHpw2O63y3R2Tq : IAsyncStateMachine
		{
			public int HqD27MjQUiW;

			public AsyncVoidMethodBuilder FK027Apjj0R;

			public _003C_003Ec__DisplayClass6_0 FeT27OVP7x6;

			private TaskAwaiter<(bool isSuccess, string button)> fLd27FL4x1X;

			private static object uIu477yuvYaBrnK0G0N3;

			private void MoveNext()
			{
				int num = HqD27MjQUiW;
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = FeT27OVP7x6;
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num != 0)
					{
						awaiter = ConfirmDialog.jQyL0Wq9wU6(null, "权限确认", "", "是否允许 [" + _003C_003Ec__DisplayClass6_.wW3vQNd9vWb.Title + "] 动作获得 【" + _003C_003Ec__DisplayClass6_.EAKvQJb37i8 + "】 权限？\r\n", "Question", "[fa:Regular_Check:#4caf50]允许(_Y)|Yes\r\n[fa:Regular_Times:#dc3545]不允许(_N)|No", "Yes").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							HqD27MjQUiW = 0;
							fLd27FL4x1X = awaiter;
							FK027Apjj0R.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = fLd27FL4x1X;
						fLd27FL4x1X = default(TaskAwaiter<(bool, string)>);
						num = -1;
						HqD27MjQUiW = -1;
					}
					_003C_003Ec__DisplayClass6_.YisvQ0uSsRS = string.Equals("Yes", awaiter.GetResult().Item2 ?? "");
					_003C_003Ec__DisplayClass6_.FVJvQCG1brE.Set();
				}
				catch (Exception exception)
				{
					HqD27MjQUiW = -2;
					FK027Apjj0R.SetException(exception);
					return;
				}
				HqD27MjQUiW = -2;
				FK027Apjj0R.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				FK027Apjj0R.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ufOnxyyudtOgvSaZKCKX()
			{
				return uIu477yuvYaBrnK0G0N3 == null;
			}
		}

		public ActionItem wW3vQNd9vWb;

		public string EAKvQJb37i8;

		public bool YisvQ0uSsRS;

		public ManualResetEventSlim FVJvQCG1brE;

		internal static _003C_003Ec__DisplayClass6_0 hgpaJJcm6l5F1AHtYVGG;

		[AsyncStateMachine(typeof(pltZxtHpw2O63y3R2Tq))]
		internal void xpRvQuMmGt4()
		{
			pltZxtHpw2O63y3R2Tq stateMachine = default(pltZxtHpw2O63y3R2Tq);
			stateMachine.FK027Apjj0R = AsyncVoidMethodBuilder.Create();
			stateMachine.FeT27OVP7x6 = this;
			stateMachine.HqD27MjQUiW = -1;
			stateMachine.FK027Apjj0R.Start(ref stateMachine);
		}

		internal static bool PwaYlOcmtSaK81vZvuWZ()
		{
			return hgpaJJcm6l5F1AHtYVGG == null;
		}
	}

	private static readonly ILog GJxtWTiDavq;

	internal static oRXTm6j4SiAmjKM7eyR zPEw1OQJInmi9G6N9JHB;

	private static string RM5tW5iM3yX(string string_0, string string_1 = "")
	{
		try
		{
			(bool, string) tuple = ActionStateWriter.ReadActionStateValue("_local_action_permissions", string_0);
			if (tuple.Item1)
			{
				return tuple.Item2;
			}
			return string_1;
		}
		catch (Exception ex)
		{
			GJxtWTiDavq.Warn("读取LocalStateManager数据出错：" + ex.Message, ex);
			return string_1;
		}
	}

	private static void SetValue(string key, string value)
	{
		ActionStateWriter.WriteActionState("_local_action_permissions", key, value);
	}

	public static bool jRCtWDfSfn6(string string_0, string string_1)
	{
		string b = RM5tW5iM3yX(string_0 + "_" + string_1);
		return string.Equals("1", b);
	}

	public static void vACtWdpMWEa(string string_0, string string_1)
	{
		SetValue(string_0 + "_" + string_1, "1");
	}

	public static (bool isSuccess, string message) hG7tWopOUbS(ActionItem actionItem_0, string string_0, string string_1)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.wW3vQNd9vWb = actionItem_0;
		_003C_003Ec__DisplayClass6_.EAKvQJb37i8 = string_1;
		if (_003C_003Ec__DisplayClass6_.wW3vQNd9vWb != null && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass6_.wW3vQNd9vWb.Id) && !(_003C_003Ec__DisplayClass6_.wW3vQNd9vWb.Id == Guid.Empty.ToString()))
		{
			if (jRCtWDfSfn6(_003C_003Ec__DisplayClass6_.wW3vQNd9vWb.Id, string_0))
			{
				return (isSuccess: true, message: "");
			}
			_003C_003Ec__DisplayClass6_.FVJvQCG1brE = new ManualResetEventSlim(false);
			_003C_003Ec__DisplayClass6_.YisvQ0uSsRS = false;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass6_.xpRvQuMmGt4);
			_003C_003Ec__DisplayClass6_.FVJvQCG1brE.Wait();
			if (_003C_003Ec__DisplayClass6_.YisvQ0uSsRS)
			{
				vACtWdpMWEa(_003C_003Ec__DisplayClass6_.wW3vQNd9vWb.Id, string_0);
				return (isSuccess: true, message: "");
			}
			return (isSuccess: false, message: "用户拒绝了 " + _003C_003Ec__DisplayClass6_.EAKvQJb37i8 + " 权限。");
		}
		return (isSuccess: false, message: "安装动作后再使用。");
	}

	static oRXTm6j4SiAmjKM7eyR()
	{
		GJxtWTiDavq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool IlSqnwQJ6Dob80p6NFeH()
	{
		return zPEw1OQJInmi9G6N9JHB == null;
	}
}
