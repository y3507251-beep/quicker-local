using System;

namespace Quicker.Common;

[Serializable]
public class ActionItemDragObject
{
	public int Row { get; set; }

	public int Col { get; set; }

	public ActionItem Action { get; set; }

	public string ProfileId { get; set; }

	public ActionItemDragObject(string profileId, ActionItem action, int row, int col)
	{
		ProfileId = profileId;
		Action = action;
		Row = row;
		Col = col;
	}
}
