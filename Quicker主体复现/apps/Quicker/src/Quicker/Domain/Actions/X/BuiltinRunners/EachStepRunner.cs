using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class EachStepRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep j0aSgiXKfWQ;

		public ActionExecuteContext XwhSg36TgKC;

		public EachStepRunner ErZSgfJFsbx;

		public XAction QfBSgzrZpxG;

		public string KB7SLwftdBQ;

		public IActionLogger b50SLtUhhBK;

		internal static _003C_003Ec__DisplayClass50_0 ACoo5yW0yeEo19gggWvH;

		internal (bool isSuccess, string message, ActionStopFlag failReason) rtdSglWWKHa()
		{
			object paramValue = XActionHelper.GetParamValue(IMvtzp3FVfv, j0aSgiXKfWQ, XwhSg36TgKC, false, true);
			IEnumerable object_ = ErZSgfJFsbx.kU0tzb42UDZ(paramValue);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(FqLtzBZM1MW, j0aSgiXKfWQ, XwhSg36TgKC);
			int millisecondsTimeout = (int)XActionHelper.GetIntegerParamValue(HqntzQ5PfKy, j0aSgiXKfWQ, XwhSg36TgKC);
			if (!booleanParamValue)
			{
				if (XwhSg36TgKC.IsDebugging)
				{
					XwhSg36TgKC.ActionLogger.BeginStepGroup("", 3);
				}
				try
				{
					int num = 0;
					foreach (object item in ErZSgfJFsbx.kU0tzb42UDZ(object_))
					{
						if (XwhSg36TgKC.IsDebugging)
						{
							XwhSg36TgKC.ActionLogger.BeginRepeat($"第 {num} 次循环，项的值：{AppHelper.GetShorterString(item.ToString(), 100)}");
						}
						XActionHelper.OutputResult(y2KtzT8ALt4, j0aSgiXKfWQ, XwhSg36TgKC, item, QfBSgzrZpxG);
						XActionHelper.OutputResult(fpqtzMD4APe, j0aSgiXKfWQ, XwhSg36TgKC, num, QfBSgzrZpxG);
						try
						{
							XActionRunner.RunChildSteps(j0aSgiXKfWQ.IfSteps, 0, XwhSg36TgKC, QfBSgzrZpxG, KB7SLwftdBQ);
						}
						finally
						{
							XwhSg36TgKC.ActionLogger.EndRepeat();
						}
						if (XwhSg36TgKC.ShouldContinue())
						{
							XwhSg36TgKC.ClearContinueFlag();
						}
						if (!XwhSg36TgKC.IsShouldBreak())
						{
							if (!XwhSg36TgKC.IsShouldStopAction())
							{
								num++;
								continue;
							}
							return (isSuccess: true, message: XwhSg36TgKC.ErrorMessage, failReason: ActionStopFlag.NoStop);
						}
						XwhSg36TgKC.ActionLogger.LogInfo("检测到Break标记，停止循环");
						XwhSg36TgKC.ClearBreakFlag();
						break;
					}
				}
				finally
				{
					if (XwhSg36TgKC.IsDebugging)
					{
						XwhSg36TgKC.ActionLogger.EndStepGroup();
					}
				}
			}
			else
			{
				_003C_003Ec__DisplayClass50_1 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_1
				{
					uJDSL2gmNv8 = this
				};
				XwhSg36TgKC.ActionLogger.LogWarning("并行运行子步骤，将会暂停记录Log");
				XwhSg36TgKC.ActionLogger = new NopActionLogger();
				IList<Task> list = new List<Task>();
				int num2 = (int)XActionHelper.GetIntegerParamValue(Ysutzj3IqII, j0aSgiXKfWQ, XwhSg36TgKC);
				if (num2 < 1)
				{
					num2 = 1;
				}
				long num3 = XActionHelper.GetIntegerParamValue(uIHtzn4ohwZ, j0aSgiXKfWQ, XwhSg36TgKC);
				if (num3 < 0L)
				{
					num3 = 2147483647L;
				}
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(UXwtz400dp9, j0aSgiXKfWQ, XwhSg36TgKC);
				_003C_003Ec__DisplayClass50_.HPsSLStBreh = XActionHelper.GetBooleanParamValue(WeTtz5F0NqD, j0aSgiXKfWQ, XwhSg36TgKC);
				_003C_003Ec__DisplayClass50_.yh2SLLL7Tn7 = new AutoResetEvent(true);
				_003C_003Ec__DisplayClass50_.o96SLvoUKlG = new SemaphoreSlim(num2);
				try
				{
					int num4 = 0;
					foreach (object item2 in ErZSgfJFsbx.kU0tzb42UDZ(object_))
					{
						_003C_003Ec__DisplayClass50_2 _003C_003Ec__DisplayClass50_2 = new _003C_003Ec__DisplayClass50_2();
						_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4 = _003C_003Ec__DisplayClass50_;
						_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.o96SLvoUKlG.Wait();
						if (XwhSg36TgKC.IsDebugging)
						{
							b50SLtUhhBK.LogInfo($"第 {num4} 次循环，项的值：{item2}");
						}
						XActionHelper.OutputResult(y2KtzT8ALt4, j0aSgiXKfWQ, XwhSg36TgKC, item2, QfBSgzrZpxG);
						XActionHelper.OutputResult(fpqtzMD4APe, j0aSgiXKfWQ, XwhSg36TgKC, num4, QfBSgzrZpxG);
						_003C_003Ec__DisplayClass50_2.IPpSLJa6069 = XwhSg36TgKC;
						if (_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.HPsSLStBreh)
						{
							_003C_003Ec__DisplayClass50_2.IPpSLJa6069 = new ActionExecuteContext(XwhSg36TgKC, XwhSg36TgKC.Action, XwhSg36TgKC.TargetInfo, XwhSg36TgKC.AppServer, XwhSg36TgKC.IsDebugging, XwhSg36TgKC.Id, null, XwhSg36TgKC.CancellationToken);
							foreach (KeyValuePair<string, object> customDatum in XwhSg36TgKC.CustomData)
							{
								_003C_003Ec__DisplayClass50_2.IPpSLJa6069.CustomData[customDatum.Key] = customDatum.Value;
							}
							_003C_003Ec__DisplayClass50_2.IPpSLJa6069.XProgram = XwhSg36TgKC.XProgram;
						}
						Task task = Task.Run((Action)_003C_003Ec__DisplayClass50_2.ieUSLNb4Rek);
						task.ContinueWith(_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.nLQSLuOJhPK ?? (_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.nLQSLuOJhPK = _003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.g20SLgcsuQB), TaskContinuationOptions.OnlyOnFaulted);
						list.Add(task);
						if (XwhSg36TgKC.ShouldContinue())
						{
							XwhSg36TgKC.ClearContinueFlag();
						}
						if (!XwhSg36TgKC.IsShouldBreak())
						{
							if (!XwhSg36TgKC.IsShouldStopAction())
							{
								num4++;
								_003C_003Ec__DisplayClass50_2.VwgSL0Wr0X4.yh2SLLL7Tn7.WaitOne();
								Thread.Sleep(millisecondsTimeout);
								continue;
							}
							return (isSuccess: false, message: XwhSg36TgKC.ErrorMessage, failReason: XwhSg36TgKC.StopFlag);
						}
						XwhSg36TgKC.ActionLogger.LogInfo("检测到Break标记，停止循环");
						XwhSg36TgKC.ClearBreakFlag();
						break;
					}
					if (XwhSg36TgKC.IsShouldStopAction())
					{
						return (isSuccess: false, message: XwhSg36TgKC.ErrorMessage, failReason: XwhSg36TgKC.StopFlag);
					}
					try
					{
						if (booleanParamValue2)
						{
							Task.WaitAny(list.ToArray(), (int)num3);
						}
						else
						{
							Task.WaitAll(list.ToArray(), (int)num3);
						}
					}
					catch (Exception exception)
					{
						SqEtz6HK9ab.Warn("多线程执行出错了：" + exception.GetMessageWithInner(), exception);
						return (isSuccess: false, message: exception.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
					}
				}
				catch (Exception exception2)
				{
					SqEtz6HK9ab.Warn("多线程执行出错了：" + exception2.GetMessageWithInner(), exception2);
					return (isSuccess: false, message: exception2.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
				finally
				{
					_003C_003Ec__DisplayClass50_.yh2SLLL7Tn7.Dispose();
					_003C_003Ec__DisplayClass50_.o96SLvoUKlG.Dispose();
					_003C_003Ec__DisplayClass50_.o96SLvoUKlG = null;
					XwhSg36TgKC.ActionLogger = b50SLtUhhBK;
					XwhSg36TgKC.ActionLogger.LogWarning("并行运行子步骤结束。恢复Log执行");
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void aVigFDW02gcVqcaPgnF6()
		{
		}

		internal static bool iXGukmW0pMohVoeXcrEP()
		{
			return ACoo5yW0yeEo19gggWvH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_1
	{
		public AutoResetEvent yh2SLLL7Tn7;

		public SemaphoreSlim o96SLvoUKlG;

		public bool HPsSLStBreh;

		public _003C_003Ec__DisplayClass50_0 uJDSL2gmNv8;

		public Action<Task> nLQSLuOJhPK;

		internal static _003C_003Ec__DisplayClass50_1 pRADvHW0A4VPWgApQakW;

		internal void g20SLgcsuQB(Task t)
		{
			AggregateException ex = t.Exception?.Flatten();
			SqEtz6HK9ab.Warn("[多线程]出错：" + ex?.GetMessageWithInner(), ex);
			if (HPsSLStBreh)
			{
				uJDSL2gmNv8.XwhSg36TgKC.StopAction(ActionStopFlag.OperationFailed, "[多线程]出错：" + ex?.GetMessageWithInner());
			}
		}

		internal static bool IKyeMjW0nXtmdNXgvEqL()
		{
			return pRADvHW0A4VPWgApQakW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_2
	{
		public ActionExecuteContext IPpSLJa6069;

		public _003C_003Ec__DisplayClass50_1 VwgSL0Wr0X4;

		private static _003C_003Ec__DisplayClass50_2 xJcrohW0jMEGumgrCibS;

		internal void ieUSLNb4Rek()
		{
			VwgSL0Wr0X4.yh2SLLL7Tn7.Set();
			try
			{
				XActionRunner.RunChildSteps(VwgSL0Wr0X4.uJDSL2gmNv8.j0aSgiXKfWQ.IfSteps, 0, IPpSLJa6069, VwgSL0Wr0X4.uJDSL2gmNv8.QfBSgzrZpxG, VwgSL0Wr0X4.uJDSL2gmNv8.KB7SLwftdBQ);
			}
			catch (Exception ex)
			{
				SqEtz6HK9ab.Warn("执行线程步骤出错：" + ex.Message, ex);
				throw;
			}
			finally
			{
				if (VwgSL0Wr0X4.o96SLvoUKlG != null)
				{
					VwgSL0Wr0X4.o96SLvoUKlG.Release();
				}
			}
			if (VwgSL0Wr0X4.HPsSLStBreh && IPpSLJa6069.IsShouldStopAction())
			{
				VwgSL0Wr0X4.uJDSL2gmNv8.XwhSg36TgKC.StopAction(IPpSLJa6069.StopFlag, IPpSLJa6069.ErrorMessage);
				throw new Exception(IPpSLJa6069.ErrorMessage);
			}
		}

		internal static bool YVUmdEW0D9pZMwp5gUyP()
		{
			return xJcrohW0jMEGumgrCibS == null;
		}
	}

	public const string KEY = "sys:each";

	private static readonly ILog SqEtz6HK9ab;

	[CompilerGenerated]
	private readonly IEnumerable<string> QM4tzXYMdbJ = new string[8] { "重复", "each", "列表", "repeat", "item", "循环", "for", "foreach" };

	[CompilerGenerated]
	private readonly string rNwtzmRKt07 = $"fa:{EFontAwesomeIcon.Light_Repeat}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> URatzKKS6LG;

	[CompilerGenerated]
	private readonly string bVUtzx4ApiQ = "https://getquicker.net/KC/Help/Doc/each";

	[CompilerGenerated]
	private readonly bool kVutzrsvZCq;

	internal static readonly StepInParamDef IMvtzp3FVfv;

	private static readonly StepInParamDef FqLtzBZM1MW;

	private static readonly StepInParamDef HqntzQ5PfKy;

	private static readonly StepInParamDef Ysutzj3IqII;

	private static readonly StepInParamDef uIHtzn4ohwZ;

	private static readonly StepInParamDef UXwtz400dp9;

	private static readonly StepInParamDef WeTtz5F0NqD;

	private static readonly StepInParamDef xg7tzDwYimq;

	private static readonly StepOutParamDef rPetzdaOQQr;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> pULtzowW3Wa = new StepInParamDef[8] { IMvtzp3FVfv, FqLtzBZM1MW, HqntzQ5PfKy, Ysutzj3IqII, uIHtzn4ohwZ, WeTtz5F0NqD, UXwtz400dp9, xg7tzDwYimq };

	private static readonly StepOutParamDef y2KtzT8ALt4;

	private static readonly StepOutParamDef fpqtzMD4APe;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> mAqtzAqqHHC = new StepOutParamDef[3] { y2KtzT8ALt4, fpqtzMD4APe, rPetzdaOQQr };

	internal static EachStepRunner E673xIQ8eo0TTi4ZcFe0;

	public string Key => "sys:each";

	public string Name => "每个";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return QM4tzXYMdbJ;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rNwtzmRKt07;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return URatzKKS6LG;
		}
	}

	public string Description => "对列表的每项执行处理";

	public StepType StepType => StepType.Loop;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bVUtzx4ApiQ;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return kVutzrsvZCq;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return pULtzowW3Wa;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return mAqtzAqqHHC;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	private IEnumerable kU0tzb42UDZ(object object_0)
	{
		if (!(object_0 is IEnumerable))
		{
			throw new InvalidDataException("输入的数据不是可枚举对象。");
		}
		if (object_0 is string value)
		{
			return VariableHelper.ConvertToList(value);
		}
		if (object_0 is DataTable source)
		{
			return source.AsEnumerable();
		}
		if (object_0 is DataRowCollection result)
		{
			return result;
		}
		return object_0 as IEnumerable;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.j0aSgiXKfWQ = step;
		int num = 0;
		if (E673xIQ8eo0TTi4ZcFe0 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass50_.XwhSg36TgKC = context;
		_003C_003Ec__DisplayClass50_.ErZSgfJFsbx = this;
		_003C_003Ec__DisplayClass50_.QfBSgzrZpxG = action;
		_003C_003Ec__DisplayClass50_.KB7SLwftdBQ = stepId;
		_003C_003Ec__DisplayClass50_.b50SLtUhhBK = _003C_003Ec__DisplayClass50_.XwhSg36TgKC.ActionLogger;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.XwhSg36TgKC, _003C_003Ec__DisplayClass50_.j0aSgiXKfWQ, _003C_003Ec__DisplayClass50_.QfBSgzrZpxG, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.rtdSglWWKHa, (Action)null, (Action)null, xg7tzDwYimq, rPetzdaOQQr);
		_003C_003Ec__DisplayClass50_.XwhSg36TgKC.ActionLogger = _003C_003Ec__DisplayClass50_.b50SLtUhhBK;
	}

	public string GetSummary(ActionStep step)
	{
		return ((XActionHelper.GetParamDirectValue(FqLtzBZM1MW, step, false) == "1") ? "[多线程] " : "") + "对 " + XActionHelper.GetParamDisplayString(IMvtzp3FVfv, step) + " 的每项执行";
	}

	static EachStepRunner()
	{
		SqEtz6HK9ab = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		IMvtzp3FVfv = new StepInParamDef
		{
			Key = "input",
			DefaultValue = "",
			Description = "要处理的列表",
			IsRequired = true,
			IsMultiLine = true,
			Name = "列表",
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		FqLtzBZM1MW = new StepInParamDef
		{
			Key = "useMultiThread",
			Name = "线程模式",
			Description = "⚠通常不要选择! 请阅读文档详细了解后再使用。",
			Type = VarType.Enum,
			DefaultValue = "0",
			VariableMode = ParamVariableMode.Input,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "单线程（顺序执行）"),
				new SelectionItem("1", "多线程（同时执行）")
			}
		};
		HqntzQ5PfKy = new StepInParamDef
		{
			Key = "threadDelay",
			Name = "线程启动间隔",
			Description = "多线程运行时，每个线程之间的启动时间间隔毫秒数。",
			Type = VarType.Integer,
			DefaultValue = 5,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "1" }
		};
		Ysutzj3IqII = new StepInParamDef
		{
			Key = "concurrentThreadNum",
			Name = "同时线程数",
			Description = "最多同时启动的线程数，请根据电脑配置和任务内容设置。",
			Type = VarType.Integer,
			DefaultValue = 4,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "1" }
		};
		uIHtzn4ohwZ = new StepInParamDef
		{
			Key = "timeoutMs",
			Name = "超时毫秒数",
			Description = "所有线程开启后，等待的超时时间，单位：毫秒。-1:不设置超时时间",
			Type = VarType.Integer,
			DefaultValue = -1,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "1" }
		};
		UXwtz400dp9 = new StepInParamDef
		{
			Key = "waitAny",
			Name = "WaitAny模式",
			Description = "任意一个线程结束即可。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "1" }
		};
		WeTtz5F0NqD = new StepInParamDef
		{
			Key = "useLocalContext",
			Name = "为线程创建独立上下文",
			Description = "此时只能读取变量，不能更新变量（词典、列表等引用传递的除外）",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "1" }
		};
		xg7tzDwYimq = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		rPetzdaOQQr = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		y2KtzT8ALt4 = new StepOutParamDef
		{
			Key = "item",
			Name = "项",
			Description = "列表中的每项，每次循环赋予当前项的值。在子步骤中应该对本输出进行处理。",
			Type = VarType.Any
		};
		fpqtzMD4APe = new StepOutParamDef
		{
			Key = "count",
			Name = "计数",
			Description = "本次循环，处理到了第几项。",
			Type = VarType.Integer
		};
	}

	internal static bool mdXfQJQ8jnHFXjP6xEM1()
	{
		return E673xIQ8eo0TTi4ZcFe0 == null;
	}
}
