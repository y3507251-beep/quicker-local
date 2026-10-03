using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using J7BsCmjJgKtd6cIAc1p;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Backup;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace mnWqVeozkVAHIg6WJW1;

internal class XJZ7kpoan1Uhg3yEL2v
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnTimerTick_003Eb__9_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public XJZ7kpoan1Uhg3yEL2v _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object xfewbeWl86dv6PVfxRb7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XJZ7kpoan1Uhg3yEL2v xJZ7kpoan1Uhg3yEL2v = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = xJZ7kpoan1Uhg3yEL2v.LJhgQ9F03kd().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							int num2 = 0;
							if (!w9aacdWlRKS7MurnRLun())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					pjVgQk9hAmq.Warn("备份状态出错：" + ex.Message, ex);
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

		internal static bool w9aacdWlRKS7MurnRLun()
		{
			return xfewbeWl86dv6PVfxRb7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBackupActionStateAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string message)> _003C_003Et__builder;

		public string actionId;

		public XJZ7kpoan1Uhg3yEL2v _003C_003E4__this;

		public bool isAuto;

		public string note;

		private TaskAwaiter<(bool isSuccess, string message)> _003C_003Eu__1;

		internal static object GBbMZ9WlPDR65b71x8N3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XJZ7kpoan1Uhg3yEL2v xJZ7kpoan1Uhg3yEL2v = _003C_003E4__this;
			(bool, string) result;
			try
			{
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00c3;
					}
					ActionState actionState = ActionStateWriter.wI5gPboylwa(actionId);
					if (actionState != null)
					{
						awaiter = xJZ7kpoan1Uhg3yEL2v.SOrgQe577uU(actionId, actionState, isAuto, note).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							if (GBbMZ9WlPDR65b71x8N3 != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00c3;
					}
					result = (false, "状态文件不存在");
					goto end_IL_0011;
					IL_00c3:
					(bool, string) result2 = awaiter.GetResult();
					if (xJZ7kpoan1Uhg3yEL2v.dPbgQH1Tygp.ContainsKey(actionId))
					{
						xJZ7kpoan1Uhg3yEL2v.dPbgQH1Tygp.Remove(actionId);
					}
					result = result2;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					pjVgQk9hAmq.Warn("备份状态" + actionId + "出错：" + ex.Message, ex);
					result = (false, "备份异常：" + ex.Message);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
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

		internal static bool mW3DiqWlM32yvot6kTqK()
		{
			return GBbMZ9WlPDR65b71x8N3 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBackupStateAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string message)> _003C_003Et__builder;

		public string actionId;

		public string note;

		public bool isAuto;

		public ActionState state;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object prG0kuWlI527H5sF1ucn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
        BackupItemVm backupItemVm = default;
				if (num == 0)
				{
					goto IL_013e;
				}
				backupItemVm = new BackupItemVm
				{
					ObjectType = UserObjectType.ActionState,
					ObjectId = actionId,
					CreateTimeUtc = DateTime.UtcNow,
					DisplayName = "",
					ObjectIcon = "",
					UserNote = (note ?? ""),
					SystemNote = ((!isAuto) ? "手动备份" : "自动动作状态备份"),
					IsManualSave = !isAuto,
					QuickerVersion = AppHelper.GetCurrAppVersion(),
					MachineName = Environment.MachineName,
					ExpireTimeUtc = DateTime.UtcNow.AddDays(isAuto ? 30 : 365)
				};
				string text = JsonConvert.SerializeObject(state);
				if (text.Length <= 1048576)
				{
					backupItemVm.Data = StringCipher.EncryptWithGzip(text, AppState.DataService.PZTtmCY0ah7());
					goto IL_013e;
				}
				if (Y3YO05Wl64LXW27aeytU())
				{
					switch (0)
					{
					}
				}
				pjVgQk9hAmq.Info("状态文件过大，不支持备份。动作ID：" + actionId);
				result = (false, "状态文件过大");
				goto end_IL_0007;
				IL_013e:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						num2 = 1;
						if (prG0kuWlI527H5sF1ucn != null)
						{
							goto IL_0194;
						}
					}
					else
					{
						awaiter = aFIptTXYsUoTUF4v33R.tDQt1ZlBCSo(backupItemVm).ConfigureAwait(false).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_01ca;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						num2 = 0;
						if (!Y3YO05Wl64LXW27aeytU())
						{
							goto IL_0194;
						}
					}
					goto IL_0195;
					IL_0195:
					switch (num2)
					{
					default:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
						break;
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01ca;
					IL_01ca:
					ApiResult<string> result2 = awaiter.GetResult();
					if (result2.IsSuccess)
					{
						goto end_IL_013e;
					}
					pjVgQk9hAmq.Warn("备份状态" + actionId + "失败：" + result2.Message);
					result = (false, "服务器返回失败：" + result2.Message);
					goto end_IL_0007;
					IL_0194:
					int num3 = default(int);
					num2 = num3;
					goto IL_0195;
					end_IL_013e:;
				}
				catch (Exception ex)
				{
					pjVgQk9hAmq.Warn("网络备份异常！" + ex.Message, ex);
					result = (false, "备份异常：" + ex.Message);
					goto end_IL_0007;
				}
				result = (true, "");
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
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

		internal static bool Y3YO05Wl64LXW27aeytU()
		{
			return prG0kuWlI527H5sF1ucn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoBackupAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public XJZ7kpoan1Uhg3yEL2v _003C_003E4__this;

		private int _003CsuccessCount_003E5__2;

		private int _003CfailCount_003E5__3;

		private ICollection<string> _003CactionIds_003E5__4;

		private IEnumerator<string> _003C_003E7__wrap4;

		private ConfiguredTaskAwaitable<(bool isSuccess, string message)>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object jIA5jeWlsX2fUPW5trwU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XJZ7kpoan1Uhg3yEL2v xJZ7kpoan1Uhg3yEL2v = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003CsuccessCount_003E5__2 = 0;
					int num2 = 0;
					if (jIA5jeWlsX2fUPW5trwU != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003CfailCount_003E5__3 = 0;
					_003CactionIds_003E5__4 = xJZ7kpoan1Uhg3yEL2v.dPbgQH1Tygp.Keys;
					_003C_003E7__wrap4 = _003CactionIds_003E5__4.GetEnumerator();
				}
				try
				{
					if (num != 0)
					{
						goto IL_00e3;
					}
					ConfiguredTaskAwaitable<(bool, string)>.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
					int num4 = 0;
					if (jIA5jeWlsX2fUPW5trwU == null)
					{
						goto IL_010d;
					}
					goto IL_0125;
					IL_0125:
					switch (num4)
					{
					case 1:
						break;
					default:
						goto IL_010d;
					}
					int num5 = default(int);
					_003CfailCount_003E5__3 = num5 + 1;
					goto IL_00e3;
					IL_010d:
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<(bool, string)>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c3;
					IL_00c3:
					if (awaiter.GetResult().Item1)
					{
						_003CsuccessCount_003E5__2++;
						goto IL_00e3;
					}
					num5 = _003CfailCount_003E5__3;
					num4 = 1;
					if (!roFeTCWlCV5W3RyP3e3C())
					{
						int num6 = default(int);
						num4 = num6;
					}
					goto IL_0125;
					IL_00e3:
					if (_003C_003E7__wrap4.MoveNext())
					{
						string current = _003C_003E7__wrap4.Current;
						awaiter = xJZ7kpoan1Uhg3yEL2v.IX3gQhkLOwF(current, true, string.Empty).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00c3;
					}
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap4 != null)
					{
						_003C_003E7__wrap4.Dispose();
					}
				}
				_003C_003E7__wrap4 = null;
				if (_003CactionIds_003E5__4.Count > 0)
				{
					pjVgQk9hAmq.Info($"备份动作状态：{_003CsuccessCount_003E5__2}成功，{_003CfailCount_003E5__3}失败");
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CactionIds_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CactionIds_003E5__4 = null;
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

		internal static bool roFeTCWlCV5W3RyP3e3C()
		{
			return jIA5jeWlsX2fUPW5trwU == null;
		}
	}

	private static readonly ILog pjVgQk9hAmq;

	[CompilerGenerated]
	private bool xFjgQGiXNc3;

	private long n8TgQs1ryFJ;

	public IDictionary<string, string> dPbgQH1Tygp = new ConcurrentDictionary<string, string>();

	private static XJZ7kpoan1Uhg3yEL2v QujlXqQzAA7yj0uE84PX;

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return xFjgQGiXNc3;
		}
		[CompilerGenerated]
		set
		{
			xFjgQGiXNc3 = value;
		}
	}

	public void XkTgQclM47D()
	{
		OeTcebjK6vK0y2ZOMOQ.pUhtkmFk1ed().a64tkrZFVWX(FCHgQVHhLZU);
		OeTcebjK6vK0y2ZOMOQ.pUhtkmFk1ed().fEBtkx60uw0(FCHgQVHhLZU);
	}

	private void FCHgQVHhLZU(object object_0, long long_1)
	{
		if (AppState.DataService.Hb9tmk3OsJ7() && AppState.HHxtaMaoqJr().EnableActionStateBackup == true)
		{
			long num = AppHelper.fLiLTj0x4QY();
			if (num - n8TgQs1ryFJ > 3600000L)
			{
				Task.Run((Func<Task>)PydgQY3POQk);
				n8TgQs1ryFJ = num;
			}
		}
	}

	public void TNHgQZCcBwG(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && !dPbgQH1Tygp.ContainsKey(string_0))
		{
			dPbgQH1Tygp.Add(string_0, "");
		}
	}

	[AsyncStateMachine(typeof(_003CDoBackupAsync_003Ed__11))]
	public Task LJhgQ9F03kd()
	{
		_003CDoBackupAsync_003Ed__11 stateMachine = default(_003CDoBackupAsync_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBackupActionStateAsync_003Ed__12))]
	internal Task<(bool isSuccess, string message)> IX3gQhkLOwF(string string_0, bool bool_1, string string_1)
	{
		_003CBackupActionStateAsync_003Ed__12 stateMachine = default(_003CBackupActionStateAsync_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.actionId = string_0;
		stateMachine.isAuto = bool_1;
		stateMachine.note = string_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBackupStateAsync_003Ed__13))]
	private Task<(bool isSuccess, string message)> SOrgQe577uU(string string_0, ActionState actionState_0, bool bool_1, string string_1)
	{
		_003CBackupStateAsync_003Ed__13 stateMachine = default(_003CBackupStateAsync_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.actionId = string_0;
		stateMachine.state = actionState_0;
		stateMachine.isAuto = bool_1;
		stateMachine.note = string_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static XJZ7kpoan1Uhg3yEL2v()
	{
		pjVgQk9hAmq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[AsyncStateMachine(typeof(_003C_003COnTimerTick_003Eb__9_0_003Ed))]
	[CompilerGenerated]
	private Task PydgQY3POQk()
	{
		_003C_003COnTimerTick_003Eb__9_0_003Ed stateMachine = default(_003C_003COnTimerTick_003Eb__9_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool ibur16QznT5cIoxpOGpW()
	{
		return QujlXqQzAA7yj0uE84PX == null;
	}
}
