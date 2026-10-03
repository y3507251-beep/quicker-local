using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using bO46JfWAenppOQ94A2q;
using C2upcwoPZZhs1EfA15V;
using CSScriptLibrary;
using FontAwesome5;
using iERcWaYpujCoDZx6wbF;
using log4net;
using LPAgent.Domain;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Other;

public class RunCsScriptStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public ActionStep D4hS9vwufFr;

		public ActionExecuteContext wAdS9Sa3nu0;

		public XAction Eq7S92ychFh;

		public RunCsScriptStep M8KS9u87600;

		internal static _003C_003Ec__DisplayClass62_0 oVQFf2W9D8qYXV9olNwl;

		internal (bool isSuccess, string message, ActionStopFlag failReason) ktxS9Lj4Agi()
		{
			string textParamValue = XActionHelper.GetTextParamValue(cxIgZUtvRt2, D4hS9vwufFr, wAdS9Sa3nu0);
			string textParamValue2 = XActionHelper.GetTextParamValue(YOXgZlahCRK, D4hS9vwufFr, wAdS9Sa3nu0);
			string textParamValue3 = XActionHelper.GetTextParamValue(iWog9tU9vLL, D4hS9vwufFr, wAdS9Sa3nu0);
			ThreadType threadType = ThreadType.Auto;
			if (textParamValue.EqualsAny(false, "normal", "normal_roslyn"))
			{
				switch (textParamValue3)
				{
				default:
					if (textParamValue3.Length != 0)
					{
						goto case null;
					}
					goto case "auto";
				case null:
					if (textParamValue3 != null)
					{
						return (isSuccess: false, message: "不支持的线程类型：" + textParamValue3 + ", 可能您使用的Quicker版本过旧。", failReason: ActionStopFlag.OperationFailed);
					}
					goto case "auto";
				case "auto":
					threadType = ThreadType.Auto;
					break;
				case "staLongRun":
					threadType = ThreadType.StaBackgroundLongRun;
					break;
				case "sta":
					threadType = ThreadType.StaBackground;
					break;
				case "background":
					threadType = ThreadType.MtaBackground;
					break;
				case "ui":
					threadType = ThreadType.Ui;
					break;
				}
				if (threadType == ThreadType.Auto)
				{
					threadType = ((textParamValue2.IndexOf(".ShowDialog", StringComparison.Ordinal) <= 0 && textParamValue2.IndexOf(".Show", StringComparison.Ordinal) <= 0) ? ((!textParamValue2.ContainsAny("Clipboard.", "ComInterfaceType", "ComImport", "ComInterfaceType", "QueryService", "Shell.Application", "RenderTargetBitmap", "System.Windows.Controls.Imag", "Viewbox", "SvgDocument")) ? ThreadType.MtaBackground : ThreadType.StaBackground) : ((!Regex.IsMatch(textParamValue2, "class\\s+\\w+\\s*:\\s*(System\\.Windows\\.Forms\\.)?Form")) ? ThreadType.Ui : ThreadType.StaBackgroundLongRun));
					wAdS9Sa3nu0.ActionLogger.LogInfo($"线程类型：{threadType}");
				}
			}
			return textParamValue switch
			{
				"generate_assembly" => M8KS9u87600.n4QgZnkTKkw(D4hS9vwufFr, wAdS9Sa3nu0, Eq7S92ychFh), 
				"low_permission_roslyn" => M8KS9u87600.mCbgZ4TWN4W(D4hS9vwufFr, wAdS9Sa3nu0, Eq7S92ychFh, true), 
				"low_permission" => M8KS9u87600.mCbgZ4TWN4W(D4hS9vwufFr, wAdS9Sa3nu0, Eq7S92ychFh, false), 
				"normal_roslyn" => K5ZgZdAW1RN(D4hS9vwufFr, wAdS9Sa3nu0, Eq7S92ychFh, textParamValue2, threadType), 
				"normal" => gSMgZ5GvJW6(D4hS9vwufFr, wAdS9Sa3nu0, Eq7S92ychFh, textParamValue2, threadType), 
				_ => (isSuccess: false, message: "未知的模式：" + textParamValue + " 可能您使用的Quicker版本过旧。", failReason: ActionStopFlag.OperationFailed), 
			};
		}

		internal static bool Ldg8oPW93tUOEPaXTySM()
		{
			return oVQFf2W9D8qYXV9olNwl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		public Assembly sCnS90KEGNZ;

		private static _003C_003Ec__DisplayClass63_0 TYTYj1W9GxuJlSVeytdF;

		internal object oBXS9NDLVtr()
		{
			return sCnS90KEGNZ;
		}

		internal object YK9S9Jsygua()
		{
			return sCnS90KEGNZ.Location;
		}

		internal static bool MO0cGFW90B9eNPJtt0EH()
		{
			return TYTYj1W9GxuJlSVeytdF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass66_0
	{
		public object IBTS9EmNTTZ;

		public MethodDelegate B80S9yYvUsq;

		public IStepContext boYS98QdN5G;

		private static _003C_003Ec__DisplayClass66_0 bKXuwQW9KYXLRWP7SV2g;

		internal void wB7S9CFO4Dc()
		{
			IBTS9EmNTTZ = B80S9yYvUsq(boYS98QdN5G);
		}

		internal void eHYS9PG77fk()
		{
			IBTS9EmNTTZ = B80S9yYvUsq(boYS98QdN5G);
		}

		internal static bool l2PlMPW9BjEZL681AH3Q()
		{
			return bKXuwQW9KYXLRWP7SV2g == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass66_1
	{
		public Exception RevS97AeQar;

		public _003C_003Ec__DisplayClass66_0 KmiS9RI8eDg;

		internal static _003C_003Ec__DisplayClass66_1 XR9r9gW9d0ERFcjqJKQp;

		internal void LHAS9aOyJla()
		{
			try
			{
				KmiS9RI8eDg.IBTS9EmNTTZ = KmiS9RI8eDg.B80S9yYvUsq(KmiS9RI8eDg.boYS98QdN5G);
			}
			catch (Exception revS97AeQar)
			{
				RevS97AeQar = revS97AeQar;
			}
		}

		internal static bool A9rEcZW9OMkfRZEUSVdV()
		{
			return XR9r9gW9d0ERFcjqJKQp == null;
		}
	}

	private static readonly ILog Ob8gZo3uy9I;

	public const string StepKey = "sys:csscript";

	[CompilerGenerated]
	private readonly IEnumerable<string> FeDgZTTHTP3;

	[CompilerGenerated]
	private readonly string XZYgZMVaTQG = $"fa:{EFontAwesomeIcon.Light_Scroll}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> poCgZAJ4h2j;

	[CompilerGenerated]
	private readonly string SatgZOQgLp2 = "https://getquicker.net/KC/Help/Doc/csscript";

	[CompilerGenerated]
	private readonly bool PcAgZFjmFWq;

	public const string MODE_NORMAL = "normal";

	public const string MODE_NORMAL_ROSLYN = "normal_roslyn";

	public const string MODE_LOW_PERMISSION = "low_permission";

	public const string MODE_LOW_PERMISSION_ROSLYN = "low_permission_roslyn";

	public const string MODE_GENERATE_ASSEMBLY = "generate_assembly";

	private static readonly StepInParamDef cxIgZUtvRt2;

	private static readonly StepInParamDef YOXgZlahCRK;

	private static readonly StepInParamDef g6bgZiWcVJO;

	private static readonly StepInParamDef rXPgZ31T7Kj;

	private static readonly StepInParamDef oBbgZfAMFXp;

	private static readonly StepInParamDef rW9gZzyRECj;

	private static readonly StepInParamDef uUtg9wowWmO;

	private static readonly StepInParamDef iWog9tU9vLL;

	private static readonly StepInParamDef hOTg9gksMYv;

	private static readonly StepInParamDef PWRg9LPx3AV;

	private static readonly StepInParamDef VYLg9vZNOFb;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> NEqg9SwZnuh = new List<StepInParamDef>
	{
		cxIgZUtvRt2, YOXgZlahCRK, g6bgZiWcVJO, rXPgZ31T7Kj, oBbgZfAMFXp, rW9gZzyRECj, hOTg9gksMYv, iWog9tU9vLL, uUtg9wowWmO, VYLg9vZNOFb,
		PWRg9LPx3AV
	};

	private static readonly StepOutParamDef YZig92K1AEH;

	private static readonly StepOutParamDef x7Rg9uljAWT;

	private static readonly StepOutParamDef L5mg9NSMjXl;

	private static readonly StepOutParamDef huvg9JFhS1j;

	private static readonly StepOutParamDef P50g90SNrG2;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Bteg9Co1oJH = new List<StepOutParamDef> { YZig92K1AEH, x7Rg9uljAWT, L5mg9NSMjXl, huvg9JFhS1j, P50g90SNrG2 };

	private static RunCsScriptStep rjN0ORQSZSaGHIoJgikd;

	public string Key => "sys:csscript";

	public string Name => "运行C#代码";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return FeDgZTTHTP3;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return XZYgZMVaTQG;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return poCgZAJ4h2j;
		}
	}

	public string Description => "执行C#代码片段。代码中应包含主函数Exec(stepContext)，请参考文档说明。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return SatgZOQgLp2;
		}
	}

	public bool IsRisky => true;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return PcAgZFjmFWq;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return NEqg9SwZnuh;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Bteg9Co1oJH;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
		_003C_003Ec__DisplayClass62_.D4hS9vwufFr = step;
		_003C_003Ec__DisplayClass62_.wAdS9Sa3nu0 = context;
		_003C_003Ec__DisplayClass62_.Eq7S92ychFh = action;
		_003C_003Ec__DisplayClass62_.M8KS9u87600 = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass62_.wAdS9Sa3nu0, _003C_003Ec__DisplayClass62_.D4hS9vwufFr, _003C_003Ec__DisplayClass62_.Eq7S92ychFh, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass62_.ktxS9Lj4Agi, (Action)null, (Action)null, VYLg9vZNOFb, YZig92K1AEH);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) n4QgZnkTKkw(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		string textParamValue = XActionHelper.GetTextParamValue(rXPgZ31T7Kj, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(rW9gZzyRECj, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass63_.sCnS90KEGNZ = IdTxBgYLD3s5dY2ejoa.EOeLD73MEQN(textParamValue, textParamValue2, true);
		XActionHelper.OutputResultIfNeeded(huvg9JFhS1j, _003C_003Ec__DisplayClass63_.oBXS9NDLVtr, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(P50g90SNrG2, _003C_003Ec__DisplayClass63_.YK9S9Jsygua, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) mCbgZ4TWN4W(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, bool bool_1)
	{
		string textParamValue = XActionHelper.GetTextParamValue(g6bgZiWcVJO, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(rW9gZzyRECj, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(oBbgZfAMFXp, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(hOTg9gksMYv, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(uUtg9wowWmO, actionStep_0, actionExecuteContext_0);
		int maxWaitMs = (int)XActionHelper.GetIntegerParamValue(PWRg9LPx3AV, actionStep_0, actionExecuteContext_0);
		y2RHWHW5SANm8yApQAU y2RHWHW5SANm8yApQAU = y2RHWHW5SANm8yApQAU.PeBtgjCTonj();
		Command command_ = new Command
		{
			Runner = "csharp",
			Data = textParamValue,
			WaitResp = booleanParamValue,
			MaxWaitMs = maxWaitMs,
			Params = new Dictionary<string, string>
			{
				{ "paramValue", textParamValue3 },
				{ "references", textParamValue2 },
				{
					"enableCache",
					booleanParamValue2 ? "1" : "0"
				},
				{
					"useRoslyn",
					bool_1 ? "1" : "0"
				}
			}
		};
		Response response = y2RHWHW5SANm8yApQAU.PFotgQdV5Ru(command_);
		if (booleanParamValue)
		{
			if (response == null)
			{
				return (isSuccess: false, message: "超时未收到低权限代理程序响应。", failReason: ActionStopFlag.OperationFailed);
			}
			if (!response.IsSuccess)
			{
				actionExecuteContext_0.ActionLogger.LogWarning(response.Message + "  StackTrace:" + response.StackTrace);
				return (isSuccess: false, message: "命令返回失败，错误：" + response.Message, failReason: ActionStopFlag.OperationFailed);
			}
			XActionHelper.OutputResult(x7Rg9uljAWT, actionStep_0, actionExecuteContext_0, response.Data, xaction_0);
		}
		else
		{
			XActionHelper.OutputResult(x7Rg9uljAWT, actionStep_0, actionExecuteContext_0, "", xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) gSMgZ5GvJW6(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, ThreadType threadType_0)
	{
		IStepContext stepContext = new StepContext(actionStep_0, xaction_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(rW9gZzyRECj, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(uUtg9wowWmO, actionStep_0, actionExecuteContext_0);
		Assembly obj = KpQc1Fo9vVSbWFx7GcL.sR3gm03BPA4(string_2, textParamValue, booleanParamValue, actionExecuteContext_0);
		MethodDelegate staticMethod = obj.GetStaticMethod("*.Exec", stepContext);
		actionExecuteContext_0.ActionLogger.LogInfo("已编译成功脚本，开始执行...");
		try
		{
			object obj2 = Df4gZDb1Iw9(threadType_0, staticMethod, stepContext);
			XActionHelper.OutputResult(L5mg9NSMjXl, actionStep_0, actionExecuteContext_0, obj2 ?? "", xaction_0);
		}
		catch (Exception exception)
		{
			Ob8gZo3uy9I.Warn("执行CS脚本出错。" + exception.GetMessageWithInner(), exception);
			return (isSuccess: false, message: "执行CS脚本出错：" + exception.GetMessageWithInner() + "。", failReason: ActionStopFlag.OperationFailed);
		}
		finally
		{
			obj.UnloadOwnerDomain();
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static object Df4gZDb1Iw9(ThreadType threadType_0, MethodDelegate methodDelegate_0, IStepContext istepContext_0)
	{
		_003C_003Ec__DisplayClass66_0 _003C_003Ec__DisplayClass66_ = new _003C_003Ec__DisplayClass66_0();
		_003C_003Ec__DisplayClass66_.B80S9yYvUsq = methodDelegate_0;
		_003C_003Ec__DisplayClass66_.boYS98QdN5G = istepContext_0;
		_003C_003Ec__DisplayClass66_.IBTS9EmNTTZ = null;
		_003C_003Ec__DisplayClass66_1 _003C_003Ec__DisplayClass66_2 = new _003C_003Ec__DisplayClass66_1();
		_003C_003Ec__DisplayClass66_2.KmiS9RI8eDg = _003C_003Ec__DisplayClass66_;
		switch (threadType_0)
		{
		case ThreadType.Ui:
			_003C_003Ec__DisplayClass66_2.RevS97AeQar = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass66_2.LHAS9aOyJla);
			if (rjN0ORQSZSaGHIoJgikd == null)
			{
				switch (0)
				{
				}
			}
			if (_003C_003Ec__DisplayClass66_2.RevS97AeQar != null)
			{
				throw _003C_003Ec__DisplayClass66_2.RevS97AeQar;
			}
			break;
		default:
			_003C_003Ec__DisplayClass66_2.KmiS9RI8eDg.IBTS9EmNTTZ = _003C_003Ec__DisplayClass66_2.KmiS9RI8eDg.B80S9yYvUsq(_003C_003Ec__DisplayClass66_2.KmiS9RI8eDg.boYS98QdN5G);
			break;
		case ThreadType.StaBackground:
			GaZT3MMHZ3eZxDOySux.sL2LMlMVkZs(_003C_003Ec__DisplayClass66_2.KmiS9RI8eDg.wB7S9CFO4Dc);
			break;
		case ThreadType.StaBackgroundLongRun:
			GaZT3MMHZ3eZxDOySux.QcLLMUD9rhr(_003C_003Ec__DisplayClass66_2.KmiS9RI8eDg.eHYS9PG77fk, "csStaLongRun");
			break;
		}
		return _003C_003Ec__DisplayClass66_.IBTS9EmNTTZ;
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) K5ZgZdAW1RN(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, ThreadType threadType_0)
	{
		IStepContext stepContext = new StepContext(actionStep_0, xaction_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(rW9gZzyRECj, actionStep_0, actionExecuteContext_0);
		MethodDelegate staticMethod = IdTxBgYLD3s5dY2ejoa.iR5LD03dxXY(string_2, textParamValue, actionExecuteContext_0).GetStaticMethod("*.Exec", stepContext);
		try
		{
			object obj = Df4gZDb1Iw9(threadType_0, staticMethod, stepContext);
			XActionHelper.OutputResult(L5mg9NSMjXl, actionStep_0, actionExecuteContext_0, obj ?? "", xaction_0);
		}
		catch (Exception exception)
		{
			Ob8gZo3uy9I.Warn("执行CS脚本出错。" + exception.GetMessageWithInner(), exception);
			throw;
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static RunCsScriptStep()
	{
		Ob8gZo3uy9I = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		cxIgZUtvRt2 = new StepInParamDef
		{
			Key = "mode",
			Name = "运行模式",
			Description = "普通模式：在Quicker进程中执行；低权限模式：在单独的进程中执行，可用于COM操作。",
			DefaultValue = "normal",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("normal_roslyn", "普通模式v2 (Roslyn)"),
				new SelectionItem("normal", "普通模式v1 (CodeDOM)"),
				new SelectionItem("low_permission_roslyn", "低权限模式v2 (Roslyn)"),
				new SelectionItem("low_permission", "低权限模式v1 (CodeDOM)"),
				new SelectionItem("generate_assembly", "生成程序集")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		YOXgZlahCRK = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "//.cs  文件类型，便于外部编辑时使用\r\n// 引用必要的命名空间\r\nusing System.Windows.Forms;\r\n\r\n// Quicker将会调用的函数。可以根据需要修改返回值类型。\r\npublic static void Exec(Quicker.Public.IStepContext context)\r\n{\r\n    //var oldValue = context.GetVarValue(\"varName\");  // 读取动作里的变量值\r\n    //MessageBox.Show(oldValue as string);\r\n    //context.SetVarValue(\"varName\", \"从脚本输出的内容。\"); // 向变量里输出值\r\n    MessageBox.Show(\"Hello World!\");\r\n}\r\n",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			DefaultHighlightType = "C#",
			ValidForList = new string[2] { "normal", "normal_roslyn" }
		};
		g6bgZiWcVJO = new StepInParamDef
		{
			Key = "scriptForLp",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "//.cs  文件类型，便于外部编辑时使用\r\n// 引用必要的命名空间\r\nusing System.Windows.Forms;\r\n\r\n// Quicker将会调用的函数\r\npublic static string Exec(string paramValue)\r\n{\r\n    System.Windows.Forms.MessageBox.Show(\"Hello World!\");\r\n    return \"Hello World!\";\r\n}\r\n",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			DefaultHighlightType = "C#",
			ValidForList = new string[2] { "low_permission", "low_permission_roslyn" }
		};
		rXPgZ31T7Kj = new StepInParamDef
		{
			Key = "scriptForAssembly",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "//.cs  文件类型，便于外部编辑时使用\r\n// 引用必要的命名空间\r\nusing System.Windows.Forms;\r\n\r\nnamespace MyNamespace\r\n{\r\n    // Quicker将会调用的函数\r\n    public static class MyClass\r\n    {\r\n        public static string Exec(string paramValue)\r\n        {\r\n            System.Windows.Forms.MessageBox.Show(\"Hello World!\");\r\n            return \"Hello World!\";\r\n        }\r\n    }\r\n}\r\n",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			DefaultHighlightType = "C#",
			ValidForList = new string[1] { "generate_assembly" }
		};
		oBbgZfAMFXp = new StepInParamDef
		{
			Key = "paramValue",
			Name = "参数值",
			Description = "传递给Exec的参数",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[2] { "low_permission", "low_permission_roslyn" }
		};
		rW9gZzyRECj = new StepInParamDef
		{
			Key = "reference",
			Name = "引用DLL库",
			Description = "要引用的DLL文件，每行一个。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			TextTools = new List<TextToolType> { TextToolType.SelectMultiFile },
			ReplaceMode = TextToolsReplaceMode.AppendWithNewline
		};
		uUtg9wowWmO = new StepInParamDef
		{
			Key = "enableCache",
			Name = "允许缓存程序集",
			DefaultValue = false,
			Description = "是否使用缓存的程序集",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "normal", "low_permission" }
		};
		iWog9tU9vLL = new StepInParamDef
		{
			Key = "runOnUiThread",
			Name = "执行线程",
			DefaultValue = "auto",
			Description = "是否在界面线程上运行代码。如果在脚本中使用了wpf窗口，请选中此项。",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", "自动"),
				new SelectionItem("ui", "UI线程"),
				new SelectionItem("background", "后台线程(MTA)"),
				new SelectionItem("sta", "后台线程(STA)"),
				new SelectionItem("staLongRun", "后台线程(STA独立线程)")
			},
			ValidForList = new string[2] { "normal", "normal_roslyn" }
		};
		hOTg9gksMYv = new StepInParamDef
		{
			Key = "waitResp",
			Name = "等待返回",
			DefaultValue = true,
			Description = "是否等待脚本返回结果",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "low_permission", "low_permission_roslyn" }
		};
		PWRg9LPx3AV = new StepInParamDef
		{
			Key = "waitMs",
			Name = "最长等待时间(ms)",
			DefaultValue = 10000,
			Description = "最长的等待返回结果的，毫秒数",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "low_permission", "low_permission_roslyn" },
			IsAdvanced = true
		};
		VYLg9vZNOFb = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		YZig92K1AEH = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		x7Rg9uljAWT = new StepOutParamDef
		{
			Key = "resp",
			Name = "返回内容",
			Description = "脚本执行返回的结果文本",
			Type = VarType.Text,
			ValidForList = new string[2] { "low_permission", "low_permission_roslyn" }
		};
		L5mg9NSMjXl = new StepOutParamDef
		{
			Key = "rtn",
			Name = "返回内容",
			Description = "Exec方法的返回值",
			Type = VarType.Text,
			ValidForList = new string[2] { "normal", "normal_roslyn" }
		};
		huvg9JFhS1j = new StepOutParamDef
		{
			Key = "rtnAssembly",
			Name = "程序集对象",
			Description = "生成的Assembly对象（已经加载）",
			Type = VarType.Object,
			ValidForList = new string[1] { "generate_assembly" }
		};
		P50g90SNrG2 = new StepOutParamDef
		{
			Key = "assemblyPath",
			Name = "程序集路径",
			Description = "生成的Assembly路径",
			Type = VarType.Text,
			ValidForList = new string[1] { "generate_assembly" }
		};
	}

	internal static bool ohOikFQS5LxuFX2mLbTp()
	{
		return rjN0ORQSZSaGHIoJgikd == null;
	}
}
