using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.Ext;

public static class ProfileExt
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public int eeF2NaECcNQ;

		public int YR92N7re5MY;

		internal static _003C_003Ec__DisplayClass8_0 Vi1ILGyB2QA8O5cpGaWB;

		internal bool OET2N8cpkcj(ActionItem x)
		{
			if (x.Row == eeF2NaECcNQ)
			{
				return x.Col == YR92N7re5MY;
			}
			return false;
		}

		internal static bool ilt0P1yBAI6EFRGoVNFN()
		{
			return Vi1ILGyB2QA8O5cpGaWB == null;
		}
	}

	private static object ssp2kyFIspdGpUOUb2Cn;

	public static bool IsGlobalProfile(this ActionProfile profile)
	{
		if (profile == null)
		{
			return false;
		}
		return profile.ExeFile == "_global";
	}

	public static bool IsCommonProfile(this ActionProfile profile)
	{
		if (profile == null)
		{
			return false;
		}
		return string.Equals(profile.ExeFile, "common", StringComparison.OrdinalIgnoreCase);
	}

	public static bool IsDefaultGlobalProfile(this ActionProfile profile)
	{
		return profile.Name == "_global";
	}

	public static bool IsDefaultProfile(this ActionProfile profile)
	{
		if (profile == null)
		{
			return false;
		}
		return profile.Name == "_default";
	}

	public static IList<ActionItem> FindParentCollection(this ActionProfile profile, string parentActionId)
	{
		if (string.IsNullOrEmpty(parentActionId))
		{
			return profile.ActionItems;
		}
		return M3RLiBlggJx(profile.ActionItems, parentActionId)?.Children;
	}

	public static IList<ActionItem> FindParentCollection(this ActionProfile profile, ActionItem action)
	{
		return profile.ActionItems.FindParentCollection(action);
	}

	public static IList<ActionItem> FindParentCollection(this IList<ActionItem> actionList, ActionItem action)
	{
		if (actionList.Contains(action))
		{
			return actionList;
		}
		foreach (ActionItem action2 in actionList)
		{
			if (action2.Children.HasData())
			{
				IList<ActionItem> list = action2.Children.FindParentCollection(action);
				if (list != null)
				{
					return list;
				}
			}
		}
		return null;
	}

	private static ActionItem M3RLiBlggJx(IList<ActionItem> ilist_0, string string_0)
	{
		foreach (ActionItem item in ilist_0)
		{
			if (!string.Equals(item.Id, string_0, StringComparison.OrdinalIgnoreCase))
			{
				if (item.Children.HasData())
				{
					ActionItem actionItem = M3RLiBlggJx(item.Children, string_0);
					if (actionItem != null)
					{
						return actionItem;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	public static ActionItem FindActionByLocation(this ActionProfile profile, int row, int col)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.eeF2NaECcNQ = row;
		_003C_003Ec__DisplayClass8_.YR92N7re5MY = col;
		return profile.ActionItems.FirstOrDefault(_003C_003Ec__DisplayClass8_.OET2N8cpkcj);
	}

	public static bool RemoveAction(this ActionProfile profile, ActionItem item)
	{
		if (item == null)
		{
			return false;
		}
		return WSpLiQWVaUH(profile.ActionItems, item);
	}

	private static bool WSpLiQWVaUH(IList<ActionItem> ilist_0, ActionItem actionItem_0)
	{
		if (ilist_0.Contains(actionItem_0))
		{
			ilist_0.Remove(actionItem_0);
			return true;
		}
		foreach (ActionItem item in ilist_0)
		{
			if (item.Children.HasData() && WSpLiQWVaUH(item.Children, actionItem_0))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool lDMACxFICMX3myK7skCX()
	{
		return ssp2kyFIspdGpUOUb2Cn == null;
	}
}
