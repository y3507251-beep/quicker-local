using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DmuKIFwWi8fjDRD9UF8;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using r3EUytwSQ9vNYu3Es8s;
using Z.Expressions;

namespace YDnFyFwG4PlN0Cedwny;

internal abstract class kWjRPcwItwkeAamARyg : oXLGvbwTuCxD9pGrbDD
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public CommonTriggerTask ktnvWaGTjU8;

		internal static _003C_003Ec__DisplayClass21_0 TRNCJhcZxsI2PylwUIRp;

		internal string odovW8JNAM6(FormField x)
		{
			return x.Label + ": " + ktnvWaGTjU8.TryGetParamValue(x.FieldKey, "");
		}

		internal static bool GnTemEcZIXOuTeA9e1ts()
		{
			return TRNCJhcZxsI2PylwUIRp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct cfXJLPHNhavFDLphTe9 : IAsyncStateMachine
		{
			public int vpv2aYjkjmp;

			public AsyncTaskMethodBuilder AcQ2aIqmoAm;

			public _003C_003Ec__DisplayClass23_0 iiF2aWERrYh;

			private TaskAwaiter g3U2akvqYHX;

			private static object CxZV3FyLXSqUdb7PIhbP;

			private void MoveNext()
			{
				int num = vpv2aYjkjmp;
				_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = iiF2aWERrYh;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass23_.bnevWRD5Ar7.vnwtgNyH6jD(_003C_003Ec__DisplayClass23_.pfxvWq9X4hH, _003C_003Ec__DisplayClass23_.U4kvWcoo6vD).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							vpv2aYjkjmp = 0;
							g3U2akvqYHX = awaiter;
							AcQ2aIqmoAm.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (CxZV3FyLXSqUdb7PIhbP != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter = g3U2akvqYHX;
						g3U2akvqYHX = default(TaskAwaiter);
						num = -1;
						vpv2aYjkjmp = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					vpv2aYjkjmp = -2;
					AcQ2aIqmoAm.SetException(exception);
					return;
				}
				vpv2aYjkjmp = -2;
				AcQ2aIqmoAm.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				AcQ2aIqmoAm.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool NfAPpxyL20Me6a25O1sB()
			{
				return CxZV3FyLXSqUdb7PIhbP == null;
			}
		}

		public kWjRPcwItwkeAamARyg bnevWRD5Ar7;

		public CommonTriggerTask pfxvWq9X4hH;

		public IDictionary<string, object> U4kvWcoo6vD;

		private static _003C_003Ec__DisplayClass23_0 imv0t8cZtO7y9St2HhiE;

		[AsyncStateMachine(typeof(cfXJLPHNhavFDLphTe9))]
		internal Task bR8vW7wayvx()
		{
			cfXJLPHNhavFDLphTe9 stateMachine = default(cfXJLPHNhavFDLphTe9);
			stateMachine.AcQ2aIqmoAm = AsyncTaskMethodBuilder.Create();
			stateMachine.iiF2aWERrYh = this;
			stateMachine.vpv2aYjkjmp = -1;
			stateMachine.AcQ2aIqmoAm.Start(ref stateMachine);
			return stateMachine.AcQ2aIqmoAm.Task;
		}

		internal static bool hoQaitcZS13OHlDsxfZY()
		{
			return imv0t8cZtO7y9St2HhiE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoTriggerAction_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommonTriggerTask task;

		public IDictionary<string, object> eventDataDict;

		public kWjRPcwItwkeAamARyg _003C_003E4__this;

		private string _003Cactionparam_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object JjT0jocZTyh5dX3rov4n;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			kWjRPcwItwkeAamARyg kWjRPcwItwkeAamARyg2 = _003C_003E4__this;
			try
			{
				try
				{
					string key = default(string);
					if (num != 0)
					{
						_003Cactionparam_003E5__2 = task.ActionParam;
						if (task.z4dfFIlpLc())
						{
							if (_003Cactionparam_003E5__2.StartsWith("$="))
							{
								_003Cactionparam_003E5__2 = EvalManager.DefaultContext.Execute(_003Cactionparam_003E5__2.Substring(2), eventDataDict)?.ToString();
							}
							else if (_003Cactionparam_003E5__2.StartsWith("$$"))
							{
								_003Cactionparam_003E5__2 = XActionHelper.xsVtDenQtcm(_003Cactionparam_003E5__2.Substring(2), eventDataDict, EvalManager.DefaultContext);
							}
						}
						if (task.ThrottleMs > 0)
						{
							key = $"{task.Id}_{_003Cactionparam_003E5__2}";
							goto IL_0134;
						}
						goto IL_01c2;
					}
					TaskAwaiter awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00f9;
					IL_01fd:
					AppState.AppServer.ExecuteActionByIdOrName(task.ActionIdOrName, null, false, false, false, _003Cactionparam_003E5__2, ActionTrigger.EventTrigger);
					_003Cactionparam_003E5__2 = null;
					goto end_IL_000f;
					IL_01c2:
					if (task.DelayMs > 0)
					{
						awaiter = Task.Delay(task.DelayMs).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00f9;
					}
					goto IL_0100;
					IL_0134:
					IDictionary<string, long> rqbtg7qLEIY = kWjRPcwItwkeAamARyg2.Rqbtg7qLEIY;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(rqbtg7qLEIY, ref lockTaken);
						if (!kWjRPcwItwkeAamARyg2.Rqbtg7qLEIY.ContainsKey(key) || AppHelper.fLiLTj0x4QY() - kWjRPcwItwkeAamARyg2.Rqbtg7qLEIY[key] > task.ThrottleMs)
						{
							kWjRPcwItwkeAamARyg2.Rqbtg7qLEIY[key] = AppHelper.fLiLTj0x4QY();
							goto IL_01c2;
						}
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(rqbtg7qLEIY);
						}
					}
					goto end_IL_000f;
					IL_0100:
					UsageCounter usageCounter = AppState.Lista4qx2wK();
					if (usageCounter == null)
					{
						if (!FDJ8OQcZm4AriWmZUYXe())
						{
							goto IL_01c2;
						}
						switch (1)
						{
						case 2:
							break;
						default:
							goto IL_01c2;
						case 1:
							goto IL_01fd;
						}
						goto IL_0134;
					}
					usageCounter.CountEventTrigger();
					goto IL_01fd;
					IL_00f9:
					awaiter.GetResult();
					goto IL_0100;
					end_IL_000f:;
				}
				catch (Exception ex)
				{
					V2GtgPvnDwP.Warn("事件触发出错，事件类型：" + task.EventType + "，错误：" + ex.Message, ex);
					AppHelper.ShowWarning("事件触发(" + task.EventType + ")出错：" + ex.Message);
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

		internal static bool FDJ8OQcZm4AriWmZUYXe()
		{
			return JjT0jocZTyh5dX3rov4n == null;
		}
	}

	private static readonly ILog V2GtgPvnDwP;

	protected readonly string[] HbutgERkglm;

	private bool Qj1tgyZ9CWP;

	protected IList<CommonTriggerTask> jpqtg8Grl0b = new List<CommonTriggerTask>();

	protected long X5mtgai7GZ6;

	private readonly IDictionary<string, long> Rqbtg7qLEIY = new ConcurrentDictionary<string, long>();

	private static kWjRPcwItwkeAamARyg I2Bf2PQWpoGVwPmGX4G7;

	[SpecialName]
	public string[] V9HM2l6b46l()
	{
		return HbutgERkglm;
	}

	protected kWjRPcwItwkeAamARyg(string[] string_1)
	{
		HbutgERkglm = string_1;
	}

	protected abstract void fb3M2Rxtx1E();

	protected abstract void C5rM2eDjuIN();

	public virtual IList<FormField> odUM2hmvkik(string string_1)
	{
		return Array.Empty<FormField>();
	}

	public virtual IDictionary<string, object> kLIM2b7eEDv(string string_1)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (FormField item in odUM2hmvkik(string_1))
		{
			if (item.DefaultValue != null)
			{
				dictionary[item.FieldKey] = item.DefaultValue;
			}
		}
		return dictionary;
	}

	[SpecialName]
	protected abstract IDictionary<string, string> OVPM2wsWcIu();

	public string wSbM2zcwFbs(string string_1)
	{
		if (OVPM2wsWcIu().ContainsKey(string_1))
		{
			return OVPM2wsWcIu()[string_1];
		}
		return string_1;
	}

	public void QYLM2voUeQh()
	{
		if (Qj1tgyZ9CWP)
		{
			throw new InvalidOperationException("任务已经在运行了！");
		}
		if (jpqtg8Grl0b.HasData())
		{
			X5mtgai7GZ6 = AppHelper.fLiLTj0x4QY();
			fb3M2Rxtx1E();
			Qj1tgyZ9CWP = true;
		}
	}

	public void Stop()
	{
		if (Qj1tgyZ9CWP)
		{
			C5rM2eDjuIN();
			Qj1tgyZ9CWP = false;
		}
	}

	public void Reset()
	{
		Stop();
		jpqtg8Grl0b.Clear();
	}

	public bool SGDMjxjBB7g(CommonTriggerTask commonTriggerTask_0)
	{
		if (Qj1tgyZ9CWP)
		{
			throw new InvalidOperationException("服务正在运行中，此时不能添加任务。");
		}
		jpqtg8Grl0b.Add(commonTriggerTask_0);
		return true;
	}

	[SpecialName]
	public bool JbmMjsn1vpM()
	{
		return jpqtg8Grl0b.HasData();
	}

	public virtual string KDDMjfoUuvt(CommonTriggerTask commonTriggerTask_0)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.ktnvWaGTjU8 = commonTriggerTask_0;
		return string.Join("\r\n", odUM2hmvkik(_003C_003Ec__DisplayClass21_.ktnvWaGTjU8.EventType).Select(_003C_003Ec__DisplayClass21_.odovW8JNAM6));
	}

	public virtual IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return Array.Empty<ActionVariable>();
	}

	protected bool iJ2tguv8HCS(CommonTriggerTask commonTriggerTask_0, IDictionary<string, object> idictionary_1)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.bnevWRD5Ar7 = this;
		_003C_003Ec__DisplayClass23_.pfxvWq9X4hH = commonTriggerTask_0;
		_003C_003Ec__DisplayClass23_.U4kvWcoo6vD = idictionary_1;
		if (!gwntg0GiSL2())
		{
			return true;
		}
		if (!_003C_003Ec__DisplayClass23_.pfxvWq9X4hH.EventFilterExpression.IsNullOrEmpty() && !P60tgJulEEg(_003C_003Ec__DisplayClass23_.pfxvWq9X4hH, _003C_003Ec__DisplayClass23_.U4kvWcoo6vD))
		{
			return false;
		}
		Task.Run((Func<Task>)_003C_003Ec__DisplayClass23_.bR8vW7wayvx);
		return true;
	}

	[AsyncStateMachine(typeof(_003CDoTriggerAction_003Ed__25))]
	private Task vnwtgNyH6jD(CommonTriggerTask commonTriggerTask_0, IDictionary<string, object> idictionary_1)
	{
		_003CDoTriggerAction_003Ed__25 stateMachine = default(_003CDoTriggerAction_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.task = commonTriggerTask_0;
		stateMachine.eventDataDict = idictionary_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static bool P60tgJulEEg(CommonTriggerTask commonTriggerTask_0, IDictionary<string, object> idictionary_1)
	{
		if (commonTriggerTask_0.EventFilterExpression.StartsWith("$="))
		{
			try
			{
				string text = commonTriggerTask_0.EventFilterExpression.Substring(2);
				if (idictionary_1.HasData())
				{
					foreach (KeyValuePair<string, object> item in idictionary_1)
					{
						text = text.Replace("{" + item.Key + "}", item.Key);
					}
				}
				if (!EvalManager.DefaultContext.Execute<bool>(text, idictionary_1))
				{
					V2GtgPvnDwP.Info("事件触发过滤成功：" + commonTriggerTask_0.EventType + "_" + commonTriggerTask_0.Note);
					return false;
				}
			}
			catch (Exception ex)
			{
				V2GtgPvnDwP.Info("事件触发过滤解析出错：" + commonTriggerTask_0.EventType + "_" + commonTriggerTask_0.Note + " 表达式：" + commonTriggerTask_0.EventFilterExpression + " 参数：" + idictionary_1?.ToJson());
				AppHelper.ShowWarning("事件触发过滤解析出错：" + commonTriggerTask_0.EventType + "_" + commonTriggerTask_0.Note + " 错误：" + ex.Message);
				return false;
			}
			return true;
		}
		AppHelper.ShowWarning("事件过滤表达式不正确。事件：" + commonTriggerTask_0.EventType + "_" + commonTriggerTask_0.Note + "，表达式：" + commonTriggerTask_0.EventFilterExpression);
		return false;
	}

	[SpecialName]
	protected bool gwntg0GiSL2()
	{
		return AppState.xhbt79wekbs();
	}

	static kWjRPcwItwkeAamARyg()
	{
		V2GtgPvnDwP = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ydp15uQWXAn16qxgLbGJ()
	{
		return I2Bf2PQWpoGVwPmGX4G7 == null;
	}
}
