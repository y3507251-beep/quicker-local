using System;
using System.Windows;
using Quicker.Common;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class ProcessStartActionRunner : ActionRunnerBase
{
	private static ProcessStartActionRunner m0gy5gQowfr9nYZlg4B3;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		try
		{
        string newString = default;
			ProcessActionParams processActionParams = ProcessActionParams.FromActionItem(action);
			string text = processActionParams.Arguments;
			string text2 = processActionParams.FileName;
			string arguments = processActionParams.Arguments;
			if (arguments == null || !arguments.Contains("{cliptext}"))
			{
				string fileName = processActionParams.FileName;
				if (fileName == null || !fileName.Contains("{cliptext}"))
				{
					goto IL_007e;
				}
			}
			newString = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			int num = 0;
			if (m0gy5gQowfr9nYZlg4B3 != null)
			{
				goto IL_005f;
			}
			goto IL_00ea;
			IL_00fd:
			ActionHelper.StartProcess(text2, text, processActionParams.WindowStyle, processActionParams.GetWorkingDir(), processActionParams.RunAsAdmin, processActionParams.WaitForExit, processActionParams.AlternativePaths, false, false, null, null, processActionParams.ActivateWindowIfRunning, processActionParams.ActivateWindowHotkey);
			return;
			IL_005f:
			text = AppHelper.ReplacePattern(text, "{cliptext}", newString);
			text2 = AppHelper.ReplacePattern(text2, "{cliptext}", newString).Trim();
			goto IL_007e;
			IL_00ea:
			switch (num)
			{
			case 1:
				goto IL_00fd;
			}
			goto IL_005f;
			IL_007e:
			string arguments2 = processActionParams.Arguments;
			if (arguments2 == null || !arguments2.Contains("{context}"))
			{
				string fileName2 = processActionParams.FileName;
				if (fileName2 == null || !fileName2.Contains("{context}"))
				{
					goto IL_00fd;
				}
			}
			string newString2 = actionExecuteContext.TextData ?? "";
			text = AppHelper.ReplacePattern(text, "{context}", newString2);
			text2 = AppHelper.ReplacePattern(text2, "{context}", newString2);
			num = 1;
			if (BDxuS4QoTiAmSBaH4q5k())
			{
				goto IL_00ea;
			}
			goto IL_00fd;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("启动进程出错:" + ex.Message);
		}
	}

	internal static bool BDxuS4QoTiAmSBaH4q5k()
	{
		return m0gy5gQowfr9nYZlg4B3 == null;
	}
}
