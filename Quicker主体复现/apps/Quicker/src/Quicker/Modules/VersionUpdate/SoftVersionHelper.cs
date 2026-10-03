using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using dkbgyyMixGueocCf9RC;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Properties;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Modules.VersionUpdate;

public static class SoftVersionHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec MEpvePRwVho;

		public static Action JUTveEyrIbq;

		public static Func<char, bool> DCOveyLrL7A;

		private static _003C_003Ec bAu5k4cbmKUqQDDgTk9I;

		static _003C_003Ec()
		{
			MEpvePRwVho = new _003C_003Ec();
		}

		internal void pdyve0EP8RN()
		{
			AppState.HS2taepcAbc()?.ShowNewVersionTip();
		}

		internal bool IenveC0t0sI(char x)
		{
			return x == '.';
		}

		internal static bool o2LB3acbs68pfcxmqe8x()
		{
			return bAu5k4cbmKUqQDDgTk9I == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Brfja4HVePeUDuqTUca : IAsyncStateMachine
		{
			public int nra2aaf4MHd;

			public AsyncVoidMethodBuilder U6g2a7oDMOJ;

			public _003C_003Ec__DisplayClass1_0 UhO2aRbM3St;

			internal static object sCeSf7y94yaGetZOQpGZ;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = UhO2aRbM3St;
				try
				{
					UpdateNotifierWindow updateNotifierWindow = new UpdateNotifierWindow(_003C_003Ec__DisplayClass1_.LIMveas99Hy.Data, false);
					updateNotifierWindow.Show();
					updateNotifierWindow.Activate();
				}
				catch (Exception exception)
				{
					nra2aaf4MHd = -2;
					U6g2a7oDMOJ.SetException(exception);
					return;
				}
				nra2aaf4MHd = -2;
				U6g2a7oDMOJ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				U6g2a7oDMOJ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool kjqCB7y9hsnKKFfCnehO()
			{
				return sCeSf7y94yaGetZOQpGZ == null;
			}
		}

		public ApiResult<AppVersionInfo> LIMveas99Hy;

		internal static _003C_003Ec__DisplayClass1_0 zKglt3cb7P0TNrBHwelN;

		[AsyncStateMachine(typeof(Brfja4HVePeUDuqTUca))]
		internal void XiJve8Y4kep()
		{
			Brfja4HVePeUDuqTUca stateMachine = default(Brfja4HVePeUDuqTUca);
			stateMachine.U6g2a7oDMOJ = AsyncVoidMethodBuilder.Create();
			stateMachine.UhO2aRbM3St = this;
			stateMachine.nra2aaf4MHd = -1;
			stateMachine.U6g2a7oDMOJ.Start(ref stateMachine);
		}

		internal static bool t0dP2Ccb4X8tyeUfkS0g()
		{
			return zKglt3cb7P0TNrBHwelN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowUpdateVersionWindow_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private ConfiguredTaskAwaitable<ApiResult<AppVersionInfo>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object jcXQLLcbH7t4Pb9e1Et8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<AppVersionInfo>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.uWptb2LjsQe("", AppHelper.GetCurrAppVersion()).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<AppVersionInfo>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<AppVersionInfo> result = awaiter.GetResult();
					int num2 = 0;
					if (jcXQLLcbH7t4Pb9e1Et8 == null)
					{
						goto IL_008f;
					}
					goto IL_00c4;
					IL_00c4:
					switch (num2)
					{
					case 1:
						AppHelper.ShowWarning("检查更新返回错误：" + result.Message);
						goto end_IL_0009;
					}
					goto IL_008f;
					IL_008f:
					if (!result.IsSuccess)
					{
						iAEAkDwqIM.Error("检查更新出错。" + result.Message);
						num2 = 1;
						if (jcXQLLcbH7t4Pb9e1Et8 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00c4;
					}
					string lastVersion = result.Data.LastVersion;
					iAEAkDwqIM.Info("检查更新成功。本地版本:" + AppHelper.GetCurrAppVersion() + "，普通通道版本：" + lastVersion + "， 快速通道版本:" + result.Data.FastChannelVersion + "。预览通道版本:" + result.Data.PreviewChanelVersion + result.Message);
					UpdateNotifierWindow updateNotifierWindow = new UpdateNotifierWindow(result.Data, true);
					updateNotifierWindow.Show();
					updateNotifierWindow.Activate();
					end_IL_0009:;
				}
				catch (Exception ex)
				{
					iAEAkDwqIM.Error("检查更新出错。" + ex.Message, ex);
					AppHelper.ShowWarning("检查更新出错：" + ex.Message);
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

		internal static bool KXmD1scbz8jQQaoah7Kw()
		{
			return jcXQLLcbH7t4Pb9e1Et8 == null;
		}
	}

	private static readonly ILog iAEAkDwqIM;

	internal static object NsK7WJHBNiykQa30nas;

	public static void CheckVersionUpdateAfterFirstSync(string pcSlowVersion, string pcFastVersion)
	{
        // 本地版通过项目 GitHub Releases 手动下载安装，不检查远程版本。
    }

	public static bool IsOnFastChannel()
	{
		return Quicker.Properties.Settings.Default.Channel == "fast";
	}

	public static bool IsVersionNewer(string newVersion, string currVersion)
	{
		try
		{
			if (string.IsNullOrEmpty(newVersion))
			{
				return false;
			}
			return Version.Parse(newVersion) > Version.Parse(currVersion);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("比较版本出错：(" + newVersion + " vs " + currVersion + ")。" + ex.Message);
			iAEAkDwqIM.Error("比较版本出错(" + newVersion + " vs " + currVersion + ")。" + ex.Message, ex);
			return false;
		}
	}

	public static void UpdateNotifiedVersion(string serverVersion)
	{
		try
		{
			Quicker.Properties.Settings.Default.notifiedVersion = serverVersion;
			Quicker.Properties.Settings.Default.Save();
		}
		catch (Exception exception)
		{
			string message = "保存配置信息出错！" + exception.GetMessageWithInner();
			iAEAkDwqIM.Warn(message);
			AppHelper.ShowWarning(message);
		}
	}

	public static string GetShortVersionString(string fullVersionString)
	{
		if (string.IsNullOrWhiteSpace(fullVersionString))
		{
			return fullVersionString;
		}
		if (fullVersionString.Count(_003C_003Ec.DCOveyLrL7A ?? (_003C_003Ec.DCOveyLrL7A = _003C_003Ec.MEpvePRwVho.IenveC0t0sI)) != 3)
		{
			return fullVersionString;
		}
		return fullVersionString.Substring(0, fullVersionString.Length - 2);
	}

	
	public static Task ShowUpdateVersionWindow()
	{
        AppHelper.ShowInformation("请到本项目的 GitHub Releases 手动下载和安装新版本。");
        return Task.CompletedTask;
    }

	static SoftVersionHelper()
	{
		iAEAkDwqIM = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool McJPKqHvXRgd9eZ4n78()
	{
		return NsK7WJHBNiykQa30nas == null;
	}
}
