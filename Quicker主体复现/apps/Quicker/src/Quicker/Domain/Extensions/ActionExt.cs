using System;
using System.IO;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Extensions;

public static class ActionExt
{
	internal static object yVDIIMQ1DwUwUMfCbMUC;

	public static bool IsActionShared(this ActionItem action)
	{
		if (!string.IsNullOrEmpty(action.SharedActionId))
		{
			return !action.ActionType.IsEither(ActionType.LinkAction);
		}
		return false;
	}

	public static bool IsFromSharedAction(this ActionItem action)
	{
		return !string.IsNullOrEmpty(action.TemplateId);
	}

	public static string GetUri(this ActionItem action)
	{
		return "quicker:runaction:" + action.Id;
	}

	public static bool CanExport(this ActionItem action)
	{
		if (action != null)
		{
			return !string.IsNullOrEmpty(action.Id);
		}
		return false;
	}

	public static bool CanCreateLinkAction(this ActionItem action)
	{
		if (action != null)
		{
			return action.ActionType != ActionType.OpenProfile;
		}
		return false;
	}

	public static bool IsValid(this ActionItem action)
	{
		ActionType actionType = action.ActionType;
		if (actionType != ActionType.OpenFile && (uint)(actionType - 11) > 1u)
		{
			return true;
		}
		if (!string.IsNullOrEmpty(action.Data) && action.Data[1] == ':')
		{
			if (!File.Exists(action.Data))
			{
				return Directory.Exists(action.Data);
			}
			return true;
		}
		return true;
	}

	public static ActionItem Clone(this ActionItem action, bool newId = true)
	{
		ActionItem actionItem = JsonConvert.DeserializeObject<ActionItem>(JsonConvert.SerializeObject(action));
		if (newId)
		{
			actionItem.Id = Guid.NewGuid().ToString();
			int num = 0;
			if (!dF8GemQ13gNspcNi4CpX())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			actionItem.Row = 0;
			actionItem.Col = 0;
			actionItem.ShareTimeUtc = null;
			actionItem.SharedActionId = "";
			actionItem.CreateTimeUtc = DateTime.UtcNow;
			actionItem.LastEditTimeUtc = null;
		}
		return actionItem;
	}

	public static bool CanBeShared(this ActionItem action)
	{
		ActionUserLimitation? userLimitation = action.UserLimitation;
		if (userLimitation.HasValue && userLimitation.GetValueOrDefault() >= ActionUserLimitation.NoShareToActionStore)
		{
			return false;
		}
		if (action.ActionType != ActionType.Empty && action.ActionType != ActionType.GoParent && action.ActionType != ActionType.Folder)
		{
			return action.ActionType != ActionType.LinkAction;
		}
		return false;
	}

	internal static bool XBttcfC2xjC(this ActionItem actionItem_0)
	{
		if (actionItem_0 != null && actionItem_0.ActionType != ActionType.Empty && actionItem_0.ActionType != ActionType.GoParent)
		{
			return actionItem_0.ActionType != ActionType.Folder;
		}
		return false;
	}

	internal static bool IsReadOnly(this ActionItem action)
	{
		if (!action.UserLimitation.HasValue)
		{
			return false;
		}
		return action.UserLimitation.Value >= ActionUserLimitation.ReadOnly;
	}

	public static bool IsNewAction(this ActionItem action)
	{
		if (string.IsNullOrEmpty(action.Data) && action.ActionType != ActionType.Folder)
		{
			return action.ActionType == ActionType.GoParent;
		}
		return true;
	}

	static ActionExt()
	{
	}

	internal static bool dF8GemQ13gNspcNi4CpX()
	{
		return yVDIIMQ1DwUwUMfCbMUC == null;
	}

	internal static void GATs0lQ109P7BKQ6Z8tQ()
	{
	}
}
