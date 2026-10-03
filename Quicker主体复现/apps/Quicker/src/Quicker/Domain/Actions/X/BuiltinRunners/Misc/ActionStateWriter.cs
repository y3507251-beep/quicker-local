using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using mnWqVeozkVAHIg6WJW1;
using Newtonsoft.Json;
using Quicker.Common.Vm.Backup;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public static class ActionStateWriter
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec skTSaUbPI5V;

		public static Action<object> NQ2SalUU8de;

		public static Func<KeyValuePair<string, ActionStateCacheItem>, bool> ewZSaiGhJUQ;

		public static Func<string, bool> EpQSa3DO3aA;

		public static Func<string, bool> HDPSafaBCqY;

		public static Func<string, bool> JpGSaziEkLu;

		internal static _003C_003Ec gLL8MbWJxwIVCWmZN1b2;

		static _003C_003Ec()
		{
			skTSaUbPI5V = new _003C_003Ec();
		}

		internal void BmkSaTya9Zh(object o)
		{
			if (Monitor.TryEnter(iREgPdnJifa))
			{
				TCPgPmvBPSv(o);
				Monitor.Exit(iREgPdnJifa);
			}
		}

		internal bool PGoSaMfEEt8(KeyValuePair<string, ActionStateCacheItem> x)
		{
			return x.Value.HasModified;
		}

		internal bool CfWSaAwy9m4(string x)
		{
			return x?.StartsWith("custom_panel_state_") ?? false;
		}

		internal bool LDlSaOvLbNY(string x)
		{
			return x?.StartsWith("custom_panel_state_") ?? false;
		}

		internal bool G0SSaFc6mpV(string x)
		{
			return x?.StartsWith("custom_panel_state_") ?? false;
		}

		internal static void X2u59EWJtQbDt3Stal0T()
		{
		}

		internal static bool pRkuEEWJI8Y10BRsIfRC()
		{
			return gLL8MbWJxwIVCWmZN1b2 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBackupActionStateAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string message)> _003C_003Et__builder;

		public string actionId;

		public string note;

		private TaskAwaiter<(bool isSuccess, string message)> _003C_003Eu__1;

		internal static object jjtdlKWJSvii8atfVufP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				if (num != 0)
				{
					awaiter = oAMgP5NtTNv.IX3gQhkLOwF(actionId, false, note).GetAwaiter();
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
				result = awaiter.GetResult();
				int num2 = 0;
				if (!RGVyogWJwVMDMfLIA7TF())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
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

		internal static bool RGVyogWJwVMDMfLIA7TF()
		{
			return jjtdlKWJSvii8atfVufP == null;
		}
	}

	private static readonly ILog znYgPnk1ZRO;

	private static IDictionary<string, ActionStateCacheItem> dbTgP4hNLQm;

	private static XJZ7kpoan1Uhg3yEL2v oAMgP5NtTNv;

	private static object qBpgPDNMx5k;

	private static object iREgPdnJifa;

	private static string a4sgPouLNcw;

	private static readonly DebounceTimer p4egPT5HDLh;

	private static IDictionary<string, ActionAdorn> A1ugPMWd0m1;

	internal static object CwPMv3QUSe0ehpDOndjp;

	static ActionStateWriter()
	{
		znYgPnk1ZRO = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		dbTgP4hNLQm = new ConcurrentDictionary<string, ActionStateCacheItem>();
		oAMgP5NtTNv = null;
		qBpgPDNMx5k = new object();
		iREgPdnJifa = new object();
		a4sgPouLNcw = Guid.Empty.ToString();
		p4egPT5HDLh = new DebounceTimer();
		A1ugPMWd0m1 = null;
		oAMgP5NtTNv = new XJZ7kpoan1Uhg3yEL2v();
		Startup();
	}

	public static void Startup()
	{
		oAMgP5NtTNv.XkTgQclM47D();
	}

	internal static string fb2gP1gvJ8p(string string_1)
	{
		return Path.Combine(AppHelper.GetUserDataDir("states"), "state_" + string_1 + ".json");
	}

	public static (bool isSuccess, string data) ReadActionStateValue(string actionId, string key)
	{
		ActionState actionState = wI5gPboylwa(actionId);
		if (actionState == null)
		{
			return (isSuccess: false, data: "");
		}
		if (!actionState.States.ContainsKey(key))
		{
			return (isSuccess: false, data: "");
		}
		return (isSuccess: true, data: actionState.States[key]);
	}

	internal static ActionState wI5gPboylwa(string string_1)
	{
		if (dbTgP4hNLQm.ContainsKey(string_1))
		{
			return dbTgP4hNLQm[string_1].ActionState;
		}
		try
		{
			BnXgP6Odnfu(string_1);
			return dbTgP4hNLQm.ContainsKey(string_1) ? dbTgP4hNLQm[string_1].ActionState : null;
		}
		catch (Exception ex)
		{
			znYgPnk1ZRO.Warn(ex.Message ?? "", ex);
			return null;
		}
	}

	private static void BnXgP6Odnfu(string string_1)
	{
		if (string_1 == a4sgPouLNcw)
		{
			dbTgP4hNLQm[string_1] = new ActionStateCacheItem
			{
				ActionState = null
			};
			return;
		}
		string text = fb2gP1gvJ8p(string_1);
		if (!System.IO.File.Exists(text))
		{
			dbTgP4hNLQm[string_1] = new ActionStateCacheItem
			{
				ActionState = null
			};
			return;
		}
		string value = System.IO.File.ReadAllText(text);
		int num = 0;
		if (!M5gMIvQUwRcPvOOkGCv2())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (string.IsNullOrEmpty(value))
		{
			dbTgP4hNLQm[string_1] = new ActionStateCacheItem
			{
				ActionState = null
			};
			return;
		}
		try
		{
			ActionState actionState = JsonConvert.DeserializeObject<ActionState>(value);
			dbTgP4hNLQm[string_1] = new ActionStateCacheItem
			{
				ActionState = actionState
			};
		}
		catch (Exception ex)
		{
			znYgPnk1ZRO.Warn("打开动作状态文件" + text + "错误：" + ex.Message, ex);
			throw;
		}
	}

	public static void WriteActionState(string actionId, string key, string value)
	{
		ActionState actionState = wI5gPboylwa(actionId);
		if (actionState == null)
		{
			actionState = new ActionState
			{
				ActionId = actionId
			};
			ActionStateCacheItem actionStateCacheItem = new ActionStateCacheItem
			{
				ActionState = actionState
			};
			actionStateCacheItem.SetModified();
			dbTgP4hNLQm[actionId] = actionStateCacheItem;
		}
		string value2 = default(string);
		if (string.Equals("*NULL*", value, StringComparison.Ordinal))
		{
			if (!actionState.States.ContainsKey(key))
			{
				goto IL_00b2;
			}
			actionState.States.Remove(key);
			int num = 0;
			if (CwPMv3QUSe0ehpDOndjp != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00b2;
			}
		}
		else if (!actionState.States.TryGetValue(key, out value2))
		{
			goto IL_00a4;
		}
		if (string.Equals(value2, value))
		{
			return;
		}
		goto IL_00a4;
		IL_00b2:
		dbTgP4hNLQm[actionId].SetModified();
		FdggPXtlTVf();
		oAMgP5NtTNv.TNHgQZCcBwG(actionId);
		return;
		IL_00a4:
		actionState.States[key] = value;
		goto IL_00b2;
	}

	public static void ChangeStateKey(string actionId, string oldKey, string newKey)
	{
		ActionState actionState = wI5gPboylwa(actionId);
		if (actionState != null && actionState.States.ContainsKey(oldKey))
		{
			actionState.States[newKey] = actionState.States[oldKey];
			actionState.States.Remove(oldKey);
			dbTgP4hNLQm[actionId].SetModified();
			FdggPXtlTVf();
		}
	}

	private static void FdggPXtlTVf()
	{
		lock (qBpgPDNMx5k)
		{
			p4egPT5HDLh.Throttle(2000, _003C_003Ec.NQ2SalUU8de ?? (_003C_003Ec.NQ2SalUU8de = _003C_003Ec.skTSaUbPI5V.BmkSaTya9Zh));
		}
	}

	public static void Flush()
	{
		p4egPT5HDLh.Clear();
		TCPgPmvBPSv(null);
	}

	private static void TCPgPmvBPSv(object object_2)
	{
		MorgPpKD0g5();
		int num2 = default(int);
		foreach (KeyValuePair<string, ActionStateCacheItem> item in dbTgP4hNLQm)
		{
			int num = 0;
			if (CwPMv3QUSe0ehpDOndjp != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			if (!item.Value.HasModified)
			{
				continue;
			}
			string contents = ((item.Value.ActionState == null) ? "" : JsonConvert.SerializeObject(item.Value.ActionState));
			item.Value.ClearModifiedFlag();
			if (!(item.Key == a4sgPouLNcw))
			{
				string text = fb2gP1gvJ8p(item.Key);
				try
				{
					System.IO.File.WriteAllText(text, contents);
				}
				catch (Exception exception)
				{
					string message = "写入状态文件 " + text + " 件出错。" + exception.GetMessageWithInner();
					znYgPnk1ZRO.Warn(message);
					AppHelper.ShowWarning(message);
					item.Value.SetModified();
				}
			}
		}
		if (dbTgP4hNLQm.Any(_003C_003Ec.ewZSaiGhJUQ ?? (_003C_003Ec.ewZSaiGhJUQ = _003C_003Ec.skTSaUbPI5V.PGoSaMfEEt8)))
		{
			FdggPXtlTVf();
		}
	}

	public static bool IsStateFileExists(string actionId)
	{
		return System.IO.File.Exists(fb2gP1gvJ8p(actionId));
	}

	public static bool IsStateHasPanelState(string actionId)
	{
		ActionState actionState = wI5gPboylwa(actionId);
		if (actionState != null && actionState.States != null && actionState.States.Keys.Any(_003C_003Ec.EpQSa3DO3aA ?? (_003C_003Ec.EpQSa3DO3aA = _003C_003Ec.skTSaUbPI5V.CfWSaAwy9m4)))
		{
			return true;
		}
		return false;
	}

	public static bool ResetPanelState(string actionId)
	{
		ActionState actionState = wI5gPboylwa(actionId);
		if (actionState != null && actionState.States != null && actionState.States.Keys.Any(_003C_003Ec.HDPSafaBCqY ?? (_003C_003Ec.HDPSafaBCqY = _003C_003Ec.skTSaUbPI5V.LDlSaOvLbNY)))
		{
			foreach (string item in actionState.States.Keys.Where(_003C_003Ec.JpGSaziEkLu ?? (_003C_003Ec.JpGSaziEkLu = _003C_003Ec.skTSaUbPI5V.G0SSaFc6mpV)).ToList())
			{
				WriteActionState(actionId, item, "*NULL*");
			}
		}
		return false;
	}

	public static void DeleteStateFile(string actionId)
	{
		string path = fb2gP1gvJ8p(actionId);
		if (System.IO.File.Exists(path))
		{
			try
			{
				FileOperationApiWrapper.MoveToRecycleBin(path, true);
				AppHelper.ShowInformation("状态文件已移入回收站。");
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("删除状态文件出错：" + ex.Message);
			}
		}
		if (dbTgP4hNLQm.ContainsKey(actionId))
		{
			dbTgP4hNLQm.Remove(actionId);
		}
	}

	public static void OpenStateFile(string actionId)
	{
		string text = fb2gP1gvJ8p(actionId);
		if (System.IO.File.Exists(text))
		{
			try
			{
				Process.Start(text);
				return;
			}
			catch (Exception ex)
			{
				try
				{
					Process.Start("notepad.exe", text);
					return;
				}
				catch
				{
					AppHelper.ShowWarning("打开文件出错：" + ex.Message);
					return;
				}
			}
		}
		AppHelper.ShowWarning("文件不存在。");
	}

	private static string dS2gPKlaR1t()
	{
		return Path.Combine(AppHelper.GetUserDataDir("states"), "state_global.json");
	}

	public static (bool sucess, string value) ReadGlobalStateValue(string key)
	{
		ActionState actionState = C6DgPxSrj0K();
		if (actionState == null)
		{
			return (sucess: false, value: "");
		}
		if (!actionState.States.ContainsKey(key))
		{
			return (sucess: false, value: "");
		}
		return (sucess: true, value: actionState.States[key]);
	}

	private static ActionState C6DgPxSrj0K()
	{
		string text = dS2gPKlaR1t();
		if (!System.IO.File.Exists(text))
		{
			return null;
		}
		string value = System.IO.File.ReadAllText(text);
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		try
		{
			return JsonConvert.DeserializeObject<ActionState>(value);
		}
		catch (Exception ex)
		{
			string message = "打开全局状态文件" + text + "错误：" + ex.Message;
			znYgPnk1ZRO.Warn(message, ex);
			return null;
		}
	}

	public static void WriteGlobalState(string key, string value)
	{
		string path = dS2gPKlaR1t();
		ActionState actionState = C6DgPxSrj0K() ?? new ActionState
		{
			ActionId = null
		};
		actionState.States[key] = value;
		System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(actionState));
	}

	private static string KwYgPrNJgpm()
	{
		return Path.Combine(AppHelper.GetUserDataDir("states"), "_action_adorn.json");
	}

	public static IDictionary<string, ActionAdorn> LoadActionAdorn()
	{
		string path = KwYgPrNJgpm();
		if (System.IO.File.Exists(path))
		{
			string value = System.IO.File.ReadAllText(path);
			try
			{
				return JsonConvert.DeserializeObject<IDictionary<string, ActionAdorn>>(value);
			}
			catch (Exception exception)
			{
				znYgPnk1ZRO.Error("加载ActionOverride出错：" + exception.GetMessageWithInner(), exception);
			}
		}
		return new ConcurrentDictionary<string, ActionAdorn>();
	}

	public static void SaveActionAdorn(IDictionary<string, ActionAdorn> data)
	{
		A1ugPMWd0m1 = data;
		FdggPXtlTVf();
	}

	private static void MorgPpKD0g5()
	{
		if (A1ugPMWd0m1 != null)
		{
			System.IO.File.WriteAllText(KwYgPrNJgpm(), JsonConvert.SerializeObject(A1ugPMWd0m1));
			A1ugPMWd0m1 = null;
		}
	}

	[AsyncStateMachine(typeof(_003CBackupActionStateAsync_003Ed__32))]
	internal static Task<(bool isSuccess, string message)> EgmgPBaUk5t(string string_1, string string_2)
	{
		_003CBackupActionStateAsync_003Ed__32 stateMachine = default(_003CBackupActionStateAsync_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.actionId = string_1;
		stateMachine.note = string_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static void t53gPQ4YJjh(string string_1, BackupItemDetailDto backupItemDetailDto_0)
	{
		ActionState actionState = JsonConvert.DeserializeObject<ActionState>(StringCipher.DecryptWithGzip(backupItemDetailDto_0.Data, AppState.DataService.PZTtmCY0ah7()));
		dbTgP4hNLQm[string_1] = new ActionStateCacheItem
		{
			ActionState = actionState
		};
		dbTgP4hNLQm[string_1].SetModified();
		FdggPXtlTVf();
	}

	internal static int XnjgPjcreIP(bool bool_0)
	{
		string userDataDir = AppHelper.GetUserDataDir("states");
		string text = Path.Combine(userDataDir, "_old");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string[] files = Directory.GetFiles(userDataDir, "state_*.json");
		int num = 0;
		string[] array = files;
		foreach (string text2 in array)
		{
			string fileName = Path.GetFileName(text2);
			if (fileName.Length != 47)
			{
				continue;
			}
			string actionId = fileName.Substring(6, 36);
			if (AppState.DataService.GetActionById(actionId).action == null)
			{
				try
				{
					System.IO.File.Move(text2, Path.Combine(text, fileName));
					num++;
				}
				catch (Exception ex)
				{
					znYgPnk1ZRO.Warn("清理状态文件 " + text2 + " 出错：" + ex.Message, ex);
				}
			}
		}
		if (bool_0 && num > 0)
		{
			Process.Start(text);
		}
		return num;
	}

	internal static bool M5gMIvQUwRcPvOOkGCv2()
	{
		return CwPMv3QUSe0ehpDOndjp == null;
	}
}
