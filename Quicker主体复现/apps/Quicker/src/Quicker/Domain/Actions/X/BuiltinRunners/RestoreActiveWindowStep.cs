using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class RestoreActiveWindowStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public ActionExecuteContext TYCSggI0x7M;

		private static _003C_003Ec__DisplayClass33_0 P4q9PpWGEQeQjk56TleS;

		internal (bool isSuccess, string message, ActionStopFlag failReason) spfSgtMrGYw()
		{
			RestoreActiveWindow(TYCSggI0x7M);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass33_0()
		{
		}

		internal static bool r9jxNQWGGbqygBTJTJBb()
		{
			return P4q9PpWGEQeQjk56TleS == null;
		}

		internal static void U8t0JtWG1wNI4nUdv6fS()
		{
		}
	}

	private static readonly ILog RW7tiUvEbEk;

	[CompilerGenerated]
	private readonly IEnumerable<string> jlXtilm1rKO;

	[CompilerGenerated]
	private readonly string GwmtiiD5x3f = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> VuHti3g9LZu;

	[CompilerGenerated]
	private readonly string syotifEYT6S = "https://getquicker.net/KC/Help/Doc/restoreactivewindow";

	[CompilerGenerated]
	private readonly bool KGVtizwTfUY;

	internal static RestoreActiveWindowStep hnXQMSQ5YXLjuuAskXcK;

	public string Key => "sys:restoreActiveWindow";

	public string Name => "恢复活动窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return jlXtilm1rKO;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GwmtiiD5x3f;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return VuHti3g9LZu;
		}
	}

	public string Description => "如果活动窗口改变了（比如使用了参数输入步骤）,使用此动作恢复窗口焦点。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return syotifEYT6S;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return KGVtizwTfUY;
		}
	}

	public IList<StepInParamDef> InputParams => Array.Empty<StepInParamDef>();

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.TYCSggI0x7M = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass33_.TYCSggI0x7M, step, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass33_.spfSgtMrGYw, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public static void RestoreActiveWindow(ActionExecuteContext context)
	{
		if (context.ActiveWindowHwnd != IntPtr.Zero)
		{
			try
			{
				AppHelper.SetForegroundWindow(context.ActiveWindowHwnd);
			}
			catch (Exception ex)
			{
				RW7tiUvEbEk.Warn("还原焦点窗口出错：" + ex.Message);
				AppHelper.ShowWarning("还原窗口焦点出错。");
			}
		}
	}

	public string GetSummary(ActionStep step)
	{
		return "还原活动窗口";
	}

	static RestoreActiveWindowStep()
	{
		RW7tiUvEbEk = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool GhZY3LQ58QbQL5ikH17y()
	{
		return hnXQMSQ5YXLjuuAskXcK == null;
	}
}
