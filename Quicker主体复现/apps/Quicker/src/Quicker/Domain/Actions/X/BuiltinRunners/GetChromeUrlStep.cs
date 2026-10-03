using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Jlr1ujXFFaeKpmreNmQ;
using Newtonsoft.Json.Linq;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Chrome;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetChromeUrlStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActionExecuteContext tuLSvzMMR2j;

		public ActionStep pPlSSwTEVIC;

		public XAction z0HSStwLNa6;

		private static _003C_003Ec__DisplayClass37_0 K20EWVW1KHjZ9CnLxn57;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Tn4SvfGsk3a()
		{
			try
			{
				string activeTabUrl = GetActiveTabUrl(tuLSvzMMR2j, 2000);
				if (string.IsNullOrEmpty(activeTabUrl))
				{
					string item = "获取url失败，可能不兼容此chrome版本。";
					return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(xVZggEARElI, pPlSSwTEVIC, tuLSvzMMR2j, activeTabUrl, z0HSStwLNa6);
			}
			catch (Exception ex)
			{
				string item2 = "获取url失败。" + ex.Message;
				return (isSuccess: false, message: item2, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool hN9VtvW1BH3wZNKulSn3()
		{
			return K20EWVW1KHjZ9CnLxn57 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> amlgg2elBGY;

	[CompilerGenerated]
	private readonly string odeggub3Bo1 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> TF5ggNPgStk;

	[CompilerGenerated]
	private readonly string JHuggJbAfQF = "https://getquicker.net/KC/Help/Doc/getchromeurl";

	[CompilerGenerated]
	private readonly bool nL5gg0UoZjy;

	private static readonly StepInParamDef jU4ggC4Yml1;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> XBeggPHmXAe = new List<StepInParamDef> { jU4ggC4Yml1 };

	private static readonly StepOutParamDef xVZggEARElI;

	private static readonly StepOutParamDef yXAggySAKBh;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> G2qgg83yhQN = new StepOutParamDef[2] { xVZggEARElI, yXAggySAKBh };

	private static GetChromeUrlStep kP2BoyQRBSGllvJgBZ9f;

	public string Key => "sys:getChromeUrl";

	public string Name => "获取浏览器网址";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return amlgg2elBGY;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return odeggub3Bo1;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.SoftInteraction;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return TF5ggNPgStk;
		}
	}

	public string Description => "获取当前浏览器网址。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return JHuggJbAfQF;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return nL5gg0UoZjy;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return XBeggPHmXAe;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return G2qgg83yhQN;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.tuLSvzMMR2j = context;
		_003C_003Ec__DisplayClass37_.pPlSSwTEVIC = step;
		_003C_003Ec__DisplayClass37_.z0HSStwLNa6 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass37_.tuLSvzMMR2j, _003C_003Ec__DisplayClass37_.pPlSSwTEVIC, _003C_003Ec__DisplayClass37_.z0HSStwLNa6, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass37_.Tn4SvfGsk3a, (Action)null, (Action)null, jU4ggC4Yml1, yXAggySAKBh);
	}

	public string GetSummary(ActionStep step)
	{
		return " => " + XActionHelper.GetOutputParamDisplayString(xVZggEARElI, step);
	}

	public static string GetActiveTabUrl(ActionExecuteContext context, int timeoutMs)
	{
		string text = AppState.CurrentProcessName.ToLower();
		int browserMainProcess = ProcessHelper.GetBrowserMainProcess(AppState.CurrentProcessId, text);
		if (ChromeControl.IsBrowserConnected(text, browserMainProcess))
		{
			try
			{
				BrowserRespMessage<JToken> tabInfo = y79XvEXVcj9PCimSMLg.GetTabInfo(null, text, timeoutMs, context.CancellationToken);
				if (tabInfo != null)
				{
					int num = 0;
					if (kP2BoyQRBSGllvJgBZ9f != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					default:
						if (tabInfo.IsSuccess)
						{
							string text2 = tabInfo.Data["url"]?.ToObject<string>();
							if (!string.IsNullOrEmpty(text2))
							{
								context.ActionLogger.LogInfo("通过浏览器插件获得了当前网址：" + text2);
								return text2;
							}
						}
						break;
					}
				}
			}
			catch (Exception exception)
			{
				context.ActionLogger.LogWarning("通过浏览器插件获得当前网址出错。" + exception.GetMessageWithInner());
			}
		}
		SendKeys.SendWait("^l");
		return AppHelper.GetSelectedText(2L);
	}

	static GetChromeUrlStep()
	{
		jU4ggC4Yml1 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		xVZggEARElI = new StepOutParamDef
		{
			Key = "output",
			Name = "网址",
			Description = "当前标签网址URL",
			Type = VarType.Text
		};
		yXAggySAKBh = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool kfTeBAQRvTMX7OqUgi0V()
	{
		return kP2BoyQRBSGllvJgBZ9f == null;
	}

	internal static void JvoQg7QRJsGOBVd7fIKf()
	{
	}
}
