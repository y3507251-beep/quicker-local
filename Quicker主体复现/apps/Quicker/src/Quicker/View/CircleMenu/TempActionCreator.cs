using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using WindowsInput.Native;

namespace Quicker.View.CircleMenu;

public static class TempActionCreator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass0_0
	{
		public bool nKsSTuPhSTs;
	}

	internal static object NDrdbFFdOntJyyNFaKx0;

	public static ActionItem CreateTempAction(string data, bool returnNullIfNotFound = false)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_0_ = default(_003C_003Ec__DisplayClass0_0);
		_003C_003Ec__DisplayClass0_0_.nKsSTuPhSTs = returnNullIfNotFound;
		if (string.IsNullOrEmpty(data))
		{
			return null;
		}
		int num;
		CircleMenuTempAction circleMenuTempAction = default(CircleMenuTempAction);
		if (!data.StartsWith("json:"))
		{
			num = 0;
			if (kTcfkxFdJMBLiO9gQFG4())
			{
				goto IL_015d;
			}
		}
		else
		{
			CircleMenuAction circleMenuAction = JsonConvert.DeserializeObject<CircleMenuAction>(data.Substring("json:".Length));
			if (circleMenuAction == null)
			{
				return VA5L9HBbLcS(ref _003C_003Ec__DisplayClass0_0_);
			}
			if (circleMenuAction.ActionType != QuickActionType.QuickerAction)
			{
				return CreateTempAction(circleMenuAction, null);
			}
			(string, string) actionIdAndParam = circleMenuAction.Data.GetActionIdAndParam();
			(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(actionIdAndParam.Item1);
			circleMenuTempAction = null;
			if (tuple.Item1 == null)
			{
				return VA5L9HBbLcS(ref _003C_003Ec__DisplayClass0_0_);
			}
			CircleMenuTempAction circleMenuTempAction2 = new CircleMenuTempAction();
			circleMenuTempAction2.Title = StringExt.FirstNotEmptyString(circleMenuAction.Title, tuple.Item1.Title);
			circleMenuTempAction2.Description = StringExt.FirstNotEmptyString(circleMenuAction.Description, tuple.Item1.Description);
			circleMenuTempAction2.Icon = StringExt.FirstNotEmptyString(circleMenuAction.Icon, tuple.Item1.Icon);
			circleMenuTempAction2.ActionType = ActionType.TempAction;
			circleMenuTempAction2.CircleMenuAction = circleMenuAction;
			circleMenuTempAction = circleMenuTempAction2;
			Gn0L9sEweQF(circleMenuAction, circleMenuTempAction);
			num = 1;
			if (!kTcfkxFdJMBLiO9gQFG4())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			return circleMenuTempAction;
		}
		goto IL_015d;
		IL_015d:
		(ActionItem, string) tuple2 = AppState.DataService.QHmtXwg81eY(data);
		if (tuple2.Item1 != null)
		{
			return tuple2.Item1;
		}
		return VA5L9HBbLcS(ref _003C_003Ec__DisplayClass0_0_);
	}

	public static CircleMenuTempAction CreateTempAction(CircleMenuAction circleAction, ActionItem originAction)
	{
		CircleMenuTempAction circleMenuTempAction = new CircleMenuTempAction
		{
			Title = circleAction.Title,
			Description = circleAction.Description,
			Icon = circleAction.Icon.Or(originAction?.Icon),
			ActionType = ActionType.TempAction,
			CircleMenuAction = circleAction
		};
		Gn0L9sEweQF(circleAction, circleMenuTempAction);
		return circleMenuTempAction;
	}

	private static void Gn0L9sEweQF(CircleMenuAction circleMenuAction_0, CircleMenuTempAction circleMenuTempAction_0)
	{
		if (circleMenuAction_0.SubActions == null || circleMenuAction_0.SubActions.Count <= 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(200);
		stringBuilder.AppendLine(circleMenuTempAction_0.Description);
		stringBuilder.AppendLine("----");
		int num = 0;
		if (NDrdbFFdOntJyyNFaKx0 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		foreach (SubAction subAction in circleMenuAction_0.SubActions)
		{
			if (!subAction.IsDisabled && subAction.ActionType != QuickActionType.None)
			{
				stringBuilder.AppendLine(KeyboardHelper.GetKeyName((VirtualKeyCode)subAction.Key) + ": " + subAction.Description.Or(subAction.GetSummary()));
			}
		}
		stringBuilder.Length -= 2;
		circleMenuTempAction_0.Description = stringBuilder.ToString();
	}

	[CompilerGenerated]
	internal static CircleMenuTempAction VA5L9HBbLcS(ref _003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_0_0)
	{
		if (_003C_003Ec__DisplayClass0_0_0.nKsSTuPhSTs)
		{
			return null;
		}
		return new CircleMenuTempAction
		{
			Title = "!动作未找到",
			Description = "此动作已从动作页删除，或存在重名动作。",
			Icon = "fa:Solid_ExclamationTriangle:#FF0000",
			ActionType = ActionType.Empty,
			CircleMenuAction = null
		};
	}

	internal static bool kTcfkxFdJMBLiO9gQFG4()
	{
		return NDrdbFFdOntJyyNFaKx0 == null;
	}
}
