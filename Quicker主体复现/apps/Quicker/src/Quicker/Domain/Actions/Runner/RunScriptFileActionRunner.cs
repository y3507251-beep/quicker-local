using System;
using System.Reflection;
using System.Text;
using System.Windows;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Properties;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class RunScriptFileActionRunner : ActionRunnerBase
{
	private static readonly ILog AZkt5HyMZK0;

	private static RunScriptFileActionRunner qSggROQorNqpwLMLEqQH;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (string.IsNullOrEmpty(action.Data))
		{
			AppHelper.ShowInformation(CommonStrings.RunScriptFileActionRunner_ExecuteAction_Error_DataEmpty);
			return;
		}
		RunScriptActionParam runScriptActionParam = JsonConvert.DeserializeObject<RunScriptActionParam>(action.Data);
		string text = runScriptActionParam.Script;
		int num;
		if (text != null && text.Contains("{cliptext}"))
		{
			string newString = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			text = AppHelper.ReplacePattern(text, "{cliptext}", newString);
			num = 1;
			if (!fJtGu1QoN40LkagaGyVF())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00bf;
		}
		goto IL_0103;
		IL_0103:
		if (text != null && text.Contains("{context}"))
		{
			string newString2 = actionExecuteContext.TextData ?? "";
			text = AppHelper.ReplacePattern(text, "{context}", newString2);
		}
		Encoding fileEncoding = Encoding.Default;
		if (!string.IsNullOrEmpty(runScriptActionParam.Encoding))
		{
			if (!runScriptActionParam.Encoding.Equals("UTF8-NOBOM", StringComparison.OrdinalIgnoreCase))
			{
				if (runScriptActionParam.Encoding.Equals("default", StringComparison.OrdinalIgnoreCase))
				{
					num = 0;
					if (qSggROQorNqpwLMLEqQH != null)
					{
						goto IL_00bf;
					}
					goto IL_0117;
				}
				try
				{
					fileEncoding = Encoding.GetEncoding(runScriptActionParam.Encoding);
				}
				catch (Exception exception)
				{
					AZkt5HyMZK0.Warn(CommonStrings.Common_Err_UnknownEncoding + runScriptActionParam.Encoding, exception);
					AppHelper.ShowWarning(CommonStrings.Common_Err_UnknownEncoding + runScriptActionParam.Encoding);
					fileEncoding = Encoding.UTF8;
				}
			}
			else
			{
				fileEncoding = new UTF8Encoding(true);
			}
		}
		goto IL_0170;
		IL_0117:
		fileEncoding = Encoding.Default;
		goto IL_0170;
		IL_00bf:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0117;
		}
		goto IL_0103;
		IL_0170:
		ScriptRunner scriptRunner = new ScriptRunner(text, runScriptActionParam.Type, runScriptActionParam.Ext, "", runScriptActionParam.RunAsAdmin, runScriptActionParam.WaitForExit, true, fileEncoding, runScriptActionParam.WorkingDir, "oem", "%FILE%", 36000000, action.Title);
		try
		{
			scriptRunner.Execute(false);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(CommonStrings.RunScriptFileActionRunner_ExecuteAction_Err_RunScriptError + ex.Message);
		}
	}

	static RunScriptFileActionRunner()
	{
		AZkt5HyMZK0 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool fJtGu1QoN40LkagaGyVF()
	{
		return qSggROQorNqpwLMLEqQH == null;
	}
}
