using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Services;

public class AutoRunService
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec eF8v5P6oCXr;

		public static Func<AutoRunTask, bool> J6Sv5EX7eQD;

		private static _003C_003Ec KNx4SGWFe42m8SSi8ojC;

		static _003C_003Ec()
		{
			eF8v5P6oCXr = new _003C_003Ec();
		}

		internal bool JCAv5CdcqdD(AutoRunTask x)
		{
			return x.TaskType != AutoRunTaskType.Start;
		}

		internal static void gTLZcyWF3w8HwlSgBCAo()
		{
		}

		internal static bool GnTkqHWFjVtq1WHng0Wx()
		{
			return KNx4SGWFe42m8SSi8ojC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct AkXGGRkqyOytL13nR0e : IAsyncStateMachine
		{
			public int Wys2RvxgcxS;

			public AsyncTaskMethodBuilder PwO2RS7kyQ4;

			public _003C_003Ec__DisplayClass10_0 mIh2R2Dvs3o;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter kQi2RufF447;

			internal static object Ht8gCWyulacV4u4B1WB3;

			private void MoveNext()
			{
				int num = Wys2RvxgcxS;
				_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = mIh2R2Dvs3o;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = kQi2RufF447;
						kQi2RufF447 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						Wys2RvxgcxS = -1;
					}
					else
					{
						awaiter = Task.Delay(_003C_003Ec__DisplayClass10_.DADv5RdMyRp * 1000).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							Wys2RvxgcxS = 0;
							kQi2RufF447 = awaiter;
							PwO2RS7kyQ4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
					_003C_003Ec__DisplayClass10_.MT9v5yO9mFA();
				}
				catch (Exception exception)
				{
					Wys2RvxgcxS = -2;
					PwO2RS7kyQ4.SetException(exception);
					return;
				}
				Wys2RvxgcxS = -2;
				PwO2RS7kyQ4.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				PwO2RS7kyQ4.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool GskXsjyuZoqcQeF7u5Vj()
			{
				return Ht8gCWyulacV4u4B1WB3 == null;
			}
		}

		public AutoRunTask r7Pv5aL7EUT;

		public AutoRunService rmLv57lFgPk;

		public int DADv5RdMyRp;

		internal static _003C_003Ec__DisplayClass10_0 pQY4BYWFE80sElww37dq;

		internal void MT9v5yO9mFA()
		{
			AppState.Lista4qx2wK()?.CountAutoRun();
			evKtxbjB1eH.Info($"开始执行启动动作({r7Pv5aL7EUT.TaskType}): {r7Pv5aL7EUT.ActionIdOrName} 参数：{r7Pv5aL7EUT.ActionParam}");
			rmLv57lFgPk.zRxtxHVku7a.NotifyRunAction(rmLv57lFgPk, r7Pv5aL7EUT.ActionIdOrName, false, true, ActionTrigger.AutoRun, false, null, r7Pv5aL7EUT.ActionParam);
		}

		[AsyncStateMachine(typeof(AkXGGRkqyOytL13nR0e))]
		internal Task lc5v58p7IOp()
		{
			AkXGGRkqyOytL13nR0e stateMachine = default(AkXGGRkqyOytL13nR0e);
			stateMachine.PwO2RS7kyQ4 = AsyncTaskMethodBuilder.Create();
			stateMachine.mIh2R2Dvs3o = this;
			stateMachine.Wys2RvxgcxS = -1;
			stateMachine.PwO2RS7kyQ4.Start(ref stateMachine);
			return stateMachine.PwO2RS7kyQ4.Task;
		}

		internal static bool P3yeXnWFGP67EC87xmig()
		{
			return pQY4BYWFE80sElww37dq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public AutoRunTask Rwyv5cioGtI;

		public AutoRunService pvQv5V7HdaA;

		private static _003C_003Ec__DisplayClass11_0 TXFk1IWF1sy9T6oCXNJT;

		internal void OTyv5qoXkXW()
		{
			AppState.Lista4qx2wK()?.CountAutoRun();
			evKtxbjB1eH.Info($"执行定时任务({Rwyv5cioGtI.TaskType}): {Rwyv5cioGtI.ActionIdOrName} 参数：{Rwyv5cioGtI.ActionParam}");
			pvQv5V7HdaA.zRxtxHVku7a.NotifyRunAction(pvQv5V7HdaA, Rwyv5cioGtI.ActionIdOrName, false, true, ActionTrigger.AutoRun, false, null, Rwyv5cioGtI.ActionParam);
		}

		internal static bool YpvMPiWFK1Co4gwJQuXG()
		{
			return TXFk1IWF1sy9T6oCXNJT == null;
		}
	}

	private readonly ITinyMessengerHub zRxtxHVku7a;

	private IList<ScheduledTask> M9ttx1oV6n0 = new List<ScheduledTask>();

	private static readonly ILog evKtxbjB1eH;

	private CancellationTokenSource rCZtx6aniiP = new CancellationTokenSource();

	private static AutoRunService xYS792QNAWIMZTJDiMqE;

	public AutoRunService(ITinyMessengerHub hub)
	{
		zRxtxHVku7a = hub;
		AppState.b4WtaUaqAg7(this);
	}

	public void StopAll()
	{
		rCZtx6aniiP.Cancel();
		M9ttx1oV6n0.Clear();
	}

	public void RestartAfterSystemSleep(string reason)
	{
		evKtxbjB1eH.Info("自动运行动作：重新计算时间。Reason：" + reason);
		StopAll();
		Start(false);
	}

	public void Start(bool isQuickerStartup)
	{
		StopAll();
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			return;
		}
		rCZtx6aniiP?.Cancel(false);
		rCZtx6aniiP = new CancellationTokenSource();
		foreach (AutoRunTask item in BZvtxIxdpB8(isQuickerStartup))
		{
			if (!item.IsEnabled || !AppHelper.IsMachineValid(item.ValidForMachines))
			{
				continue;
			}
			switch (item.TaskType)
			{
			case AutoRunTaskType.Timer:
				tlftxkdK1xm(item);
				continue;
			case AutoRunTaskType.Start:
				LoAtxWILTZX(item);
				continue;
			}
			AppHelper.ShowWarning("不支持的自动任务类型：" + item.TaskType);
			if (xYS792QNAWIMZTJDiMqE == null)
			{
				switch (0)
				{
				}
			}
		}
	}

	private static IList<AutoRunTask> BZvtxIxdpB8(bool bool_0)
	{
		IList<AutoRunTask> list = AppState.DataService.CpItmVISR7P().AutoRunTaskList;
		if (list == null && !string.IsNullOrWhiteSpace(AppState.HHxtaMaoqJr().AutoRunTasks))
		{
			list = TryParseOldData(AppState.HHxtaMaoqJr().AutoRunTasks);
		}
		if (list != null && list.HasData())
		{
			if (bool_0)
			{
				return list.ToList();
			}
			return list.Where(_003C_003Ec.J6Sv5EX7eQD ?? (_003C_003Ec.J6Sv5EX7eQD = _003C_003Ec.eF8v5P6oCXr.JCAv5CdcqdD)).ToList();
		}
		return Array.Empty<AutoRunTask>();
	}

	public static IList<AutoRunTask> TryParseOldData(string oldData)
	{
		if (string.IsNullOrEmpty(oldData))
		{
			return Array.Empty<AutoRunTask>();
		}
		string[] array = oldData.Split(new string[3] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
		if (!array.HasData())
		{
			return Array.Empty<AutoRunTask>();
		}
		IList<AutoRunTask> list = new List<AutoRunTask>();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.StartsWith("//", StringComparison.Ordinal))
			{
				continue;
			}
			int num = text.IndexOf("//", StringComparison.InvariantCulture);
			string note = "";
			if (num > 0)
			{
				note = text.Substring(num + 2);
			}
			string text2 = ((num > 0) ? text.Substring(0, num) : text);
			AutoRunTask autoRunTask = null;
			if (text2.StartsWith("S:", StringComparison.OrdinalIgnoreCase))
			{
				autoRunTask = wuCtxsuBTTP(text2);
			}
			else if (text2.StartsWith("T:", StringComparison.Ordinal))
			{
				autoRunTask = VaqtxGbOR9p(text2);
			}
			if (autoRunTask != null)
			{
				int num2 = autoRunTask.ActionIdOrName.IndexOfAny(new char[2] { '?', ' ' });
				if (num2 > 0)
				{
					string text3 = autoRunTask.ActionIdOrName.Substring(0, num2);
					string actionParam = ((autoRunTask.ActionIdOrName.Length > text3.Length + 1) ? autoRunTask.ActionIdOrName.Substring(num2 + 1) : string.Empty);
					autoRunTask.ActionIdOrName = text3;
					autoRunTask.ActionParam = actionParam;
				}
				autoRunTask.Note = note;
				list.Add(autoRunTask);
			}
		}
		return list;
	}

	private void LoAtxWILTZX(AutoRunTask autoRunTask_0)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT = autoRunTask_0;
		_003C_003Ec__DisplayClass10_.rmLv57lFgPk = this;
		if (_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.TaskType != AutoRunTaskType.Start)
		{
			if (UEmiruQNnBXe249oZiYQ())
			{
				switch (0)
				{
				}
			}
			throw new InvalidOperationException("错误的自动任务类型：" + _003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.TaskType);
		}
		if (_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.IsEnabled && !string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.ActionIdOrName) && (!_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.OnlyFirstStartInSameDay || AppState.IsFirstStartInSameDay) && (!_003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.OnlyAutoRunQuicker || AppState.IsAutoRun))
		{
			_003C_003Ec__DisplayClass10_.DADv5RdMyRp = _003C_003Ec__DisplayClass10_.r7Pv5aL7EUT.DelaySeconds;
			if (_003C_003Ec__DisplayClass10_.DADv5RdMyRp <= 0)
			{
				_003C_003Ec__DisplayClass10_.MT9v5yO9mFA();
				Thread.Sleep(10);
			}
			else
			{
				Task.Factory.StartNew((Func<Task>)_003C_003Ec__DisplayClass10_.lc5v58p7IOp, rCZtx6aniiP.Token, TaskCreationOptions.None, TaskScheduler.Default);
			}
		}
	}

	private void tlftxkdK1xm(AutoRunTask autoRunTask_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.Rwyv5cioGtI = autoRunTask_0;
		_003C_003Ec__DisplayClass11_.pvQv5V7HdaA = this;
		if (_003C_003Ec__DisplayClass11_.Rwyv5cioGtI.TaskType != AutoRunTaskType.Timer)
		{
			throw new InvalidOperationException("错误的自动任务类型：" + _003C_003Ec__DisplayClass11_.Rwyv5cioGtI.TaskType);
		}
		if (!_003C_003Ec__DisplayClass11_.Rwyv5cioGtI.IsEnabled)
		{
			return;
		}
		ScheduledTask scheduledTask = new ScheduledTask(_003C_003Ec__DisplayClass11_.Rwyv5cioGtI.Data, _003C_003Ec__DisplayClass11_.OTyv5qoXkXW);
		try
		{
			scheduledTask.Start(rCZtx6aniiP.Token);
			M9ttx1oV6n0.Add(scheduledTask);
		}
		catch (Exception exception)
		{
			string message = "启动定时任务出错：" + exception.GetMessageWithInner() + "\n原始内容：" + _003C_003Ec__DisplayClass11_.Rwyv5cioGtI.Data + ":" + _003C_003Ec__DisplayClass11_.Rwyv5cioGtI.ActionIdOrName;
			evKtxbjB1eH.Warn(message, exception);
			AppHelper.ShowWarning(message);
		}
	}

	static AutoRunService()
	{
		evKtxbjB1eH = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static AutoRunTask VaqtxGbOR9p(string string_0)
	{
		string[] array = string_0.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 3)
		{
			return null;
		}
		return new AutoRunTask
		{
			TaskType = AutoRunTaskType.Timer,
			Data = array[1].Trim(),
			ActionIdOrName = array[2].Trim()
		};
	}

	[CompilerGenerated]
	internal static AutoRunTask wuCtxsuBTTP(string string_0)
	{
		string actionIdOrName = string_0.Substring(2).Trim();
		return new AutoRunTask
		{
			TaskType = AutoRunTaskType.Start,
			ActionIdOrName = actionIdOrName
		};
	}

	internal static bool UEmiruQNnBXe249oZiYQ()
	{
		return xYS792QNAWIMZTJDiMqE == null;
	}

	internal static void qhLHr8QNGFaFdF19iOha()
	{
	}
}
