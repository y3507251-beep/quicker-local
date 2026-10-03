using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Public.Searching;

namespace Quicker.Domain.Searching.Actions;

public class ActionSearchResultItem : SearchResultItem
{
	[CompilerGenerated]
	private ActionProfile aqGteU5uFeV;

	internal static ActionSearchResultItem YHVekoQdU006sFG7fcZm;

	public ActionProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return aqGteU5uFeV;
		}
		[CompilerGenerated]
		set
		{
			aqGteU5uFeV = value;
		}
	}

	public ActionSearchResultItem(SearchPlugin plugin, ActionItem action, ActionProfile profile, int score, bool isDirectWord)
	{
		base.Title = action.Title.Replace("\\n", " ");
		base.Description = (string.IsNullOrEmpty(action.Description) ? "(Quicker动作)" : action.Description.Replace("\\n", " "));
		base.Tag = action;
		base.Icon = action.Icon;
		base.Score = score;
		base.TextData = action.Id;
		base.SecondaryTitle = profile?.ExeFile + "\\" + profile?.Name;
		Profile = profile;
		base.Label = (isDirectWord ? "直达" : "");
	}

	static ActionSearchResultItem()
	{
	}

	internal static bool kw6UUFQdx9lC5A5qnAfb()
	{
		return YHVekoQdU006sFG7fcZm == null;
	}

	internal static void pTUUwbQd6wnUO2hDpQqY()
	{
	}
}
