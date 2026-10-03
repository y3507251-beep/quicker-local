using System;
using System.Globalization;
using System.Web;
using System.Windows;
using Quicker.Common;
using Quicker.Properties;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Runner;

public class UrlActionRunner : ActionRunnerBase
{
	internal static UrlActionRunner FuNiccQfJFG0w4cIkgtW;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (string.IsNullOrWhiteSpace(action.Data))
		{
			MessageBoxHelper.Show(CommonStrings.UrlActionRunner_ExecuteAction_Err_NoUrlToOpen);
			return;
		}
		try
		{
			string url = AppHelper.ReplacePattern(action.Data, "{cliptext}", HttpUtility.UrlEncode(ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText)));
			if (actionExecuteContext.TextData != null)
			{
				url = AppHelper.ReplacePattern(action.Data, "{context}", HttpUtility.UrlEncode(actionExecuteContext.TextData));
			}
			ActionHelper.OpenUrl(url, action.Data2, action.Data3);
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(string.Format(CultureInfo.InvariantCulture, CommonStrings.UrlActionRunner_ExecuteAction_Err_Fmt, ex.Message), "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	internal static bool xpEZ1UQfkp48sbsCg4F7()
	{
		return FuNiccQfJFG0w4cIkgtW == null;
	}
}
