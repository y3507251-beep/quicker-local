using System;
using System.Reflection;
using System.Windows.Forms;
using Ko4fe7AdlIHVfm4LNc6;
using log4net;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using vWqIxxMqTcYJW8kXilN;

namespace Tx7JHl2LkU52UwokyCJ;

internal class CxPyBB2GbLo3XslgL6G
{
	private static readonly ILog Bv4ththfUeA;

	internal static CxPyBB2GbLo3XslgL6G XsDOdbQBEmky5BNANint;

	public static string oP6thw9VUmy(string string_0, string string_1, string string_2, bool bool_0)
	{
		string text = string_0.ToUpperInvariant();
		switch (text)
		{
		case "OPEN":
			AppHelper.TryOpenUrlOrFile(string_1);
			return "Ok.";
		case "COPY":
			try
			{
				ClipboardHelper.SetText(string_1);
				AppHelper.ShowInformation("内容已写入剪贴板。");
				return "Ok.";
			}
			catch (Exception exception2)
			{
				AppHelper.ShowWarning("内容写入剪贴板失败！" + exception2.GetMessageWithInner());
				return "Error:" + exception2.GetMessageWithInner();
			}
		case "PASTE":
			try
			{
				ActionHelper.SendTextToWindow(string_1, true, false, 50, 50);
				return "Ok.";
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("内容写入剪贴板失败！" + exception.GetMessageWithInner());
				return "Error:" + exception.GetMessageWithInner();
			}
		case "ACTION":
			try
			{
				(ActionItem, ActionExecuteContext, string) tuple = AppState.AppServer.ExecuteActionByIdOrName(string_2, null, false, bool_0, true, string_1, ActionTrigger.Extern);
				if (XsDOdbQBEmky5BNANint != null)
				{
					switch (0)
					{
					}
				}
				if (!string.IsNullOrEmpty(tuple.Item2?.ReturnResult))
				{
					return tuple.Item2.ReturnResult;
				}
				ActionExecuteContext item = tuple.Item2;
				if (item != null && item.ReturnError)
				{
					return "Error:" + tuple.Item2?.ErrorMessage;
				}
				return "Ok.";
			}
			catch (Exception ex2)
			{
				Bv4ththfUeA.Warn("运行动作(" + string_2 + ")出错：" + ex2.Message, ex2);
				return "Error:" + ex2.Message;
			}
		case "INPUT":
		case "SENDKEYS":
			SendKeys.SendWait(string_1);
			return "Ok.";
		case "INPUTTEXT":
			ActionHelper.SendTextToWindow(string_1, false, false, 0, 0);
			return "Ok.";
		case "START_SYNC":
			AppState.DataService.xdNt6mQNakh(false);
			return "Ok.";
		case "INPUTSCRIPT":
			D3mwCbAmx8tANGphaEi.ExecuteScript(string_1);
			return "Ok.";
		case "DOWNLOADFILE":
			try
			{
				return E2w4SAMlovhlOvIpCdY.fKBLD6NAWdP(string_1.Trim());
			}
			catch (Exception ex)
			{
				string text2 = "下载文件出错：" + ex.Message + " 网址:" + string_1.Trim();
				Bv4ththfUeA.Warn(text2);
				AppHelper.ShowWarning(text2);
				return "Error:" + text2;
			}
		default:
			return "Error:不支持的操作类型(" + text + ")";
		}
	}

	static CxPyBB2GbLo3XslgL6G()
	{
		Bv4ththfUeA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool YH0hD0QBGuSPffZ3IgFh()
	{
		return XsDOdbQBEmky5BNANint == null;
	}

	internal static void jXgqC5QBBAYxPalJcAub()
	{
	}
}
