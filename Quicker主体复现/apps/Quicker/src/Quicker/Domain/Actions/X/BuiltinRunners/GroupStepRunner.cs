using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GroupStepRunner : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GKuSwDOpESr;

		public static Action<Task> HZvSwdJKFJk;

		internal static _003C_003Ec dsMoMsWEJpZ0gG7ZCGo6;

		static _003C_003Ec()
		{
			GKuSwDOpESr = new _003C_003Ec();
		}

		internal void rUgSw514HYQ(Task t)
		{
			AggregateException exception = t.Exception.Flatten();
			QJntUDDhHES.Warn("[多线程]出错：" + exception.GetMessageWithInner(), exception);
		}

		internal static bool jB5upnWEk76HssE1dWG4()
		{
			return dsMoMsWEJpZ0gG7ZCGo6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionExecuteContext YPfSwoXLwmw;

		public XAction A37SwTmUpZY;

		public string UtNSwMIZXpp;

		public ActionStep VfjSwAPYx3C;

		public AutoResetEvent rRrSwO9CDpk;

		public SemaphoreSlim R7eSwF9QIbC;

		public bool CWJSwU2ECj9;

		internal static _003C_003Ec__DisplayClass41_0 MsPtyJWENUSefxGuhILM;

		internal static bool d4CNfoWE9lc9EBPQ2qBQ()
		{
			return MsPtyJWENUSefxGuhILM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_1
	{
		public ActionStep uGTSwiwyjYE;

		public _003C_003Ec__DisplayClass41_0 b1DSw3ifRok;

		private static _003C_003Ec__DisplayClass41_1 AaEePhWEu4jHROT8Bt4X;

		internal void J6aSwlbc5ew()
		{
			b1DSw3ifRok.rRrSwO9CDpk.Set();
			try
			{
				StepRunnerRegistry.GetRunner(uGTSwiwyjYE.StepRunnerKey).Execute(uGTSwiwyjYE, b1DSw3ifRok.YPfSwoXLwmw, b1DSw3ifRok.A37SwTmUpZY, b1DSw3ifRok.UtNSwMIZXpp);
				if (b1DSw3ifRok.VfjSwAPYx3C.DelayMs > 0)
				{
					Thread.Sleep(b1DSw3ifRok.VfjSwAPYx3C.DelayMs);
				}
			}
			finally
			{
				if (!b1DSw3ifRok.CWJSwU2ECj9)
				{
					b1DSw3ifRok.R7eSwF9QIbC.Release();
				}
			}
		}

		internal static bool EVSgK0WEo06Xd9Yt3Tpl()
		{
			return AaEePhWEu4jHROT8Bt4X == null;
		}
	}

	public const string KEY = "sys:group";

	private static readonly ILog QJntUDDhHES;

	[CompilerGenerated]
	private readonly IEnumerable<string> gY0tUdE4lCi;

	[CompilerGenerated]
	private readonly string SvMtUosrTRc = $"fa:{EFontAwesomeIcon.Light_LayerGroup}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> HW4tUTZIiAZ = new StepRunnerCategory[1];

	[CompilerGenerated]
	private readonly string DjatUMM1U9U = "https://getquicker.net/KC/Help/Doc/group";

	[CompilerGenerated]
	private readonly bool R37tUAsaMaQ;

	private static readonly StepInParamDef DDutUOK7crr;

	private static readonly StepInParamDef dp1tUF5rmqU;

	private static readonly StepInParamDef cwNtUU4g4vb;

	private static readonly StepInParamDef xFYtUlXwRfM;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> VAhtUikDAMg = new List<StepInParamDef> { DDutUOK7crr, dp1tUF5rmqU, cwNtUU4g4vb, xFYtUlXwRfM };

	private static readonly StepOutParamDef jbKtU3tlNGT;

	private static readonly StepOutParamDef uNktUfdFLWq;

	internal static GroupStepRunner FZvsIAQZt4ikj1nWkoAD;

	public string Key => "sys:group";

	public string Name => "步骤组";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return gY0tUdE4lCi;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return SvMtUosrTRc;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return HW4tUTZIiAZ;
		}
	}

	public string Description => "一组有关的模块（方便整体禁用、删除等）";

	public StepType StepType => StepType.Loop;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return DjatUMM1U9U;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return R37tUAsaMaQ;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return VAhtUikDAMg;
		}
	}

	public IList<StepOutParamDef> OutputParams => new List<StepOutParamDef> { jbKtU3tlNGT, uNktUfdFLWq };

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.YPfSwoXLwmw = context;
		_003C_003Ec__DisplayClass41_.A37SwTmUpZY = action;
		_003C_003Ec__DisplayClass41_.UtNSwMIZXpp = stepId;
		_003C_003Ec__DisplayClass41_.VfjSwAPYx3C = step;
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(DDutUOK7crr, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(cwNtUU4g4vb, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw);
		bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(dp1tUF5rmqU, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw);
		if (EqN6WTQZSAr3TZbAZiFS())
		{
			switch (0)
			{
			}
		}
		bool hideWarning = _003C_003Ec__DisplayClass41_.YPfSwoXLwmw.HideWarning;
		_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.HideWarning = booleanParamValue;
		try
		{
			int num;
			if (!booleanParamValue2)
			{
				if (_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.IsDebugging && booleanParamValue3 && !(_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger is NopActionLogger))
				{
					_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger.LogWarning("本步骤已设置为跳过调试输出");
					IActionLogger actionLogger = _003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger;
					_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger = new NopActionLogger();
					XActionRunner.RunChildSteps(_003C_003Ec__DisplayClass41_.VfjSwAPYx3C.IfSteps, 0, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw, _003C_003Ec__DisplayClass41_.A37SwTmUpZY, _003C_003Ec__DisplayClass41_.UtNSwMIZXpp);
					_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger = actionLogger;
					num = 1;
					if (FZvsIAQZt4ikj1nWkoAD != null)
					{
						goto IL_03d8;
					}
					goto IL_03da;
				}
				XActionRunner.RunChildSteps(_003C_003Ec__DisplayClass41_.VfjSwAPYx3C.IfSteps, 0, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw, _003C_003Ec__DisplayClass41_.A37SwTmUpZY, _003C_003Ec__DisplayClass41_.UtNSwMIZXpp);
			}
			else
			{
				_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger.LogWarning("并行运行子步骤，将会暂停记录Log");
				bool booleanParamValue4 = XActionHelper.GetBooleanParamValue(xFYtUlXwRfM, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw);
				int initialCount = Environment.ProcessorCount * 3;
				_003C_003Ec__DisplayClass41_.rRrSwO9CDpk = new AutoResetEvent(true);
				IActionLogger actionLogger2 = _003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger;
				_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger = new NopActionLogger();
				IList<Task> list = new List<Task>();
				_003C_003Ec__DisplayClass41_.R7eSwF9QIbC = new SemaphoreSlim(initialCount);
				try
				{
					_003C_003Ec__DisplayClass41_.CWJSwU2ECj9 = false;
					using (IEnumerator<ActionStep> enumerator = _003C_003Ec__DisplayClass41_.VfjSwAPYx3C.IfSteps.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							_003C_003Ec__DisplayClass41_1 _003C_003Ec__DisplayClass41_2 = new _003C_003Ec__DisplayClass41_1();
							_003C_003Ec__DisplayClass41_2.b1DSw3ifRok = _003C_003Ec__DisplayClass41_;
							_003C_003Ec__DisplayClass41_2.uGTSwiwyjYE = enumerator.Current;
							if (_003C_003Ec__DisplayClass41_2.uGTSwiwyjYE.Disabled)
							{
								continue;
							}
							if (!EqN6WTQZSAr3TZbAZiFS())
							{
								switch (0)
								{
								}
							}
							if (!_003C_003Ec__DisplayClass41_2.b1DSw3ifRok.CWJSwU2ECj9)
							{
								_003C_003Ec__DisplayClass41_2.b1DSw3ifRok.R7eSwF9QIbC.Wait();
								Task task = new Task(_003C_003Ec__DisplayClass41_2.J6aSwlbc5ew);
								task.ContinueWith(_003C_003Ec.HZvSwdJKFJk ?? (_003C_003Ec.HZvSwdJKFJk = _003C_003Ec.GKuSwDOpESr.rUgSw514HYQ), TaskContinuationOptions.OnlyOnFaulted);
								task.Start();
								list.Add(task);
								_003C_003Ec__DisplayClass41_2.b1DSw3ifRok.rRrSwO9CDpk.WaitOne();
								Thread.Sleep(5);
							}
						}
					}
					try
					{
						if (booleanParamValue4)
						{
							Task.WaitAny(list.ToArray(), int.MaxValue);
						}
						else
						{
							Task.WaitAll(list.ToArray());
						}
						_003C_003Ec__DisplayClass41_.CWJSwU2ECj9 = true;
					}
					catch (Exception ex)
					{
						QJntUDDhHES.Warn("多线程执行出错了：" + ex.GetMessageWithInner(), ex);
						throw new Exception("多线程执行出错了：" + ex.GetMessageWithInner(), ex);
					}
					_003C_003Ec__DisplayClass41_.rRrSwO9CDpk.Dispose();
				}
				finally
				{
					if (_003C_003Ec__DisplayClass41_.R7eSwF9QIbC != null)
					{
						((IDisposable)_003C_003Ec__DisplayClass41_.R7eSwF9QIbC).Dispose();
					}
				}
				_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger = actionLogger2;
				_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger.LogWarning("并行运行子步骤结束。恢复Log执行");
			}
			goto IL_03ed;
			IL_03da:
			while (true)
			{
				switch (num)
				{
				case 2:
					if (_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag != ActionStopFlag.NoStop)
					{
						if (!_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag.IsEither(ActionStopFlag.UserCancel, ActionStopFlag.OperationFailed, ActionStopFlag.StopFromCode))
						{
							_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger?.LogWarning($"不能忽略停止({_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag})");
							return;
						}
						goto IL_03cb;
					}
					return;
				case 1:
					break;
				default:
					_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger?.LogWarning($"忽略停止({_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag})");
					_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag = ActionStopFlag.NoStop;
					XActionHelper.OutputResult(uNktUfdFLWq, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ErrorMessage, _003C_003Ec__DisplayClass41_.A37SwTmUpZY);
					return;
				}
				break;
				IL_03cb:
				num = 0;
				if (EqN6WTQZSAr3TZbAZiFS())
				{
					continue;
				}
				goto IL_03d8;
			}
			goto IL_03ed;
			IL_03ed:
			XActionHelper.OutputResult(jbKtU3tlNGT, _003C_003Ec__DisplayClass41_.VfjSwAPYx3C, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw, _003C_003Ec__DisplayClass41_.YPfSwoXLwmw.StopFlag == ActionStopFlag.NoStop, _003C_003Ec__DisplayClass41_.A37SwTmUpZY);
			if (booleanParamValue)
			{
				num = 2;
				if (FZvsIAQZt4ikj1nWkoAD != null)
				{
					goto IL_03d8;
				}
				goto IL_03da;
			}
			return;
			IL_03d8:
			int num2 = default(int);
			num = num2;
			goto IL_03da;
		}
		catch (Exception ex2)
		{
			_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger?.LogError(ex2.Message, ex2);
			if (booleanParamValue)
			{
				_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.ActionLogger?.LogInfo("忽略错误，继续运行。");
				return;
			}
			throw;
		}
		finally
		{
			_003C_003Ec__DisplayClass41_.YPfSwoXLwmw.HideWarning = hideWarning;
		}
	}

	public string GetSummary(ActionStep step)
	{
		string paramDirectValue = XActionHelper.GetParamDirectValue(cwNtUU4g4vb, step);
		bool valueOrDefault = VariableHelper.ConvertToBoolean(XActionHelper.GetParamDirectValue(DDutUOK7crr, step)) == true;
		bool valueOrDefault2 = VariableHelper.ConvertToBoolean(XActionHelper.GetParamDirectValue(dp1tUF5rmqU, step)) == true;
		return ((paramDirectValue == "1" || paramDirectValue == "true") ? "【多线程】" : "") + " " + (valueOrDefault ? "【忽略错误】" : "") + " " + ((!valueOrDefault2) ? "" : "【忽略调试输出】") + " ";
	}

	static GroupStepRunner()
	{
		QJntUDDhHES = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		DDutUOK7crr = new StepInParamDef
		{
			Key = "skipErr",
			Name = "忽略错误",
			Description = "忽略内部步骤的错误，继续允许后续代码",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		dp1tUF5rmqU = new StepInParamDef
		{
			Key = "skipWhenDebugging",
			Name = "调试运行时不输出调试内容",
			Description = "用以减少不必要的调试输出",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		cwNtUU4g4vb = new StepInParamDef
		{
			Key = "useMultiThread",
			Name = "使用多线程",
			Description = "⚠通常不要选择! 请阅读文档详细了解后再使用。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		xFYtUlXwRfM = new StepInParamDef
		{
			Key = "waitAny",
			Name = "多线程使用WaitAny模式",
			Description = "任意一个线程结束即可。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		jbKtU3tlNGT = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "内部步骤是否运行成功",
			Type = VarType.Boolean
		};
		uNktUfdFLWq = new StepOutParamDef
		{
			Key = "errorMessage",
			Name = "错误消息",
			Description = "",
			Type = VarType.Text
		};
	}

	internal static bool EqN6WTQZSAr3TZbAZiFS()
	{
		return FZvsIAQZt4ikj1nWkoAD == null;
	}
}
