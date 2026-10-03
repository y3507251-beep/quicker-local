using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Common.QuickActions;
using Quicker.Public.Extensions;
using Quicker.View.Hotkeys;
using Quicker.View.TextCommands;

namespace Quicker.Domain.QuickActions;

public static class QuickActionExt
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public string I4UvmMaLty4;

		internal static _003C_003Ec__DisplayClass2_0 SiCYcIctTbobq5QtiAA5;

		internal bool KZ0vmTBDbrJ(QuickOperationItem x)
		{
			return string.Equals(x.Key, I4UvmMaLty4);
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}

		internal static void TfbVF7ctCWovNBFn2TVu()
		{
		}

		internal static bool fafOZWctmeprutfELhhB()
		{
			return SiCYcIctTbobq5QtiAA5 == null;
		}

		internal static void UOwZSict49bQOt8NE7lE()
		{
		}
	}

	private static object Dw2F3QQKGvVtgnJlMqIv;

	public static string GetSummary(this IQuickActionItem actionItem)
	{
		return actionItem.ActionType switch
		{
			QuickActionType.InheritGlobal => "-继承-", 
			QuickActionType.None => "-无-", 
			QuickActionType.Keystroke => hAftVDjxEvu(actionItem.Data), 
			QuickActionType.QuickerOperation => ddKtV4bfRHI(actionItem.Data), 
			QuickActionType.QuickerAction => CIDtV5bu0Of(actionItem.Data), 
			_ => actionItem.Data.ToShortString(40), 
		};
	}

	public static (string actionId, string actionParam) GetActionIdAndParam(this string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return (actionId: "", actionParam: "");
		}
		int num = data.IndexOf('\n');
		if (num < 0)
		{
			return (actionId: data, actionParam: "");
		}
		return (actionId: data.Substring(0, num), actionParam: (data.Length > num) ? data.Substring(num + 1) : "");
	}

	private static string ddKtV4bfRHI(string string_0)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.I4UvmMaLty4 = string_0;
		QuickOperationItem quickOperationItem = QuickOperationItem.AllQuickerOperationItems.FirstOrDefault(_003C_003Ec__DisplayClass2_.KZ0vmTBDbrJ);
		if (quickOperationItem != null)
		{
			return quickOperationItem.Name;
		}
		return _003C_003Ec__DisplayClass2_.I4UvmMaLty4.ToShortString(20);
	}

	private static string CIDtV5bu0Of(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		(string, string) actionIdAndParam = string_0.GetActionIdAndParam();
		(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(actionIdAndParam.Item1);
		string text = "";
		if (actionById.Item1 != null)
		{
			text = actionById.Item1.Title;
		}
		else
		{
			text = actionIdAndParam.Item1;
			if (txUgm8QK0V0xTv9CYNvi())
			{
				switch (0)
				{
				}
			}
		}
		if (!actionIdAndParam.Item2.IsNullOrEmpty())
		{
			text = text + "：" + actionIdAndParam.Item2.ToShortString(20);
		}
		return text;
	}

	private static string hAftVDjxEvu(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		return new Hotkey(string_0).ToString();
	}

	public static ActionItem GetAction(this IQuickActionItem quickAction)
	{
		if (quickAction == null)
		{
			return null;
		}
		if (quickAction.ActionType == QuickActionType.QuickerAction)
		{
			(string, string) actionIdAndParam = quickAction.Data.GetActionIdAndParam();
			if (string.IsNullOrEmpty(actionIdAndParam.Item1))
			{
				return null;
			}
			try
			{
				return AppState.DataService.QHmtXwg81eY(actionIdAndParam.Item1).action;
			}
			catch (Exception)
			{
			}
			return null;
		}
		return null;
	}

	internal static bool txUgm8QK0V0xTv9CYNvi()
	{
		return Dw2F3QQKGvVtgnJlMqIv == null;
	}
}
